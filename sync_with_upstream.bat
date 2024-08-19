@echo off
chcp 65001
setlocal

set "UPSTREAM_REPO=upstream"
set "UPSTREAM_BRANCH=master"
set "SYNC_BRANCH=upstream-sync"
set "ORIGIN_REPO=origin"
set "TARGET_BRANCH=master"

echo Переключение на ветку %TARGET_BRANCH%
git checkout %TARGET_BRANCH%
if errorlevel 1 (
    echo Ошибка при переключении на ветку %TARGET_BRANCH%.
    pause
    exit /b 1
)

echo Получение последних изменений из ветки %TARGET_BRANCH% в %ORIGIN_REPO%
git pull %ORIGIN_REPO% %TARGET_BRANCH%
if errorlevel 1 (
    echo Ошибка при получении последних изменений из ветки %TARGET_BRANCH%.
    pause
    exit /b 1
)

echo Удаление ветки %SYNC_BRANCH% из %ORIGIN_REPO% (если существует)
git push %ORIGIN_REPO% --delete %SYNC_BRANCH% 2>nul
if errorlevel 1 (
    echo Ошибка при удалении ветки %SYNC_BRANCH% из %ORIGIN_REPO%.
)

echo Удаление локальной ветки %SYNC_BRANCH% (если существует)
git branch -d %SYNC_BRANCH% 2>nul
if errorlevel 1 (
    echo Ошибка при удалении локальной ветки %SYNC_BRANCH% или ветка не существует.
)

echo Создание и переключение на ветку %SYNC_BRANCH%
git checkout -b %SYNC_BRANCH%
if errorlevel 1 (
    echo Ошибка при создании и переключении на ветку %SYNC_BRANCH%.
    pause
    exit /b 1
)

echo Получение последних изменений из ветки %UPSTREAM_BRANCH% в %UPSTREAM_REPO%
git pull %UPSTREAM_REPO% %UPSTREAM_BRANCH%
if errorlevel 1 (
    echo Возникли конфликты при слиянии. Пожалуйста, разрешите конфликты вручную.
    echo После разрешения конфликтов выполните следующие команды для завершения процесса:
    echo 1. git add <файлы>
    echo 2. git commit -m "Resolve merge conflicts"
    echo 3. git push %ORIGIN_REPO% %SYNC_BRANCH%
    pause
    exit /b 1
)

echo Отправка ветки %SYNC_BRANCH% в %ORIGIN_REPO%
git push %ORIGIN_REPO% %SYNC_BRANCH%
if errorlevel 1 (
    echo Ошибка при отправке ветки в %ORIGIN_REPO%.
    pause
    exit /b 1
)

echo ==============================================
echo Синхронизация завершена!
echo Следующие шаги:
echo 1. Перейдите на GitHub и создайте pull request из %SYNC_BRANCH% в %TARGET_BRANCH%.
echo 2. Проверьте изменения и слейте их, если всё правильно.
echo ==============================================
pause
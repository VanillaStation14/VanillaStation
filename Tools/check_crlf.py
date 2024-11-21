#!/usr/bin/env python3

import subprocess
import os
from typing import Iterable

def main() -> int:
    any_failed = False
    for file_name in get_text_files():
        file_path = os.path.normpath(file_name)  # Нормализуем путь для ОС
        if is_file_crlf(file_path):
            print(f"::error file={file_name},title=File contains CRLF line endings::The file '{file_name}' was committed with CRLF new lines. Please make sure your git client is configured correctly and you are not uploading files directly to GitHub via the web interface.")
            any_failed = True

    return 1 if any_failed else 0


def get_text_files() -> Iterable[str]:
    # Получение списка текстовых файлов с использованием git grep
    process = subprocess.run(
        ["git", "grep", "--cached", "-Il", ""],
        check=True,
        stdout=subprocess.PIPE
    )

    # Преобразуем вывод в список путей
    for x in process.stdout.decode("utf-8").splitlines():  # Указываем декодирование явно
        yield x.strip()

def is_file_crlf(path: str) -> bool:
    # Проверка файла на наличие CRLF
    try:
        with open(path, "rb") as f:
            for line in f:
                if line.endswith(b"\r\n"):
                    return True
    except FileNotFoundError:
        print(f"Файл не найден: {path}")
    except OSError as e:
        print(f"Ошибка при открытии файла {path}: {e}")

    return False

if __name__ == "__main__":
    exit(main())

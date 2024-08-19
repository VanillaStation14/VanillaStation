#!/usr/bin/env python3

from __future__ import print_function
import sys
import subprocess
import os

version = sys.version_info
if version.major < 3 or (version.major == 3 and version.minor < 5):
    print("ERROR: You need at least Python 3.5 to build SS14.")
    sys.exit(1)

# Проверка наличия SSH-ключа
def has_ssh_key():
    ssh_key_path = os.path.expanduser("~/.ssh/id_ed25519")
    return os.path.exists(ssh_key_path)

# Запуск ssh-agent и добавление ключа
def setup_ssh_agent():
    try:
        subprocess.run(["ssh-agent", "-s"], check=True)
        ssh_key_path = os.path.expanduser("~/.ssh/id_ed25519")
        subprocess.run(["ssh-add", ssh_key_path], check=True)
    except subprocess.CalledProcessError as e:
        print(f"ERROR: Failed to setup ssh-agent or add SSH key: {e}")
        sys.exit(1)

# Инициализация и обновление подмодулей с исключением секретного подмодуля
def init_submodules(exclude_secret=False):
    try:
        # Инициализируем все подмодули
        subprocess.run(["git", "submodule", "init"], check=True)
        
        if exclude_secret:
            # Исключаем секретный подмодуль из обновления
            subprocess.run(["git", "submodule", "update", "--remote", "--", ":!secrets"], check=True)
        else:
            # Обновляем все подмодули, включая секретный
            subprocess.run(["git", "submodule", "update", "--remote"], check=True)
    except subprocess.CalledProcessError as e:
        print(f"ERROR: Failed to initialize or update submodules: {e}")
        sys.exit(1)

# Основной код
if has_ssh_key():
    setup_ssh_agent()
    init_submodules(exclude_secret=False)
else:
    print("WARNING: SSH key not found. Secret module will not be downloaded.")
    init_submodules(exclude_secret=True)

subprocess.run([sys.executable, "git_helper.py"], cwd="BuildChecker")
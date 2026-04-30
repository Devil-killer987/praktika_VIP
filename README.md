# Практика: виртуализация, разработка, базы данных и серверы

Автор: Участник практики
Период: 7 дней
Репозиторий: https://gitlab.com/devil-killer987-group/Devil-killer987-project

## О проекте

В рамках практики выполнены следующие работы:
- Установка и настройка виртуальных машин (VirtualBox)
- Работа с ОС: Ubuntu Desktop, Red OS, Ubuntu Server
- Разработка Windows-приложения «Мастер Пол» (CRUD, история продаж, расчёт скидки)
- Написание юнит-тестов для бизнес-логики
- Составление 10 тест-кейсов и блок-схемы
- Установка и настройка NAS OpenMediaVault (SMB/CIFS)
- Выгрузка конфигурации 1С в GitLab
- Установка MongoDB и API-сервиса Fusio (Docker)
- Локальная разработка сайта на WordPress (Open Server Panel)

## Технологии и инструменты

Виртуализация: Oracle VM VirtualBox
ОС: Ubuntu 22.04, Red OS, Ubuntu Server 25.04, OpenMediaVault
Разработка: C#, .NET, WPF, Entity Framework
Базы данных: MySQL, MongoDB 8.0
Тестирование: MSTest, юнит-тесты
Документация: Markdown, PDF, PlantUML
Веб-серверы: Open Server Panel (Nginx, PHP, MySQL), Fusio
CMS: WordPress
Другое: Git, GitLab, Docker, ClamAV, VSCode

## Структура репозитория

Devil-killer987-project/
├── Master_floor/                 # Исходный код приложения
│   ├── MainWindow.xaml/.cs
│   ├── PartnerWindow.xaml/.cs
│   ├── History.xaml/.cs
│   ├── DiscountCalculator.cs
│   └── ...
├── MasterFloorTests/             # Юнит-тесты
│   └── DiscountCalculatorTests.cs
├── Docs/
│   ├── Тест_кейсы.pdf
│   ├── Блок_схема.png
│   ├── Руководство_по_установке_OMV.pdf
│   ├── Сравнение_гостевых_ОС.pdf
│   └── Итоговый_отчёт.pdf
├── WordPress/                    # Файлы сайта
├── Scripts/
│   ├── docker-compose-fusio.yml
│   └── mongodb_init.js
└── README.md

## Основные достижения

1. Приложение «Мастер Пол»
   - Полный CRUD для партнёров
   - Расчёт скидки от суммы продаж (0%/5%/10%/15%)
   - Окно истории реализации продукции
   - Юнит-тесты для DiscountCalculator

2. Тестирование и документация
   - 10 тест-кейсов (все PASS)
   - Блок-схема алгоритма
   - Руководство по установке OpenMediaVault
   - Сравнительный анализ ОС

3. Серверная часть
   - Настроено сетевое хранилище OMV с доступом по SMB
   - Установлен Ubuntu Server → MongoDB (Docker) → Fusio API
   - Импорт JSON-данных через MongoDB Compass

4. Веб-разработка
   - Локальный сервер Open Server Panel
   - Установлен WordPress (русская версия)
   - Активирована образовательная тема
   - Создана структура сайта колледжа

5. Интеграция
   - Выгрузка конфигурации 1С в GitLab через SSH
   - Фоновое задание в 1С для контроля сроков (канбан)

## Итоговые показатели

Установлено ОС: 4
Написано юнит-тестов: 5
Составлено тест-кейсов: 10
Разработано приложений: 1
Создано документации: 5 файлов
Настроено серверов: 3 (NAS, Fusio, Open Server)

## Как запустить проект

Приложение «Мастер Пол»:
1. Открыть Master_floor.sln в Visual Studio
2. Убедиться, что база данных TestBase локально развёрнута (LocalDB)
3. Запустить проект (F5)

Юнит-тесты:
- Открыть Test Explorer → запустить все тесты

WordPress (локально):
1. Запустить Open Server Panel
2. Открыть в браузере http://example.local

Fusio API:
cd Scripts
sudo docker-compose up -d
Админка: http://IP_виртуалки:8080/apps/fusio
Логин: admin / admin123

## Лицензия

Проект создан в образовательных целях. Все права на использованное ПО принадлежат соответствующим владельцам.

## Автор

Практика выполнена в рамках учебного курса.
GitLab: https://gitlab.com/devil-killer987-group

Дата завершения: 30 апреля 2026 года

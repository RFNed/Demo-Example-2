-- phpMyAdmin SQL Dump
-- version 5.2.2
-- https://www.phpmyadmin.net/
--
-- Хост: MySQL-8.4:3306
-- Время создания: Мар 24 2026 г., 19:51
-- Версия сервера: 8.4.6
-- Версия PHP: 8.4.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `demo2`
--

-- --------------------------------------------------------

--
-- Структура таблицы `arenda`
--

CREATE TABLE `arenda` (
  `id` int NOT NULL,
  `clientID` int DEFAULT NULL,
  `invID` int DEFAULT NULL,
  `takeDate` date DEFAULT NULL,
  `quantityDays` int DEFAULT NULL,
  `backDate` date DEFAULT NULL,
  `price` decimal(6,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `arenda`
--

INSERT INTO `arenda` (`id`, `clientID`, `invID`, `takeDate`, `quantityDays`, `backDate`, `price`) VALUES
(1, 1, 101, '2026-02-20', 3, '2026-02-23', 1500.00),
(2, 3, 103, '2026-02-25', 5, '2026-03-02', 2000.00),
(3, 2, 106, '2026-02-28', 2, '2026-03-02', 1800.00),
(4, 5, 105, '2026-02-01', 10, '2026-02-11', 100.00),
(5, 4, 102, '2026-02-27', 2, '2026-03-01', 600.00);

-- --------------------------------------------------------

--
-- Структура таблицы `client`
--

CREATE TABLE `client` (
  `id` int NOT NULL,
  `name` varchar(28) DEFAULT NULL,
  `birthday` varchar(10) DEFAULT NULL,
  `phone` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `client`
--

INSERT INTO `client` (`id`, `name`, `birthday`, `phone`) VALUES
(1, 'Петров Алексей Александрович', '1955-04-12', '7(903)123-45-67'),
(2, 'Сидорова Мария Ивановна', '1990-08-23', '7(916)234-56-78'),
(3, 'Иванов Иван Петрович', '1985-01-15', '7(925)111-22-33'),
(4, 'Николаев Сергей Сергеевич', '2000-05-05', '7(495)555-77-88'),
(5, 'Васильева Елена Алексеевна', '1940-11-30', '7(926)333-44-55');

-- --------------------------------------------------------

--
-- Структура таблицы `inventory`
--

CREATE TABLE `inventory` (
  `id` int NOT NULL,
  `name` varchar(17) DEFAULT NULL,
  `typeID` int DEFAULT NULL,
  `priceperday` decimal(5,2) DEFAULT NULL,
  `statusid` int DEFAULT NULL,
  `photo` varchar(12) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'notfound.jpg'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `inventory`
--

INSERT INTO `inventory` (`id`, `name`, `typeID`, `priceperday`, `statusid`, `photo`) VALUES
(101, 'Велосипед горный', 1, 500.00, 1, 'bike1.jpg'),
(102, 'Велосипед детский', 1, 300.00, 2, 'bike_kid.jpg'),
(103, 'Лыжи беговые', 2, 400.00, 1, 'skis_1.jpg'),
(104, 'Лыжи горные', 2, 650.00, 2, 'skis_pro.jpg'),
(105, 'Палатка 2-местная', 3, 100.00, 1, 'notfound.jpg'),
(106, 'Палатка 4-местная', 3, 900.00, 1, 'tent_4.jpg'),
(107, 'Рюкзак 60л', 4, 250.00, 1, 'backpack.jpg'),
(108, 'Ролики квады', 5, 350.00, 1, 'notfound.jpg');

-- --------------------------------------------------------

--
-- Структура таблицы `roles`
--

CREATE TABLE `roles` (
  `id` int NOT NULL,
  `name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `roles`
--

INSERT INTO `roles` (`id`, `name`) VALUES
(1, 'Сотрудник'),
(2, 'Администратор');

-- --------------------------------------------------------

--
-- Структура таблицы `status_table`
--

CREATE TABLE `status_table` (
  `id` int NOT NULL,
  `name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `status_table`
--

INSERT INTO `status_table` (`id`, `name`) VALUES
(1, 'Доступен'),
(2, 'В аренде');

-- --------------------------------------------------------

--
-- Структура таблицы `types`
--

CREATE TABLE `types` (
  `id` int NOT NULL,
  `name` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `types`
--

INSERT INTO `types` (`id`, `name`) VALUES
(1, 'Велосипед'),
(2, 'Лыжи'),
(3, 'Палатка'),
(4, 'Рюкзак'),
(5, 'Ролики');

-- --------------------------------------------------------

--
-- Структура таблицы `users`
--

CREATE TABLE `users` (
  `id` int NOT NULL,
  `name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `login` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `password` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `role_id` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `users`
--

INSERT INTO `users` (`id`, `name`, `login`, `password`, `role_id`) VALUES
(1, 'Иванов Иван Иванович', 'ivanov', 'pass123', 1),
(2, 'Петрова Мария Сергеевна', 'petrova', 'pass456', 2),
(3, 'Сидоров Алексей Петрович', 'sidorov', 'pass789', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `arenda`
--
ALTER TABLE `arenda`
  ADD PRIMARY KEY (`id`),
  ADD KEY `clientID` (`clientID`);

--
-- Индексы таблицы `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`id`),
  ADD KEY `typeID` (`typeID`),
  ADD KEY `statusid` (`statusid`);

--
-- Индексы таблицы `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `status_table`
--
ALTER TABLE `status_table`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `types`
--
ALTER TABLE `types`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `role_id` (`role_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `arenda`
--
ALTER TABLE `arenda`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `client`
--
ALTER TABLE `client`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `inventory`
--
ALTER TABLE `inventory`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=109;

--
-- AUTO_INCREMENT для таблицы `roles`
--
ALTER TABLE `roles`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `status_table`
--
ALTER TABLE `status_table`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `types`
--
ALTER TABLE `types`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `users`
--
ALTER TABLE `users`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `arenda`
--
ALTER TABLE `arenda`
  ADD CONSTRAINT `arenda_ibfk_1` FOREIGN KEY (`clientID`) REFERENCES `client` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `inventory_ibfk_1` FOREIGN KEY (`typeID`) REFERENCES `types` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `inventory_ibfk_2` FOREIGN KEY (`statusid`) REFERENCES `status_table` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `roles` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

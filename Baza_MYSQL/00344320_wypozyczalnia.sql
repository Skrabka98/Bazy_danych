-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Czas generowania: 12 Maj 2020, 17:17
-- Wersja serwera: 5.7.26-29-log
-- Wersja PHP: 5.6.40

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `00344320_wypozyczalnia`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `Aktor`
--

CREATE TABLE `Aktor` (
  `id_aktora` int(11) NOT NULL,
  `imie` varchar(200) COLLATE utf8_polish_ci NOT NULL,
  `nazwisko` varchar(200) COLLATE utf8_polish_ci NOT NULL,
  `wiek` varchar(100) CHARACTER SET utf32 COLLATE utf32_polish_ci NOT NULL,
  `data_urodzenia` varchar(12) COLLATE utf8_polish_ci NOT NULL,
  `miejsce_urodzenia` varchar(200) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `Aktor`
--

INSERT INTO `Aktor` (`id_aktora`, `imie`, `nazwisko`, `wiek`, `data_urodzenia`, `miejsce_urodzenia`) VALUES
(18, 'Keanu', 'Reeves', '55 lat', '02.09.1964', 'Bejrut,Liban '),
(19, 'Carrie-Anne', 'Moss', '52 lata', '21.08.1967', 'Vancouver, Kanada '),
(20, 'Hugo ', 'Wearing', '60 lat', '04.04.1960', 'Ibadan, Nigeria'),
(21, 'Laurence ', 'Fishburne', '58 lat', '30.07.1961', 'Augusta, Georgia, USA '),
(22, 'Tom ', 'Ellis II', '41 lat', '17.11.1978', 'Cardiff, Walia, Wielka Brytania '),
(23, 'Lesley-Ann', 'Brandt', '38 lat', '02.12.1981', 'Kapsztad, RPA '),
(24, 'Lauren', 'German', '41 lat', '29.11.1978', 'Huntington Beach, Kalifornia, USA '),
(25, 'David Bryan', 'Woodside', '50 lat', '25.07. 1969', 'Nowy Jork, USA '),
(26, 'Vin', 'Diesel', '52 lata', '18.07.1967', 'Nowy Jork, USA '),
(27, 'Paul ', 'Walker ', 'Zmarł w wieku 40 lat (30.11.2013)', '30.09.1973', 'Glendale, Kalifornia, USA '),
(28, 'Jordana', 'Brewster', '40 lat ', '26.04.1980', 'Panama, Panama '),
(29, 'Michelle', 'Rodriguez ', '41 lat ', '12.07.1978', 'San Antonio, Teksas, USA ');

-- --------------------------------------------------------

--
-- Zastąpiona struktura widoku `Dodawanie_filmu`
-- (Zobacz poniżej rzeczywisty widok)
--
CREATE TABLE `Dodawanie_filmu` (
`id_filmu` int(11)
,`tytul` varchar(200)
,`premiera` varchar(20)
,`gatunek` varchar(200)
,`opis_filmu` mediumtext
);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `Film`
--

CREATE TABLE `Film` (
  `id_filmu` int(11) NOT NULL,
  `tytul` varchar(200) COLLATE utf8_polish_ci NOT NULL,
  `premiera` varchar(20) COLLATE utf8_polish_ci NOT NULL,
  `Id_gatunek` int(11) NOT NULL,
  `id_wytwornia` int(11) NOT NULL,
  `opis_filmu` mediumtext COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `Film`
--

INSERT INTO `Film` (`id_filmu`, `tytul`, `premiera`, `Id_gatunek`, `id_wytwornia`, `opis_filmu`) VALUES
(17, 'Matrix ', '24.03.1999', 13, 24, ''),
(18, 'Matrix Reaktywacja', '07.05.2003', 13, 24, ''),
(19, 'Matrix Rewolucje', '27.10.2003', 13, 24, ''),
(20, 'Lucyfer', '25.01. 2016', 15, 25, ''),
(21, 'Szybcy i Wściekli ', '18.06.2001', 12, 26, '');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `Gatunek_filmu`
--

CREATE TABLE `Gatunek_filmu` (
  `Id_gatunku` int(11) NOT NULL,
  `gatunek` varchar(200) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `Gatunek_filmu`
--

INSERT INTO `Gatunek_filmu` (`Id_gatunku`, `gatunek`) VALUES
(12, 'Akcja'),
(13, 'Sci-Fi'),
(14, 'Fantasy'),
(15, 'Kryminał ');

-- --------------------------------------------------------

--
-- Zastąpiona struktura widoku `Login`
-- (Zobacz poniżej rzeczywisty widok)
--
CREATE TABLE `Login` (
`id_uzytkownika` int(11)
,`login` varchar(20)
,`haslo` varchar(20)
,`uprawnienia` tinyint(1)
);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `Obsada`
--

CREATE TABLE `Obsada` (
  `Id_obsady` int(11) NOT NULL,
  `id_aktor` int(11) NOT NULL,
  `id_film` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `Obsada`
--

INSERT INTO `Obsada` (`Id_obsady`, `id_aktor`, `id_film`) VALUES
(21, 19, 17),
(22, 18, 17),
(23, 20, 17),
(24, 21, 17),
(25, 23, 20),
(26, 24, 20),
(27, 22, 20),
(28, 25, 20),
(29, 26, 21),
(30, 27, 21),
(31, 28, 21),
(32, 29, 21);

-- --------------------------------------------------------

--
-- Zastąpiona struktura widoku `Obsada_filmu`
-- (Zobacz poniżej rzeczywisty widok)
--
CREATE TABLE `Obsada_filmu` (
`id_film` int(11)
,`imie` varchar(200)
,`nazwisko` varchar(200)
,`wiek` varchar(100)
,`data_urodzenia` varchar(12)
,`miejsce_urodzenia` varchar(200)
);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `Uzytkownik`
--

CREATE TABLE `Uzytkownik` (
  `id_uzytkownika` int(11) NOT NULL,
  `imie` varchar(150) COLLATE utf8_polish_ci NOT NULL,
  `nazwisko` varchar(200) COLLATE utf8_polish_ci NOT NULL,
  `login` varchar(20) COLLATE utf8_polish_ci NOT NULL,
  `haslo` varchar(20) CHARACTER SET utf32 COLLATE utf32_polish_ci NOT NULL,
  `email` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `zdjecie` varbinary(255) NOT NULL,
  `uprawnienia` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `Uzytkownik`
--

INSERT INTO `Uzytkownik` (`id_uzytkownika`, `imie`, `nazwisko`, `login`, `haslo`, `email`, `zdjecie`, `uprawnienia`) VALUES
(9, 'Adam', 'Kowalski ', 'admin', 'admin', 'Adam.kowalski@gmail.com', '', 1),
(10, 'Jan', 'Nowak ', 'user', 'user', 'Jan. kowalski@gmail.com', '', 0);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `Wypozyczone_filmy`
--

CREATE TABLE `Wypozyczone_filmy` (
  `id_wypozyczenia` int(11) NOT NULL,
  `id_uzytkownika` int(11) NOT NULL,
  `id_filmu` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `Wytwornia`
--

CREATE TABLE `Wytwornia` (
  `id_wytworni` int(11) NOT NULL,
  `nazwa` varchar(200) COLLATE utf8_polish_ci NOT NULL,
  `kraj` varchar(100) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `Wytwornia`
--

INSERT INTO `Wytwornia` (`id_wytworni`, `nazwa`, `kraj`) VALUES
(24, 'Warner Bros ', 'USA '),
(25, 'Netflix', 'USA '),
(26, 'United International Pictures Sp.z.o.o', 'Wielka Brytania ');

-- --------------------------------------------------------

--
-- Struktura widoku `Dodawanie_filmu`
--
DROP TABLE IF EXISTS `Dodawanie_filmu`;

CREATE ALGORITHM=UNDEFINED DEFINER=`00344320_wypozyczalnia`@`%` SQL SECURITY DEFINER VIEW `Dodawanie_filmu`  AS  select `Film`.`id_filmu` AS `id_filmu`,`Film`.`tytul` AS `tytul`,`Film`.`premiera` AS `premiera`,`Gatunek_filmu`.`gatunek` AS `gatunek`,`Film`.`opis_filmu` AS `opis_filmu` from (`Film` join `Gatunek_filmu`) where (`Film`.`Id_gatunek` = `Gatunek_filmu`.`Id_gatunku`) ;

-- --------------------------------------------------------

--
-- Struktura widoku `Login`
--
DROP TABLE IF EXISTS `Login`;

CREATE ALGORITHM=UNDEFINED DEFINER=`00344320_wypozyczalnia`@`%` SQL SECURITY DEFINER VIEW `Login`  AS  select `Uzytkownik`.`id_uzytkownika` AS `id_uzytkownika`,`Uzytkownik`.`login` AS `login`,`Uzytkownik`.`haslo` AS `haslo`,`Uzytkownik`.`uprawnienia` AS `uprawnienia` from `Uzytkownik` order by `Uzytkownik`.`id_uzytkownika` ;

-- --------------------------------------------------------

--
-- Struktura widoku `Obsada_filmu`
--
DROP TABLE IF EXISTS `Obsada_filmu`;

CREATE ALGORITHM=UNDEFINED DEFINER=`00344320_wypozyczalnia`@`%` SQL SECURITY DEFINER VIEW `Obsada_filmu`  AS  select `Obsada`.`id_film` AS `id_film`,`Aktor`.`imie` AS `imie`,`Aktor`.`nazwisko` AS `nazwisko`,`Aktor`.`wiek` AS `wiek`,`Aktor`.`data_urodzenia` AS `data_urodzenia`,`Aktor`.`miejsce_urodzenia` AS `miejsce_urodzenia` from (`Obsada` left join `Aktor` on((`Aktor`.`id_aktora` = `Obsada`.`id_aktor`))) order by `Obsada`.`id_film` ;

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `Aktor`
--
ALTER TABLE `Aktor`
  ADD PRIMARY KEY (`id_aktora`);

--
-- Indeksy dla tabeli `Film`
--
ALTER TABLE `Film`
  ADD PRIMARY KEY (`id_filmu`),
  ADD KEY `Id_gatunek` (`Id_gatunek`),
  ADD KEY `id_wytwornia` (`id_wytwornia`);

--
-- Indeksy dla tabeli `Gatunek_filmu`
--
ALTER TABLE `Gatunek_filmu`
  ADD PRIMARY KEY (`Id_gatunku`);

--
-- Indeksy dla tabeli `Obsada`
--
ALTER TABLE `Obsada`
  ADD PRIMARY KEY (`Id_obsady`),
  ADD KEY `id_aktor` (`id_aktor`),
  ADD KEY `id_film` (`id_film`);

--
-- Indeksy dla tabeli `Uzytkownik`
--
ALTER TABLE `Uzytkownik`
  ADD PRIMARY KEY (`id_uzytkownika`);

--
-- Indeksy dla tabeli `Wypozyczone_filmy`
--
ALTER TABLE `Wypozyczone_filmy`
  ADD PRIMARY KEY (`id_wypozyczenia`),
  ADD KEY `id_uzytkownika` (`id_uzytkownika`),
  ADD KEY `id_filmu` (`id_filmu`);

--
-- Indeksy dla tabeli `Wytwornia`
--
ALTER TABLE `Wytwornia`
  ADD PRIMARY KEY (`id_wytworni`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `Aktor`
--
ALTER TABLE `Aktor`
  MODIFY `id_aktora` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT dla tabeli `Film`
--
ALTER TABLE `Film`
  MODIFY `id_filmu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT dla tabeli `Gatunek_filmu`
--
ALTER TABLE `Gatunek_filmu`
  MODIFY `Id_gatunku` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT dla tabeli `Obsada`
--
ALTER TABLE `Obsada`
  MODIFY `Id_obsady` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT dla tabeli `Uzytkownik`
--
ALTER TABLE `Uzytkownik`
  MODIFY `id_uzytkownika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT dla tabeli `Wypozyczone_filmy`
--
ALTER TABLE `Wypozyczone_filmy`
  MODIFY `id_wypozyczenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT dla tabeli `Wytwornia`
--
ALTER TABLE `Wytwornia`
  MODIFY `id_wytworni` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=27;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `Film`
--
ALTER TABLE `Film`
  ADD CONSTRAINT `Film_ibfk_1` FOREIGN KEY (`Id_gatunek`) REFERENCES `Gatunek_filmu` (`Id_gatunku`),
  ADD CONSTRAINT `Film_ibfk_2` FOREIGN KEY (`id_wytwornia`) REFERENCES `Wytwornia` (`id_wytworni`);

--
-- Ograniczenia dla tabeli `Obsada`
--
ALTER TABLE `Obsada`
  ADD CONSTRAINT `Obsada_ibfk_1` FOREIGN KEY (`id_aktor`) REFERENCES `Aktor` (`id_aktora`),
  ADD CONSTRAINT `Obsada_ibfk_2` FOREIGN KEY (`id_film`) REFERENCES `Film` (`id_filmu`);

--
-- Ograniczenia dla tabeli `Wypozyczone_filmy`
--
ALTER TABLE `Wypozyczone_filmy`
  ADD CONSTRAINT `Wypozyczone_filmy_ibfk_1` FOREIGN KEY (`id_uzytkownika`) REFERENCES `Uzytkownik` (`id_uzytkownika`),
  ADD CONSTRAINT `Wypozyczone_filmy_ibfk_2` FOREIGN KEY (`id_filmu`) REFERENCES `Film` (`id_filmu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

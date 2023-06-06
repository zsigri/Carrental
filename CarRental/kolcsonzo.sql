-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2021. Aug 08. 17:06
-- Kiszolgáló verziója: 10.4.17-MariaDB
-- PHP verzió: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `kolcsonzo`
--

DELIMITER $$
--
-- Eljárások
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_CheckJogsi` (IN `jogsi` VARCHAR(10))  BEGIN
	SELECT count(ugyfel.nev) AS 'foglalt'
	FROM ugyfel
	WHERE ugyfel.jogositvany = jogsi;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_CheckRendszam` (IN `rendszam` VARCHAR(6))  BEGIN
	SELECT count(kocsik.marka) AS 'foglalt'
	FROM kocsik
	WHERE kocsik.rendszam = rendszam;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_KivalasztottUgyfelOsszKolt` (IN `jogsiAzon` VARCHAR(10))  BEGIN
	SELECT
		ugyfel.jogositvany,
	    ugyfel.nev,
	    SUM((berlesek.bvege - berlesek.bkezdete) * kocsik.napiDij) AS 'osszkoltes'
	FROM
		ugyfel
	    LEFT JOIN berlesek ON ugyfel.jogositvany = berlesek.bJogositvany
	    LEFT JOIN kocsik ON berlesek.bRendszam = kocsik.rendszam
	WHERE ugyfel.jogositvany = jogsiAzon;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_Kocsik` ()  BEGIN
	SELECT
		kocsik.rendszam,
	    kocsik.marka,
	    kocsik.tipus
	FROM kocsik
    WHERE kocsik.stat = 0;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_KocsiModosit` (IN `Mrendszam` VARCHAR(6), IN `Mmarka` VARCHAR(40), IN `Mtipus` VARCHAR(40), IN `Mterfogat` INT(5), IN `Muzemanyag` VARCHAR(20), IN `Mkilometer` INT(6), IN `Mmuszakivege` DATE, IN `Mnapidij` INT(5), IN `Mleiras` TEXT, IN `Mstat` INT(1))  BEGIN
	
	UPDATE kocsik
	SET kocsik.marka = Mmarka,
		kocsik.tipus = Mtipus,
		kocsik.terfogat = Mterfogat,
		kocsik.uzemanyag = Muzemanyag,
		kocsik.kilometer = Mkilometer,
		kocsik.muszakivege = Mmuszakivege,
		kocsik.napidij = Mnapidij,
		kocsik.leiras = Mleiras,
		kocsik.stat = Mstat
    WHERE kocsik.rendszam = Mrendszam;
    
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_OsszesKocsi` ()  BEGIN
	SELECT
		kocsik.rendszam,
	    kocsik.marka,
	    kocsik.tipus,
        kocsik.terfogat,
        kocsik.uzemanyag,
        kocsik.kilometer,
        kocsik.muszakiVege,
        kocsik.napiDij,
        kocsik.stat
	FROM kocsik;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_Ugyfelek` ()  begin
	SELECT
		ugyfel.jogositvany AS 'Jogsi',
	    ugyfel.nev AS 'Nev'
	FROM ugyfel;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_UgyfelInfo` ()  BEGIN
	SELECT *
	FROM ugyfel;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_UgyfelModosit` (IN `Mjogositvany` VARCHAR(10), IN `Mnev` VARCHAR(60), IN `Mlakcim` VARCHAR(50), IN `Mtel` VARCHAR(13))  BEGIN
	UPDATE ugyfel
    SET 
    	ugyfel.nev = Mnev,
        ugyfel.lakcim = Mlakcim,
        ugyfel.telefon = Mtel
    WHERE ugyfel.jogositvany = Mjogositvany;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_UjBerles` (IN `brend` VARCHAR(6), IN `bjogsi` VARCHAR(10), IN `bkez` DATE, IN `bveg` DATE)  BEGIN
	INSERT INTO berlesek(bRendszam, bJogositvany, bkezdete, bvege)
    VALUES (brend, bjogsi, bkez, bveg);
    
    UPDATE kocsik
    SET kocsik.stat = 1
    WHERE kocsik.rendszam = brend;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_UjKocsi` (IN `rendszam` VARCHAR(6), IN `marka` VARCHAR(40), IN `tipus` VARCHAR(40), IN `terfogat` INT(5), IN `uzemanyag` VARCHAR(20), IN `kilometer` INT(6), IN `muszakiVege` DATE, IN `napiDij` INT(5), IN `Leiras` TEXT(500), IN `stat` INT(1))  BEGIN
	INSERT INTO kocsik(rendszam, marka, tipus, terfogat, uzemanyag, kilometer, muszakiVege, napiDij, Leiras, stat)
    VALUES(rendszam, marka, tipus, terfogat, uzemanyag, kilometer, muszakiVege, napiDij, Leiras, stat);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_UjUgyfel` (IN `jogsi` VARCHAR(10), IN `nev` VARCHAR(60), IN `anya` VARCHAR(60), IN `datum` DATE, IN `cim` VARCHAR(50), IN `tel` VARCHAR(13))  BEGIN
	INSERT into ugyfel(jogositvany, nev, anyjaNeve, szulDatum, lakcim, telefon)
	VALUES(jogsi, nev, anya, datum, cim, tel);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_ValasztottKocsi` (IN `vrendszam` VARCHAR(6))  BEGIN
	SELECT *
	FROM kocsik
    WHERE kocsik.rendszam = vrendszam;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pr_ValasztottUgyfel` (IN `azon` VARCHAR(10))  BEGIN
	SELECT jogositvany, nev, lakcim, telefon
    FROM ugyfel
    WHERE ugyfel.jogositvany = azon;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `berlesek`
--

CREATE TABLE `berlesek` (
  `berlesAzon` int(11) NOT NULL,
  `bRendszam` varchar(6) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `bJogositvany` varchar(10) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `bkezdete` date DEFAULT NULL,
  `bvege` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `berlesek`
--

INSERT INTO `berlesek` (`berlesAzon`, `bRendszam`, `bJogositvany`, `bkezdete`, `bvege`) VALUES
(7, 'KUK464', '13249996', '2021-07-14', '2021-07-21'),
(8, 'IRF334', '13249996', '2021-07-14', '2021-07-21'),
(9, 'KUK464', '4984653', '2021-08-13', '2021-08-26');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `kocsik`
--

CREATE TABLE `kocsik` (
  `rendszam` varchar(6) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `marka` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `tipus` varchar(40) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `terfogat` int(5) NOT NULL,
  `uzemanyag` varchar(20) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `kilometer` int(6) NOT NULL,
  `muszakiVege` date DEFAULT NULL,
  `napiDij` int(5) NOT NULL,
  `Leiras` text COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `stat` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `kocsik`
--

INSERT INTO `kocsik` (`rendszam`, `marka`, `tipus`, `terfogat`, `uzemanyag`, `kilometer`, `muszakiVege`, `napiDij`, `Leiras`, `stat`) VALUES
('ASD123', 'bmw', '118i', 1800, 'Benzin', 12000, '2022-03-17', 8000, '', 0),
('IRF334', 'opel', 'Astra', 1400, 'Benzin', 119985, '2022-12-23', 6000, '', 1),
('KUK464', 'Opel', 'Astra', 1400, 'Benzin', 45500, '2023-06-30', 5432, 'jo kis kocsi', 1),
('TFT420', 'mercedes', 'c', 2800, 'Benzin', 12000, '2022-04-28', 7500, '', 0),
('WOW444', 'audi', 'a4', 1800, 'Benzin', 24005, '2022-03-17', 10000, '', 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ugyfel`
--

CREATE TABLE `ugyfel` (
  `jogositvany` varchar(10) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `nev` varchar(60) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `anyjaNeve` varchar(60) COLLATE utf8mb4_hungarian_ci NOT NULL,
  `szulDatum` date DEFAULT NULL,
  `lakcim` varchar(50) COLLATE utf8mb4_hungarian_ci DEFAULT NULL,
  `telefon` varchar(13) COLLATE utf8mb4_hungarian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `ugyfel`
--

INSERT INTO `ugyfel` (`jogositvany`, `nev`, `anyjaNeve`, `szulDatum`, `lakcim`, `telefon`) VALUES
('13249996', 'Mozer Dávid', 'Toth Gabriell', '1999-07-13', 'Budapest Dohany utca 10', '+36206548521'),
('4984653', 'Nagy Alex', 'Nagy Livia', '2004-06-24', 'Budapest Dohany utca 16', '+36206548521');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `berlesek`
--
ALTER TABLE `berlesek`
  ADD PRIMARY KEY (`berlesAzon`),
  ADD KEY `bRendszam` (`bRendszam`),
  ADD KEY `bJogositvany` (`bJogositvany`);

--
-- A tábla indexei `kocsik`
--
ALTER TABLE `kocsik`
  ADD PRIMARY KEY (`rendszam`);

--
-- A tábla indexei `ugyfel`
--
ALTER TABLE `ugyfel`
  ADD PRIMARY KEY (`jogositvany`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `berlesek`
--
ALTER TABLE `berlesek`
  MODIFY `berlesAzon` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `berlesek`
--
ALTER TABLE `berlesek`
  ADD CONSTRAINT `berlesek_ibfk_1` FOREIGN KEY (`bRendszam`) REFERENCES `kocsik` (`rendszam`),
  ADD CONSTRAINT `berlesek_ibfk_2` FOREIGN KEY (`bJogositvany`) REFERENCES `ugyfel` (`jogositvany`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

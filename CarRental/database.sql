CREATE DATABASE 'kolcsonzo' DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;

-------------------------------------------------

CREATE TABLE ugyfel
(
    jogositvany VARCHAR(10) PRIMARY KEY NOT NULL,
    nev VARCHAR(60) NOT NULL,
    anyjaNeve VARCHAR(60) NOT NULL,
    szulDatum DATE,
    lakcim VARCHAR(50),
    telefon VARCHAR(13)
);

-------------------------------------------------

CREATE TABLE kocsik
(
    rendszam VARCHAR(6) PRIMARY KEY NOT NULL,
    marka VARCHAR(40) NOT NULL,
    tipus VARCHAR(40) NOT NULL,
    terfogat INT(5) NOT NULL,
    uzemanyag VARCHAR(20),
    kilometer INT(6) not null,
    muszakiVege DATE,
    napiDij INT(5) not null,
    Leiras TEXT(500),
    stat INT(1)
);

-------------------------------------------------

CREATE TABLE berlesek
(
    berlesAzon INT PRIMARY KEY NOT NULL,
    bRendszam VARCHAR(6) NOT NULL,
    bJogositvany VARCHAR(10) NOT NULL,
    bkezdete DATE,
    bvege DATE,
    FOREIGN KEY(bRendszam) REFERENCES kocsik(rendszam),
    FOREIGN KEY(bJogositvany) REFERENCES ugyfel(jogositvany)
);

-------------------------------------------------

ALTER TABLE `berlesek` CHANGE `berlesAzon` `berlesAzon` INT(11) NOT NULL AUTO_INCREMENT;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_UjKocsi
(
    IN rendszam VARCHAR(6),
    IN marka VARCHAR(40),
    IN tipus VARCHAR(40),
    IN terfogat INT(5),
    IN uzemanyag VARCHAR(20),
    IN kilometer INT(6),
    IN muszakiVege DATE,
    IN napiDij INT(5),
    IN Leiras TEXT(500),
    IN stat INT(1)
)
BEGIN
	INSERT INTO kocsik(rendszam, marka, tipus, terfogat, uzemanyag, kilometer, muszakiVege, napiDij, Leiras, stat)
    VALUES(rendszam, marka, tipus, terfogat, uzemanyag, kilometer, muszakiVege, napiDij, Leiras, stat);
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_CheckRendszam(IN rendszam VARCHAR(6))
BEGIN
	SELECT count(kocsik.marka) AS 'foglalt'
	FROM kocsik
	WHERE kocsik.rendszam = rendszam;
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PORCEDURE pr_CheckJogsi
BEGIN
	SELECT count(ugyfel.nev) AS 'foglalt'
	FROM ugyfel
	WHERE ugyfel.jogositvany = jogsi;
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_UjUgyfel
(
    IN jogsi VARCHAR(10),
    IN nev VARCHAR(60),
    IN anya VARCHAR(60),
    IN datum DATE,
    IN cim VARCHAR(50),
    IN tel VARCHAR(13)
)
BEGIN
	INSERT into ugyfel(jogositvany, nev, anyjaNeve, szulDatum, lakcim, telefon)
	VALUES(jogsi, nev, anya, datum, cim, tel);
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_Ugyfelek()
BEGIN
	SELECT
		ugyfel.jogositvany AS 'Jogsi',
	    ugyfel.nev AS 'Nev'
	FROM ugyfel;
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_Kocsik()
BEGIN
	SELECT
		kocsik.rendszam,
	    kocsik.marka,
	    kocsik.tipus
	FROM kocsik
	WHERE kocsik.stat = 0;
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_UjBerles
(
    IN brend VARCHAR(6),
    IN bjogsi VARCHAR(10),
    IN bkez DATE,
    IN bveg DATE
)

BEGIN
	INSERT INTO berlesek(bRendszam, bJogositvany, bkezdete, bvege)
    VALUES (brend, bjogsi, bkez, bveg);
    
    UPDATE kocsik
    SET kocsik.stat = 1
    WHERE kocsik.rendszam = brend

END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_OsszesKocsi()
BEGIN
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
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_KocsiModosit
(
    IN Mrendszam VARCHAR(6),
    IN Mmarka VARCHAR(40),
    IN Mtipus VARCHAR(40),
    IN Mterfogat INT(5),
    IN Muzemanyag VARCHAR(20),
    IN Mkilometer INT(6),
    IN Mmuszakivege DATE,
    IN Mnapidij INT(5),
    IN Mleiras TEXT,
    IN Mstat INT(1)
)
BEGIN
	
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
    
END $$

DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_ValasztottKocsi(IN vrendszam VARCHAR(6))
BEGIN
	SELECT *
	FROM kocsik
    WHERE kocsik.rendszam = vrendzsam;
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_UgyfelModosit
(
	IN Mjogositvany VARCHAR(10),
	IN Mnev VARCHAR(60),
	IN Mlakcim VARCHAR(50),
	IN Mtel VARCHAR(13)
)
BEGIN
	UPDATE ugyfel
    SET 
    	ugyfel.nev = Mnev,
        ugyfel.lakcim = Mlakcim,
        ugyfel.telefon = Mtel
    WHERE ugyfel.jogositvany = Mjogositvany;
END $$
DELIMITER ;

-------------------------------------------------

DELIMITER $$
CREATE PROCEDURE pr_LegtobbetKoltott()
BEGIN
	SELECT
		ugyfel.jogositvany,
	    ugyfel.nev,
	    SUM((berlesek.bvege - berlesek.bkezdete) * kocsik.napiDij) AS 'osszkoltes'
	FROM
		ugyfel
	    LEFT JOIN berlesek ON ugyfel.jogositvany = berlesek.bJogositvany
	    LEFT JOIN kocsik ON berlesek.bRendszam = kocsik.rendszam
	ORDER BY osszkoltes DESC;
END $$
DELIMITER ;
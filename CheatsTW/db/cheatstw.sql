-- phpMyAdmin SQL Dump
-- version 3.5.5
-- http://www.phpmyadmin.net
--
-- Host: api.xpeedo.net
-- Generation Time: Nov 09, 2016 at 05:13 PM
-- Server version: 10.1.18-MariaDB-cll-lve
-- PHP Version: 5.3.28

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `brutefor_cheats`
--

-- --------------------------------------------------------

--
-- Table structure for table `cheatstw`
--

CREATE TABLE IF NOT EXISTS `cheatstw` (
  `user` varchar(20) COLLATE ascii_bin NOT NULL COMMENT 'Aici este numele jucatorului',
  `userpc` text COLLATE ascii_bin COMMENT 'Numele PC-ului clientului.',
  `version` text COLLATE ascii_bin COMMENT 'Versiunea curenta a clientului',
  `cd_key` varchar(16) COLLATE ascii_bin NOT NULL COMMENT 'key-ul jucatorului',
  `use_key` binary(1) NOT NULL DEFAULT '0' COMMENT 'Daca este 0 inseamna ca key-ul nu este folosit, iar daca este 1 inseamna ca, key-ul este folosit.',
  `email` text COLLATE ascii_bin NOT NULL COMMENT 'email-ul cumparatorului',
  `hash` text COLLATE ascii_bin COMMENT 'MAC-ul cumparatorului sub forma de Hash',
  `blocked` binary(1) NOT NULL DEFAULT '0' COMMENT 'Verifica daca este blocat!',
  `ip` text COLLATE ascii_bin COMMENT 'Aici este ultimul IP conectat pe key!',
  `download` binary(1) NOT NULL DEFAULT '0' COMMENT 'Daca este 0 codul poate fi descarcat, iar daca este 1 nu poate fi descarcat',
  PRIMARY KEY (`user`),
  FULLTEXT KEY `cd_key` (`cd_key`)
) ENGINE=MyISAM DEFAULT CHARSET=ascii COLLATE=ascii_bin COMMENT='Aici se afla baza de date unde se pot gasi key-urile ca sa poti accesa cheat-ul.';

--
-- Dumping data for table `cheatstw`
--

INSERT INTO `cheatstw` (`user`, `userpc`, `version`, `cd_key`, `use_key`, `email`, `hash`, `blocked`, `ip`, `download`) VALUES
('Xpeedo', 'XPEEDO', '3', '1234567890abcdef', '0', 'xpeedo@cheatstw.com', NULL, '0', NULL, '0');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

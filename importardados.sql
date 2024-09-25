-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 25-Set-2024 às 12:07
-- Versão do servidor: 5.7.11
-- PHP Version: 7.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `importardados`
--
CREATE DATABASE IF NOT EXISTS `importardados` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `importardados`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `pera`
--

DROP TABLE IF EXISTS `pera`;
CREATE TABLE IF NOT EXISTS `pera` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(70) NOT NULL,
  `Idade` varchar(70) NOT NULL,
  `NomeMae` varchar(70) NOT NULL,
  `Endereco` varchar(70) NOT NULL,
  `Telefone` varchar(70) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `pera`
--

INSERT INTO `pera` (`id`, `Nome`, `Idade`, `NomeMae`, `Endereco`, `Telefone`) VALUES
(2, 'Levi', '18', 'Suane', 'Meia Praia', 'Sei la');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

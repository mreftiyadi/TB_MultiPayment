-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 06, 2018 at 01:34 PM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `multipayment`
--
CREATE DATABASE IF NOT EXISTS `multipayment` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `multipayment`;

-- --------------------------------------------------------

--
-- Table structure for table `listrik`
--

CREATE TABLE IF NOT EXISTS `listrik` (
  `no` int(11) NOT NULL,
  `no_meter` varchar(50) NOT NULL,
  `nama_plg` varchar(50) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `tanggal` date NOT NULL,
  `jml_nominal` int(50) NOT NULL,
  `total` int(50) NOT NULL,
  PRIMARY KEY (`no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pulsa`
--

CREATE TABLE IF NOT EXISTS `pulsa` (
  `no` int(11) NOT NULL,
  `nama_pembeli` varchar(50) NOT NULL,
  `no_hp` varchar(50) NOT NULL,
  `operator` varchar(50) NOT NULL,
  `tanggal` date NOT NULL,
  `jumlah_nominal` int(11) NOT NULL,
  `jumlah_bayar` int(11) NOT NULL,
  PRIMARY KEY (`no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tv_kabel`
--

CREATE TABLE IF NOT EXISTS `tv_kabel` (
  `no` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `no_layanan` varchar(50) NOT NULL,
  `tanggal` date NOT NULL,
  `tv` varchar(50) NOT NULL,
  `paket` varchar(50) NOT NULL,
  `jml_bayar` int(50) NOT NULL,
  PRIMARY KEY (`no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `voucher`
--

CREATE TABLE IF NOT EXISTS `voucher` (
  `no` int(11) NOT NULL,
  `jenis_voucher` varchar(50) NOT NULL,
  `no_hp` varchar(50) NOT NULL,
  `tgl` date NOT NULL,
  `jml_beli` int(11) NOT NULL,
  `jml_nominal` int(11) NOT NULL,
  `jml_bayar` int(11) NOT NULL,
  PRIMARY KEY (`no`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

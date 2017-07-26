-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 26, 2017 at 03:41 PM
-- Server version: 10.1.19-MariaDB
-- PHP Version: 5.6.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `counterhp`
--

-- --------------------------------------------------------

--
-- Table structure for table `jurnal`
--

CREATE TABLE `jurnal` (
  `IdJurnal` bigint(20) NOT NULL,
  `TglJurnal` date NOT NULL,
  `TipeJurnal` char(1) NOT NULL,
  `IdRekanan` int(11) NOT NULL,
  `Keterangan` varchar(255) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `kas`
--

CREATE TABLE `kas` (
  `IdKas` bigint(20) NOT NULL,
  `Tglkas` date NOT NULL,
  `TipeKas` char(1) NOT NULL,
  `Keterangan` varchar(255) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `masterpulsa`
--

CREATE TABLE `masterpulsa` (
  `IdMasterPulsa` int(11) NOT NULL,
  `IdProvider` int(11) NOT NULL,
  `KodeMasterPulsa` varchar(25) NOT NULL,
  `Keterangan` varchar(50) NOT NULL,
  `Harga` int(11) NOT NULL,
  `IsActive` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `masterpulsa`
--

INSERT INTO `masterpulsa` (`IdMasterPulsa`, `IdProvider`, `KodeMasterPulsa`, `Keterangan`, `Harga`, `IsActive`) VALUES
(1, 1, 'SN 5K', 'Lancar', 5500, b'1'),
(2, 1, 'SN 10K', 'Lancar', 10550, b'1');

-- --------------------------------------------------------

--
-- Table structure for table `provider`
--

CREATE TABLE `provider` (
  `IdProvider` int(11) NOT NULL,
  `NamaProvider` varchar(50) NOT NULL,
  `IsActive` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `provider`
--

INSERT INTO `provider` (`IdProvider`, `NamaProvider`, `IsActive`) VALUES
(1, 'Simpati', b'1'),
(2, 'IM3', b'1'),
(3, 'XL', b'1');

-- --------------------------------------------------------

--
-- Table structure for table `rekanan`
--

CREATE TABLE `rekanan` (
  `IdRekanan` int(11) NOT NULL,
  `TipeRekanan` char(1) NOT NULL,
  `NamaRekanan` varchar(255) NOT NULL,
  `Alamat` varchar(255) NOT NULL,
  `NoTlp` varchar(15) NOT NULL,
  `IsActive` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `rekanan`
--

INSERT INTO `rekanan` (`IdRekanan`, `TipeRekanan`, `NamaRekanan`, `Alamat`, `NoTlp`, `IsActive`) VALUES
(1, 'S', 'Hofi Pulsa', 'test', '111', b'1'),
(2, 'P', 'Diah', 'Cipocok', '122', b'1'),
(3, 'S', 'aa', 'aa', '860000', b'1');

-- --------------------------------------------------------

--
-- Table structure for table `saldopulsa`
--

CREATE TABLE `saldopulsa` (
  `IdSaldo` bigint(20) NOT NULL,
  `IdTopup` bigint(20) NOT NULL,
  `Saldo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `topupsaldo`
--

CREATE TABLE `topupsaldo` (
  `IdTopup` bigint(20) NOT NULL,
  `TglTopup` date NOT NULL,
  `JenisTopup` varchar(15) NOT NULL,
  `IdRekanan` int(11) NOT NULL,
  `jumlahtopup` int(11) NOT NULL,
  `Status` tinyint(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `jurnal`
--
ALTER TABLE `jurnal`
  ADD PRIMARY KEY (`IdJurnal`);

--
-- Indexes for table `kas`
--
ALTER TABLE `kas`
  ADD PRIMARY KEY (`IdKas`);

--
-- Indexes for table `masterpulsa`
--
ALTER TABLE `masterpulsa`
  ADD PRIMARY KEY (`IdMasterPulsa`);

--
-- Indexes for table `provider`
--
ALTER TABLE `provider`
  ADD PRIMARY KEY (`IdProvider`);

--
-- Indexes for table `rekanan`
--
ALTER TABLE `rekanan`
  ADD PRIMARY KEY (`IdRekanan`);

--
-- Indexes for table `saldopulsa`
--
ALTER TABLE `saldopulsa`
  ADD PRIMARY KEY (`IdSaldo`);

--
-- Indexes for table `topupsaldo`
--
ALTER TABLE `topupsaldo`
  ADD PRIMARY KEY (`IdTopup`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

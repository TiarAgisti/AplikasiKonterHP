-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 02, 2017 at 06:24 PM
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
-- Table structure for table `penjualan`
--

CREATE TABLE `penjualan` (
  `IdPenjualan` bigint(20) NOT NULL,
  `TglPenjualan` date NOT NULL,
  `Jenis` char(1) NOT NULL,
  `IdProduk` int(11) NOT NULL,
  `HargaBeli` int(11) NOT NULL,
  `HargaJual` int(11) NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `produk`
--

CREATE TABLE `produk` (
  `IdProduk` int(11) NOT NULL,
  `IdProvider` int(11) NOT NULL,
  `Jenis` char(1) NOT NULL,
  `NamaProduk` varchar(150) NOT NULL,
  `IsActive` bit(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `produkmasuk`
--

CREATE TABLE `produkmasuk` (
  `IdProdukMasuk` bigint(20) NOT NULL,
  `TglProdukMasuk` date NOT NULL,
  `IdProduk` int(11) NOT NULL,
  `Qty` int(11) NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
(1, 'Simpati', b'0'),
(2, 'IM3', b'1'),
(3, 'XL', b'0');

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

-- --------------------------------------------------------

--
-- Table structure for table `returproduk`
--

CREATE TABLE `returproduk` (
  `IdRetur` bigint(20) NOT NULL,
  `TglRetur` date NOT NULL,
  `IdProdukMasuk` bigint(20) NOT NULL,
  `Qty` int(11) NOT NULL,
  `Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `saldopulsa`
--

CREATE TABLE `saldopulsa` (
  `IdSaldo` int(11) NOT NULL,
  `Saldo` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `stokproduk`
--

CREATE TABLE `stokproduk` (
  `IdStok` bigint(20) NOT NULL,
  `IdBarangMasuk` bigint(20) NOT NULL,
  `Stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `topupsaldo`
--

CREATE TABLE `topupsaldo` (
  `IdTopup` bigint(20) NOT NULL,
  `TglTopup` date NOT NULL,
  `jumlahtopup` int(11) NOT NULL,
  `Status` bit(1) NOT NULL
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
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`IdPenjualan`);

--
-- Indexes for table `produk`
--
ALTER TABLE `produk`
  ADD PRIMARY KEY (`IdProduk`);

--
-- Indexes for table `produkmasuk`
--
ALTER TABLE `produkmasuk`
  ADD PRIMARY KEY (`IdProdukMasuk`);

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
-- Indexes for table `returproduk`
--
ALTER TABLE `returproduk`
  ADD PRIMARY KEY (`IdRetur`);

--
-- Indexes for table `saldopulsa`
--
ALTER TABLE `saldopulsa`
  ADD PRIMARY KEY (`IdSaldo`);

--
-- Indexes for table `stokproduk`
--
ALTER TABLE `stokproduk`
  ADD PRIMARY KEY (`IdStok`);

--
-- Indexes for table `topupsaldo`
--
ALTER TABLE `topupsaldo`
  ADD PRIMARY KEY (`IdTopup`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

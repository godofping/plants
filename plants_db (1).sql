-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 25, 2020 at 04:07 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `plants_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `plantcategories`
--

CREATE TABLE `plantcategories` (
  `plantcategoryid` int(6) NOT NULL,
  `plantcategory` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `plantcategories`
--

INSERT INTO `plantcategories` (`plantcategoryid`, `plantcategory`) VALUES
(1, 'Trees'),
(2, 'Shrub'),
(3, 'Herbs'),
(4, 'Grasses');

-- --------------------------------------------------------

--
-- Table structure for table `plants`
--

CREATE TABLE `plants` (
  `plantid` int(6) NOT NULL,
  `plantcategoryid` int(6) DEFAULT NULL,
  `plantcommonname` varchar(200) DEFAULT NULL,
  `plantscientificname` varchar(200) DEFAULT NULL,
  `plantfamily` varchar(100) DEFAULT NULL,
  `plantmorphology` text,
  `planteconomicimportance` text,
  `plantwholeimage` text,
  `plantflowerimage` text,
  `plantleavesimage` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `plantcategories`
--
ALTER TABLE `plantcategories`
  ADD PRIMARY KEY (`plantcategoryid`);

--
-- Indexes for table `plants`
--
ALTER TABLE `plants`
  ADD PRIMARY KEY (`plantid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `plantcategories`
--
ALTER TABLE `plantcategories`
  MODIFY `plantcategoryid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `plants`
--
ALTER TABLE `plants`
  MODIFY `plantid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3352;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

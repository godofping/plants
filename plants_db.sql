-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 24, 2020 at 04:19 PM
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
-- Dumping data for table `plants`
--

INSERT INTO `plants` (`plantid`, `plantcategoryid`, `plantcommonname`, `plantscientificname`, `plantfamily`, `plantmorphology`, `planteconomicimportance`, `plantwholeimage`, `plantflowerimage`, `plantleavesimage`) VALUES
(3307, 4, 'asdxxx', 'sdasdasdasdxxxx', '', 'asdxxasd', 'dasdasdasasdasdasdasd', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\IMLGZI0Q81077LC8RKM5.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\1QLGZQATJTYO6A8KU65N.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\PP92YLWA2HUEIP2LSSG5.JPG'),
(3310, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\CL9LTE3ZYRFR054M5I1K.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\PAF01E90XN790HBMVFGR.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\WD3M1H5JR31GBL0ZWNBS.JPG'),
(3311, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\RG5FGNC42GAWZ3OAD2NZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\YJT1GQ8OWV43A7ENEAHZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\YJT1GQ8OWV43A7ENEAHZ.JPG'),
(3312, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\XLRTJ7F4TZ3R5LLS77PZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\R081BB5NOI5HGE35II3S.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\4PFFJABONEXZGQA58FJZ.JPG'),
(3313, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\Q16SERB3LL45BS99BFBS.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\KGN06V1MF46VMLRNMQPL.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\X5UFEU7NF0YCMXZMDN5S.JPG'),
(3314, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\FZM8QDGO5FKPTR23XPMZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\AE3FHH670ZLF4KKH800S.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\AE3FHH670ZLF4KKH800S.JPG'),
(3315, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\FJPTL197QHFAA2GY352S.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\S8W8T0F8QE7SAENYT2HZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\MMDFK45RKX9IL75B4DWS.JPG'),
(3316, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\SRZTOO7RBF2DRQ1SYIXS.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\SRZTOO7RBF2DRQ1SYIXS.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\5G58WNDSACUVR18SOFDZ.JPG'),
(3317, 4, 'asd', 'asd', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\BMRNZ7GS1VNQYK59JKEZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\508URB6BWEPG9DNNUVTS.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\508URB6BWEPG9DNNUVTS.JPG'),
(3318, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\OU0N2UFCMTBTF7Q4EXAZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\OU0N2UFCMTBTF7Q4EXAZ.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\I9IUUY4VHCDIQ08HP8PS.JPG'),
(3319, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\03AN5HDW7RYVXUBYAA6Z.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\03AN5HDW7RYVXUBYAA6Z.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\DSH2DGJX6NQDW6IY07L6.JPG'),
(3320, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\LIZS4FKR114QNAI7775S.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\FWGZWIAAWK5GY30KIIJL.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\SLNE4IGBVGYXYF7K8FZS.JPG'),
(3321, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\S5Q0Z59UHITIFRLFDVFL.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\5UWF75FVGFL0F2SF3SUS.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\IJ3UF4LWFBDIFEZEUPAZ.JPG'),
(3322, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\I26FASEF1D83XPD9Z5QS.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\P6U1AVAZVS3A8U3M0DKS.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\P6U1AVAZVS3A8U3M0DKS.JPG'),
(3323, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\70MUMEI0L7ONEO63LF10.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\1F42DI8IGRQDPHOGWQGT.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\1F42DI8IGRQDPHOGWQGT.JPG'),
(3324, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\K9WVP1HJ66BQVBRXGSX0.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\XY2AX1NK5247VNYX6PD7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\RCKHP4D30L6X7GGAH0R0.JPG'),
(3325, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\HA0W0RIOKGLHOF943A27.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\HA0W0RIOKGLHOF943A27.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\UZ7B8QOPJCEZORG4T7IE.JPG'),
(3326, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\HU3HVEA76IG25QNZ9QJ0.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\UJAW3EG85E8K52UZZNY7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\UJAW3EG85E8K52UZZNY7.JPG'),
(3327, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\CD2PEXP9VTUXCWXGJPFE.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\JGQCE0LTP9O4N1MTLX9E.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\DV8J64BCKSQUYU46W7O7.JPG'),
(3328, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\J0TX9OECBAJP4C1NQDP7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\WP0CHNKDA7B74O8NGA5E.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\9E6RPMQE934P40FN67LL.JPG'),
(3329, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\W93XCBCWV96SM0MIMPL7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\W93XCBCWV96SM0MIMPL7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\9Y9CKAIXV5ZAMBTHCN1E.JPG'),
(3330, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\TA7ZN0D0AJGKE33P87RF.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\6ZEEV0J19F91EFBOZ56M.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\6ZEEV0J19F91EFBOZ56M.JPG'),
(3331, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\VXUT7MOMTAOMWE3IKFHT.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\QBB0YQE5OTQB76LWVPWM.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\20IF6PK6NPJT7ISVLNCT.JPG'),
(3332, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\F9SGACJQ8O6WO5EQH07T.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\F9SGACJQ8O6WO5EQH07T.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\SYYVICPR7KYDOHLQ7XN0.JPG'),
(3333, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\SH1GDZHATMTY6SZKDC3T.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\568VLZNBSILG646K3AI0.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\IVFATYTCRFEY6GDKT7Y7.JPG'),
(3334, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\IFIVOMMVDG9JNRREYNE0.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\V4OAWLSWCD10N3YEOKU7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\PJ6HOPIF7W3QYWGRZU80.JPG'),
(3335, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\7DYBZ8RGXBO35QK8KXP7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\7DYBZ8RGXBO35QK8KXP7.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\2RFIRCHZSUQTGJ2MV741.JPG'),
(3336, 4, 'asd', 'asdasd', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\XBEQAUV1H64NMPC2671F.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\RPWX2YLJCP6DXIUGHIF8.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\4E2CAYSKBLYVXU1F7FVF.JPG'),
(3337, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\HNCCDLQ4WJMXFHNA3SQF.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\UCJRLKW5VGEFESU9TP6M.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\1F7DLNSPPV8MQXJMUX0M.JPG'),
(3338, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\EOGEOAR9ATWP7K4HPAWM.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\EOGEOAR9ATWP7K4HPAWM.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\RDNTWAXA9QO77WBGF7BT.JPG'),
(3339, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\BPLFZ0SEO45H0OMOCS1T.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\NERU8ZYFO0YY0ZTN2PH0.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\NERU8ZYFO0YY0ZTN2PH0.JPG'),
(3340, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\NYUG3NQY92TJHB7I85XT.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\0N1VBMWZ8YL1HMEIY2D0.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\U1I22QMI3HNRSFWV9CRU.JPG'),
(3341, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\DVAVE9VJTW84ZA0CUF81.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\7AS26DL1OGATA3IP5PNU.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\KZZHECR2NC3BAEPPVM21.JPG'),
(3342, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\3TRAPW03DROOG9S6FPJ8.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\X78HHZQM8AQER1AJQZY1.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\AWFWPZWN77IVRDHJGXE8.JPG'),
(3343, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\G20BSJYNYPBRXWD1B2F8.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\AGIIKMO6T8DG9PVEMCU1.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\AGIIKMO6T8DG9PVEMCU1.JPG'),
(3344, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\FL3WN6R6KR6CF7RVGHV1.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\SAABV6X7JNZTFJZV6FB8.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\MPRIN9NQE70JQCH8HPP1.JPG'),
(3345, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\LRPARQU6BAZ7LQNDBMX1.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\LRPARQU6BAZ7LQNDBMX1.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\LRPARQU6BAZ7LQNDBMX1.JPG'),
(3346, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\RWBOUAW61ST3R8KU5SY1.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\4LH329271PLKRKRUVPE8.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\YZZAUDSQV8NA2D976ZS1.JPG'),
(3347, 4, '', '', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\HUR35W1RLN8N97COR298.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\B88BX0RAG6ACK0U12CO1.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\OXFQ5ZXBG32UKC11S938.JPG'),
(3348, 2, 'asd', 'sdasdasd', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\6NS30YJB27VORC9D8LHI.jpg', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\image-icon-png-8.png', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\image-icon-png-8.png'),
(3349, 4, 'asda', 'asd', '', '', '', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\image-icon-png-8.png', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\image-icon-png-8.png', 'C:\\xampp\\htdocs\\plants\\plants.PL\\bin\\Debug\\img\\image-icon-png-8.png');

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
  MODIFY `plantid` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3350;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

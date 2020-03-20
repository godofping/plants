/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.1.38-MariaDB : Database - plants_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`plants_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `plants_db`;

/*Table structure for table `plantcategories` */

DROP TABLE IF EXISTS `plantcategories`;

CREATE TABLE `plantcategories` (
  `plantcategoryid` int(6) NOT NULL AUTO_INCREMENT,
  `plantcategory` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`plantcategoryid`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `plantcategories` */

insert  into `plantcategories`(`plantcategoryid`,`plantcategory`) values (1,'Trees'),(2,'Shrub'),(3,'Herbs'),(4,'Grasses');

/*Table structure for table `plants` */

DROP TABLE IF EXISTS `plants`;

CREATE TABLE `plants` (
  `plantid` int(6) NOT NULL AUTO_INCREMENT,
  `plantcategoryid` int(6) DEFAULT NULL,
  `plantcommonname` varchar(200) DEFAULT NULL,
  `plantscientificname` varchar(200) DEFAULT NULL,
  `plantfamily` varchar(100) DEFAULT NULL,
  `plantmorphology` text,
  `planteconomicimportance` text,
  `plantwholeimage` longblob,
  `plantflowerimage` longblob,
  `plantleavesimage` longblob,
  PRIMARY KEY (`plantid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `plants` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

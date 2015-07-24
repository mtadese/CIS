CREATE DATABASE  IF NOT EXISTS `his_record` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `his_record`;
-- MySQL dump 10.13  Distrib 5.1.40, for Win32 (ia32)
--
-- Host: localhost    Database: his_record
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Not dumping tablespaces as no INFORMATION_SCHEMA.FILES table on this server
--

--
-- Table structure for table `clinicians`
--

DROP TABLE IF EXISTS `clinicians`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `clinicians` (
  `clnc_sys_id` int(11) NOT NULL auto_increment,
  `clnc_id` varchar(45) NOT NULL,
  `title` varchar(30) default NULL,
  `lastName` varchar(45) NOT NULL COMMENT '				',
  `firstName` varchar(45) default NULL,
  `specialty` varchar(45) default NULL,
  `department` varchar(45) default NULL,
  `address` varchar(45) default NULL,
  `phone` varchar(35) default NULL,
  `email` varchar(45) default NULL,
  `date_created` datetime default NULL,
  `date_amended` datetime default NULL,
  PRIMARY KEY  (`clnc_sys_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clinicians`
--

LOCK TABLES `clinicians` WRITE;
/*!40000 ALTER TABLE `clinicians` DISABLE KEYS */;
INSERT INTO `clinicians` VALUES (1,'C01','Dr','Test','Orlando','GP','Consultation','Lagos','0','',NULL,'2013-08-28 15:06:20'),(2,'C02','Surgeon','Test2','Aliko','General Surgery','Surgery','Ikeja','13452','Doc@Aliko.com','2013-08-27 02:07:33','2013-08-28 15:32:25'),(3,'C03','Mrs.','','','','','','0','','2013-08-27 02:16:44','2013-08-28 15:11:21');
/*!40000 ALTER TABLE `clinicians` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-04-15 22:38:11

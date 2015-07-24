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
-- Table structure for table `appointments`
--

DROP TABLE IF EXISTS `appointments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `appointments` (
  `appointments_id` int(11) NOT NULL auto_increment,
  `clinician_id` varchar(30) NOT NULL,
  `clinician_name` varchar(45) NOT NULL,
  `patient_id` int(11) NOT NULL,
  `hospital_number` varchar(30) default NULL,
  `patient_name` varchar(45) default NULL,
  `date_of_appointment` date NOT NULL,
  `time_of_appointment` time NOT NULL,
  `purpose_of_appointment` varchar(100) default NULL,
  `patient_attended` varchar(10) default NULL,
  `time_arrived` time default NULL,
  `time_departed` time default NULL,
  `appointment_outcome` varchar(300) default NULL,
  `date_created` datetime default NULL,
  `date_amended` datetime default NULL,
  PRIMARY KEY  (`appointments_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointments`
--

LOCK TABLES `appointments` WRITE;
/*!40000 ALTER TABLE `appointments` DISABLE KEYS */;
INSERT INTO `appointments` VALUES (1,'C01','Dr Test',1,'H1','Test Mike','2013-09-06','10:00:00','Consultation',NULL,NULL,NULL,NULL,'2013-09-01 20:11:41',NULL),(2,'C01','Dr Test',2,'H2a','Mtest2 Gab','2013-09-27','00:00:00','',NULL,NULL,NULL,NULL,'2013-09-08 18:21:18',NULL),(3,'C02','Surgeon Test2',1,'H1','Test Mike','2015-04-21','00:00:00','consultation',NULL,NULL,NULL,NULL,'2015-04-15 20:22:20',NULL),(4,'C01','Dr Test',1,'H1','Test Mike','2015-04-21','12:30:00','consultation',NULL,NULL,NULL,NULL,'2015-04-15 22:33:21',NULL);
/*!40000 ALTER TABLE `appointments` ENABLE KEYS */;
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

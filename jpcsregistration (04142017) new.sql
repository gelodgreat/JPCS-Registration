CREATE DATABASE  IF NOT EXISTS `jpcsregistration` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `jpcsregistration`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: jpcsregistration
-- ------------------------------------------------------
-- Server version	5.6.26-log

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
-- Table structure for table `auth_accounts`
--

DROP TABLE IF EXISTS `auth_accounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `auth_accounts` (
  `studno` varchar(13) NOT NULL,
  `fname` varchar(45) NOT NULL,
  `lname` varchar(45) NOT NULL,
  `gender` varchar(45) NOT NULL,
  `isofficer` varchar(10) NOT NULL,
  `address` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(255) NOT NULL,
  `securityquestion` varchar(100) NOT NULL,
  `securityanswer` varchar(100) NOT NULL,
  PRIMARY KEY (`studno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `auth_accounts`
--

LOCK TABLES `auth_accounts` WRITE;
/*!40000 ALTER TABLE `auth_accounts` DISABLE KEYS */;
INSERT INTO `auth_accounts` VALUES ('13-02321','Angelo','Umali','Male','Yes','Pandacan','gelodgreat','a47d8a5e9e6ebb80b5461277c699d5fe0329ef6b3c6477159c2c1879f7b0108b513597053885c21c0f17e618cb1a88e473b1b57b3e93e55bda51f66a16a2d96b','What is your dream job?','Soldier');
/*!40000 ALTER TABLE `auth_accounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `memberlist`
--

DROP TABLE IF EXISTS `memberlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `memberlist` (
  `slotnum` int(11) DEFAULT NULL,
  `ornumber` varchar(15) DEFAULT NULL,
  `studno` varchar(8) NOT NULL,
  `lname` varchar(15) DEFAULT NULL,
  `fname` varchar(50) DEFAULT NULL,
  `mname` varchar(15) DEFAULT NULL,
  `courseyearsection` varchar(10) NOT NULL,
  `emailaddress` varchar(100) DEFAULT NULL,
  `birthday` datetime DEFAULT NULL,
  `nationality` varchar(15) DEFAULT NULL,
  `cityaddress` varchar(100) DEFAULT NULL,
  `provinceaddress` varchar(100) DEFAULT NULL,
  `contactnumber` varchar(255) DEFAULT NULL,
  `emergencycontactname` varchar(45) DEFAULT NULL,
  `emergencycontactnumber` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`studno`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `memberlist`
--

LOCK TABLES `memberlist` WRITE;
/*!40000 ALTER TABLE `memberlist` DISABLE KEYS */;
/*!40000 ALTER TABLE `memberlist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-14 15:32:41

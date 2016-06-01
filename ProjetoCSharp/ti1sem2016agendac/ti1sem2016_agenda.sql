CREATE DATABASE  IF NOT EXISTS `ti1sem2016` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `ti1sem2016`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: ti1sem2016
-- ------------------------------------------------------
-- Server version	5.5.8

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
-- Table structure for table `agenda`
--

DROP TABLE IF EXISTS `agenda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `agenda` (
  `agdid` int(11) NOT NULL,
  `agdnome` varchar(30) NOT NULL,
  `agdtelefone` varchar(14) DEFAULT NULL,
  `agdemail` varchar(30) DEFAULT NULL,
  `agddtnasc` date DEFAULT NULL,
  `agdcpf` varchar(13) DEFAULT NULL,
  `agdsalario` decimal(10,2) DEFAULT NULL,
  `agdlogin` varchar(20) DEFAULT NULL,
  `agdsenha` varchar(20) DEFAULT NULL,
  `agdperfil` varchar(20) DEFAULT NULL,
  `agdfilhos` smallint(6) DEFAULT NULL,
  PRIMARY KEY (`agdid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agenda`
--

LOCK TABLES `agenda` WRITE;
/*!40000 ALTER TABLE `agenda` DISABLE KEYS */;
INSERT INTO `agenda` VALUES (1,'thiago da silva','(11)3656-8907','titi@gmail.com','1995-12-06','987654321-11',2356.69,'thiago da silva','123','administrador',2),(2,'keity da silva','(11)3656-9007','keke@gmail.com','1990-12-09','987654321-11',2500.69,'keity da silva','234','usuario',NULL),(3,'luiz da silva','(11)3656-8007','lulu@gmail.com','1988-12-09','987654321-11',2200.69,'luiz da silva','345','usuario',NULL),(4,'rodrigo da silva','(11)3656-9010','roro@gmail.com','1992-10-20','987654321-11',2100.69,'rodrigo da silva','456','usuario',1);
/*!40000 ALTER TABLE `agenda` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-04-11 22:30:20

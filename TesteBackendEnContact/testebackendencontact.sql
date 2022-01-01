-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: testebackendencontact
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20211230192235_inicial','5.0.13');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `companies`
--

DROP TABLE IF EXISTS `companies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `companies` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ContactBookId` int NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `companies`
--

LOCK TABLES `companies` WRITE;
/*!40000 ALTER TABLE `companies` DISABLE KEYS */;
INSERT INTO `companies` VALUES (1,1,'CocaCola'),(2,2,'Pepsi'),(3,3,'McDonald\'s'),(4,4,'Microsoft'),(5,5,'Google'),(6,6,'Stone');
/*!40000 ALTER TABLE `companies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contactbooks`
--

DROP TABLE IF EXISTS `contactbooks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contactbooks` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contactbooks`
--

LOCK TABLES `contactbooks` WRITE;
/*!40000 ALTER TABLE `contactbooks` DISABLE KEYS */;
INSERT INTO `contactbooks` VALUES (1,'FuncionariosCocaCola'),(2,'FuncionariosPepsi'),(3,'FuncionariosMcDonalds'),(4,'FuncionariosMicrosoft'),(5,'FuncionariosGoogle');
/*!40000 ALTER TABLE `contactbooks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contacts`
--

DROP TABLE IF EXISTS `contacts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `contacts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ContactBookId` int NOT NULL,
  `CompanyId` int NOT NULL,
  `Name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Phone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Email` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Address` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contacts`
--

LOCK TABLES `contacts` WRITE;
/*!40000 ALTER TABLE `contacts` DISABLE KEYS */;
INSERT INTO `contacts` VALUES (1,1,1,'Homem Aranha','67999999999','homemaranha@marvel.com','rua coca, campo grande - ms'),(2,1,1,'batman','671235689','batman@cocacola.com','rua coca, campo grande - ms'),(3,1,1,'homem de ferro','9563254612','homemdeferro@cocacola.com','rua coca, campo grande - ms'),(4,1,1,'hulk','63258741','hulk@cocacola.com','rua coca, campo grande - ms'),(5,2,2,'flash','325697412','flash@pepsi.com','rua pepsi, campo grande - ms'),(6,2,2,'capitao amaerica','531975612','capitao@pepsi.com','rua pepsi, campo grande - ms'),(7,2,2,'viuva negra','9521265','viuva@pepsi.com','rua pepsi, campo grande - ms'),(8,2,2,'dr estranho','64973258','drestranho@pepsi.com','rua pepsi, campo grande - ms'),(9,3,3,'tocha humana','349765623','tochahumana@mcdonalds.com','rua mc donalds, campo grande - ms'),(10,3,3,'wolverine','365648913','wolverine@mcdonalds.com','rua mc donalds, campo grande - ms'),(11,3,3,'superman','6973213265','superman@mcdonalds.com','rua mc donalds, campo grande - ms'),(12,3,3,'demolidor','74533258','demolidor@mcdonalds.com','rua mc donalds, campo grande - ms'),(13,4,4,'mulher gato','34965523','mgato@microsoft.com','rua microsoft, campo grande - ms'),(14,4,4,'homem formiga','5793226894','hformiga@microsoft.com','rua microsoft, campo grande - ms'),(15,4,4,'mysterio','7631598','mysterio@microsoft.com','rua microsoft, campo grande - ms'),(16,4,4,'thanos','397612356','thanos@microsoft.com','rua microsoft, campo grande - ms'),(17,5,5,'gaviao arqueiro','3976231','gaviao@google.com','rua google, campo grande - ms'),(18,5,5,'thor','3469785221560','thor@google.com','rua google, campo grande - ms'),(19,5,5,'falcao','456322189','falcao@google.com','rua google, campo grande - ms'),(20,5,5,'capita marvel','98630254','capitam@google.com','rua google, campo grande - ms'),(21,6,6,'Helena','973468251','helena@stone.com','rua stone, campo grande - ms'),(22,6,6,'Arthur','973468252','arthur@stone.com','rua stone, campo grande - ms'),(23,6,6,'Heitor','973468253','heitor@stone.com','rua stone, campo grande - ms'),(24,6,6,'Bernardo','973468254','bernardo@stone.com','rua stone, campo grande - ms'),(25,7,7,'Davi','973468255','davi@nubank.com','rua nubank, campo grande - ms'),(26,7,7,'Théo','973468256','davi@nubank.com','rua nubank, campo grande - ms'),(27,7,7,'Jose','999999966','jose@nubank','rua nubank, campo grande - ms'),(28,7,7,'Gabriel','973468258','davi@nubank.com','rua nubank, campo grande - ms');
/*!40000 ALTER TABLE `contacts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'testebackendencontact'
--

--
-- Dumping routines for database 'testebackendencontact'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-31 20:27:25

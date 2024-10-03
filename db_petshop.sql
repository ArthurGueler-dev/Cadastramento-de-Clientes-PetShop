-- MySQL dump 10.13  Distrib 8.0.39, for Win64 (x86_64)
--
-- Host: localhost    Database: db_petshop
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cadastro`
--

DROP TABLE IF EXISTS `cadastro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cadastro` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `tipo_animal` varchar(45) NOT NULL,
  `raça` varchar(45) DEFAULT NULL,
  `data_registro` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `data_nascimento` date NOT NULL,
  `peso` varchar(5) NOT NULL,
  `telefone` varchar(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadastro`
--

LOCK TABLES `cadastro` WRITE;
/*!40000 ALTER TABLE `cadastro` DISABLE KEYS */;
INSERT INTO `cadastro` VALUES (1,'bruce','cachorro','srd','2024-09-18 23:48:15','2020-10-22','20kg','27998551098'),(2,'Holliver','Cachorro','chow-chow','2024-09-20 02:16:41','2020-04-09','18kg','279990000'),(3,'Chico','Papagaio','Papagaio-Charão','2024-09-21 06:35:42','2004-04-05','400g','279999000'),(4,'Akame','Gato','srd','2024-09-21 06:38:28','2004-05-04','5kg','278889999'),(5,'Crystal','Gato','srd','2024-09-21 19:35:02','2011-05-06','3kg','2799998844');
/*!40000 ALTER TABLE `cadastro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultas`
--

DROP TABLE IF EXISTS `consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `consultas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `animal_id` int NOT NULL,
  `data_consulta` datetime NOT NULL,
  `sintomas` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `animal_id` (`animal_id`),
  CONSTRAINT `consultas_ibfk_1` FOREIGN KEY (`animal_id`) REFERENCES `cadastro` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-10-03  2:29:14

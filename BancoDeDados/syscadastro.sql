CREATE DATABASE  IF NOT EXISTS `syscadastro` /*!40100 DEFAULT CHARACTER SET utf8mb3 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `syscadastro`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: localhost    Database: syscadastro
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `convenio`
--

DROP TABLE IF EXISTS `convenio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `convenio` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) DEFAULT NULL,
  `fl_status` enum('I','A') NOT NULL DEFAULT 'A' COMMENT ' I - INATIVO;  A - ATIVO;',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `convenio`
--

LOCK TABLES `convenio` WRITE;
/*!40000 ALTER TABLE `convenio` DISABLE KEYS */;
INSERT INTO `convenio` VALUES (1,'Unimed','A'),(2,'Bradesco','A'),(3,'Amil','A'),(4,'Servmed','A'),(5,'Boa Vida','A'),(6,'Pladsa','A'),(8,'Clinipam','A');
/*!40000 ALTER TABLE `convenio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco`
--

DROP TABLE IF EXISTS `endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `endereco` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pessoa` int NOT NULL,
  `CEP` varchar(15) DEFAULT NULL,
  `rua` varchar(50) NOT NULL,
  `numero` int NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `cidade` varchar(30) NOT NULL,
  `uf` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_endereco_pessoa_idx` (`id_pessoa`),
  CONSTRAINT `fk_endereco_pessoa` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
INSERT INTO `endereco` VALUES (16,16,'89.236-25','Weise',290,'Agua Verde','Blumenau','SC'),(18,18,'89.456-558','asd',123,'asd','Blu','AP');
/*!40000 ALTER TABLE `endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_pessoa` int NOT NULL,
  `id_convenio` int NOT NULL,
  `numero_prontuario` int NOT NULL,
  `paciente_risco` varchar(10) DEFAULT NULL,
  `fl_status` enum('E','A') NOT NULL DEFAULT 'A' COMMENT 'E - EXCLUIDO; A - ATIVO;',
  `fl_obito` tinyint NOT NULL DEFAULT '0' COMMENT '0 - VIVO; 1 - MORTO',
  PRIMARY KEY (`id`),
  KEY `index_nrprontuario` (`numero_prontuario`),
  KEY `fk_paciente_pessoa1_idx` (`id_pessoa`),
  KEY `fk_paciente_convenio1_idx` (`id_convenio`),
  CONSTRAINT `fk_paciente_convenio1` FOREIGN KEY (`id_convenio`) REFERENCES `convenio` (`id`),
  CONSTRAINT `fk_paciente_pessoa1` FOREIGN KEY (`id_pessoa`) REFERENCES `pessoa` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (15,16,1,8306713,'Nenhum','A',0),(17,18,1,6844417,'Grave','A',0);
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pessoa` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(55) NOT NULL,
  `cgccpf` varchar(18) NOT NULL,
  `tipo_pessoa` enum('PF','PJ') NOT NULL COMMENT '0 - PF; 1 - PJ (ENUM)',
  `fl_status` enum('E','A','I') NOT NULL COMMENT 'E  - EXCLUÍDO; A - ATIVO; I - INATIVO',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa`
--

LOCK TABLES `pessoa` WRITE;
/*!40000 ALTER TABLE `pessoa` DISABLE KEYS */;
INSERT INTO `pessoa` VALUES (16,'Alexandre Schwanke da Costa','123.456.789-25','PF','A'),(18,'BobRoss','123.456.789-25','PF','A');
/*!40000 ALTER TABLE `pessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'syscadastro'
--

--
-- Dumping routines for database 'syscadastro'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-10 21:11:40

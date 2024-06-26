DROP DATABASE IF EXISTS administracionEspaciosDeportivos;
CREATE DATABASE administracionEspaciosDeportivos;
USE administracionEspaciosDeportivos;

CREATE TABLE `EspaciosDeportivos` (
    `EspaciosDeportivosId` INT NOT NULL AUTO_INCREMENT,
    `Nombre` VARCHAR(255) NOT NULL,
	`Descripcion` TEXT,
    `Locacion` VARCHAR(255),
	`Capacidad` INT,
	PRIMARY KEY (`EspaciosDeportivosId`)
)ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

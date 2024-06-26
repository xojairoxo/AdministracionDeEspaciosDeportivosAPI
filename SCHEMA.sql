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

CREATE TABLE `Reserva` (
	`ReservaId` INT NOT NULL AUTO_INCREMENT,
    `EspaciosDeportivosId` INT,
    `DiaReservacion` DATE NOT NULL,
    `HoraInicio`  TIME NOT NULL,
     `HoraFinal`  TIME NOT NULL,
     PRIMARY KEY (`ReservaId`),
     FOREIGN KEY (`EspaciosDeportivosId`) REFERENCES `EspaciosDeportivos`(`EspaciosDeportivosId`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `EspaciosDeportivos` (`Nombre`, `Descripcion`, `Locacion`, `Capacidad`)
VALUES
('Cancha de Fútbol', 'Cancha de fútbol reglamentaria con césped natural.', 'Parque Central', 22),
('Gimnasio', 'Gimnasio con equipo completo de entrenamiento y pesas.', 'Centro Deportivo', 100),
('Piscina Olímpica', 'Piscina olímpica con dimensiones de 50m x 25m.', 'Club Deportivo Acuático', 500),
('Cancha de Baloncesto', 'Cancha cubierta con suelo de madera y gradas para espectadores.', 'Escuela Secundaria', 30),
('Campo de Béisbol', 'Campo de béisbol con capacidad para ligas menores.', 'Parque Recreativo', 40);


INSERT INTO `Reserva` (`EspaciosDeportivosId`, `DiaReservacion`, `HoraInicio`, `HoraFinal`) VALUES
(1, '2024-06-25', '09:00:00', '10:00:00'),
(1, '2024-06-26', '10:00:00', '11:00:00'),
(2, '2024-06-25', '11:00:00', '12:00:00'),
(2, '2024-06-26', '12:00:00', '13:00:00'),
(3, '2024-06-25', '14:00:00', '15:00:00'),
(3, '2024-06-26', '15:00:00', '16:00:00'),
(1, '2024-06-27', '09:00:00', '10:00:00'),
(2, '2024-06-27', '10:00:00', '11:00:00'),
(3, '2024-06-27', '11:00:00', '12:00:00'),
(1, '2024-06-28', '12:00:00', '13:00:00');



select * from `EspaciosDeportivos`; 
select * from `Reserva`; 
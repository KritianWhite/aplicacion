CREATE DATABASE INVENTARIO;
USE INVENTARIO;

CREATE TABLE ACTIVO 
(
 ACT_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 PLACA VARCHAR(10) UNIQUE,
 CHASIS VARCHAR(50) NOT NULL UNIQUE,
 TIPO VARCHAR(50) NOT NULL,
 MARCA VARCHAR(50) NOT NULL,
 MODELO VARCHAR(50) NOT NULL,
 COLOR VARCHAR(25),
 ANIO VARCHAR(5) NOT NULL,
 ESTADO VARCHAR(25) NOT NULL
);

CREATE TABLE BAJAS_EQUIPOS 
(
 BAJAS_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 IMEI INT NOT NULL UNIQUE,
 FECHA_BAJA DATETIME NOT NULL
);

CREATE TABLE CLIENTE 
(
 CLI_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 NOMBRE VARCHAR(100) NOT NULL,
 TELEFONO VARCHAR(15),
 CORREO VARCHAR(150)
);

CREATE TABLE MARCA_GPS
(
 ID_MARCA INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 MARCA VARCHAR(100) NOT NULL
);

CREATE TABLE MODELO_GPS
(
 ID_MODELO INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 ID_MARCA INT NOT NULL,
 MODELO VARCHAR(100) NOT NULL,
 FOREIGN KEY (ID_MARCA) REFERENCES MARCA_GPS (ID_MARCA)
);

CREATE TABLE EQUIPO 
(
 EQUI_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 ID_MODELO INT NOT NULL,
 IMEI INT NOT NULL UNIQUE,
 ESTADO VARCHAR(25) NOT NULL,
 FOREIGN KEY (ID_MODELO) REFERENCES MODELO_GPS (ID_MODELO)
);

CREATE TABLE PLATAFORMA 
(
 PLAT_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 NOMBRE VARCHAR(50) NOT NULL
);

CREATE TABLE SIM 
(
 SIM_ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 COMPANIA VARCHAR(15) NOT NULL,
 NUMERO VARCHAR(15) NOT NULL UNIQUE,
 ICC VARCHAR(30) NOT NULL UNIQUE,
 VENCE DATETIME NOT NULL,
 PROPIETARIO VARCHAR(75) NOT NULL,
 ESTADO VARCHAR(25) NOT NULL,
 PLAN_DATOS VARCHAR(250) NOT NULL
);

CREATE TABLE USUARIOS 
(
 ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
 USUARIO VARCHAR(15) NOT NULL UNIQUE,
 CONTRASENIA TEXT NOT NULL,
 ROL VARCHAR(15) NOT NULL
);

CREATE TABLE MIGRACION_SIM 
(
 SIM_SIM_ID INT NOT NULL PRIMARY KEY,
 ICC_ACTUAL VARCHAR(30) NOT NULL UNIQUE,
 ICC_NUEVA VARCHAR(30) NOT NULL UNIQUE,
 FECHA_MIGRACION DATETIME NOT NULL,
 FOREIGN KEY (SIM_SIM_ID) REFERENCES SIM (SIM_ID)
);

CREATE TABLE ASIGNACION_SIM 
(
 EQUIPO_EQUI_ID INT NOT NULL,
 SIM_SIM_ID INT NOT NULL,
 FECHA_ASIGNACION_SIM DATETIME NOT NULL,
 FOREIGN KEY (EQUIPO_EQUI_ID) REFERENCES EQUIPO (EQUI_ID),
 FOREIGN KEY (SIM_SIM_ID) REFERENCES SIM (SIM_ID)
);

CREATE TABLE ASIGNACION_PLATAFORMA 
(
 ACTIVO_ACT_ID INT NOT NULL,
 PLATAFORMA_PLAT_ID INT NOT NULL,
 FECHA_ASIGNACION DATETIME NOT NULL,
 FOREIGN KEY (ACTIVO_ACT_ID) REFERENCES ACTIVO (ACT_ID),
 FOREIGN KEY (PLATAFORMA_PLAT_ID) REFERENCES PLATAFORMA (PLAT_ID)
);

CREATE TABLE ASIGNACION_EQUIPO 
(
 ACTIVO_ACT_ID INT NOT NULL,
 EQUIPO_EQUI_ID INT NOT NULL,
 FECHA_ASIGNACION_EQUIPO DATETIME NOT NULL,
 ESTADO VARCHAR(30) NOT NULL,
 FOREIGN KEY (ACTIVO_ACT_ID) REFERENCES ACTIVO (ACT_ID),
 FOREIGN KEY (EQUIPO_EQUI_ID) REFERENCES EQUIPO (EQUI_ID)
);

CREATE TABLE ASIGNACION_ACTIVO 
(
 ACTIVO_ACT_ID INT NOT NULL,
 CLIENTE_CLI_ID INT NOT NULL,
 FECHA DATETIME NOT NULL,
 FOREIGN KEY (ACTIVO_ACT_ID) REFERENCES ACTIVO (ACT_ID),
 FOREIGN KEY (CLIENTE_CLI_ID) REFERENCES CLIENTE (CLI_ID)
);

INSERT INTO PLATAFORMA(NOMBRE) VALUES("POSITION LOGIC");
INSERT INTO PLATAFORMA(NOMBRE) VALUES("RED GPS");

INSERT INTO MARCA_GPS(MARCA) VALUES("TELTONIKA");
INSERT INTO MARCA_GPS(MARCA) VALUES("QUECLINK");

INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (1, "FMC125");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (1, "FMC130");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (1, "FMC920");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (1, "FMB910");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (1, "FMB920");

INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (2, "GV55");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (2, "GV55N");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (2, "GV55W");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (2, "G300");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (2, "GV300N");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (2, "GV300W");
INSERT INTO MODELO_GPS (ID_MARCA, MODELO) VALUES (2, "GL300W");

SELECT * FROM PLATAFORMA;

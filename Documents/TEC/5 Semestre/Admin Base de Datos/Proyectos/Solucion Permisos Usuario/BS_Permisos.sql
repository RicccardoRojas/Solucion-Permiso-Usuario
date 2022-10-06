CREATE DATABASE permisos;
USE permisos;

CREATE TABLE producto(codigobarras VARCHAR(20),
nombre VARCHAR(50),
descripcion VARCHAR(80),
marca VARCHAR(50)
);

CREATE TABLE herramientas(codigoherramienta INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(50),
medida DOUBLE,
marca VARCHAR(50),
descripcion VARCHAR(100)
);


CREATE TABLE usuarios(idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(50),
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fechanacimiento DATE,
rfc VARCHAR(10),
modulo VARCHAR(30),
pusto VARCHAR(50)
);

CREATE TABLE login(idlogin INT PRIMARY KEY AUTO_INCREMENT,
fkidusuario INT,
constraseña VARCHAR(10),
FOREIGN KEY(fkidusuario)REFERENCES usuarios(idusuario)
);
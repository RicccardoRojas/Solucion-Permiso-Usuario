CREATE DATABASE permisos;
USE permisos;

#Tabla Productos y Almacenados/////////////////////////////////////////////////////////////////////////////////////

CREATE TABLE producto(codigobarras BIGINT PRIMARY KEY,
nombre VARCHAR(50),
descripcion VARCHAR(80),
marca VARCHAR(50)
);

delimiter $$
DROP PROCEDURE if EXISTS insertproducto;
CREATE PROCEDURE insertproducto(
IN _codigobarras BIGINT,
IN _nombre VARCHAR(50),
IN _descripcion VARCHAR(80),
IN _marca VARCHAR(50)
)
BEGIN
DECLARE X INT;
DECLARE A INT;
SELECT COUNT(*)FROM producto WHERE nombre = _nombre INTO X;
SELECT COUNT(*)FROM producto WHERE codigobarras = _codigobarras INTO A;
if X=0 AND A=0 then
INSERT INTO producto VALUES(_codigobarras,_nombre,_descripcion,_marca);
ELSE if X=0 AND A=1 then
UPDATE producto SET nombre = _nombre, descripcion = _descripcion, marca = _marca WHERE codigobarras = _codigobarras;
ELSE
UPDATE producto SET descripcion = _descripcion, marca = _marca WHERE codigobarras = _codigobarras;
END if;
END if;
END;;
 
delimiter $$
DROP PROCEDURE if EXISTS deleteproducto;
CREATE PROCEDURE deleteproducto(
IN _codigobarras BIGINT
)
BEGIN
DELETE FROM producto WHERE codigobarras = _codigobarras;
END;;

delimiter $$
DROP PROCEDURE if EXISTS showproducto;
CREATE PROCEDURE showproducto(
IN _nombre VARCHAR(50)
)
BEGIN
SELECT pr.codigobarras AS Codigo_de_Barras, pr.nombre AS Nombre, pr.descripcion AS Descripcion, pr.marca AS Marca FROM producto pr
WHERE nombre LIKE _nombre ORDER BY nombre;
END;;

CALL insertproducto(654321,'Bujia','Bujia Platinum de Calidad','Castrol');
CALL deleteproducto(654321);
CALL showproducto('%');

# FIN Tabla Productos y Almacenados/////////////////////////////////////////////////////////////////////////////////////



#Tabla Herramientas y Almacenados/////////////////////////////////////////////////////////////////////////////////////

CREATE TABLE herramientas(codigoherramienta INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(50),
medida DOUBLE,
marca VARCHAR(50),
descripcion VARCHAR(100)
);

delimiter $$
DROP PROCEDURE if EXISTS insertherramientas;
CREATE PROCEDURE insertherramientas(
IN _nombre VARCHAR(50),
IN _medida DOUBLE,
IN _marca VARCHAR(50),
IN _descripcion VARCHAR(100),
IN _codigoherramienta INT
)
BEGIN
DECLARE X INT;
SELECT COUNT(*) FROM herramientas WHERE codigoherramienta = _codigoherramienta INTO X;
if X=0 AND _codigoherramienta<0 then
INSERT INTO herramientas VALUES(NULL,_nombre,_medida,_marca,_descripcion);
ELSE if X=0 AND _codigoherramienta>0 then
UPDATE herramientas SET nombre = _nombre, medida = _medida, marca = _marca, descripcion = _descripcion WHERE 
codigoherramienta = _codigoherramienta;
ELSE
UPDATE herramientas SET medida = _medida, marca = _marca, descripcion = _descripcion WHERE 
codigoherramienta = _codigoherramienta;
END if;
END if;
END;;

delimiter $$
DROP PROCEDURE if EXISTS deleteherramientas;
CREATE PROCEDURE deleteherramientas(
IN _codigoherramienta INT
)
BEGIN
DELETE FROM herramientas WHERE codigoherramienta = _codigoherramienta;
END;;

delimiter $$
DROP PROCEDURE if EXISTS showherramientas;
CREATE PROCEDURE showherramientas(
IN _nombre VARCHAR(50)
)
BEGIN
SELECT he.codigoherramienta AS Codigo_Herramienta, he.nombre AS Nombre, he.medida AS Medida,
he.marca AS Marca, he.descripcion AS Descripcion FROM herramientas he WHERE nombre LIKE _nombre ORDER BY nombre;
END;; 

CALL insertherramientas('Desarmador',2.5,'Truper','Acero',-1);
CALL deleteherramientas(2);
CALL showherramientas('%');



#FIN Tabla Herramientas y Almacenados/////////////////////////////////////////////////////////////////////////////////////

#Tabla Usuarios y Almacenados/////////////////////////////////////////////////////////////////////////////////////

CREATE TABLE usuarios(idusuario INT PRIMARY KEY AUTO_INCREMENT,
nombre VARCHAR(50),
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fechanacimiento DATE,
rfc VARCHAR(10),
modulo VARCHAR(30),
puesto VARCHAR(50)
);

delimiter $$
DROP PROCEDURE if EXISTS insertusuarios;
CREATE PROCEDURE insertusuarios(
IN _nombre VARCHAR(50),
IN _apellidop VARCHAR(50),
IN _apellidom VARCHAR(50),
IN _fechanacimiento DATE,
IN _rfc VARCHAR(10),
IN _modulo VARCHAR(30),
IN _puesto VARCHAR(50),
IN _idusuario INT
)
BEGIN
DECLARE X INT;
SELECT COUNT(*)FROM usuarios WHERE idusuario = _idusuario INTO X;
if X=0 AND _idusuario<0 then
INSERT INTO usuarios VALUES(NULL,_nombre,_apellidop,_apellidom,_fechanacimiento,_rfc,_modulo,_puesto);
ELSE if X=0 AND _idusuario>0 then
UPDATE usuarios SET nombre = _nombre, apellidop = _apellidop, apellidom = _apellidom, fechanacimiento = _fechanacimiento, modulo = _modulo,
puesto = _puesto WHERE idusuario = _idusuario;
ELSE
UPDATE usuarios SET apellidop = _apellidop, apellidom = _apellidom, fechanacimiento = _fechanacimiento, modulo = _modulo,
puesto = _puesto WHERE idusuario = _idusuario;
END if;
END if;
END;;

delimiter $$
DROP PROCEDURE if EXISTS deleteusuario;
CREATE PROCEDURE deleteusuario(
IN _idusuario INT
)
BEGIN
DELETE FROM usuarios WHERE idusuario = _idusuario;
END;;

delimiter $$
DROP PROCEDURE if EXISTS showusuarios;
CREATE PROCEDURE showusuarios(
IN _nombre VARCHAR(50)
)
BEGIN
SELECT us.idusuario AS Num_Usuario, us.nombre AS Nombre, us.apellidop AS Apellido_Paterno, 
us.apellidom AS Apellido_Materno, us.fechanacimiento AS Fecha_Nacimiento, us.rfc AS RFC,
us.modulo AS Modulo, us.puesto AS Puesto FROM usuarios us WHERE nombre LIKE _nombre ORDER BY nombre;
END;;

CALL insertusuarios('Giovanni','Rojas','Garcia','2002/02/07','0714DBJJHF','Taller','Obrero',-1);
CALL showusuarios('%');
CALL deleteusuario(2);


#FIN Tabla Usuarios y Almacenados/////////////////////////////////////////////////////////////////////////////////////

#Tabla Login y Almacenados/////////////////////////////////////////////////////////////////////////////////////

CREATE TABLE login(idlogin INT PRIMARY KEY AUTO_INCREMENT,
fkidusuario INT,
constraseña VARCHAR(10),
FOREIGN KEY(fkidusuario)REFERENCES usuarios(idusuario)
);

delimiter $$
DROP PROCEDURE if EXISTS insertlogin;
CREATE PROCEDURE insertlogin(
IN _fkidusuario INT,
IN _contraseña VARCHAR(10),
IN _idlogin INT
)
BEGIN
if _idlogin<0 then
INSERT INTO login VALUES (NULL,_fkidusuario,_contraseña);
if _idlogin>0 then
UPDATE login SET contraseña = _contraseña;
END if;
END if;
END;;

delimiter $$
DROP PROCEDURE if EXISTS deletelogin;
CREATE PROCEDURE deletelogin(
IN _idlogin INT
)
BEGIN
DELETE FROM login WHERE idlogin = _idlogin;
END;;

delimiter $$
DROP PROCEDURE if EXISTS showlogin;
CREATE PROCEDURE showlogin(
IN _nombre VARCHAR(50)
)
BEGIN
SELECT lo.idlogin AS Num_Login, us.nombre AS Nombre, us.apellidop AS Apellido_Paterno,
lo.`constraseña` AS Contraseña FROM login lo, usuarios us WHERE lo.fkidusuario = us.idusuario AND us.nombre LIKE _nombre
ORDER BY nombre;
END;;

CALL insertlogin(3,'jfijiodJDA',-1);
CALL showlogin('%');
CALL deletelogin(2);

#FIN Tabla Login y Almacenados/////////////////////////////////////////////////////////////////////////////////////


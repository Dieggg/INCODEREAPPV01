-- ------------------------------------ --
-- 	Base de datos proyecto Incodere V1 	--
-- ------------------------------------ --

-- Eliminar tablas que puedan estar creadas previamente

DROP TABLE TRABAJADORES;
DROP TABLE PROVEEDORES;
DROP TABLE PRODUCTOS;
DROP TABLE GUIAS;
DROP TABLE COMPRAS;

-- Creación de tablas
CREATE TABLE TRABAJADORES(
	id INT IDENTITY(1,1) PRIMARY KEY,
	rut VARCHAR(15) UNIQUE NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	apellidos VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	nombre_usuario VARCHAR(100) UNIQUE NOT NULL,
	password VARCHAR(2048) NOT NULL,
	ultimo_login DATETIME,
	perfil VARCHAR(10) NOT NULL
);

-- Tabla para clientes empresas
CREATE TABLE PROVEEDORES(
	id INT IDENTITY(1,1) PRIMARY KEY,
	rut VARCHAR(15) UNIQUE NOT NULL,
	telefono VARCHAR(100) NOT NULL,
	email VARCHAR(100) NOT NULL,
	direccion VARCHAR(100) NOT NULL,
	razon_social VARCHAR(100),
	giro VARCHAR(100),
	nombre_representante VARCHAR(100) NOT NULL,
	apellidos_representante VARCHAR(100) NOT NULL,	
);


CREATE TABLE PRODUCTOS(
	codigo_interno INT IDENTITY(1,1) PRIMARY KEY,
	descripcion VARCHAR(200) NOT NULL,
	stock INT NOT NULL,
	unidad VARCHAR(100) NOT NULL
);

CREATE TABLE GUIAS(
	id INT IDENTITY(1,1) PRIMARY KEY,
	id_proveedor INT FOREIGN KEY REFERENCES PROVEEDORES(id),
	fecha DATETIME NOT NULL
);

CREATE TABLE COMPRAS(
	id INT IDENTITY(1,1) PRIMARY KEY,
	numero_unidades INT NOT NULL,
	id_producto INT FOREIGN KEY REFERENCES PRODUCTOS(codigo_interno),
	id_guia INT FOREIGN KEY REFERENCES GUIAS(id)
);

-- Insertar trabajadores de prueba
INSERT INTO TRABAJADORES(
	rut, 
	nombre, 
	apellidos, 
	email, 
	nombre_usuario, 
	password, 
	ultimo_login, 
	perfil
	)
VALUES (
	'15632255-5',
	'Gino',
	'Carpanetti D.',
	'g.carpanetti@alumnos.duoc.cl',
	'gcarpanetti',
	'holahola',
	'21-03-18',
	'adm'
);

-- Insertar Prooveedores de prueba
INSERT INTO PROVEEDORES (
	rut, telefono, email, direccion, razon_social, 
	giro, nombre_representante, apellidos_representante
	)
VALUES (
	'78421650-0',
	'22454433',
	'constructora@dlyc.cl',
	'Mario Silva Iriarte 515, Antofagasta',
	'DLYC Limitada',
	'Obras civiles',
	'Cristian',
	'Hidalgo Durán'
);

INSERT INTO PROVEEDORES (
	rut, telefono, email, direccion, razon_social, 
	giro, nombre_representante, apellidos_representante
	)
VALUES (
	'78429850-0',
	'7776655',
	'contacto@incov.cl',
	'Alirante algo 515, Talcahuano',
	'INCOV SA',
	'comercio',
	'Albert',
	'Einstein'
);
INSERT INTO PROVEEDORES (
	rut, telefono, email, direccion, razon_social, 
	giro, nombre_representante, apellidos_representante
	)
VALUES (
	'6545434-4',
	'22556677',
	'contacto@cafeta.com',
	'El Vergel 4000, Providencia, Santiago',
	'CAFETA INC.',
	'Articulos de mascotas',
	'Cafeta María',
	'Carpanetti'
);
INSERT INTO PROVEEDORES (
	rut, telefono, email, direccion, razon_social, 
	giro, nombre_representante, apellidos_representante
	)
VALUES (
	'654545344-5',
	'22454433',
	'ventas@intercom.com',
	'Avernida siempre viva 8000, Valparaiso',
	'Intercom SpA',
	'importaciones',
	'Mario',
	'Serazzi Durán'
);

INSERT INTO PRODUCTOS(descripcion, stock, unidad) 
VALUES ('Aireador monomando', 13, 'UN');

INSERT INTO PRODUCTOS(descripcion, stock, unidad) 
VALUES ('Barniz transparente', 10, 'tarro 1 litro');

INSERT INTO PRODUCTOS(descripcion, stock, unidad) 
VALUES ('Esmalte al agua color Verde', 5, 'tineta');

INSERT INTO PRODUCTOS(descripcion, stock, unidad) 
VALUES ('Mascarilla protectora', 20, 'UN');

INSERT INTO PRODUCTOS(descripcion, stock, unidad) 
VALUES ('Brocha 4 pulgadas', 5, 'UN');

INSERT INTO PRODUCTOS(descripcion, stock, unidad) 
VALUES ('tornillos 10 mm', 30, 'Bolsa de 100 unidades');






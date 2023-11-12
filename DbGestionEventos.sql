--CREATE DATABASE GestionEventos;
--GO

--USE GestionEventos;


--CREATE TABLE TIPO_USUARIO(
--	ID_TIPO_USUARIO INT IDENTITY(1,1), --PK
--	TIPO VARCHAR(30),
--	CONSTRAINT PK_TIPO_USUARIO PRIMARY KEY(ID_TIPO_USUARIO)
--);

--CREATE TABLE SERVICIO(
--	ID_SERVICIO INT IDENTITY(1,1), --PK
--	SERVICIO VARCHAR(30),	
--	CONSTRAINT PK_SERVICIOS PRIMARY KEY(ID_SERVICIO)
--);

--CREATE TABLE USUARIO(
--	ID_USUARIO INT IDENTITY(1,1), --PK
--	ID_TIPO_USUARIO INT NOT NULL, --FK
--	NOMBRE VARCHAR(50) NOT NULL,
--	APELLIDO VARCHAR(30) NOT NULL,
--	DNI BIGINT UNIQUE NOT NULL,
--	EMAIL VARCHAR(50) UNIQUE NOT NULL,
--	[PASSWORD] VARCHAR(16),
--	CONSTRAINT PK_USUARIOS PRIMARY KEY(ID_USUARIO)
--);

--CREATE TABLE SERVICIO_PUBLICADO(
--	ID_PUBLICACION UNIQUEIDENTIFIER NOT NULL,
--	ID_PROVEEDOR INT,--FK
--	ID_SERVICIO INT,--FK	
--	PRECIO DECIMAL(10,2) NOT NULL,
--	DESCRIPCION VARCHAR(MAX) NOT NULL,
--	CONSTRAINT PK_SERVICIOS_PUBLICADOS PRIMARY KEY(ID_PUBLICACION)
--);

--CREATE TABLE EVENTO(
--	ID_EVENTO UNIQUEIDENTIFIER, --PK
--	ID_USUARIO INT NOT NULL,--FK
--	FECHA_HORA DATETIME NOT NULL,
--	LUGAR VARCHAR(100),
--	CONSTRAINT PK_EVENTOS PRIMARY KEY(ID_EVENTO)
--);

--CREATE TABLE EVENTO_SERVICIO(
--	ID_EVENTO UNIQUEIDENTIFIER,--PK
--	ID_PUBLICACION UNIQUEIDENTIFIER NOT NULL, --PK,FK
--	ID_SERVICIO INT ,--FK
--	ID_PROVEEDOR INT ,--FK
--	CANTIDAD INT,
--	PRECIO DECIMAL(10,2) NOT NULL,
--	CONSTRAINT PK_EVENTO_SERVICIO PRIMARY KEY(ID_EVENTO,ID_PUBLICACION)
--);

--CREATE TABLE PAGO(
--	ID_PAGO INT IDENTITY(1,1), --PK
--	ID_EVENTO UNIQUEIDENTIFIER UNIQUE,--PK,FK
--	FECHA_PAGO DATE NOT NULL,
--	TOTAL DECIMAL(10,2),
--	CONSTRAINT PK_PAGO PRIMARY KEY(ID_PAGO, ID_EVENTO)
--);

--CREATE TABLE INVITADO(
--	ID_EVENTO UNIQUEIDENTIFIER,--PK,FK
--	EMAIL VARCHAR(50),--PK
--	NOMBRE VARCHAR(50),
--	APELLIDO VARCHAR(30),
--	CONSTRAINT PK_INVITADOS PRIMARY KEY(ID_EVENTO, EMAIL)
--);


---------------------/*DECLARACION DE FOREIGN KEYS*/-------------------

--ALTER TABLE USUARIO ADD
--CONSTRAINT FK_USUARIO_TIPO_USUARIO 
--	FOREIGN KEY (ID_TIPO_USUARIO) REFERENCES TIPO_USUARIO (ID_TIPO_USUARIO);
-------------------------------------------------------------
--ALTER TABLE SERVICIO_PUBLICADO ADD
--CONSTRAINT FK_SERVICIO_PUBLICADO_SERVICIO 
--	FOREIGN KEY (ID_SERVICIO) REFERENCES SERVICIO(ID_SERVICIO),
--CONSTRAINT FK_SERVICIOS_PUBLICADOS_USUARIOS 
--	FOREIGN KEY (ID_PROVEEDOR) REFERENCES USUARIO(ID_USUARIO);
-------------------------------------------------------------
--ALTER TABLE EVENTO ADD
--CONSTRAINT FK_EVENTO_USUARIO
--	FOREIGN KEY (ID_USUARIO) REFERENCES USUARIO(ID_USUARIO);
-------------------------------------------------------------
--ALTER TABLE EVENTO_SERVICIO ADD
--CONSTRAINT FK_EVENTO_SERVICIO_EVENTO
--	FOREIGN KEY(ID_EVENTO) REFERENCES EVENTO(ID_EVENTO),
--CONSTRAINT FK_EVENTO_SERVICIO_SERVICIO_PUBLICADO
--	FOREIGN KEY (ID_PUBLICACION) REFERENCES SERVICIO_PUBLICADO(ID_PUBLICACION);
-------------------------------------------------------------
--ALTER TABLE PAGO ADD
--CONSTRAINT FK_PAGO_EVENTO
--	FOREIGN KEY (ID_EVENTO) REFERENCES EVENTO(ID_EVENTO);
-------------------------------------------------------------
--ALTER TABLE INVITADO ADD
--CONSTRAINT FK_INVITADO_EVENTO
--	FOREIGN KEY (ID_EVENTO) REFERENCES EVENTO (ID_EVENTO);
--GO
-------------------------------------------------------------
--INSERT INTO TIPO_USUARIO VALUES ('Organizar'),('Proveedor');

--INSERT INTO SERVICIO VALUES
--	('Catering'),
--	('Bebidas'),
--	('Sonido e iluminacion'),
--	('Souvenirs'),
--	('Decoracion'),
--	('Barras'),
--	('Seguridad'),
--	('Espacios'),
--	('Animacion'),
--	('Asador'),
--	('Fotografia');

--INSERT INTO USUARIO VALUES
--	(1,'Alberto Alfredo','Carabajal',36541258,'AlbertoCarabajal@hotmail.com','albertitoDSM'),
--	(2,'Beatriz Clara','Fernandez',85123641,'betiClarita@gmail.com','asd9684s'),
--	(2,'Santiago Diego','Martinez',63541258,'santiMartincito64@yahoo.com','hfae6W'),
--	(1,'Ana Sandra','Santini',21456314,'4nit4deboulogne98@live.com','laskie6sO'),
--	(1,'Luis Eduardo','Gonzalez',74582361,'luisitoG@gmail.com','pIhj56Kd'),
--	(2,'María Isabel','López',98145623,'mariaLopez@gmail.com','UoPq2nSv'),
--	(1,'Andrés José','Pérez',32658791,'andresPerez@hotmail.com','RtYb4zXl'),
--	(2,'Sofía Carolina','Rodríguez',45782369,'sofiRodri@gmail.com','oNqJ8sDp'),
--	(1,'Carlos Alberto','Fernández',59873142,'carlitosFer@gmail.com','aBvCpE8R'),
--	(2,'Laura Cecilia','Ramírez',21458637,'lauraRamirez@hotmail.com','ZsXtNv2W'),
--	(1,'Diego Alejandro','López',32874915,'diegoLopez@yahoo.com','KlMnO9pQ'),
--	(2,'Valentina Fernanda','García',89412356,'valenGarcia@gmail.com','XwYzU1Jp'),
--	(1,'José Luis','Torres',45982314,'joseTorres@gmail.com','LmNopR3Q'),
--	(2,'Camila Isabella','Gómez',36584127,'camilaGomez@hotmail.com','S4TUVwXy'),
--	(1,'Manuel Alejandro','Rodríguez',71843269,'manuelRodriguez@yahoo.com','Hx9KlMnO'),
--	(2,'Ana María','Martínez',96587412,'anaMartinez@gmail.com','wXyZ7DpA'),
--	(1,'Fernando Alberto','Sánchez',14785263,'fernandoSanchez@hotmail.com','qB4E6mN8'),
--	(2,'Mariana Isabel','Pérez',52314786,'marianaPerez@gmail.com','zXtR9wQp'),
--	(1,'Miguel Ángel','García',36478192,'miguelGarcia@yahoo.com','tU3O2NvP'),
--	(2,'Luisa Fernanda','Gómez',98146527,'luisaGomez@gmail.com','nR4E2mN7'),
--	(1,'Roberto Carlos','Fernández',74152638,'robertoFernandez@hotmail.com','KlM1J3pW'),
--	(2,'Cristina Isabel','Ramírez',36587429,'cristinaRamirez@gmail.com','wX5T7v2J'),
--	(1,'Juan Diego','Torres',21458736,'juanTorres@yahoo.com','zXpR1LwO'),
--	(2,'Lucía Carolina','Santini',98145672,'luciaSantini@hotmail.com','yD3pE8Rt'),
--	(1,'Sergio Alberto','Gómez',74152396,'sergioGomez@gmail.com','qN7wXyZt'),
--	(2,'Gabriela Isabel','García',36587452,'gabrielaGarcia@hotmail.com','vB2N8m3Q'),
--	(1,'Pedro Alejandro','Pérez',52367841,'pedroPerez@gmail.com','uRwX4TlO'),
--	(2,'Isabel María','Martínez',98142563,'isabelMartinez@yahoo.com','KlMnO7pW'),
--	(1,'Pablo Alberto','Fernández',36587412,'pabloFernandez@hotmail.com','qBvC8R2W'),
--	(2,'Lorena Carolina','Gómez',74125836,'lorenaGomez@gmail.com','sXtRwQ3p'),
--	(1,'Ricardo Alberto','Ramírez',52316847,'ricardoRamirez@yahoo.com','zXyZvJpA'),
--	(2,'Tatiana Isabel','Torres',98142376,'tatianaTorres@gmail.com','HxK7DpNv'),
--	(1,'Javier Alejandro','Sánchez',93587412,'javierSanchez@hotmail.com','qBvCpRtW'),
--	(2,'Elena María','López',74152836,'elenaLopez@gmail.com','zX5T7vNpA'),
--	(1,'Víctor Alberto','García',21453736,'victorGarcia@yahoo.com','yXyZpRlO'),
--	(2,'Amanda Isabel','Pérez',98145236,'amandaPerez@gmail.com','uRwX4DpL'),
--	(1,'Federico Alberto','Martínez',36377412,'federicoMartinez@hotmail.com','qB2NvRtW'),
--	(2,'Natalia Carolina','Fernández',74125386,'nataliaFernandez@gmail.com','sXtR3mNvQ'),
--	(1,'Ernesto Alberto','Ramírez',21458116,'ernestoRamirez@yahoo.com','zXyZ7DpA'),
--	(1,'Test','test',11111111,'test@test.com','test');

	
--INSERT INTO SERVICIO_PUBLICADO VALUES
--	(NEWID(),20,1,6000,'El servicio consta de entrada, plato principal, 1litro de bebida y postre por persona'),
--	(NEWID(),3,7,40000,'El precio de servicio corresponde a DOS (2) personal de seguridad, para ser utilizados en vigilancia o control de recepcion'),
--	(NEWID(),6, 2, 15000, 'Servicio de bebidas para tu evento'),
--	(NEWID(),8, 3, 10000, 'Servicio de sonido e iluminación para crear la atmósfera perfecta'),
--	(NEWID(),10, 4, 22000, 'Encuentra souvenirs únicos para recordar tu evento'),
--	(NEWID(),12, 5, 35000, 'Decora tu evento con nuestro servicio de decoración personalizada'),
--	(NEWID(),14, 6, 9000, 'Barras de bebidas personalizadas para tu evento'),
--	(NEWID(),16, 7, 18000, 'Servicio de seguridad con dos profesionales para vigilancia o control de recepción'),
--	(NEWID(),18, 8, 25000, 'Encuentra el espacio ideal para tu evento'),
--	(NEWID(),20, 9, 7000, 'Servicio de animación para mantener entretenidos a tus invitados'),
--	(NEWID(),22, 10, 30000, 'Asador profesional para tus eventos al aire libre'),
--	(NEWID(),24, 11, 12000, 'Servicio de fotografía para capturar los mejores momentos de tu evento'),
--	(NEWID(),26, 1, 20000, 'Catering personalizado para tu ocasión especial'),
--	(NEWID(),28, 2, 17000, 'Bebidas de alta calidad para complementar tu evento'),
--	(NEWID(),30, 3, 6000, 'Sonido e iluminación de primera para crear la atmósfera perfecta'),
--	(NEWID(),32, 4, 18000, 'Souvenirs únicos y memorables para tus invitados'),
--	(NEWID(),34, 5, 13000, 'Decoración que hará que tu evento sea inolvidable'),
--	(NEWID(),36, 6, 9000, 'Barras de bebidas personalizadas para hacer de tu evento una experiencia única'),
--	(NEWID(),37, 7, 40000, 'Seguridad profesional para garantizar la tranquilidad de tu evento'),
--	('25AC89A1-1A12-4C78-AEFC-D7A514C8339F',2, 8, 16000, 'Espacios ideales para tu evento, adaptados a tus necesidades'),
--	('82383E86-A2EF-4608-92FB-82A5E70F024F',6, 9, 7000, 'Servicio de animación para mantener a tus invitados entretenidos y felices'),
--	(NEWID(),8, 10, 24000, 'Servicio de asador para disfrutar de deliciosas parrilladas'),
--	(NEWID(),10, 11, 28000, 'Fotografía de alta calidad para capturar los momentos más especiales de tu evento'),
--	(NEWID(),12, 1, 12000, 'Catering excepcional que hará las delicias de tus invitados'),
--	(NEWID(),14, 2, 18000, 'Amplia variedad de bebidas para satisfacer todos los gustos'),
--	(NEWID(),16, 3, 8000, 'Sonido e iluminación profesional para una experiencia inolvidable'),
--	(NEWID(),18, 4, 21000, 'Souvenirs únicos y personalizados para recordar tu evento'),
--	(NEWID(),20, 5, 30000, 'Decoración que transformará tu espacio en un lugar mágico'),
--	(NEWID(),22, 6, 9500, 'Barras de bebidas con mixólogos expertos para sorprender a tus invitados'),
--	(NEWID(),24, 7, 22000, 'Personal de seguridad altamente capacitado para garantizar la seguridad de tu evento'),
--	(NEWID(),26, 8, 27000, 'Espacios versátiles y elegantes para todo tipo de eventos'),
--	(NEWID(),28, 9, 7500, 'Animadores profesionales que harán de tu evento una fiesta inolvidable'),
--	(NEWID(),30, 10, 31000, 'Servicio de asador con chefs expertos para deleitar a tus invitados'),
--	(NEWID(),32, 11, 12500, 'Fotografía de calidad para capturar los momentos más especiales'),
--	(NEWID(),34, 1, 21000, 'Catering a medida para satisfacer los paladares más exigentes'),
--	(NEWID(),36, 2, 15000, 'Variedad de bebidas premium para tu evento'),
--	(NEWID(),38, 3, 35000, 'Ambiente excepcional con sonido e iluminación de última generación');


--INSERT INTO EVENTO VALUES('4A30E504-D5F0-4B5A-A31B-AD814DDD0156',40,'2023-12-25','La quinta del ñato');
--GO

--INSERT INTO EVENTO_SERVICIO VALUES
--	('4A30E504-D5F0-4B5A-A31B-AD814DDD0156','82383E86-A2EF-4608-92FB-82A5E70F024F',6,9,2,10000),
--	('4A30E504-D5F0-4B5A-A31B-AD814DDD0156','25AC89A1-1A12-4C78-AEFC-D7A514C8339F',2,8,10,2000);
--GO

--INSERT INTO PAGO VALUES('4A30E504-D5F0-4B5A-A31B-AD814DDD0156','2023-12-1',40000);
--GO

--INSERT INTO INVITADO VALUES
--	('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario1@example.com', 'Juan', 'Pérez'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario2@example.com', 'María', 'González'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario3@example.com', 'Carlos', 'López'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario4@example.com', 'Ana', 'Martínez'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario5@example.com', 'Luis', 'Rodríguez'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario6@example.com', 'Laura', 'Fernández'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario7@example.com', 'Pedro', 'Sánchez'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario8@example.com', 'Sofía', 'Gómez'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario9@example.com', 'Diego', 'Díaz'),
--    ('4A30E504-D5F0-4B5A-A31B-AD814DDD0156', 'usuario10@example.com', 'Elena', 'Torres');
--GO

--SELECT * FROM SERVICIO_PUBLICADO;
--SELECT * FROM USUARIO;
--SELECT * FROM EVENTO;
--SELECT * FROM EVENTO_SERVICIO;
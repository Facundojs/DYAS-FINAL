CREATE DATABASE DbGestionEventos;
GO

USE DbGestionEventos;

CREATE TABLE ORGANIZADOR(
	ID_ORGANIZADOR INT IDENTITY(1,1),
	NOMBRE VARCHAR(50),
	APELLIDO VARCHAR(50),
	DNI BIGINT UNIQUE,
	EMAIL VARCHAR(50) UNIQUE,
	[PASSWORD] VARCHAR(10),
	CONSTRAINT PK_ORGANIZADOR PRIMARY KEY(ID_ORGANIZADOR)
);

CREATE TABLE PROVEEDOR(
	ID_PROVEEDOR INT IDENTITY(1,1),
	NOMBRE VARCHAR(50),
	APELLIDO VARCHAR(50),
	DNI BIGINT UNIQUE,
	EMAIL VARCHAR(50) UNIQUE,
	[PASSWORD] VARCHAR(10),
	CONSTRAINT PK_PROVEEDOR PRIMARY KEY(ID_PROVEEDOR)
);

CREATE TABLE EVENTO(
	ID_EVENTO INT IDENTITY(1,1),
	ID_ORGANIZADOR INT,
	NOMBRE_EVENTO VARCHAR(50),
	FECHA DATE,
	HORA TIME,
	LUGAR VARCHAR(100),
	CONSTRAINT PK_EVENTO PRIMARY KEY(ID_EVENTO),
	CONSTRAINT FK_EVENTO_ORGANIZADOR FOREIGN KEY(ID_ORGANIZADOR)
		REFERENCES ORGANIZADOR(ID_ORGANIZADOR)
);


CREATE TABLE SERVICIO(
	ID_SERVICIO INT IDENTITY(1,1),
	ID_PROVEEDOR INT,
	NOMBRE_SERVICIO VARCHAR(50),
	DESCRIPCION VARCHAR(MAX),
	PRECIO FLOAT,
	CONSTRAINT PK_SERVICIO PRIMARY KEY(ID_SERVICIO),
	CONSTRAINT FK_SERVICIO_PROVEEDOR FOREIGN KEY(ID_PROVEEDOR)
		REFERENCES PROVEEDOR(ID_PROVEEDOR)
);

CREATE TABLE EVENTO_SERVICIO(
	ID_EVENTO INT,
	ID_SERVICIO INT,
	CANTIDAD INT,
	SUBTOTAL FLOAT,
	CONSTRAINT PK_EVENTO_SERVICIO PRIMARY KEY (ID_EVENTO, ID_SERVICIO),
	CONSTRAINT FK_EVENTO_SERVICIO_EVENTO FOREIGN KEY(ID_EVENTO)
		REFERENCES EVENTO(ID_EVENTO),
	CONSTRAINT FK_EVENTO_SERVICIO_SERVICIO FOREIGN KEY (ID_SERVICIO)
		REFERENCES SERVICIO(ID_SERVICIO)
);

CREATE TABLE PAGO(
	ID_PAGO INT IDENTITY(1,1),
	ID_EVENTO INT,
	FECHA DATETIME,
	MONTO FLOAT,
	CONSTRAINT PK_PAGO PRIMARY KEY(ID_PAGO),
	CONSTRAINT FK_PAGO_EVENTO FOREIGN KEY (ID_EVENTO)
		REFERENCES EVENTO(ID_EVENTO)
);

CREATE TABLE INVITADO(
	EMAIL VARCHAR(50),
	ID_EVENTO INT,
	NOMBRE VARCHAR(50),
	APELLIDO VARCHAR(50),
	DNI BIGINT,
	CONSTRAINT PK_INVITADO PRIMARY KEY(EMAIL, ID_EVENTO),
	CONSTRAINT FK_INVITADO_EVENTO FOREIGN KEY (ID_EVENTO)
		REFERENCES EVENTO(ID_EVENTO)
);


INSERT INTO ORGANIZADOR VALUES
	('Test','test',11111111,'test@test.com','test'),
	('Alberto Alfredo','Carabajal',36541258,'AlbertoCarabajal@hotmail.com','albertito'),
	('Ana Sandra','Santini',21456314,'4nit4deboulogne98@live.com','laskie6sO'),
	('Luis Eduardo','Gonzalez',74582361,'luisitoG@gmail.com','pIhj56Kd'),
	('Andrés José','Pérez',32658791,'andresPerez@hotmail.com','RtYb4zXl'),
	('Carlos Alberto','Fernández',59873142,'carlitosFer@gmail.com','aBvCpE8R'),
	('Diego Alejandro','López',32874915,'diegoLopez@yahoo.com','KlMnO9pQ'),
	('José Luis','Torres',45982314,'joseTorres@gmail.com','LmNopR3Q'),
	('Manuel Alejandro','Rodríguez',71843269,'manuelRodriguez@yahoo.com','Hx9KlMnO'),
	('Fernando Alberto','Sánchez',14785263,'fernandoSanchez@hotmail.com','qB4E6mN8'),
	('Miguel Ángel','García',36478192,'miguelGarcia@yahoo.com','tU3O2NvP'),
	('Roberto Carlos','Fernández',74152638,'robertoFernandez@hotmail.com','KlM1J3pW'),
	('Juan Diego','Torres',21458736,'juanTorres@yahoo.com','zXpR1LwO'),
	('Sergio Alberto','Gómez',74152396,'sergioGomez@gmail.com','qN7wXyZt'),
	('Pedro Alejandro','Pérez',52367841,'pedroPerez@gmail.com','uRwX4TlO'),
	('Pablo Alberto','Fernández',36587412,'pabloFernandez@hotmail.com','qBvC8R2W'),
	('Ricardo Alberto','Ramírez',52316847,'ricardoRamirez@yahoo.com','zXyZvJpA'),
	('Javier Alejandro','Sánchez',93587412,'javierSanchez@hotmail.com','qBvCpRtW'),
	('Víctor Alberto','García',21453736,'victorGarcia@yahoo.com','yXyZpRlO'),
	('Federico Alberto','Martínez',36377412,'federicoMartinez@hotmail.com','qB2NvRtW'),
	('Ernesto Alberto','Ramírez',21458116,'ernestoRamirez@yahoo.com','zXyZ7DpA');
	

INSERT INTO PROVEEDOR VALUES
	('Beatriz Clara','Fernandez',85123641,'betiClarita@gmail.com','asd9684s'),
	('Santiago Diego','Martinez',63541258,'santiMartincito64@yahoo.com','hfae6W'),	
	('María Isabel','López',98145623,'mariaLopez@gmail.com','UoPq2nSv'),
	('Sofía Carolina','Rodríguez',45782369,'sofiRodri@gmail.com','oNqJ8sDp'),	
	('Laura Cecilia','Ramírez',21458637,'lauraRamirez@hotmail.com','ZsXtNv2W'),	
	('Valentina Fernanda','García',89412356,'valenGarcia@gmail.com','XwYzU1Jp'),	
	('Camila Isabella','Gómez',36584127,'camilaGomez@hotmail.com','S4TUVwXy'),	
	('Ana María','Martínez',96587412,'anaMartinez@gmail.com','wXyZ7DpA'),	
	('Mariana Isabel','Pérez',52314786,'marianaPerez@gmail.com','zXtR9wQp'),	
	('Luisa Fernanda','Gómez',98146527,'luisaGomez@gmail.com','nR4E2mN7'),	
	('Cristina Isabel','Ramírez',36587429,'cristinaRamirez@gmail.com','wX5T7v2J'),	
	('Lucía Carolina','Santini',98145672,'luciaSantini@hotmail.com','yD3pE8Rt'),	
	('Gabriela Isabel','García',36587452,'gabrielaGarcia@hotmail.com','vB2N8m3Q'),	
	('Isabel María','Martínez',98142563,'isabelMartinez@yahoo.com','KlMnO7pW'),	
	('Lorena Carolina','Gómez',74125836,'lorenaGomez@gmail.com','sXtRwQ3p'),
	('Tatiana Isabel','Torres',98142376,'tatianaTorres@gmail.com','HxK7DpNv'),	
	('Elena María','López',74152836,'elenaLopez@gmail.com','zX5T7vNpA'),	
	('Amanda Isabel','Pérez',98145236,'amandaPerez@gmail.com','uRwX4DpL'),	
	('Natalia Carolina','Fernández',74125386,'nataliaFernandez@gmail.com','sXtR3mNvQ');



INSERT INTO SERVICIO VALUES
    (1, 'Catering', 'El servicio consta de entrada, plato principal, 1 litro de bebida y postre por persona', 6000),
    (2, 'Seguridad', 'El precio del servicio corresponde a DOS (2) personal de seguridad, para ser utilizados en vigilancia o control de recepción', 40000),
    (3, 'Bebidas', 'Servicio de bebidas para tu evento', 15000),
    (4, 'Sonido e Iluminacion', 'Servicio de sonido e iluminación para crear la atmósfera perfecta', 10000),
    (5, 'Souvenirs', 'Encuentra souvenirs únicos para recordar tu evento', 22000),
    (6, 'Decoracion', 'Decora tu evento con nuestro servicio de decoración personalizada', 35000),
    (7, 'Barras', 'Barras de bebidas personalizadas para tu evento', 9000),
    (8, 'Seguridad', 'Servicio de seguridad con dos profesionales para vigilancia o control de recepción', 18000),
    (9, 'Espacios', 'Encuentra el espacio ideal para tu evento', 25000),
    (10, 'Animacion', 'Servicio de animación para mantener entretenidos a tus invitados', 7000),
    (11, 'Asador', 'Asador profesional para tus eventos al aire libre', 30000),
    (12, 'Fotografia', 'Servicio de fotografía para capturar los mejores momentos de tu evento', 12000),
    (13, 'Catering', 'Catering personalizado para tu ocasión especial', 20000),
    (14, 'Bebidas', 'Bebidas de alta calidad para complementar tu evento', 17000),
    (15, 'Sonido e Iluminacion', 'Sonido e iluminación de primera para crear la atmósfera perfecta', 6000),
    (16, 'Souvenirs', 'Souvenirs únicos y memorables para tus invitados', 18000),
    (17, 'Decoracion', 'Decoración que hará que tu evento sea inolvidable', 13000),
    (18, 'Barras', 'Barras de bebidas personalizadas para hacer de tu evento una experiencia única', 9000),
    (19, 'Seguridad', 'Seguridad profesional para garantizar la tranquilidad de tu evento', 40000),
    (19, 'Espacios', 'Espacios ideales para tu evento, adaptados a tus necesidades', 16000),
    (1, 'Animacion', 'Servicio de animación para mantener a tus invitados entretenidos y felices', 7000),
    (2, 'Asador', 'Servicio de asador para disfrutar de deliciosas parrilladas', 24000),
    (3, 'Fotografia', 'Fotografía de alta calidad para capturar los momentos más especiales de tu evento', 28000),
    (4, 'Catering', 'Catering excepcional que hará las delicias de tus invitados', 12000),
    (5, 'Bebidas', 'Amplia variedad de bebidas para satisfacer todos los gustos', 18000),
    (6, 'Sonido e Iluminacion', 'Sonido e iluminación profesional para una experiencia inolvidable', 8000),
    (7, 'Souvenirs', 'Souvenirs únicos y personalizados para recordar tu evento', 21000),
    (8, 'Decoracion', 'Decoración que transformará tu espacio en un lugar mágico', 30000),
    (9, 'Barras', 'Barras de bebidas con mixólogos expertos para sorprender a tus invitados', 9500),
    (10, 'Seguridad', 'Personal de seguridad altamente capacitado para garantizar la seguridad de tu evento', 22000),
    (11, 'Espacios', 'Espacios versátiles y elegantes para todo tipo de eventos', 27000),
    (12, 'Animacion', 'Animadores profesionales que harán de tu evento una fiesta inolvidable', 7500),
    (13, 'Asador', 'Servicio de asador con chefs expertos para deleitar a tus invitados', 31000),
    (14, 'Fotografia', 'Fotografía de calidad para capturar los momentos más especiales', 12500),
    (15, 'Catering', 'Catering a medida para satisfacer los paladares más exigentes', 21000),
    (16, 'Bebidas', 'Variedad de bebidas premium para tu evento', 15000),
    (17, 'Sonido e Iluminacion', 'Ambiente excepcional con sonido e iluminación de última generación', 35000);



INSERT INTO EVENTO VALUES
	(1,'Festejo de divorcio','2023-6-12','22:00:00','Av.Cordoba 1236 - CABA'),
	(1,'Despedida de año','2023-12-20','20:00:00','Av. Rolon 123 - BOULOGNE');	   


INSERT INTO EVENTO_SERVICIO VALUES
	(1,34,2,14500),
	(1,5,1,15000),
	(1,13,1,30000),
	(1,6,1,10000),
	(2,12,1,7000),
	(2,11,1,25000),
	(2,20,2,18000),
	(2,28,1,8000),
	(2,26,4,48000);


INSERT INTO INVITADO VALUES
	('usuario1@example.com',1, 'Juan', 'Pérez',30000001),
    ('usuario2@example.com',1, 'María', 'González',20096001),
    ('usuario3@example.com',1, 'Carlos', 'López',50000001),
    ('usuario4@example.com',1, 'Ana', 'Martínez',30000001),
    ('usuario5@example.com',1, 'Luis', 'Rodríguez',20000001),
    ('usuario6@example.com',2, 'Laura', 'Fernández',10036001),
    ('usuario7@example.com',2, 'Pedro', 'Sánchez',60000001),
    ('usuario8@example.com',2, 'Sofía', 'Gómez',20000001),
    ('usuario9@example.com',2, 'Diego', 'Díaz',12000001),
    ('usuario10@example.com',2,'Elena', 'Torres',30041001);



SELECT 
	B.NOMBRE_EVENTO AS [NOMBRE EVENTO],
	CONCAT(C.APELLIDO,' ', C.NOMBRE) AS [NOMBRE ORGANIZADOR], 
	SUM(SUBTOTAL)AS TOTAL 
FROM EVENTO_SERVICIO AS A
JOIN EVENTO AS B
	ON A.ID_EVENTO = B.ID_EVENTO
JOIN ORGANIZADOR  AS C
	ON C.ID_ORGANIZADOR = B.ID_ORGANIZADOR
GROUP BY B.NOMBRE_EVENTO, CONCAT(C.APELLIDO,' ', C.NOMBRE);
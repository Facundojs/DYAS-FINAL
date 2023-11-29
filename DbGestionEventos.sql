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
	('Andr�s Jos�','P�rez',32658791,'andresPerez@hotmail.com','RtYb4zXl'),
	('Carlos Alberto','Fern�ndez',59873142,'carlitosFer@gmail.com','aBvCpE8R'),
	('Diego Alejandro','L�pez',32874915,'diegoLopez@yahoo.com','KlMnO9pQ'),
	('Jos� Luis','Torres',45982314,'joseTorres@gmail.com','LmNopR3Q'),
	('Manuel Alejandro','Rodr�guez',71843269,'manuelRodriguez@yahoo.com','Hx9KlMnO'),
	('Fernando Alberto','S�nchez',14785263,'fernandoSanchez@hotmail.com','qB4E6mN8'),
	('Miguel �ngel','Garc�a',36478192,'miguelGarcia@yahoo.com','tU3O2NvP'),
	('Roberto Carlos','Fern�ndez',74152638,'robertoFernandez@hotmail.com','KlM1J3pW'),
	('Juan Diego','Torres',21458736,'juanTorres@yahoo.com','zXpR1LwO'),
	('Sergio Alberto','G�mez',74152396,'sergioGomez@gmail.com','qN7wXyZt'),
	('Pedro Alejandro','P�rez',52367841,'pedroPerez@gmail.com','uRwX4TlO'),
	('Pablo Alberto','Fern�ndez',36587412,'pabloFernandez@hotmail.com','qBvC8R2W'),
	('Ricardo Alberto','Ram�rez',52316847,'ricardoRamirez@yahoo.com','zXyZvJpA'),
	('Javier Alejandro','S�nchez',93587412,'javierSanchez@hotmail.com','qBvCpRtW'),
	('V�ctor Alberto','Garc�a',21453736,'victorGarcia@yahoo.com','yXyZpRlO'),
	('Federico Alberto','Mart�nez',36377412,'federicoMartinez@hotmail.com','qB2NvRtW'),
	('Ernesto Alberto','Ram�rez',21458116,'ernestoRamirez@yahoo.com','zXyZ7DpA');
	

INSERT INTO PROVEEDOR VALUES
	('Beatriz Clara','Fernandez',85123641,'betiClarita@gmail.com','asd9684s'),
	('Santiago Diego','Martinez',63541258,'santiMartincito64@yahoo.com','hfae6W'),	
	('Mar�a Isabel','L�pez',98145623,'mariaLopez@gmail.com','UoPq2nSv'),
	('Sof�a Carolina','Rodr�guez',45782369,'sofiRodri@gmail.com','oNqJ8sDp'),	
	('Laura Cecilia','Ram�rez',21458637,'lauraRamirez@hotmail.com','ZsXtNv2W'),	
	('Valentina Fernanda','Garc�a',89412356,'valenGarcia@gmail.com','XwYzU1Jp'),	
	('Camila Isabella','G�mez',36584127,'camilaGomez@hotmail.com','S4TUVwXy'),	
	('Ana Mar�a','Mart�nez',96587412,'anaMartinez@gmail.com','wXyZ7DpA'),	
	('Mariana Isabel','P�rez',52314786,'marianaPerez@gmail.com','zXtR9wQp'),	
	('Luisa Fernanda','G�mez',98146527,'luisaGomez@gmail.com','nR4E2mN7'),	
	('Cristina Isabel','Ram�rez',36587429,'cristinaRamirez@gmail.com','wX5T7v2J'),	
	('Luc�a Carolina','Santini',98145672,'luciaSantini@hotmail.com','yD3pE8Rt'),	
	('Gabriela Isabel','Garc�a',36587452,'gabrielaGarcia@hotmail.com','vB2N8m3Q'),	
	('Isabel Mar�a','Mart�nez',98142563,'isabelMartinez@yahoo.com','KlMnO7pW'),	
	('Lorena Carolina','G�mez',74125836,'lorenaGomez@gmail.com','sXtRwQ3p'),
	('Tatiana Isabel','Torres',98142376,'tatianaTorres@gmail.com','HxK7DpNv'),	
	('Elena Mar�a','L�pez',74152836,'elenaLopez@gmail.com','zX5T7vNpA'),	
	('Amanda Isabel','P�rez',98145236,'amandaPerez@gmail.com','uRwX4DpL'),	
	('Natalia Carolina','Fern�ndez',74125386,'nataliaFernandez@gmail.com','sXtR3mNvQ');



INSERT INTO SERVICIO VALUES
    (1, 'Catering', 'El servicio consta de entrada, plato principal, 1 litro de bebida y postre por persona', 6000),
    (2, 'Seguridad', 'El precio del servicio corresponde a DOS (2) personal de seguridad, para ser utilizados en vigilancia o control de recepci�n', 40000),
    (3, 'Bebidas', 'Servicio de bebidas para tu evento', 15000),
    (4, 'Sonido e Iluminacion', 'Servicio de sonido e iluminaci�n para crear la atm�sfera perfecta', 10000),
    (5, 'Souvenirs', 'Encuentra souvenirs �nicos para recordar tu evento', 22000),
    (6, 'Decoracion', 'Decora tu evento con nuestro servicio de decoraci�n personalizada', 35000),
    (7, 'Barras', 'Barras de bebidas personalizadas para tu evento', 9000),
    (8, 'Seguridad', 'Servicio de seguridad con dos profesionales para vigilancia o control de recepci�n', 18000),
    (9, 'Espacios', 'Encuentra el espacio ideal para tu evento', 25000),
    (10, 'Animacion', 'Servicio de animaci�n para mantener entretenidos a tus invitados', 7000),
    (11, 'Asador', 'Asador profesional para tus eventos al aire libre', 30000),
    (12, 'Fotografia', 'Servicio de fotograf�a para capturar los mejores momentos de tu evento', 12000),
    (13, 'Catering', 'Catering personalizado para tu ocasi�n especial', 20000),
    (14, 'Bebidas', 'Bebidas de alta calidad para complementar tu evento', 17000),
    (15, 'Sonido e Iluminacion', 'Sonido e iluminaci�n de primera para crear la atm�sfera perfecta', 6000),
    (16, 'Souvenirs', 'Souvenirs �nicos y memorables para tus invitados', 18000),
    (17, 'Decoracion', 'Decoraci�n que har� que tu evento sea inolvidable', 13000),
    (18, 'Barras', 'Barras de bebidas personalizadas para hacer de tu evento una experiencia �nica', 9000),
    (19, 'Seguridad', 'Seguridad profesional para garantizar la tranquilidad de tu evento', 40000),
    (19, 'Espacios', 'Espacios ideales para tu evento, adaptados a tus necesidades', 16000),
    (1, 'Animacion', 'Servicio de animaci�n para mantener a tus invitados entretenidos y felices', 7000),
    (2, 'Asador', 'Servicio de asador para disfrutar de deliciosas parrilladas', 24000),
    (3, 'Fotografia', 'Fotograf�a de alta calidad para capturar los momentos m�s especiales de tu evento', 28000),
    (4, 'Catering', 'Catering excepcional que har� las delicias de tus invitados', 12000),
    (5, 'Bebidas', 'Amplia variedad de bebidas para satisfacer todos los gustos', 18000),
    (6, 'Sonido e Iluminacion', 'Sonido e iluminaci�n profesional para una experiencia inolvidable', 8000),
    (7, 'Souvenirs', 'Souvenirs �nicos y personalizados para recordar tu evento', 21000),
    (8, 'Decoracion', 'Decoraci�n que transformar� tu espacio en un lugar m�gico', 30000),
    (9, 'Barras', 'Barras de bebidas con mix�logos expertos para sorprender a tus invitados', 9500),
    (10, 'Seguridad', 'Personal de seguridad altamente capacitado para garantizar la seguridad de tu evento', 22000),
    (11, 'Espacios', 'Espacios vers�tiles y elegantes para todo tipo de eventos', 27000),
    (12, 'Animacion', 'Animadores profesionales que har�n de tu evento una fiesta inolvidable', 7500),
    (13, 'Asador', 'Servicio de asador con chefs expertos para deleitar a tus invitados', 31000),
    (14, 'Fotografia', 'Fotograf�a de calidad para capturar los momentos m�s especiales', 12500),
    (15, 'Catering', 'Catering a medida para satisfacer los paladares m�s exigentes', 21000),
    (16, 'Bebidas', 'Variedad de bebidas premium para tu evento', 15000),
    (17, 'Sonido e Iluminacion', 'Ambiente excepcional con sonido e iluminaci�n de �ltima generaci�n', 35000);



INSERT INTO EVENTO VALUES
	(1,'Festejo de divorcio','2023-6-12','22:00:00','Av.Cordoba 1236 - CABA'),
	(1,'Despedida de a�o','2023-12-20','20:00:00','Av. Rolon 123 - BOULOGNE');	   


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
	('usuario1@example.com',1, 'Juan', 'P�rez',30000001),
    ('usuario2@example.com',1, 'Mar�a', 'Gonz�lez',20096001),
    ('usuario3@example.com',1, 'Carlos', 'L�pez',50000001),
    ('usuario4@example.com',1, 'Ana', 'Mart�nez',30000001),
    ('usuario5@example.com',1, 'Luis', 'Rodr�guez',20000001),
    ('usuario6@example.com',2, 'Laura', 'Fern�ndez',10036001),
    ('usuario7@example.com',2, 'Pedro', 'S�nchez',60000001),
    ('usuario8@example.com',2, 'Sof�a', 'G�mez',20000001),
    ('usuario9@example.com',2, 'Diego', 'D�az',12000001),
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
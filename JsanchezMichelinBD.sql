CREATE DATABASE JSanchezMichelin
USE JSanchezMichelin
GO

CREATE TABLE Punto(
	IdPunto INT IDENTITY(1,1) PRIMARY KEY,
	Nombre VARCHAR(50),
	Latitud VARCHAR(100),
	Longitud VARCHAR(100),
	FechaHora DATETIME
)
GO
SELECT * FROM Punto
INSERT INTO Punto(Nombre,Latitud,Longitud,FechaHora)VALUES('Punto1','19.59761','-99.18054','2020-11-03 10:09:58')
INSERT INTO Punto(Nombre,Latitud,Longitud,FechaHora)VALUES('Punto2','19.59764','-99.18063','2020-11-03 10:11:16')
INSERT INTO Punto(Nombre,Latitud,Longitud,FechaHora)VALUES('Punto3','19.59784','-99.1804','2020-11-03 10:58:24')
INSERT INTO Punto(Nombre,Latitud,Longitud,FechaHora)VALUES('Punto4','19.51953','-99.20602','2020-11-03 15:01:50')
INSERT INTO Punto(Nombre,Latitud,Longitud,FechaHora)VALUES('Punto5','19.51987','-99.20607','2020-11-05 08:51:40')
GO

CREATE PROCEDURE PuntoGetAll
AS
SELECT IdPunto,Nombre,Latitud,Longitud,FechaHora FROM Punto
GO

CREATE PROCEDURE GetById
@IdPunto INT
AS
SELECT IdPunto,Nombre,Latitud,Longitud,FechaHora FROM Punto
WHERE IdPunto = @IdPunto
GO
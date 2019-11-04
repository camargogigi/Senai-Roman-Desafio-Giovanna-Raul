CREATE DATABASE M_Roman;

USE M_Roman

CREATE TABLE Tipo(
	idTipoUser INT PRIMARY KEY IDENTITY,
	Tipo VARCHAR(200) NOT NULL
);

CREATE TABLE Professor(
	IdProf INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (200) NOT NULL,
	Email VARCHAR (200) UNIQUE NOT NULL,
	Senha VARCHAR (200) NOT NULL,
	idTipoUser INT FOREIGN KEY REFERENCES Tipo(idTipoUser)
);


CREATE TABLE Tema(
	IdTema INT PRIMARY KEY IDENTITY,
	Tema VARCHAR (200) NOT NULL,
);

CREATE TABLE Projeto (
	idProjeto INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (255) NOT NULL,
	IdTema INT FOREIGN KEY REFERENCES Tema (IdTema)
);

INSERT INTO Tipo
	VALUES ('AUTORIZADO');
select * from Tipo;

INSERT INTO Professor 
	VALUES ('Professor A', 'professora@gmail.com', '125746', 1),
		   ('Professor B','professorb@gmail.com','3518258', 1);
select * from Professor;

INSERT INTO Tema 
	VALUES ('Gestão'),
		   ('HQ''s');
select * from Tema;

INSERT INTO Projeto 
	VALUES ('Controle de Estoque', 1),
		   ('listagem de personagens', 2);
select * from Projeto;
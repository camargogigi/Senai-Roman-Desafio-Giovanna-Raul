CREATE DATABASE M_Roman;

CREATE TABLE Professor(
	IdProf INT PRIMARY KEY IDENTITY,
	Nome VARCHAR (200) NOT NULL,
	Email VARCHAR (200) UNIQUE NOT NULL,
	Senha VARCHAR (200) NOT NULL
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

INSERT INTO Professor 
	VALUES ('Professor A', 'professora@gmail.com', '125746'),
		   ('Professor B','professorb@gmail.com','3518258');
select * from Professor;

INSERT INTO Tema 
	VALUES ('Gestão'),
		   ('HQ''s');
select * from Tema;

INSERT INTO Projeto 
	VALUES ('Controle de Estoque', 1),
		   ('listagem de personagens', 2);
select * from Projeto;
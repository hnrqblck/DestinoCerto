DROP DATABASE IF EXISTS DestinoCerto;

CREATE DATABASE DestinoCerto;
USE DestinoCerto;

CREATE TABLE IF NOT EXISTS usuario(
IdUser int PRIMARY KEY AUTO_INCREMENT,
NomeUser varchar(200) not null,
DataNascimento Date,
Login varchar(50) not null,
Senha varchar(20) not null,
tipo int
);

CREATE TABLE IF NOT EXISTS pacote(
IdPacote int PRIMARY KEY auto_increment,
NomePacote varchar(200) not null,
Origem varchar(200),
Destino varchar(200) not null,
Atrativos text,
Saida date not null,
Retorno date,
Usuario int,
FOREIGN KEY (Usuario) REFERENCES usuario(IdUser) 
);





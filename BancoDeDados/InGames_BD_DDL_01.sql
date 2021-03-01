--Criar um database
create database BDInGames;

--Usar o banco de dados
use BDInGames;

--Criação das tabelas 
create table Estudio(
	IdEstudio int primary key identity,
	NomeEstudio varchar(255) not null unique
);

create table Jogo(
	IdJogo int primary key identity, 
	NomeJogo varchar(255) not null unique,
	Descricao varchar(500) not null,
	DataDeLancamento date not null,
	Valor decimal not null,
	IdEstudio int foreign key references Estudio (IdEstudio) 
);

select IdJogo, NomeJogo, Descricao, DataDeLancamento, Valor, IdEstudio from Jogo

create table TipoUsuario(
	IdTipoUsuario int primary key identity,
	Titulo varchar(255) not null
);
select IdTipoUsuario, Titulo from TipoUsuario

create table Usuarios(
	IdUsuario int primary key identity,
	Email varchar(255) not null unique,
	Senha varchar(255) not null,
	IdTipoUsuario int foreign key references TipoUsuario( IdTipoUsuario)
);

	SELECT Usuarios.IdUsuario, Usuarios.Email, Usuarios.Senha, TipoUsuario.IdTipoUsuario from Usuarios
	inner join TipoUsuario on Usuarios.IdTipoUsuario = TipoUsuario.IdTipoUsuario;



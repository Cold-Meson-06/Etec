create database bdJogo;
use bdJogo;

create table usuario(
	codigo int(6) not null auto_increment primary key,
    nome varchar(50) not null,
    senha varchar(150) not null,
    pontuacao int(10)
);

create table tema(
	codigo int(2) not null auto_increment primary key,
    nome varchar(25)
);

create table pergunta(
	codigo int(6) not null auto_increment primary key,
    descricao varchar(100),
    pontuacao int(4),
    codTema int(2),
    foreign key(codTema) references tema(codigo)
);

create table resposta(
	codigo int(6) not null auto_increment primary key,
    resposta varchar(30),
    flag char(1),
    codPerg int(6),
    foreign key(codPerg) references pergunta(codigo)
);

create table responde(
	codigo int(6) not null auto_increment primary key,
    codUsuario int(6),
    codPerg int(6),
    data date,
    flag char(1),
    foreign key(codUsuario) references usuario(codigo),
    foreign key(codPerg) references pergunta(codigo)
);
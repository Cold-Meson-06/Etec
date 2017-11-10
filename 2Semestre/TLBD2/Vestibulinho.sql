create database vestibulinho;

use vestibulinho;

create table etec(
	codigo int(4),
	nome varchar(100),
	rua varchar(50),
	num varchar(10),
	bairro varchar(25),
	cidade varchar(30),
	uf char(2),
	cep char(8),
	primary key(codigo)
);

create table candidato(
	cpf varchar(11),
	nome varchar(100),
	sexo char(1),
	dtnascto date,
	rua varchar(50),
	num varchar(10),
	bairro varchar(25),
	cidade varchar(30),
	uf char(2),
	cep char(8),
	primary key(cpf)
);

create table curso(
	id int(3),
	nome varchar(30),
	duracao int(2),
	periodo varchar(10),
	qtdVaga int(2),
	primary key(id)
);

create table cursoetec(
	cod int(4),
	id int(3),
	primary key(cod,id),
	foreign key(cod) references etec(codigo),
	foreign key(id) references curso(id)
);

create table inscricao(
	cpf varchar(11),
	id int(3),
	dtInscr date,
	valor decimal(5,2),
	primary key(cpf, id, dtInscr),
	foreign key(cpf) references candidato(cpf),
	foreign key(id) references curso(id)
);

create table telefone(
	ddd char(3),
	numero char(9),
	tipo varchar(15),
	codigo int(4),
	cpf varchar(11),
	primary key(ddd, numero),
	foreign key(codigo) references etec(codigo),
	foreign key (cpf) references candidato(cpf)
);

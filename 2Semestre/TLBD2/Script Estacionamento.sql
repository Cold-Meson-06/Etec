drop database Estacionamento;

create database Estacionamento;

use Estacionamento;

create table cliente (
cpf integer,
nome varchar (60),
dtNasc date,
primary key (cpf)
);

create table modelo (
codMod integer,
desc_2 varchar (40),
primary key (codMod)
);

create table patio(
num integer,
ender varchar (40),
capacidade integer,
primary key (num)
);

create table veiculo (
placa varchar (8),
modelo_codMod integer,
cliente_cpf integer,
cor varchar (20),
primary key (placa),
foreign key (modelo_codMod) references modelo (codMod),
foreign key (cliente_cpf) references cliente (cpf) 
);

create table estaciona(
cod integer,
patio_num integer,
veiculo_placa varchar (8),
dtEntrada varchar (10),
dtSaida varchar (10),
hsEntrada varchar (10),
hsSaida varchar (10),
primary key (cod),
foreign key (patio_num) references patio (num),
foreign key (veiculo_placa) references veiculo (placa)
);

insert into cliente values
(4518,"joão","2014-04-11"),
(4581,"Maria","2012-06-10"),
(9658,"jose","2011-07-20"),
(5489,"jeniffer","1995-07-20"),
(1558,"jefferson","2011-07-20");

insert into modelo values
(458,"astra"),
(265,"gol"),
(873,"c3"),
(158,"corsa"),
(198,"uno");

insert into patio values 
(48,"rua A", "5"),
(78,"rua B", "2"),
(12,"rua C", "5"),
(39,"rua D", "2"),
(11,"rua E", "5");

insert into veiculo values 
("ppp-4578",458,4518,"azul"),
("ggg-7845",265,4581,"preto"),
("ggg-1254",873,9658,"branco"),
("jjj-2020",158,5489,"vermelho"),
("www-4315",198,9658,"verde");

insert into estaciona values 
(01,48,"ppp-4578","2000-04-11","2014-04-11","14:00","19:00"),
(18,78,"ggg-7845","2008-05-12","2014-06-12","08:00","19:00"),
(65,12,"ggg-1254","2004-06-12","2018-06-16","08:00","14:00"),
(90,39,"jjj-2020","2003-07-12","2007-06-14","05:00","18:00"),
(87,11,"www-4315","2004-06-12","2018-06-12","06:00","21:00");

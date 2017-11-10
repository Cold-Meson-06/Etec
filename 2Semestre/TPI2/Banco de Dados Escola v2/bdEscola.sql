Create Database bdEscola;

Use bdEscola;

Create Table Aluno(
	RA int(10) primary key,
	nome varchar(30),
	rua varchar(30),
	num int(4),
	bairro varchar(50),
	cidade varchar(30),
	estado varchar(2)
);

#delete from aluno where ra = 123;
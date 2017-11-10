create database Universidade;

use Universidade;

CREATE TABLE Curso (
  NumCurso int(4) NOT NULL,
  Nome varchar(30),
  TotalCreditos int(4), 
  PRIMARY KEY (NumCurso)
);

CREATE TABLE Aluno (
  NumAluno int(6) NOT NULL,
  Nome varchar(30),
  Endereco varchar(30), 
  cidade varchar(20), 
  Telefone varchar(13), 
  NumCurso int(4),
  PRIMARY KEY (NumAluno),
  foreign key(NumCurso) references curso(NumCurso)
);

CREATE TABLE Disciplina (
  NumDisp int(5) NOT NULL,
  Nome varchar(30),
  QuantCreditos decimal(4,2), 
  PRIMARY KEY (NumDisp)
);

CREATE TABLE Professor (
  NumFunc int(5) NOT NULL primary key,
  Nome varchar(30),
  admissao date,
  AreaPesquisa varchar(30)
);


CREATE TABLE Aula (
  NumAluno int(4),
  NumDisp int(5),
  NumFunc int(5),
  Semestre varchar(7),
  Nota decimal(4,2),
  primary key(numAluno, NumDisp, NumFunc, Semestre),
  foreign key(NumAluno) references aluno(numAluno),
  foreign key(NumDisp) references disciplina(NumDisp),
  foreign key(NumFunc) references professor(NumFunc)

);

CREATE TABLE DisciplinaCurso (
  NumDisp int(5),
  NumCurso int(4),
  primary key(NumDisp,NumCurso),
  foreign key(NumDisp) references disciplina(NumDisp),
  foreign key(NumCurso) references curso(NumCurso)
);

INSERT INTO Curso VALUES("2142", "Engenharia Civil", "1500");
INSERT INTO Curso VALUES("2143", "Ciência da Computação","2000");
INSERT INTO Curso VALUES("2144", "Direito", "1750");
INSERT INTO Curso VALUES("2145", "Pedagogia", "1500");
INSERT INTO Curso VALUES("2146", "Odontologia", "1600");


INSERT INTO Aluno VALUES("111", "Edvaldo Carlos Silva","Av. São Carlos, 186","São Carlos - SP","(017)276-9999","2143");
INSERT INTO Aluno VALUES("112", "João Benedito Seapin","r. José Bonifácio, 70, 186","São Carlos - SP","(017)273-8974","2142");
INSERT INTO Aluno VALUES("113", "Carol Antonia Silveira","R. Luiz Camões, 120, 186","Ibaté - SP","(017)278-8568","2145");
INSERT INTO Aluno VALUES("114", "Marcos João Casanova","Av. São Carlos, 176","São Carlos - SP","(017)274-9874","2143");
INSERT INTO Aluno VALUES("115", "Simone Cristina Lima","R. Raul Junior, 180","São Carlos - SP","(017)273-9865","2144");
INSERT INTO Aluno VALUES("116", "Ailton Castro","R. Antonio Carlos, 120","Ibaté - SP","(017)278-8568","2142");
INSERT INTO Aluno VALUES("117", "José Paulo Figueiredo","R. XV Novembro, 871, 186","São Carlos - SP","(017)274-9774","2145");


INSERT INTO Professor VALUES("45675", "Abgair Simon Ferreira","1992-04-10", "Banco de Dados");
INSERT INTO Professor VALUES("45690", "Ramon Travanti","1993-05-20", "Direito Romano");
INSERT INTO Professor VALUES("45691", "Gustavo Golveia Netto","1993-04-05", "Sociologia");
INSERT INTO Professor VALUES("45692", "Marcos Salvador","1993-03-31", "Matemática Financeira");
INSERT INTO Professor VALUES("45693", "Cintia Falcão","1993-02-15", "Engenharia de Software");

INSERT INTO Disciplina VALUES("1", "Banco de Dados", "30");	   
INSERT INTO Disciplina VALUES("2", "Estrutura de Dados", "30");
INSERT INTO Disciplina VALUES("3", "Direito Penal", "25");
INSERT INTO Disciplina VALUES("4", "Cálculo Numérico", "30");
INSERT INTO Disciplina VALUES("5", "Psicologia Infantil", "25");
INSERT INTO Disciplina VALUES("6", "Direito Tributário", "33");
INSERT INTO Disciplina VALUES("7", "Engenharia Software", "27");


INSERT INTO DisciplinaCurso VALUES("1", "2143");	   
INSERT INTO DisciplinaCurso VALUES("2", "2143");
INSERT INTO DisciplinaCurso VALUES("3", "2144");
INSERT INTO DisciplinaCurso VALUES("4", "2143");
INSERT INTO DisciplinaCurso VALUES("4", "2142");
INSERT INTO DisciplinaCurso VALUES("5", "2145");
INSERT INTO DisciplinaCurso VALUES("6", "2144");
INSERT INTO DisciplinaCurso VALUES("7", "2143");
INSERT INTO DisciplinaCurso VALUES("7", "2142");
 
INSERT INTO Aula VALUES("111", "1", "45675", "1998-01", "8.5");
INSERT INTO Aula VALUES("111", "2", "45675", "1998-01", "6.0");
INSERT INTO Aula VALUES("111", "2", "45675", "1998-02", "7.0");
INSERT INTO Aula VALUES("115", "3", "45690", "1998-01", "4.5");
INSERT INTO Aula VALUES("115", "3", "45690", "1998-02", "7.5");
INSERT INTO Aula VALUES("111", "4", "45692", "1998-01", "8.0");
INSERT INTO Aula VALUES("112", "4", "45692", "1998-01", "7.0");
INSERT INTO Aula VALUES("113", "5", "45691", "1998-01", "7.5");
INSERT INTO Aula VALUES("115", "6", "45690", "1998-01", "9.0");
INSERT INTO Aula VALUES("111", "7", "45693", "1998-01", "10.0");
INSERT INTO Aula VALUES("112", "7", "45693", "1998-01", "5.5");
INSERT INTO Aula VALUES("112", "7", "45693", "1998-02", "10.0");
INSERT INTO Aula VALUES("114", "1", "45675", "1998-01", "7.0");
INSERT INTO Aula VALUES("114", "2", "45675", "1998-01", "8.0");
INSERT INTO Aula VALUES("114", "4", "45692", "1998-01", "6.5");
INSERT INTO Aula VALUES("114", "4", "45692", "1998-02", "8.5");
INSERT INTO Aula VALUES("116", "4", "45692", "1998-01", "3.5");
INSERT INTO Aula VALUES("116", "4", "45692", "1998-02", "9.5");
INSERT INTO Aula VALUES("114", "7", "45693", "1998-01", "9.5");
INSERT INTO Aula VALUES("116", "7", "45693", "1998-01", "8.5");

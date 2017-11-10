#Cria um novo banco de dados
Create Database Biblioteca;

#Usa o banco de dados
Use Biblioteca;     

#Agora todos os comandos executados irão alterar o banco `Biblioteca`

#Cria uma tabela
Create Table Livros(
    IdLivro int,                    #Uma propiadade com valores inteiros
    NomeLivro varchar(100),         #Uma propiadade do tipo string, largura máxima de 100
    PrecoDoLivro varchar(8),        #Uma propiadade do tipo string, largura máxima de 8 
    AutorDoLivro varchar(80),       #Uma propiadade do tipo string, largura máxima de 80 
    DataPublicacao date,            #Uma propiadade do tipo date (data)
    primary key (idLivro)           #Diz qual é a chave primaria da tabela
);

#Mostra informações sobre a tabela
Describe Livros;

#Adiciona um novo valor na tabela `Livros`
Insert Into Livros Values (
	"12",           #Valores inteiros vem entre "12"
    "Sad Carrot",   #Strings tabmbem"12"
    "96.12",        
    "Isac Cohein",
    20/12/1999      #Valores de data vão na forma literal
);

#Registrar os campos individualmente
#insert into Livros (IdLivro) values ("12");
#insert into Livros (NomeLivro) values ("Sad Carrot");
#insert into Livros (PrecoDoLivro) values ("96.12");
#insert into Livros (AutorDoLivro) values ("Isac Cohein");
#insert into Livros (DataPublicacao) values (20/12/1999);
    
#Pega todas as tabelas do campo `Livros`
Select * from Livros;

#Conta quantos items tem em `Livros`
Select Count(*) from Livros;

#Diz qual é o item em `Livros` que tem o maior valor no campo `IdLivro`
Select Max(IdLivro) from Livros;

#Diz qual é o item em `Livros` que tem o menor valor no campo `IdLivro`
Select Min(IdLivro) from Livros;

#Diz qual é a media dos valores no campo `IdLivro` em `Livros`
Select Avg(idLivros) From Livros;

#Diz a soma de todos os campos `idLivros` em `Livros`
Select Sum(idLivros) From Livros;

#Dá todos os items da tabela `Livros` ordenados por `NomeLivro`
#(em ordem alfabetica ou numerica (Crescente por padrão))
Select * From Livros Order By NomeLivro;

#Dá todos os items da tabela `Livros` ordenados por `NomeLivro`
#(em ordem alfabetica ou numerica) em ordem Decrescente
Select * From Livros Order By PrecoLivro Desc;

#Dá todos os items da tabela `Livros` dos quais a propiedade 
#`PrecoLivro` não está duplicadas
Select Distinct PrecoLivro from Livros;

#Adiciona um novo campo a tabela `Livros` chamado `Idade`
# com o tipo `date`
Alter Table Livros Add Idade date;

#Muda o tipo do campo `Nome` da tabela `Livros` para `varchar(100)`
Alter Table Livros Modify Nome varchar(100);

#Renomeia a tabela `Livros` para `AutoresCadastrados`
Rename Table Livros to AutoresCadastrados;

#Deleta todos os itenms da tabela `AutoresCadastrados` (Livros)
Drop Table AutoresCadastrados;

#Deleta o banco de dados `Biblioteca` inteiro 
Drop Database Biblioteca;

#Deleta todos os items da tabela `Livros` aonde o campo `idLivro` é exatamente '2'
Delete From Livros Where idLivro = '2';

#Troca todos os valores do campo `nomeLivro` da tabela `Livros` aonde o campo `idLivro` 
# é exatamente 'O cortiço'
Update Livros Set nomeLivro = 'The Life After Parsing' where nomeLivro = 'O cortiço';

#Dá todos os items da tabela `Livros` aonde o campo `nomeLivro` é 'F...(alguma coisa)'
Select * From Livros Where nomeLivro like 'F%';

#Deleta todos os items da tabela `Livros`
Truncate Table Livros;

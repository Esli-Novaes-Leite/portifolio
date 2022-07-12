create database Sistema_escolar_47;
use sistema_escolar_47;

create table alunos(
MATRICULA INT UNSIGNED auto_increment NOT NULL PRIMARY KEY,
NOME VARCHAR(80) NOT NULL,
SEXO VARCHAR(15) NOT NULL,
EMAIL VARCHAR(100) NOT NULL,
ENDERECO VARCHAR(150) NOT NULL,
TELEFONE CHAR(15) NOT NULL,
SENHA VARCHAR(150) NOT NULL
)ENGINE=INNODB;
insert into alunos values (null,'aa','zz','aa','aa','aa','aa');
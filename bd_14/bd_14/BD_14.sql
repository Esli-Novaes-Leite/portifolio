create database alunos_turma_14;
use alunos_turma_14;
create table alunos(
matricula int unsigned auto_increment not null primary key,
nome varchar(80) not null,
dt_nasc date not null,
sexo char(1) not null,
nota double not null,
foto varchar(150) not null
);
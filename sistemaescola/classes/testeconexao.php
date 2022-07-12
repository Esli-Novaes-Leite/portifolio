<?php
// importar um arquivo
require_once  "Alunos.php";

// criar uma instancia da classe
$alunos= new Alunos(); // criando um objeto do tipo classe
//criando variavel para receber a conexao
$listadealunos = $alunos->listartodos();

var_dump($listadealunos);
?>
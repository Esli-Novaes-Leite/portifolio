<?php
header("Content-type:text/html;charset=utf8;");

// inportar  a classe Alunos
require_once "classes/Alunos.php";

// criar  a instancia da classe
$Alunos=new Alunos();
// criar a  lista de alunos
$listaralunos=$Alunos->listartodos();


//  chamando a  funcao  excluir  passando a  matricula escolhida   pelo usuario
if(isset($_GET["matricula"])){
    $Alunos->excluir($_GET["matricula"]);
}



?>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Title</title>

    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/main.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

</head>
<body>

<div class="container lista">
<div class="row">
    <div class="col-md-10">
        <h3>Lista de Alunos</h3>
    </div>
     <div  class="col-md-2">

         <form action="cadalunos.php">
         <button class="btn btn-info">Novo</button>
             <a class="btn btn-dark" href="index.html">Voltar</a
        </form>
     </div>
</div>
<table class="table table-striped table-dark">
    <thead>
    <tr>
        <th>Matricula</th>
        <th>Nome</th>
        <th>Endereco</th>
        <th>Telefone</th>
        <th></th>
    </tr>
    </thead>
<tbody>

<?php  if($listaralunos):foreach ($listaralunos as $aluno): ?>
<tr>
    <td><?php echo $aluno->MATRICULA; ?></td>
    <td><?php echo $aluno->NOME; ?></td>
    <td><?php echo $aluno->ENDERECO; ?></td>
    <td><?php echo $aluno->TELEFONE; ?></td>
    <td>

        <a href="alterar_aluno.php?matricula=<?php echo $aluno->MATRICULA ;?>" class="btn btn-info"><i class="fa fa-edit"></i></a>
        <a href="index_alunos.php?matricula=<?php echo  $aluno->MATRICULA; ?>" class="btn btn-secondary"><i class="fa fa-trash"></i></a>

    </td>

</tr>
<?php endforeach; ?>
<?php else :  ?>
<tr>
    <td colspan="5">Nenhum aluno cadastrado</td>


</tr>
<?php endif ?>

</tbody>





</table>




</div>































</body>
</html>








<?php
header("Content-type:text/html;charset=utf8;");

require_once "classes/Alunos.php";

$Alunos= new Alunos();
if(isset($_POST["salvar"])) {
    $Alunos->inserir();
}

?>


<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <title>Cadastro escolar</title>


    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/main.css">
</head>












<body>


<div class="main">
    <div class="fRMESTRUTURE">
        <h1 class="text-center">Cadastre o aluno</h1>
        <form action="cadalunos.php" method="post">
            <div class="form-group">
                <label for="NOME">Informe o Nome </label><br>
                <input type="text"  id="NOME" name="NOME" class="form-control" required >  </div>
            <div class="form-group">
                <label for="email">Digite o email </label><br>
                <input type="email"  id="email" name="EMAIL" class="form-control"  required  >  </div>

            <div class="form-group">
                <label for="senha">Digite a senha </label><br>
                <input type="password"  id="senha" name="SENHA" class="form-control" required >  </div>

            <div class="form-group">
                <label for="categoria">Informe o telefone </label><br>
                <input type="number"  id="categoria" name="TELEFONE" class="form-control" required >  </div>
            <div class="form-group">
                <label for="endereco">Informe o endereço </label><br>
                <input type="text"  id="endereco" name="ENDERECO" class="form-control" required >  </div>
            <div class="form-group">
                <select class="custom-select" required name="SEXO" >
                    <option value="">Selecione o sexo </option>
                    <option  value="F">Feminino </option>
                    <option value="M">Masculino </option>
                    <option value="no">Não mencionar </option>
                </select>
            </div>


            <button class="btn btn-dark"  type="submit" name="salvar">Salvar</button>

            <a class="btn btn-dark" href="index.html">Voltar</a>



        </form>
    </div>
</div>





</body>
</html>

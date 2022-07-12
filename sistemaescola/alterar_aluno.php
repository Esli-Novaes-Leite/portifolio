<?php
header("Content-type:text/html;charset=utf8;");

//  importar  a classe  Alunos

require_once "classes/Alunos.php";
// instanciar   a classe Alunos
$Alunos=New Alunos();

// recuperar  os dados  do aluno  escolhido no  index_alunos.php

if(isset($_GET["matricula"])){
    $dadosaluno=$Alunos->listarid($_GET["matricula"]) ;

}
// chamando  a funcao  alterar  apos o usuario  clicar  no botao     salvar
if(isset($_POST["salvar"])){
// chamar  a funcao alterar
    $Alunos->alterar();

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
        <h1 class="text-center">Alterar dados do aluno</h1>
        <form action="alterar_aluno.php?matricula= <?php echo $dadosaluno->MATRICULA;  ?>" method="post">
            <div class="form-group">
                <label for="NOME">Informe o Nome </label><br>
                <input type="text"  id="NOME" name="NOME" class="form-control" value="<?php echo $dadosaluno->NOME; ?>"  >  </div>
            <div class="form-group">
                <label for="email">Digite o email </label><br>
                <input type="email"  id="email" name="EMAIL" class="form-control" value="<?php echo $dadosaluno->EMAIL;   ?>"   ></div>

            <div class="form-group">
                <label for="senha">Digite a senha </label><br>
                <input type="password"  id="senha" name="SENHA" class="form-control"  value="<?php echo $dadosaluno->SENHA;  ?>"  >  </div>

            <div class="form-group">
                <label for="categoria">Informe o telefone </label><br>
                <input type="number"  id="categoria" name="TELEFONE" class="form-control"  value="<?php echo $dadosaluno->TELEFONE;  ?>"  >  </div>
            <div class="form-group">
                <label for="endereco">Informe o endereço </label><br>
                <input type="text"  id="endereco" name="ENDERECO" class="form-control" value="<?php echo $dadosaluno->ENDERECO;   ?>"  >  </div>
            <div class="form-group">
                <div class="form-group">
                    <select name="SEXO" class="form-control" >
                        <option value="">Selecione o sexo </option>
                        <option  value="F" <?php if($dadosaluno->SEXO == "F"){echo "selected";} ?>>Feminino </option>
                        <option value="M"    <?php if($dadosaluno->SEXO == "M"){echo "selected";} ?>>Masculino </option>
                        <option value="no"     <?php if($dadosaluno->SEXO == "no"){echo "selected";} ?>>Não mencionar </option>
                    </select>
                </div>


            <button class="btn btn-dark" type="submit" name="salvar">Salvar</button>

            <a class="btn btn-dark" href="index_alunos.php">Voltar</a>



        </form>
    </div>
</div>





</body>
</html>


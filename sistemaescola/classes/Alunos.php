<?php
// importar  arquivos
// include  importar  um arquivo  dar mensagem  de erro  e continuar  a execucao ( utilizado  para incluir  conteudos html)
// require importar  um arquivo  dar mensagem de erro  e parar  a execucao  (utilizado  toda vez que  tratarmos de classes)
// require_once  //  include_once ->  once  importar  uma unica vez o arquivo
// É OBRIGATORIO IMPORTAR O ARQUIVO , SIMILAR AO START_SESSION
require_once "Conexao.php";
class Alunos
{
    // atributos

    public $MATRICULA;
    public $NOME;
    public $SEXO;
    public $EMAIL;
    public $ENDERECO;
    public $TELEFONE;
    public $SENHA;

    // metodos (select  / update/ insert / delete)
    //  metodo para  listar  todos alunos (select * from alunos)

    public function  listartodos(){

        try {
            // criar uma instancia  da classe  de conexao
            $bd =  new Conexao();
            //cria uma variavel  para receber a conexao
            $con= $bd->conectar();
            // criar o comando  sql  que sera  executado no servidor
            $sql = $con->prepare("select * from alunos ");
            // executar  o comando sql
            $sql->execute();
            //testar se retornou  valores  da tabela alunos
            if ($sql->rowCount() > 0) {
                //retornar  os dados  para html
                return $result = $sql->fetchAll(PDO::FETCH_CLASS);
                // fetchAll -> trazer  todas as linhas // FETCH_CLASS-> Retornar  no formato  classe  ->  atributos
                // fetch_class -> alunos->MATRICULA
                //fetch_assoc  ->  alunos["MATRICULA"]


            }

        }catch(PDOException $msg){
            echo "Não  foi  possivel listar  os dados dos alunos {$msg->getMessage()} ";
        }



























    }

    public  function  inserir ()
    {try{
        if(isset($_POST["NOME"]) &&  isset($_POST["SEXO"])){

            $this->NOME = $_POST["NOME"];
            $this->SEXO = $_POST["SEXO"];
            $this->EMAIL = $_POST["EMAIL"];
            $this->ENDERECO = $_POST["ENDERECO"];
            $this->TELEFONE = $_POST["TELEFONE"];
            $this->SENHA = $_POST["SENHA"];

            $bd= new Conexao();
            $con =$bd  ->conectar();
            $sql = $con->prepare("insert into alunos(MATRICULA,NOME,SEXO,EMAIL,ENDERECO,TELEFONE,SENHA)
           values(null,?,?,?,?,?,?)");

            $sql->execute(array($this->NOME,$this->SEXO,$this->EMAIL,$this->ENDERECO,$this->TELEFONE,$this->SENHA));

            if($sql->rowCount()>0){header("location:index_alunos.php");}

        }else{header("location:cadalunos.php");
        }


    }catch (PDOException $msg){echo "Não foi possivel acessar o site";}}

    public function  excluir($MATRICULA){
        try{
            // verificar  se recebeu a matricula
            if(isset($MATRICULA)){
                // preencher o atributo  com o valor  enviado pelo  formulario
                $this->MATRICULA=$MATRICULA;
                // instanciar  classe conexao
                $bd = new Conexao();
                //criar  o objeto  contento a conexao
                $con = $bd->conectar();
                // cria o  comando sql  para  enviar  ao banco
                $sql=$con->prepare("delete from alunos where MATRICULA = ? ");
                // executar o comando passando o  parametro  matricula
                $sql->execute(array($this->MATRICULA));
                //testar  se retornou valores
                if($sql->rowCount()>0){
                    //se o aluno foi excluido  retornar  para a tela  index_alunos.php
                    header("location:index_alunos.php");

                }





            }else{
                // se o  usuario  nao selecionou  no codigo para  excluir
                // retornar para  index_alunos.php
                header("location:index_alunos.php");

            }



        }catch (PDOException $msg){
            echo "Não foi possivel  excluir os alunos: ".$msg->getMessage();
        }






    }

    public function  alterar(){
        try{
            // verificar  se recebeu  valores do  formulario
            if(isset($_POST["salvar"])) {

                $this->MATRICULA=$_GET["matricula"];
                $this->NOME=$_POST["NOME"];
                $this->SEXO=$_POST["SEXO"];
                $this->EMAIL=$_POST["EMAIL"];
                $this->ENDERECO=$_POST["ENDERECO"];
                $this->TELEFONE=$_POST["TELEFONE"];
                $this->SENHA=$_POST["SENHA"];
                //  instanciar  classe conexao
                $bd = new Conexao();
                // criar o  objeto  contento  a conexao
                $con=$bd->conectar();

                // cria  o comando sql  para enviar  ao  banco  passando  parametros ?
                $sql= $con->prepare("update  alunos  set  NOME = ?,SEXO = ?,EMAIL = ?,
                 ENDERECO = ?,TELEFONE = ?,SENHA = ? WHERE MATRICULA = ?            ");
                // executar  o comando  passando os  valores  recebidos  do formulario

                $sql->execute(array(
                    $this->NOME,
                    $this->SEXO,
                    $this->EMAIL,
                    $this->ENDERECO,
                    $this->TELEFONE,
                    $this->SENHA,
                    $this->MATRICULA
                ));
                // testar  se retornou valores
                if($sql->rowCount()>0){
                    //se conseguiu  alterar  no banco de dados retornar  para pagina  index_alunos.php
                    header("location:index_alunos.php");
                }



            }else{
                //se  o usuario não preencheu  os valores  devolver para  o index_alunos.php
                header("location:index_alunos.php");

            }






        }catch (PDOException $msg){
            echo "Não foi possivel  alterar o aluno  ".$msg->getMessage();
        }



    }

    public  function  listarid($MATRICULA){

        try{
            if(isset($MATRICULA)){
                $this->MATRICULA=$MATRICULA;
                // instanciar  classe conexao
                $bd=new Conexao();
                // criar o  objeto  contento a  conexao
                $con=$bd->conectar();
                // cria  o comando sql   para enviar  ao banco
                $sql=$con->prepare("Select *  from alunos  where MATRICULA = ?");
                // executar o comando
                $sql->execute(array($this->MATRICULA));
                // testar  se retornou  valores
                if($sql->rowCount()>0){
                    // se  tem resultado  devolver os dados  do aluno  ao html
                    return  $result=$sql->fetchObject();
                    //  fetchAll ->  linhas/colunas


                }

            }




        }catch (PDOException $msg){
            echo"Não foi possivel  listar o aluno ".$msg->getMessage();
        }



    }







}
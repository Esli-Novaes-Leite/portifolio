<?php

// classe e uma estrutura de um objeto contendo atributos e metodos
// atributos  sao caracteristicas que descrevem a classe(campos da tabela)

// metodos sao acoes das classes (inserir ; deletar/atualizar/selecionar na tabela) CRUD

class Conexao
{

    // atributos para criar uma conexao (servidor,/banco de dados,/usuario,/senha)
    // visibilidade public/private
    private $servidor;
    private $banco;
    private $usuario;
    private $senha;



    // metodos -- representado  por function
    //  construtor quando a classe  é instanciada

    function __construct(){
        // executada  toda vez que  instanciamos  a classe
        $this->servidor = "localhost";       // this  faz  referencia a classe
        $this->banco = "sistema_escolar_47";
        $this->usuario = "root";
        $this->senha = "";


    }

     // metodo  para criar  uma conexao com o mysql com PDO
    // metodo  public  vai ser visivel fora da classe

    public function  conectar(){

try{   //  tentar executar esse bloco
  //  criar  a conexao  com mysql  utilizando  o PDO  new -> criar uma  instancia  da classe
    $con = new PDO ("mysql:host={$this->servidor};dbname={$this->banco};charset=utf8;",
        $this->usuario,$this->senha);
return $con;





}catch (PDOException $msg ) {//  se der  erro , retornar msg
          echo "Não foi possivel  conectar  ao banco de dados {$msg->getMessage()}";
        }










    }














}

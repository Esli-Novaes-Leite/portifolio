using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace bd_14
{
    class ConexãoBD
    {
        private MySqlConnection conexao;
        public void conectarBD() {
            conexao = new MySqlConnection("Persist Security Info = false; " +
                " server = localhost; " +
                "database = alunos_turma_14; " +
                "uid = root; pwd =; SslMode = none");
            conexao.Open();
        }
        public void AlterarTabelas(string sql)
        {
            conectarBD();
            MySqlCommand comandos = new MySqlCommand(sql, conexao);
            comandos.ExecuteNonQuery();
            conexao.Close();
        }
        public DataTable ConsultarTabelas(string sql)
        {
            conectarBD();
            MySqlDataAdapter consulta = new MySqlDataAdapter(sql, conexao);
            DataTable resultado = new DataTable();
            consulta.Fill(resultado);
            conexao.Close();
            return resultado;
        }
    }
}

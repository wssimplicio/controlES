using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ControlES
{
    class conexao
    {
        // vamos nos conectar ao SQL Server Express e à base de dados
        public static string connString = @"Server=localhost;Port=3306;Database=control;Uid=admin;Pwd=supertux@;";

        // representa a conexão com o banco
        private static MySqlConnection conn = null;

        // método que permite obter a conexão
        public static MySqlConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new MySqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (MySqlException)
            {
                conn = null;
                // ops! o que aconteceu?
                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }

            return conn;

        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
        

        public static void inserir()
        {

            try
            {
                //string a;
                //a = ;
                //object obj1 = new object();
                //obj1.ToString(Propriedade);

                obterConexao();
                
                MySqlCommand comd;
                MySqlConnection conn = obterConexao();

                comd = new MySqlCommand(@"insert into teste(nome) values('Marcelo');", conn);

                comd.ExecuteNonQuery();

            }
            catch (MySqlException)
            {
                
            }
        }
    }
}

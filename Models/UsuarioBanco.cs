using MySqlConnector;
using System.Collections.Generic;

namespace DestinoCerto.Models
{
    public class UsuarioBanco
    {
        private const string dadosConexao = "Database=DestinoCerto; Data Source=localhost; User Id=root;";

        public void Insert(Usuario novoUsuario)
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();

            string query = "INSERT INTO usuario(NomeUser, DataNascimento, Login, Senha, Tipo) VALUES (@NomeUser, @DataNascimento, @Login, @Senha, @Tipo)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@NomeUser", novoUsuario.NomeUser); // Pega o comando, testa no banco de dados, vai por as aspas e aspas simples e testar antes de por no bando de dados.
            comando.Parameters.AddWithValue("@DataNascimento", novoUsuario.DataNascimento);
            comando.Parameters.AddWithValue("@Login", novoUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", novoUsuario.Senha);
            comando.Parameters.AddWithValue("@Tipo", novoUsuario.Tipo);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
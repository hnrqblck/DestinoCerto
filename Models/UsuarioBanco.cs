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
        public List<Usuario> Query()
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();
            string query = "SELECT * FROM usuario";

            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();
            while(reader.Read())
            {
                Usuario user = new Usuario();
                user.IdUser = reader.GetInt32("IdUser");
                
                if (!reader.IsDBNull(reader.GetOrdinal("NomeUser"))) //Verificação. Se o dado não estiver nulo. GetOrdinal garante performance mais otimizada.
                {
                    user.NomeUser = reader.GetString("NomeUser");
                }

                if (!reader.IsDBNull(reader.GetOrdinal("DataNascimento")))
                {
                    user.DataNascimento = reader.GetDateTime("DataNascimento");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                {
                    user.Login = reader.GetString("Login");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                {
                    user.Senha = reader.GetString("Senha");
                }

                user.Tipo = reader.GetInt32("Tipo");

                lista.Add(user);
            }

            conexao.Close();
            return lista;

        }

    }
}
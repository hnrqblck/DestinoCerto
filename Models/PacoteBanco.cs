using MySqlConnector;
using System.Collections.Generic;

namespace DestinoCerto.Models
{
    public class PacoteBanco
    {
        private const string dadosConexao = "Database=DestinoCerto; Data Source=localhost; User Id=root;";

        public void Insert(Pacote novoPacote)
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();

            string query = "INSERT INTO pacote(NomePacote, Origem, Destino, Atrativos, Saida, Retorno) VALUES (@NomePacote, @Origem, @Destino, @Atrativos, @Saida, @Retorno)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

            comando.Parameters.AddWithValue("@NomePacote", novoPacote.NomePacote); // Pega o comando, testa no banco de dados, vai por as aspas e aspas simples e testar antes de por no bando de dados.
            comando.Parameters.AddWithValue("@Origem", novoPacote.Origem);
            comando.Parameters.AddWithValue("@Destino", novoPacote.Destino);
            comando.Parameters.AddWithValue("@Atrativos", novoPacote.Atrativos);
            comando.Parameters.AddWithValue("@Saida", novoPacote.Saida);
            comando.Parameters.AddWithValue("@Retorno", novoPacote.Retorno);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
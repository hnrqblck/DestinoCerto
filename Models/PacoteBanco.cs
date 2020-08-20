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

        public List<Pacote> Query()
        {
            MySqlConnection conexao = new MySqlConnection (dadosConexao);

            conexao.Open();
            string query = "SELECT * FROM pacote";

            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader reader = comando.ExecuteReader();

            List<Pacote> lista = new List<Pacote>();
            while(reader.Read())
            {
                Pacote pack = new Pacote();
                pack.IdPacote = reader.GetInt32("IdPacote");
                //pack.IdUser = reader.GetInt32("IdUser");
                
                if (!reader.IsDBNull(reader.GetOrdinal("NomePacote"))) //Verificação. Se o dado não estiver nulo. GetOrdinal garante performance mais otimizada.
                {
                    pack.NomePacote = reader.GetString("NomePacote");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("Origem")))
                {
                    pack.Origem = reader.GetString("Origem");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("Destino")))
                {
                    pack.Destino = reader.GetString("Destino");
                }

                if(!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                {
                    pack.Atrativos = reader.GetString("Atrativos");
                }

                if (!reader.IsDBNull(reader.GetOrdinal("Saida")))
                {
                    pack.Saida = reader.GetDateTime("Saida");
                }

                if (!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                {
                    pack.Retorno = reader.GetDateTime("Retorno");
                }

                lista.Add(pack);
            }

            conexao.Close();
            return lista;

        }
    }
}
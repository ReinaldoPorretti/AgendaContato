using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Dados
{
   public class TipoContatoRepositorio
    {
        public List<TipoContatoRepositorio> ConsultaTipoContatoRepositorio()
        {
            List<TipoContatoRepositorio> retornoConsulta = new List<TipoContatoRepositorio>();

            string comandoSQL = "SELECT * FROM TipoContato;";

            MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=AgendaContato;Uid=root;Pwd=;"); //Ponte
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexao);

            conexao.Open();

            MySqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                retornoConsulta.Add(new TipoContato
                {
                    Codigo = Convert.ToInt32(dr["Codigo"]),
                    Descricao = dr["Descricao"].ToString()
                });
            }

            return retornoConsulta;
        }

      

        public int InserirTipoContatoRepositorio(TipoContatoRepositorio tipocontato)
        {
            int codigoGerado = 0;

            string comandoSQL = "Insert into TipoContato(Nome,  Descricao) values (@Nome,  @Descricao);";

            MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=AgendaContato;Uid=root;Pwd=;");
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexao);

            comando.Parameters.AddWithValue("@Nome", tipocontato.Nome);
            comando.Parameters.AddWithValue("@Descricao", tipocontato.Descricao);

            conexao.Open();

            comando.ExecuteNonQuery();

            comando = new MySqlCommand("SELECT MAX(Codigo) from TipoContato", conexao);

            MySqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                codigoGerado = Convert.ToInt32(dr[0]);
            }

            return codigoGerado;
        }

        public void AlterarTipoContatoRepositorio(TipoContatoRepositorio tipocontato)
        {
            string comandoSQL = "Update TipoContato set Nome=@Nome,  Descricao=@Descricao where Codigo=@Codigo;";

            MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=AgendaContato;Uid=root;Pwd=;");
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexao);

            comando.Parameters.AddWithValue("@Codigo", tipocontato.Codigo);
            comando.Parameters.AddWithValue("@Descricao", tipocontato.Descricao);
            
            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void ApagarTipoContatoRepositorio(int codigoTipoContato)
        {
            string comandoSQL = "Delete from TipoContato where Codigo=@Codigo;";

            MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=AgendaContato;Uid=root;Pwd=;");
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexao);

            comando.Parameters.AddWithValue("@Codigo", codigoTipoContato);

            conexao.Open();

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public TipoContatoRepositorio ConsultaTipoContatoRepositorio(Int32 codigo)
        {
            TipoContatoRepositorio retornoConsulta = new TipoContatoRepositorio();

            string comandoSQL = "SELECT * FROM TipoContato where Codigo=@Codigo;";

            MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=AgendaContato;Uid=root;Pwd=;"); //Ponte
            MySqlCommand comando = new MySqlCommand(comandoSQL, conexao);

            comando.Parameters.AddWithValue("@Codigo", codigo);

            conexao.Open();

            MySqlDataReader dr = comando.ExecuteReader();

            while (dr.Read())
            {
                retornoConsulta= new TipoContato
                {
                    Codigo = Convert.ToInt32(dr["Codigo"]),
                    Nome = dr["Nome"].ToString()
                };
            }

            return retornoConsulta;
        }
    }
}

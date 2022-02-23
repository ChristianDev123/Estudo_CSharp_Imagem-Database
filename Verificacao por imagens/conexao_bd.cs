using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Verificacao_por_imagens
{
    class conexao_bd
    {
        // em casa:
        // Banco de dados já com insercao!
        // Não esquecer de trocar a string:
        private static string str_conexao = "server=localhost;User Id=root;database=estudos;password=''";
        public static MySqlConnection conexao = new MySqlConnection(str_conexao);
    }
    public class query
    {
        private static bool verifica_conexao()
        {
            bool res = false;
            try
            {
                conexao_bd.conexao.Open();
                res = true;
            }
            catch
            {
                res = false;
                MessageBox.Show("Houve um erro na comunicação com a base de dados!");
            }
            return res;
        }
        public static object select_mysql( string campo_procurado,string valor_procurado,string tabela="imagem_em_bd")
        {
            bool res = false;
            if (verifica_conexao())
            {
                // vou deixar estático a tabela de imagens:
                string str_query = $"SELECT imagem FROM imagens_mysql WHERE {campo_procurado} = '{valor_procurado}'";
                MySqlCommand select = new MySqlCommand(str_query, conexao_bd.conexao);
                MySqlDataReader informacoes = select.ExecuteReader();
                informacoes.Read();
                if (informacoes[campo_procurado] != null)
                {
                    res = true;
                }
            }
            return res;
        }
        public static object select_imagens_mysql(string campo_procurado, string valor_procurado, string tabela = "imagem_em_bd")
        {
            bool res = false;
            if (verifica_conexao())
            {
                // vou deixar estático a tabela de imagens:
                string str_query = $"SELECT imagem FROM imagens_mysql WHERE {campo_procurado} = '{valor_procurado}'";
                MySqlCommand select = new MySqlCommand(str_query, conexao_bd.conexao);
                MySqlDataReader informacoes = select.ExecuteReader();
                informacoes.Read();
                byte[] imagem = (byte[])informacoes["imagem"];
                MemoryStream ms = new MemoryStream(imagem);
                if (imagem.Length > 0)
                {
                    res = true;
                    return ms;
                }
                conexao_bd.conexao.Close();
            }
            return res;
        }
        public static bool insert_imagem_mysql(object imagem)
        {
            bool res = false;
            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Verificacao_por_imagens
{
    class conexao_bd
    {
        private static string str_conexao = "sever=locahost;User Id=root;password=''";
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
                MessageBox.Show("Houve um erro na camunicação com a base de dados!");
            }
            return res;
        }
        public bool select_mysql(string tabela="imagem_em_bd", string campo_procurado,string valor_procurado)
        {
            bool res = false;
            if (verifica_conexao())
            {
                string str_query = "";
            }
            
            return res;
        }
    }
}

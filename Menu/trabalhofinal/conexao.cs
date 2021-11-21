using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhofinal
{
    class Conexao
    {
        string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=12345;SSLMODE=none;";
        public MySqlConnection conexao;
        public string abreConexao()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                
                return "OK";
            }
            catch (MySqlException erro)
            {
                return erro.Message;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }

        public string fechaConexao()
        {
            try
            {
                conexao.Close();
                return "OK";
            }
            catch (MySqlException erro)
            {
                return erro.Message;
            }
            catch (Exception erro)
            {
                return erro.Message;
            }
        }
    }

}


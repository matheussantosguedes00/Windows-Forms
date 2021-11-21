using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Formularios
{
    class Conexao
    {
        string strConexao = @"SERVER=localhost; DATABASE=bdexemplo;UID=root;PASSWORD=;SSLMODE=none;";
        public MySqlConnection conexao;
        public string abreConexao()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                return "OK";
            }
            catch(MySqlException erro)
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

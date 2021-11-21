using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formularios
{
    class Funcionario
    {
        public string inserir(string nome, int idade, float salario)
        {
            Conexao c = new Conexao();
            try
            {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tblfuncionario(nome, idade, salario)" +
                    " VALUES(@nome, @idade, @salario)", c.conexao);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@salario", salario);
                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch(MySqlException erro)
            {
                return erro.Message;
            }
            catch(Exception erro)
            {
                return erro.Message;
            }
            finally
            {
                c.fechaConexao();
            }
        }

        public DataTable listar() {
            DataTable tabela = new DataTable();
            Conexao c = new Conexao();
            try
            {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand(@"select * from tblfuncionario", c.conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    tabela.Load(dados);
                }
                else
                {
                    tabela = new DataTable("Erro");
                    tabela.Rows.Add("Nenhum funcionário encontrado.");
                }
            }
            catch(MySqlException erro)
            {
                tabela = new DataTable("Erro");
                tabela.Rows.Add("Erro: " + erro.Message);
            }
            catch (Exception erro)
            {
                tabela = new DataTable("Erro");
                tabela.Rows.Add("Erro: " + erro.Message);
            }
            finally
            {
                c.fechaConexao();
            }
            return tabela;

        }

        public string atualizar(string nome, int idade, float salario, int idFunc)
        {
            Conexao c = new Conexao();
            try
            {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand("update tblfuncionario set nome = @nome, idade = @idade, " +
                    "salario = @salario where id = @id;", c.conexao) ;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@idade", idade);
                cmd.Parameters.AddWithValue("@salario", salario);
                cmd.Parameters.AddWithValue("@id", idFunc);
                cmd.ExecuteNonQuery();
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
            finally
            {
                c.fechaConexao();
            }
        }

        public string excluir(int idFunc)
        {
            Conexao c = new Conexao();
            try
            {
                c.abreConexao();
                MySqlCommand cmd = new MySqlCommand("delete from tblfuncionario where id = @id", c.conexao);
                cmd.Parameters.AddWithValue("@id", idFunc);
                cmd.ExecuteNonQuery();
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
            finally
            {
                c.fechaConexao();
            }
        }
    }
}

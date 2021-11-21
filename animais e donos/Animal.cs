using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Animal
    {
        
            public string inserir(string nome, int tipo, char sexo, string dono, DateTime data)
            {
                Conexao c = new Conexao();
                try
                {
                    c.abreConexao();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Animais(nome, tipo, sexo,dono,dataNascimento)" +
                        " VALUES(@nome, @tipo, @sexo,@dono,@data)", c.conexao);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@dono", dono);
                    cmd.Parameters.AddWithValue("@data", data);


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


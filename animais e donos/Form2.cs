using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
        private void nomeanimais()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=12345;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);


            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("VAZIO !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    conexao.Open();


                    MySqlCommand cmd = new MySqlCommand("select  *from animais where nome  like '%" + textBox1.Text + "%'   ", conexao);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);
                        dataGridView1.DataSource = dt;

                    }

                }
            }




            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        private void nomedonoanimais()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=12345;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);


            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("VAZIO !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    conexao.Open();


                    MySqlCommand cmd = new MySqlCommand("select  *from animais where  dono like '%" + textBox1.Text + "%'  ", conexao);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);
                        dataGridView1.DataSource = dt;

                    }

                }
            }




            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nomeanimais();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nomedonoanimais();
        }
    }
}

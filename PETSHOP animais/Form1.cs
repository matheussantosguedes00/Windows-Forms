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

namespace pFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Petshop an = new Petshop();


                string nome = textBoxnomeani.Text;
                int tipo = 0;
                char sexo = 'l';
                if (comboBox1.Text == "1-Cachorro")
                {
                    tipo = 1;
                }
                else if (comboBox1.Text == "2-Gato")
                {
                    tipo = 2;
                }
                else if (comboBox1.Text == "3-Coelho")
                {
                    tipo = 3;
                }


                if (radioBFemea.Checked)
                {

                    sexo = 'F';

                }
                else if (radioBmacho.Checked)
                {

                    sexo = 'M';
                }
                string dono = textBoxnomedon.Text;

            
           an.inserir(nome, tipo, sexo,dono);

                MessageBox.Show("Cadastro Realizado!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        private void pesquisa()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=9974;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);


            try
            {
                string AA= textBoxpequisa.Text;
                if (AA== "")
                {
                    MessageBox.Show(" NAO TEM NADA NO TEXBOX", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                else
                {
                    conexao.Open();


                    MySqlCommand cmd = new MySqlCommand("select * from animais where nome or dono like '%" + AA + "%'  ", conexao);
                    MySqlDataReader dados = cmd.ExecuteReader();
                    if (dados.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dados);
                        dGVPESQUISA.DataSource = dt;

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




        private void button2_Click(object sender, EventArgs e)
        {
            pesquisa();
        }


        private void animaisquatidade()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=9974;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from animais", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();

                    dt.Load(dados);

                    lbanimais.Text = "Animais :" + dt.Rows.Count;
                }
                else
                {
                    MessageBox.Show("Nenhum animal cadastrado");
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
        private void Cachorroquatidade()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=9974;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from animais where tipo=1", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();

                    dt.Load(dados);

                    lbdog.Text = "Cachorro :" + dt.Rows.Count;
                }
                else
                {
                    lbdog.Text = "Cachorro :" + "nao tem";
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
        private void gatoquatidade()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=9974;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from animais where tipo=2", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();

                    dt.Load(dados);

                    lbcat.Text = "Gato :" + dt.Rows.Count;
                }
                else
                {
                    lbcat.Text = "Gato:" + "nao tem";
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
        private void Coelhoquatidade()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=9974;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from animais where tipo=3", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();

                    dt.Load(dados);

                    lbcoelho.Text = "Coelho :" + dt.Rows.Count;
                }
                else
                {
                    lbcoelho.Text = "Coelho :" + "nao tem";
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
            animaisquatidade();
            Cachorroquatidade();
            gatoquatidade();
            Coelhoquatidade();
        }
    }
    }


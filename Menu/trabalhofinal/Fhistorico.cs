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

namespace trabalhofinal
{
    public partial class Fhistorico : Form
    {
        public Fhistorico()
        {
            InitializeComponent();
        }
        private void historicoanimais()
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

                    lbanimais.Text ="Animais :" + dt.Rows.Count; 
                }
                else
                {
                    lbanimais.Text = "Animais :" + 0;
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
            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from animais where tipo=1", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();

                    dt.Load(dados);

                    lbcachorro.Text = "Cachorro :" + dt.Rows.Count;
                }
                else
                {
                    lbcachorro.Text = "Coelho :" + 0;
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
            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from animais where tipo=2", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();

                    dt.Load(dados);

                    lbgato.Text = "Gato :" + dt.Rows.Count;
                }
                else
                {
                    lbgato.Text = "Coelho :" + 0;
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
                    lbcoelho.Text = "Coelho :" + 0;
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
        private void buscanimais()
        {
            string strConexao = @"SERVER=localhost; DATABASE=bdpetshop;UID=root;PASSWORD=12345;SSLMODE=none;";
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {

                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select nome,tipo,sexo,dono,dataNascimento from animais", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                if (dados.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dados);
                    dgvanimais.DataSource = dt;
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
        private void Fhistorico_Load(object sender, EventArgs e)
        {
            
            historicoanimais();
            buscanimais();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


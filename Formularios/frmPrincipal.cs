using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Formularios
{
    public partial class frmPrincipal : Form
    {
        public string strConexao = @"SERVER=localhost; DATABASE=bdexemplo;UID=root;PASSWORD=;SSLMODE=none;";
        private int idEditar;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btCadastraPessoa_Click(object sender, EventArgs e)
        {
            frmCadastraPessoa frmCadastraPessoa = new frmCadastraPessoa();
            //frmCadastraPessoa.lbNome.Text = txtNome.Text;
            //frmCadastraPessoa.strConexao = strConexao;
            frmCadastraPessoa.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastraPessoa frmCadastraPessoa = new frmCadastraPessoa();
            frmCadastraPessoa.ShowDialog();
        }

        private void btTestar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {
                conexao.Open();
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

        private void buscaFuncionario()
        {
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select id, nome as 'Nome', idade as 'Idade', salario as 'Salario' from tblfuncionario", conexao);
                //MySqlDataReader dados = cmd.ExecuteReader();
                //if (dados.HasRows)
                //{
                //    DataTable dt = new DataTable();
                //    dt.Load(dados);
                //    dgvFuncionarios.DataSource = dt;
                //}
                //else
                //{
                //    MessageBox.Show("Nenhum funcionário cadastrado");
                //}

                MySqlDataAdapter dados = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dados.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    dgvFuncionarios.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Nenhum funcionário cadastrado");
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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            buscaFuncionario();

            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("select * from tblprofissao", conexao);
                MySqlDataReader dados = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dados);
                cbProfissao.DisplayMember = "profissao";
                cbProfissao.ValueMember = "id";
                cbProfissao.DataSource = dt;
                cbProfissao.Text = "Selecione uma profissão";

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

        private void dgvFuncionarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewColumn coluna in dgvFuncionarios.Columns)
            {
                switch (coluna.Name)
                {
                    case "id":
                        coluna.Visible = false;
                        break;
                    case "Salario":
                        coluna.Width = 50;
                        coluna.HeaderText = "Salário";
                        break;
                    case "editar":
                        coluna.DisplayIndex = 4;
                        break;
                    case "excluir":
                        coluna.DisplayIndex = 5;
                        break;
                }
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvFuncionarios.Columns[e.ColumnIndex] == dgvFuncionarios.Columns["editar"])
            {
                txtNome.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Nome"].Value.ToString();
                txtIdade.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Idade"].Value.ToString();
                txtSalario.Text = dgvFuncionarios.Rows[e.RowIndex].Cells["Salario"].Value.ToString();
                idEditar = Convert.ToInt32(dgvFuncionarios.Rows[e.RowIndex].Cells["id"].Value);
            }
            else if(dgvFuncionarios.Columns[e.ColumnIndex] == dgvFuncionarios.Columns["excluir"])
            {
                int idExcluir = Convert.ToInt32(dgvFuncionarios.Rows[e.RowIndex].Cells["id"].Value);
                MySqlConnection conexao = new MySqlConnection(strConexao);
                try
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand("delete from tblfuncionario where id = @id ", conexao);
                    cmd.Parameters.AddWithValue("@id", idExcluir);
                    cmd.ExecuteNonQuery();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    conexao.Close();
                    buscaFuncionario();
                }
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("update tblfuncionario set nome = @nome, idade = @idade, salario = @salario where id = @id ", conexao);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@idade", txtIdade.Text);
                cmd.Parameters.AddWithValue("@salario", txtSalario.Text);
                cmd.Parameters.AddWithValue("@id", idEditar);
                cmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
                buscaFuncionario();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection(strConexao);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand("insert into tblfuncionario(nome, idade, salario) values (@nome, @idade, @salario)", conexao);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@idade", txtIdade.Text);
                cmd.Parameters.AddWithValue("@salario", txtSalario.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
                buscaFuncionario();
            }
        }
    }
}

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

namespace Formularios
{
    public partial class frmCadastraPessoa : Form
    {
   
        
        public frmCadastraPessoa()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastraPessoa_Load(object sender, EventArgs e)
        {
            
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario funcionario = new Funcionario();
                string nome = txtNome.Text;
                int idade = Convert.ToInt32(txtIdade.Text);
                float salario = float.Parse(txtSalario.Text);
                funcionario.inserir(nome, idade, salario);
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

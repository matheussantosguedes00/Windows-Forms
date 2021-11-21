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
    public partial class Fprincipal : Form
    {
        public Fprincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fcadastro Fcadastro = new Fcadastro();
            Fcadastro.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fpesquisa Fpesquisa = new Fpesquisa();
            Fpesquisa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fhistorico Fhistorico = new Fhistorico();
            Fhistorico.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            
          
            if (radiodire.Checked)
            {
                lbnome.Text = "Nome:" + nome;
                lbsalario.Text = "Salario :"+"R$ 10.000,00";
                lbconta.Text = "Conta :"+"R$ 10.000,00";
            }
            else if (radiogere.Checked)
            {
                textBoxhoras.Enabled = false;
                textBoxvenda.Enabled = false;
                double gerente;
                gerente = Convert.ToDouble(textBoxbonus.Text);
                double ss;
               
                ss = 6000 + gerente;
                lbnome.Text = "Nome:" + nome;
                lbsalario.Text ="Salario :"+ ss.ToString("C");
                lbconta.Text ="Conta :"+ "R$ 6.000,00 "+ "+"+gerente.ToString("C");

            }
            else if (radiodesen.Checked)
            {
                textBoxvenda.Enabled = false;
                textBoxbonus.Enabled = false;
                double desenvo;

                desenvo = Convert.ToDouble(textBoxhoras.Text);
                double ss;

                ss = 50 / desenvo;
                lbnome.Text = "Nome:" + nome;
                lbsalario.Text = "Salario :" + ss.ToString("C");
                lbconta.Text = "Conta :" + "R$ 50,00 " +"/"+ desenvo;
            }
            else if (radiovend.Checked)
            {
                textBoxhoras.Enabled = false;
                textBoxbonus.Enabled = false;
                double vende;
                double ss,aa;
                vende = Convert.ToDouble(textBoxvenda.Text);
                ss = vende/ 10;
                aa = ss + 1000;
                lbnome.Text = "Nome:" + nome;
                lbsalario.Text = "Salario :" + aa.ToString("C");
                lbconta.Text = "Conta :"+"10% da"+ vende +"+"+"R$ 1.000,00";
            }
        }
    }
}

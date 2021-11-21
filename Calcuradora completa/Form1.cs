using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace calcuradora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal valor1 =0, valor2 =0;
        string op = "";
        private void btlimpar_Click(object sender, EventArgs e)
        {
            
            lbsinal.Text = string.Empty;
            textBox1.Text = string.Empty;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }
        private void btponto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btresultado_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDecimal(textBox1.Text,CultureInfo.InvariantCulture);
            if (op == "soma") 
            {
                decimal res;
                res =Convert.ToDecimal( valor1 + valor2);
                textBox1.Text = ""+ res;

            }

            else if (op=="divisao")
            {
                decimal res;
                res = Convert.ToDecimal(valor1 / valor2);
                textBox1.Text = "" + res;
            }

            else if (op == "subta")
            {
                decimal res;
                res = Convert.ToDecimal(valor1 - valor2);
                textBox1.Text = "" + res;
            }

            else if (op == "multi")
            {
                decimal res;
                res = Convert.ToDecimal(valor1 * valor2);
                textBox1.Text = "" + res;
            }
        }

       

        private void soma_Click(object sender, EventArgs e)
        {
            
            valor1 = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
            lbsinal.Text = "+";
            op = "soma";
            textBox1.Text = string.Empty;

        }

        private void btsublitacao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
            lbsinal.Text = "-";
            op = "subta";
            textBox1.Text = string.Empty;
        }

        private void btmultip_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
            lbsinal.Text = "*";
            op = "multi";
            textBox1.Text = string.Empty;
        }

       

        private void btdivisao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDecimal(textBox1.Text, CultureInfo.InvariantCulture);
            lbsinal.Text = "/";
            op = "divisao";
            textBox1.Text = string.Empty;
        }

       
    }
}

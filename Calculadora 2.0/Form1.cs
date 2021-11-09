using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe5a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void buttonsoma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double n1, n2, soma;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                soma = n1 + n2;
                lbtext2.Text = "" + soma;
                lbtext1.Text = "+";


            }
        }

            private void buttondivisao_Click_1(object sender, EventArgs e)
            {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double n1, n2, div;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                div = n1 / n2;
                lbtext2.Text = "" + div;
                lbtext1.Text = "%";
            }
           
        }

            private void buttonmultipicao_Click(object sender, EventArgs e)
            {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double n1, n2, mut;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                mut = n1 * n2;
                lbtext2.Text = "" + mut;
                lbtext1.Text = "X";
            }
           
        }

            private void buttonsubtacao_Click_1(object sender, EventArgs e)
            {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular !!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double n1, n2, sub;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                sub = n1 - n2;
                lbtext2.Text = "" + sub;
                lbtext1.Text = "-";
            }
        }

            private void button5_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                textBox2.Clear();
                lbtext1.Text = "";
                lbtext2.Text = "";
            }
        }
    }
    


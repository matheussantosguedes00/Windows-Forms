using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("O espaço de número esta vazio !!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else { 
                double n1, n2;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);
           MessageBox.Show( n1 >n2 ? "Maior :"+n1 : "Maior :"+n2 , "Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("O espaço de número esta vazio !!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
            else
                {
                double n1, n2;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                if (n1 > n2)
                {
                    MessageBox.Show("O número maior é :" + n1, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (n2 > n1)
                {
                    MessageBox.Show("O número maior é :" + n2, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (n1 == n2)
                {
                    MessageBox.Show("O número sâo iguais !!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
    }
}

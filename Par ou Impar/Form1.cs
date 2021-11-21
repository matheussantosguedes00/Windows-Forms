using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("O espaço do número esta vazio  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else { 
                double n1;
            n1 = Convert.ToDouble(textBox1.Text);
            MessageBox.Show(n1 % 2 == 0 ? "Par" : "Impar", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("O espaço do número esta vazio  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
            else
            {
                double n1;
                n1 = Convert.ToDouble(textBox1.Text);
                if (n1 % 2 == 0)
                {
                    MessageBox.Show("O número " + n1 + " e Par", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O número " + n1 + " e Impar", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

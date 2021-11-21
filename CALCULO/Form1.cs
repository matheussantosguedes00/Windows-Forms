using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace execicio4b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Número vazio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                int val=0;
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                    {
                        val++;
                    }
                }
                if (val == 2)
                {
                    MessageBox.Show(a+" : "+"E primo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(a + " : " + "Não e primo", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Número vazio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                int  fatorial;
                

                fatorial = a;
                for (int i = a - 1; i >= 1; i--)
                {
                   

                    fatorial = fatorial * i;

                  
                }
                MessageBox.Show("O fatorial do número " + a + " é " + fatorial, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
 }


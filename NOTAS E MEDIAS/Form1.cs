using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace execicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (texb1.Text=="" || texb2.Text == "" || texb3.Text == "" || texb4.Text == "" || texb5.Text == "" )
            {
                MessageBox.Show("Espaço vazio","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                double[] notas = new double[5];
                notas[0] = Convert.ToDouble(texb1.Text);
                notas[1] = Convert.ToDouble(texb2.Text);
                notas[2] = Convert.ToDouble(texb3.Text);
                notas[3] = Convert.ToDouble(texb4.Text);
                notas[4] = Convert.ToDouble(texb5.Text);
                double not = notas[0] + notas[1] + notas[2] + notas[3] + notas[4];

                foreach (double nott in notas)
                {
                    
                    MessageBox.Show("Notas :" + nott, "Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                label7.Text = "Media é :" + not/5;
               
            }

        }

       
    }
}

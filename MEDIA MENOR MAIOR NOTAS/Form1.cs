using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace execicio3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Espaço vazio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double[] idade = new double[5];
                idade[0] = Convert.ToDouble(textBox1.Text);
                idade[1] = Convert.ToDouble(textBox2.Text);
                idade[2] = Convert.ToDouble(textBox3.Text);
                idade[3] = Convert.ToDouble(textBox4.Text);
                idade[4] = Convert.ToDouble(textBox5.Text);

                double media;
                media = idade[0] + idade[1] + idade[2] + idade[3] + idade[4];
                lbmedia.Text = "Media :" + (media / 5);

                double menor, maior;
                maior = idade[0];
                menor = idade[0];
                for (int i = 0; i < 5; i++)
                {


                    if (idade[i] < menor)
                    {

                        menor = idade[i];

                    }
                    else if (idade[i] > maior)
                    {
                        maior = idade[i];

                    }


                }
                lbmaior.Text = "Idade maior :" + maior;
                lbmenor.Text = "Idade menor :" + menor;

            }
        }
    }
}

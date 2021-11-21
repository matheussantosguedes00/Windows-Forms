using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace execicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2 =0;
            n1 = Convert.ToInt32(textBox1.Text);
            if (comboBox1.Text == "x")
            {
                while (n2 < 11)
                {
                    MessageBox.Show(n1 + " X " + n2 + " = " + (n2 * n1));
                    n2++;
                }
            }else if (comboBox1.Text == "+")
            {
                while (n2 < 11)
                {
                    MessageBox.Show(n1 + " + " + n2 + " = " + (n2 + n1));
                    n2++;
                }
            }else if (comboBox1.Text == "-")
            {
                while (n2 < 11)
                {
                    MessageBox.Show(n1 + " - " + n2 + " = " + (n2 - n1));
                    n2++;
                }
            }else if (comboBox1.Text == "/")
            {
                while (n2 < 11)
                {
                    MessageBox.Show(n1 + " / " + n2 + " = " + (n2 / n1));
                    n2++;
                }
            }
            else
            {
                MessageBox.Show("Opição não selecionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1;
            n1 = Convert.ToInt32(textBox1.Text);

            if (comboBox1.Text == "x")
            {
                for (int n2 = 0; n2 < 11; n2++)
                {
                    MessageBox.Show(n1 + " X " + n2 + " = " + (n2 * n1));

                }
            }
            else if (comboBox1.Text == "-")
            {
                for (int n2 = 0; n2 < 11; n2++)
                {
                    MessageBox.Show(n1 + " - " + n2 + " = " + (n2 - n1));

                }
            }
            else if (comboBox1.Text == "+")
            {
                for (int n2 = 0; n2 < 11; n2++)
                {
                    MessageBox.Show(n1 + " + " + n2 + " = " + (n2 + n1));

                }
            }
            else if (comboBox1.Text == "/")
            {
                for (int n2 = 0; n2 < 11; n2++)
                {
                    MessageBox.Show(n1 + " / " + n2 + " = " + (n2 / n1));

                }
            }
            else
            {
                MessageBox.Show("Opição não selecionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

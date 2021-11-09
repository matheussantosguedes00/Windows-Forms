using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe4a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular", " ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Não foi possivel calcular", " ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double n1, n2, s, a, m, d;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                a = n1 + n2;
                s = n1 - n2;
                d = n1 / n2;
                m = n1 * n2;
                lbsubtra.Text = "Subtração :" + s;
                lbmulti.Text = "Multiplicação :" + m;
                lbdivi.Text = "Divisão :" + d;
                lbadição.Text = "Adição :" + a;
            }

        }
    }
}

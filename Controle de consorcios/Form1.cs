using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe3a
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
                MessageBox.Show("Não foi possivel!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Não foi possivel!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Não foi possivel!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                double vcp, ntp, qp, vp, sd, vv, va;
                vcp = Convert.ToDouble(textBox1.Text);
                ntp = Convert.ToDouble(textBox2.Text);
                qp = Convert.ToDouble(textBox3.Text);
                vv = vcp * ntp;
                va = qp * vcp;
                vp = vv - va;
                sd = vv - vp;
                lbpago.Text = "Valor total pago :" + sd;
                lbdevedor.Text = "Saldo devedor :" + vp;
            }

            
        }
    }
}

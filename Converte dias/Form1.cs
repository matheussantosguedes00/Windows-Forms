using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2b
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


                MessageBox.Show("Nao foi possivel realizar a converção", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            else
            {

                double dias, semanas, meses, anos;
                dias = Convert.ToDouble(textBox1.Text);
                semanas = dias / 7;
                meses = dias / 30;
                anos = dias / 365;
                MessageBox.Show("Semanas :" + semanas + "\n" + "Meses :" + meses + "\n" + "Anos :" + anos, "Resultado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}

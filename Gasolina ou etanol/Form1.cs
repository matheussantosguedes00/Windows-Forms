using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Espaço do preço vazio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double n1, n2, nn;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                nn = n1 / n2;
                if (nn > 0.7){
                    MessageBox.Show("Gasolina é melhor para abastecer", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (nn < 0.7)
                {
                    MessageBox.Show("Etanol é melhor para abastecer", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Resutado igual voce poder escolher um dos dois", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace exe2._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Espaço idade vazio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double n1;
                n1 = Convert.ToDouble(textBox2.Text);
                if (n1 < 14)
                {
                    MessageBox.Show("Mirim", "Categoria do atleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (n1>=14 && n1<=15)
                {
                    MessageBox.Show("Infantil", "Categoria do atleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (n1 >= 16 && n1 <= 17)
                {
                    MessageBox.Show("Juvenil", "Categoria do atleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (n1 >= 18 && n1 <= 20)
                {
                    MessageBox.Show("Juniores", "Categoria do atleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (n1>20)
                {
                    MessageBox.Show("Profissional", "Categoria do atleta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}

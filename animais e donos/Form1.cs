using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Animal animal = new Animal();

            
            int tipo = 0;
            char sexo = 'o';
            if (comboBox1.Text == "1-Cachorro")
            {
                tipo = 1;
            }
            else if (comboBox1.Text == "2-Gato")
            {
                tipo = 2;
            }
            else if (comboBox1.Text == "3-Coelho")
            {
                tipo = 3;
            }


            if (rbsM.Checked)
            {

                sexo = 'M';

            }
            else if (rbsF.Checked)
            {

                sexo = 'F';
            }
            string dono = txtdono.Text;

            DateTime dat = DateTime.Parse(txtdata.Text);


            animal.inserir(txtnome.Text, tipo, sexo, txtdono.Text, dat);

            MessageBox.Show("Animal cadastrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Fpesquisa = new Form2();
            Fpesquisa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Fpesquisa = new Form3();
            Fpesquisa.ShowDialog();
        }
    }
    }
    


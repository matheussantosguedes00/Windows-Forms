using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhofinal
{
    public partial class Fcadastro : Form
    {
        public Fcadastro()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal = new Animal();
           
         
            string nome = txtnome.Text;
            int tipo = 0;
            char sexo='l';
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
           

            if (sexoM.Checked)
            {
               
                sexo = 'M';
               
            }else if (SexoF.Checked)
            {
               
                sexo = 'F';
            }
            string dono = txtdono.Text;

           DateTime dat = DateTime .Parse(txdata.Text);

            
            animal.inserir(nome,tipo,sexo,dono,dat);

            MessageBox.Show("Cadastro foi um sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }
       

       
    }
}


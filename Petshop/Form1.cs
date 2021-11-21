using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova1a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        public struct animais
        {
           public string nome;
            public int tipo;
            public char sexo;
            public string dono;
            
        }
        public static List<animais> listap = new List<animais>();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            animais a=new animais();
            
            
            a.nome = Convert.ToString(textBox1.Text);
            
            if (comboBox1.Text == "1 - Cachorro")
            {
                a.tipo = 1 ;
            }else if  (comboBox1.Text == "2 - Gato")
                {
                    a.tipo = 2;
                }
            else if (comboBox1.Text == "3 - Outro")
            {
                a.tipo = 3;
            }
            if (SexoM.Checked)
            {
                a.sexo = 'M';
            }
            else if(SexoF.Checked)
            {
                a.sexo = 'F';
            }

             a.dono= Convert.ToString(textBox2.Text);

            listap.Add(a);


            
           
            listBox1.Items.Add("Nome :" +a.nome );
            listBox1.Items.Add("Sexo :" + a.sexo);
            listBox1.Items.Add("Tipo :" + a.tipo);
            listBox1.Items.Add("Dono :" + a.dono);
            listBox1.Items.Add("---------------------------------------------------------------------------------------------------------------------------------------------------------" );

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            SexoF.Checked = false;
            SexoM.Checked = false;
            
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           foreach(animais item in listap)
            {
                

                string nome1 = textBox3.Text;

                
                    if (nome1 == item.nome )
                    {
                    
                    listBox1.Items.Remove("Nome :" + item.nome);
                    listBox1.Items.Remove("Sexo :" + item.sexo);
                    listBox1.Items.Remove("Tipo :" + item.tipo);
                    listBox1.Items.Remove("Dono :" + item.dono);
                    listBox1.Items.Remove("---------------------------------------------------------------------------------------------------------------------------------------------------------");

                }
                

            }
           textBox3.Clear();
        }

       
    }
}

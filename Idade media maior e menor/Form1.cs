using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Espaço vazio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double somatoria = 0;
            double iitem;
            double  maior =0;
            double menor = 100000;
            foreach (string item in listBox1.Items)
            {
                iitem = Convert.ToDouble(item);
                int it = Convert.ToInt32(listBox1.Items.Count);

                for (int i = 0; i < it; i++)
                {
                    somatoria = somatoria + iitem;
                }
                lbMedia.Text= "Media Idade :"+Convert.ToDouble((somatoria/it)/it);

                
                for (int i = 0; i < it; i++)
                {


                    if ( iitem <menor)
                    {
                       
                        menor = iitem;

                    }
                    else if (iitem > maior)
                    {
                        maior = iitem;

                    }


                }
                lbMaior.Text = " Maior Idade :" + maior;
                lbMenor.Text = "Menor Idade :" + menor;



            }
            
            
           

    }
    }
}

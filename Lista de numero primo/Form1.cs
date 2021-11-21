using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
                listBox1.Items.Add(textBox1.Text);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            foreach (string item in listBox1.Items)
            {

                int aa = Convert.ToInt32(item);
                int val = 0;
                for (int i = 1; i <= aa; i++)
                {
                    if (aa % i == 0)
                    {
                        val++;
                    }
                }
                if (val == 2)
                {
                    for (int j = 0; j < 1; j++)
                    {
                        listBox2.Items.Add(item);
                    }
                }
              


            }
            MessageBox.Show("Números Primos : " + listBox2.Items.Count.ToString(),"Resultados",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}

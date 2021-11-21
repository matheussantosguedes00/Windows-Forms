using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exe3
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
            listBox2.Items.Clear();
            foreach(string item in listBox1.Items)
            {
                string pletra = Convert.ToString(textBox2.Text);
               
                string pp ;
                pp = item.Substring(0, 1);


                
                    if (pletra == pp)
                    {

                        listBox2.Items.Add(item);
                    }

                




            }
         
        }
    }
}

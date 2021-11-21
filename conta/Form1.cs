using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        decimal saldo =0 , limite=0;
       

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lbvalsa.Text =  saldo.ToString("C");
            lblimite.Text = limite.ToString("C");
            
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            decimal  valormor;
            valormor = Convert.ToDecimal(textBox1.Text);
            if (valormor < limite)
            {

                MessageBox.Show("Não foi possivel!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {

                if (valormor > saldo)
                {
                    MessageBox.Show("saldo insuficiente!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    decimal ss;
                    ss = valormor - saldo;
                    lbvalsa.Text = "" + ss.ToString("C");
                    MessageBox.Show("Foi um sucesso!!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            decimal ss, valormor;
            valormor = Convert.ToDecimal(textBox1.Text);

            if (valormor >= limite)
            {
                MessageBox.Show("Não foi possivel!!! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ss = saldo+valormor;
                lbvalsa.Text = ss.ToString("C");
                MessageBox.Show("Foi um sucesso!!! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void button3_Click(object sender, EventArgs e)
        {

            limite = Convert.ToDecimal(textBox2limite.Text);
            lblimite.Text = limite.ToString("C");
        }

    }
}

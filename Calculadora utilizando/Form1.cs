using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_utilizando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void button1_Click_1(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = Convert.ToDouble(textBox1.Text);
            n2 = Convert.ToDouble(textBox2.Text);


           


                if (radiosoma.Checked)
                {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                    groupBox1.Enabled = false;
                    double rs;
                    rs = n1 + n2;
                    lbresultado.Text = "Resultado :" + rs;
                }
                else if (radiosubt.Checked)
                {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                groupBox1.Enabled = false;
                    double rs;
                    rs = n1 - n2;
                    lbresultado.Text = "Resultado :" + rs;
                }
                else if (radiodivi.Checked)
                {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                groupBox1.Enabled = false;
                    if (n2 != 0)
                    {
                        double rs;
                        rs = n1 / n2;
                        lbresultado.Text = "Resultado :" + rs;
                    }
                }
                else if (radiomult.Checked)
                {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                groupBox1.Enabled = false;
                    double rs;
                    rs = n1 * n2;
                    lbresultado.Text = "Resultado :" + rs;
                }
            


             else if (radio1so.Checked)
            {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                panel2.Enabled = false;
                double rs;
                rs = n1 + n2;
                lbresultado.Text = "Resultado :" + rs;
            }
            else if (radio1sub.Checked)
            {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                panel2.Enabled = false;
                double rs;
                rs = n1 - n2;
                lbresultado.Text = "Resultado :" + rs;
            }
            else if (radio1divi.Checked)
            {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                panel2.Enabled = false;
                double rs;
                rs = n1 / n2;
                lbresultado.Text = "Resultado :" + rs;
            }
            else if (radio1mutl.Checked)
            {
                comboBox1.Enabled = false;
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                panel2.Enabled = false;
                double rs;
                rs = n1 * n2;
                lbresultado.Text = "Resultado :" + rs;
            }


            else if (checkBoxsoma.Checked)
            {
                
                comboBox1.Enabled = false;
                groupBox1.Enabled = false;
                panel2.Enabled = false;
                checkBoxsubtrair.Checked = false;
                double rs;
                rs = n1 + n2;
                lbresultado.Text = "Resultado :" + rs;
            }
            else if (checkBoxsubtrair.Checked)
            {
                comboBox1.Enabled = false;
                
                groupBox1.Enabled = false;
                panel2.Enabled = false;
                checkBoxsoma.Checked = false;
                double rs;
                rs = n1 - n2;
                lbresultado.Text = "Resultado :" + rs;
            }

            //string ss = comboBox1.SelectedItem.ToString();
            int ss = comboBox1.SelectedIndex;

             if (ss == 0)
            {
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                groupBox1.Enabled = false;
                panel2.Enabled = false;
                checkBoxsoma.Checked = false;
                double rs;
                rs = n1 + n2;
                lbresultado.Text = "Resultado :" + rs;
            }
            else if (ss == 3)
            {
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                groupBox1.Enabled = false;
                panel2.Enabled = false;
                checkBoxsoma.Checked = false;
                double rs;
                rs = n1 / n2;
                lbresultado.Text = "Resultado :" + rs;
            }
            else if (ss ==1)
            {
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                groupBox1.Enabled = false;
                panel2.Enabled = false;
                checkBoxsoma.Checked = false;
                double rs;
                rs = n1 - n2;
                lbresultado.Text = "Resultado :" + rs;
            }
            else if (ss == 2)
            {
                checkBoxsubtrair.Enabled = false;
                checkBoxsoma.Enabled = false;
                groupBox1.Enabled = false;
                panel2.Enabled = false;
                checkBoxsoma.Checked = false;
                double rs;
                rs = n1 * n2;
                lbresultado.Text = "Resultado :" + rs;
            }


        }
    }
}


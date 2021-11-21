using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAFIO
{
    public partial class Form1 : Form
    {
        bool x = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            B11.Click += new EventHandler(BClick);
            B12.Click += new EventHandler(BClick);
            B13.Click += new EventHandler(BClick);

            B21.Click += new EventHandler(BClick);
            B22.Click += new EventHandler(BClick);
            B23.Click += new EventHandler(BClick);

            B31.Click += new EventHandler(BClick);
            B32.Click += new EventHandler(BClick);
            B33.Click += new EventHandler(BClick);

            foreach (Control item in this.Controls)
            {
                if(item is Button)
                {
                    item.TabStop = false;
                }
            }
        }
        private void BClick(object sender, EventArgs e)
        {
            ((Button)sender).Text = this.x ? "X" : "O";
            ((Button)sender).Enabled = false;
            Verificaganhador();
            x = !x;
            
        }
        private void Verificaganhador()
        {
            if (
          B11.Text != String.Empty && B11.Text == B12.Text && B12.Text == B13.Text ||
          B21.Text != String.Empty && B21.Text == B22.Text && B22.Text == B23.Text ||
          B31.Text != String.Empty && B31.Text == B32.Text && B32.Text == B33.Text ||

          B11.Text != String.Empty && B11.Text == B21.Text && B21.Text == B31.Text ||
          B12.Text != String.Empty && B12.Text == B22.Text && B22.Text == B32.Text ||
          B13.Text != String.Empty && B13.Text == B23.Text && B23.Text == B33.Text ||

          B11.Text != String.Empty && B11.Text == B22.Text && B22.Text == B33.Text ||
          B13.Text != String.Empty && B13.Text == B22.Text && B22.Text == B31.Text

          )
            {
                MessageBox.Show(String.Format("O ganhador é o :"+( x ? "X" : "O")), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reiniciar();
            }
            else
            {
                Verificaempate();
            }
        }
        private void reiniciar()
        {

            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    item.Enabled = true;
                    item.Text = String.Empty;
                }
            }
        }
        private void Verificaempate()
        {
            bool todosdesabilitado = false;
           
            foreach (Control item in this.Controls)
            {
                if (item is Button && item.Enabled)
                {
                    todosdesabilitado = false;
                    break;
                }
            }
            if (todosdesabilitado)
            {
                MessageBox.Show((String.Format("Empate")), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reiniciar();
            }
        }

    }
}

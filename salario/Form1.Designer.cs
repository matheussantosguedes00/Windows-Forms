
namespace salario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radiodire = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiogere = new System.Windows.Forms.RadioButton();
            this.radiodesen = new System.Windows.Forms.RadioButton();
            this.radiovend = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lbsalario = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxvenda = new System.Windows.Forms.TextBox();
            this.textBoxbonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxhoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbconta = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 23);
            this.textBox1.TabIndex = 1;
            // 
            // radiodire
            // 
            this.radiodire.AutoSize = true;
            this.radiodire.Location = new System.Drawing.Point(14, 22);
            this.radiodire.Name = "radiodire";
            this.radiodire.Size = new System.Drawing.Size(61, 19);
            this.radiodire.TabIndex = 2;
            this.radiodire.TabStop = true;
            this.radiodire.Text = "Diretor";
            this.radiodire.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiogere);
            this.groupBox1.Controls.Add(this.radiodesen);
            this.groupBox1.Controls.Add(this.radiovend);
            this.groupBox1.Controls.Add(this.radiodire);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargo";
            // 
            // radiogere
            // 
            this.radiogere.AutoSize = true;
            this.radiogere.Location = new System.Drawing.Point(14, 47);
            this.radiogere.Name = "radiogere";
            this.radiogere.Size = new System.Drawing.Size(66, 19);
            this.radiogere.TabIndex = 4;
            this.radiogere.TabStop = true;
            this.radiogere.Text = "Gerente";
            this.radiogere.UseVisualStyleBackColor = true;
            // 
            // radiodesen
            // 
            this.radiodesen.AutoSize = true;
            this.radiodesen.Location = new System.Drawing.Point(14, 72);
            this.radiodesen.Name = "radiodesen";
            this.radiodesen.Size = new System.Drawing.Size(103, 19);
            this.radiodesen.TabIndex = 5;
            this.radiodesen.TabStop = true;
            this.radiodesen.Text = "Desenvolvedor";
            this.radiodesen.UseVisualStyleBackColor = true;
            // 
            // radiovend
            // 
            this.radiovend.AutoSize = true;
            this.radiovend.Location = new System.Drawing.Point(14, 97);
            this.radiovend.Name = "radiovend";
            this.radiovend.Size = new System.Drawing.Size(75, 19);
            this.radiovend.TabIndex = 6;
            this.radiovend.TabStop = true;
            this.radiovend.Text = "Vendedor";
            this.radiovend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbsalario
            // 
            this.lbsalario.AutoSize = true;
            this.lbsalario.Location = new System.Drawing.Point(10, 322);
            this.lbsalario.Name = "lbsalario";
            this.lbsalario.Size = new System.Drawing.Size(48, 15);
            this.lbsalario.TabIndex = 5;
            this.lbsalario.Text = "Salario :";
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(12, 262);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(46, 15);
            this.lbnome.TabIndex = 6;
            this.lbnome.Text = "Nome :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Venda:";
            // 
            // textBoxvenda
            // 
            this.textBoxvenda.Location = new System.Drawing.Point(10, 225);
            this.textBoxvenda.Name = "textBoxvenda";
            this.textBoxvenda.Size = new System.Drawing.Size(100, 23);
            this.textBoxvenda.TabIndex = 8;
            // 
            // textBoxbonus
            // 
            this.textBoxbonus.Location = new System.Drawing.Point(141, 225);
            this.textBoxbonus.Name = "textBoxbonus";
            this.textBoxbonus.Size = new System.Drawing.Size(100, 23);
            this.textBoxbonus.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bonus";
            // 
            // textBoxhoras
            // 
            this.textBoxhoras.Location = new System.Drawing.Point(261, 223);
            this.textBoxhoras.Name = "textBoxhoras";
            this.textBoxhoras.Size = new System.Drawing.Size(100, 23);
            this.textBoxhoras.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Horas";
            // 
            // lbconta
            // 
            this.lbconta.AutoSize = true;
            this.lbconta.Location = new System.Drawing.Point(12, 292);
            this.lbconta.Name = "lbconta";
            this.lbconta.Size = new System.Drawing.Size(42, 15);
            this.lbconta.TabIndex = 13;
            this.lbconta.Text = "Conta:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.lbconta);
            this.Controls.Add(this.textBoxhoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxbonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxvenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.lbsalario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radiodire;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiogere;
        private System.Windows.Forms.RadioButton radiodesen;
        private System.Windows.Forms.RadioButton radiovend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbsalario;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxvenda;
        private System.Windows.Forms.TextBox textBoxbonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxhoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbconta;
    }
}


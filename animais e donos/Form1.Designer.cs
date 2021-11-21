
namespace WinFormsApp1
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
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtdono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbsF = new System.Windows.Forms.RadioButton();
            this.rbsM = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(27, 36);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(179, 23);
            this.txtnome.TabIndex = 0;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(27, 142);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(179, 23);
            this.txtdata.TabIndex = 1;
            // 
            // txtdono
            // 
            this.txtdono.Location = new System.Drawing.Point(27, 88);
            this.txtdono.Name = "txtdono";
            this.txtdono.Size = new System.Drawing.Size(179, 23);
            this.txtdono.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Animal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Dono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de nacsimento :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbsF
            // 
            this.rbsF.AutoSize = true;
            this.rbsF.Location = new System.Drawing.Point(247, 40);
            this.rbsF.Name = "rbsF";
            this.rbsF.Size = new System.Drawing.Size(60, 19);
            this.rbsF.TabIndex = 7;
            this.rbsF.TabStop = true;
            this.rbsF.Text = "Femea";
            this.rbsF.UseVisualStyleBackColor = true;
            // 
            // rbsM
            // 
            this.rbsM.AutoSize = true;
            this.rbsM.Location = new System.Drawing.Point(334, 40);
            this.rbsM.Name = "rbsM";
            this.rbsM.Size = new System.Drawing.Size(62, 19);
            this.rbsM.TabIndex = 8;
            this.rbsM.TabStop = true;
            this.rbsM.Text = "Macho";
            this.rbsM.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-Cachorro",
            "2-Gato",
            "3-Coelho"});
            this.comboBox1.Location = new System.Drawing.Point(249, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 23);
            this.comboBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sexo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(384, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pesquisa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(384, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Quatidade de Animais";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 327);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbsM);
            this.Controls.Add(this.rbsF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdono);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.TextBox txtdono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbsF;
        private System.Windows.Forms.RadioButton rbsM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


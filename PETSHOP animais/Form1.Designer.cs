
namespace pFinal
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
            this.textBoxnomeani = new System.Windows.Forms.TextBox();
            this.textBoxnomedon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioBFemea = new System.Windows.Forms.RadioButton();
            this.radioBmacho = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxpequisa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dGVPESQUISA = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbanimais = new System.Windows.Forms.Label();
            this.lbdog = new System.Windows.Forms.Label();
            this.lbcat = new System.Windows.Forms.Label();
            this.lbcoelho = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPESQUISA)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do animal :";
            // 
            // textBoxnomeani
            // 
            this.textBoxnomeani.Location = new System.Drawing.Point(25, 82);
            this.textBoxnomeani.Name = "textBoxnomeani";
            this.textBoxnomeani.Size = new System.Drawing.Size(204, 23);
            this.textBoxnomeani.TabIndex = 1;
            // 
            // textBoxnomedon
            // 
            this.textBoxnomedon.Location = new System.Drawing.Point(25, 133);
            this.textBoxnomedon.Name = "textBoxnomedon";
            this.textBoxnomedon.Size = new System.Drawing.Size(204, 23);
            this.textBoxnomedon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do dono :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1-Cachorro",
            "2-Gato",
            "3-Coelho"});
            this.comboBox1.Location = new System.Drawing.Point(25, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // radioBFemea
            // 
            this.radioBFemea.AutoSize = true;
            this.radioBFemea.Location = new System.Drawing.Point(25, 222);
            this.radioBFemea.Name = "radioBFemea";
            this.radioBFemea.Size = new System.Drawing.Size(60, 19);
            this.radioBFemea.TabIndex = 6;
            this.radioBFemea.TabStop = true;
            this.radioBFemea.Text = "Femea";
            this.radioBFemea.UseVisualStyleBackColor = true;
            // 
            // radioBmacho
            // 
            this.radioBmacho.AutoSize = true;
            this.radioBmacho.Location = new System.Drawing.Point(151, 222);
            this.radioBmacho.Name = "radioBmacho";
            this.radioBmacho.Size = new System.Drawing.Size(62, 19);
            this.radioBmacho.TabIndex = 7;
            this.radioBmacho.TabStop = true;
            this.radioBmacho.Text = "Macho";
            this.radioBmacho.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cadastra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxpequisa
            // 
            this.textBoxpequisa.Location = new System.Drawing.Point(307, 76);
            this.textBoxpequisa.Name = "textBoxpequisa";
            this.textBoxpequisa.Size = new System.Drawing.Size(241, 23);
            this.textBoxpequisa.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pesquisa pelo nome do animal ou dono :";
            // 
            // dGVPESQUISA
            // 
            this.dGVPESQUISA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPESQUISA.Location = new System.Drawing.Point(307, 105);
            this.dGVPESQUISA.Name = "dGVPESQUISA";
            this.dGVPESQUISA.RowTemplate.Height = 25;
            this.dGVPESQUISA.Size = new System.Drawing.Size(489, 262);
            this.dGVPESQUISA.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cadastro dos Animais";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(307, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Pesquisa por nome ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(286, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade de Animais Cadastrados";
            // 
            // lbanimais
            // 
            this.lbanimais.AutoSize = true;
            this.lbanimais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbanimais.Location = new System.Drawing.Point(25, 436);
            this.lbanimais.Name = "lbanimais";
            this.lbanimais.Size = new System.Drawing.Size(66, 17);
            this.lbanimais.TabIndex = 18;
            this.lbanimais.Text = "Animais :";
            // 
            // lbdog
            // 
            this.lbdog.AutoSize = true;
            this.lbdog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbdog.Location = new System.Drawing.Point(234, 436);
            this.lbdog.Name = "lbdog";
            this.lbdog.Size = new System.Drawing.Size(77, 17);
            this.lbdog.TabIndex = 19;
            this.lbdog.Text = "Cachorros :";
            // 
            // lbcat
            // 
            this.lbcat.AutoSize = true;
            this.lbcat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcat.Location = new System.Drawing.Point(461, 436);
            this.lbcat.Name = "lbcat";
            this.lbcat.Size = new System.Drawing.Size(51, 17);
            this.lbcat.TabIndex = 20;
            this.lbcat.Text = "Gatos :";
            // 
            // lbcoelho
            // 
            this.lbcoelho.AutoSize = true;
            this.lbcoelho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcoelho.Location = new System.Drawing.Point(649, 436);
            this.lbcoelho.Name = "lbcoelho";
            this.lbcoelho.Size = new System.Drawing.Size(65, 17);
            this.lbcoelho.TabIndex = 21;
            this.lbcoelho.Text = "Coelhos :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(433, 34);
            this.button3.TabIndex = 22;
            this.button3.Text = "Quatidade de animais";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbcoelho);
            this.Controls.Add(this.lbcat);
            this.Controls.Add(this.lbdog);
            this.Controls.Add(this.lbanimais);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dGVPESQUISA);
            this.Controls.Add(this.textBoxpequisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioBmacho);
            this.Controls.Add(this.radioBFemea);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxnomedon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxnomeani);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVPESQUISA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnomeani;
        private System.Windows.Forms.TextBox textBoxnomedon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioBFemea;
        private System.Windows.Forms.RadioButton radioBmacho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxpequisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGVPESQUISA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbanimais;
        private System.Windows.Forms.Label lbdog;
        private System.Windows.Forms.Label lbcat;
        private System.Windows.Forms.Label lbcoelho;
        private System.Windows.Forms.Button button3;
    }
}


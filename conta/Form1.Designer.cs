
namespace conta
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
            this.lbsaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbvalsa = new System.Windows.Forms.Label();
            this.textBox2limite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblimite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbsaldo
            // 
            this.lbsaldo.AutoSize = true;
            this.lbsaldo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbsaldo.Location = new System.Drawing.Point(45, 41);
            this.lbsaldo.Name = "lbsaldo";
            this.lbsaldo.Size = new System.Drawing.Size(59, 21);
            this.lbsaldo.TabIndex = 0;
            this.lbsaldo.Text = "Saldo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor da movirmentação :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(55, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sacar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(245, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(192, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Depositar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbvalsa
            // 
            this.lbvalsa.AutoSize = true;
            this.lbvalsa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbvalsa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbvalsa.Location = new System.Drawing.Point(102, 41);
            this.lbvalsa.Name = "lbvalsa";
            this.lbvalsa.Size = new System.Drawing.Size(64, 21);
            this.lbvalsa.TabIndex = 5;
            this.lbvalsa.Text = "RS 0,00";
            
            // 
            // textBox2limite
            // 
            this.textBox2limite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2limite.Location = new System.Drawing.Point(158, 262);
            this.textBox2limite.Name = "textBox2limite";
            this.textBox2limite.Size = new System.Drawing.Size(100, 29);
            this.textBox2limite.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Limite :";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(279, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Novo Limite :";
            // 
            // lblimite
            // 
            this.lblimite.AutoSize = true;
            this.lblimite.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblimite.Location = new System.Drawing.Point(108, 225);
            this.lblimite.Name = "lblimite";
            this.lblimite.Size = new System.Drawing.Size(70, 21);
            this.lblimite.TabIndex = 10;
            this.lblimite.Text = "R$ 100,0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 434);
            this.Controls.Add(this.lblimite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2limite);
            this.Controls.Add(this.lbvalsa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbsaldo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbsaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbvalsa;
        private System.Windows.Forms.TextBox textBox2limite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblimite;
    }
}


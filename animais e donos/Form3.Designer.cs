
namespace WinFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbanimal = new System.Windows.Forms.Label();
            this.lbCachorro = new System.Windows.Forms.Label();
            this.lbcoelho = new System.Windows.Forms.Label();
            this.lbgato = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quatidade de animais :";
            // 
            // lbanimal
            // 
            this.lbanimal.AutoSize = true;
            this.lbanimal.Location = new System.Drawing.Point(68, 87);
            this.lbanimal.Name = "lbanimal";
            this.lbanimal.Size = new System.Drawing.Size(98, 15);
            this.lbanimal.TabIndex = 1;
            this.lbanimal.Text = "Total de animais :";
            // 
            // lbCachorro
            // 
            this.lbCachorro.AutoSize = true;
            this.lbCachorro.Location = new System.Drawing.Point(68, 122);
            this.lbCachorro.Name = "lbCachorro";
            this.lbCachorro.Size = new System.Drawing.Size(106, 15);
            this.lbCachorro.TabIndex = 2;
            this.lbCachorro.Text = "Total de Cachorro :";
            this.lbCachorro.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbcoelho
            // 
            this.lbcoelho.AutoSize = true;
            this.lbcoelho.Location = new System.Drawing.Point(68, 187);
            this.lbcoelho.Name = "lbcoelho";
            this.lbcoelho.Size = new System.Drawing.Size(95, 15);
            this.lbcoelho.TabIndex = 3;
            this.lbcoelho.Text = "Total de Coelho :";
            // 
            // lbgato
            // 
            this.lbgato.AutoSize = true;
            this.lbgato.Location = new System.Drawing.Point(68, 153);
            this.lbgato.Name = "lbgato";
            this.lbgato.Size = new System.Drawing.Size(87, 15);
            this.lbgato.TabIndex = 4;
            this.lbgato.Text = "Total de Gatos :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbgato);
            this.Controls.Add(this.lbcoelho);
            this.Controls.Add(this.lbCachorro);
            this.Controls.Add(this.lbanimal);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbanimal;
        private System.Windows.Forms.Label lbCachorro;
        private System.Windows.Forms.Label lbcoelho;
        private System.Windows.Forms.Label lbgato;
        private System.Windows.Forms.Button button1;
    }
}
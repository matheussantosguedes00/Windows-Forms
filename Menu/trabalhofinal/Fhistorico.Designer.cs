
namespace trabalhofinal
{
    partial class Fhistorico
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
            this.lbanimais = new System.Windows.Forms.Label();
            this.lbcachorro = new System.Windows.Forms.Label();
            this.lbgato = new System.Windows.Forms.Label();
            this.lbcoelho = new System.Windows.Forms.Label();
            this.dgvanimais = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvanimais)).BeginInit();
            this.SuspendLayout();
            // 
            // lbanimais
            // 
            this.lbanimais.AutoSize = true;
            this.lbanimais.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbanimais.Location = new System.Drawing.Point(8, 20);
            this.lbanimais.Name = "lbanimais";
            this.lbanimais.Size = new System.Drawing.Size(82, 25);
            this.lbanimais.TabIndex = 0;
            this.lbanimais.Text = "Animais";
            // 
            // lbcachorro
            // 
            this.lbcachorro.AutoSize = true;
            this.lbcachorro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcachorro.Location = new System.Drawing.Point(153, 20);
            this.lbcachorro.Name = "lbcachorro";
            this.lbcachorro.Size = new System.Drawing.Size(94, 25);
            this.lbcachorro.TabIndex = 1;
            this.lbcachorro.Text = "Cachorro";
            // 
            // lbgato
            // 
            this.lbgato.AutoSize = true;
            this.lbgato.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbgato.Location = new System.Drawing.Point(476, 20);
            this.lbgato.Name = "lbgato";
            this.lbgato.Size = new System.Drawing.Size(55, 25);
            this.lbgato.TabIndex = 2;
            this.lbgato.Text = "Gato";
            // 
            // lbcoelho
            // 
            this.lbcoelho.AutoSize = true;
            this.lbcoelho.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbcoelho.Location = new System.Drawing.Point(309, 20);
            this.lbcoelho.Name = "lbcoelho";
            this.lbcoelho.Size = new System.Drawing.Size(74, 25);
            this.lbcoelho.TabIndex = 3;
            this.lbcoelho.Text = "Coelho";
            this.lbcoelho.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvanimais
            // 
            this.dgvanimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvanimais.Location = new System.Drawing.Point(12, 70);
            this.dgvanimais.Name = "dgvanimais";
            this.dgvanimais.RowTemplate.Height = 25;
            this.dgvanimais.Size = new System.Drawing.Size(554, 210);
            this.dgvanimais.TabIndex = 4;
            // 
            // Fhistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 329);
            this.Controls.Add(this.dgvanimais);
            this.Controls.Add(this.lbcoelho);
            this.Controls.Add(this.lbgato);
            this.Controls.Add(this.lbcachorro);
            this.Controls.Add(this.lbanimais);
            this.Name = "Fhistorico";
            this.Text = "Historico";
            this.Load += new System.EventHandler(this.Fhistorico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvanimais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbanimais;
        private System.Windows.Forms.Label lbcachorro;
        private System.Windows.Forms.Label lbgato;
        private System.Windows.Forms.Label lbcoelho;
        private System.Windows.Forms.DataGridView dgvanimais;
    }
}
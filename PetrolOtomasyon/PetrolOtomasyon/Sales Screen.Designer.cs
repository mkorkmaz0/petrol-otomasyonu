namespace PetrolOtomasyon
{
    partial class Sales_Screen
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
            this.cmbYakitTuru = new System.Windows.Forms.ComboBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbYakitTuru
            // 
            this.cmbYakitTuru.FormattingEnabled = true;
            this.cmbYakitTuru.Location = new System.Drawing.Point(114, 36);
            this.cmbYakitTuru.Name = "cmbYakitTuru";
            this.cmbYakitTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbYakitTuru.TabIndex = 0;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(130, 104);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(17, 16);
            this.lblToplamTutar.TabIndex = 1;
            this.lblToplamTutar.Text = "\"\"";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(387, 53);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(75, 23);
            this.btnSat.TabIndex = 3;
            this.btnSat.Text = "SAT";
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // Sales_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.cmbYakitTuru);
            this.Name = "Sales_Screen";
            this.Text = "Sales_Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYakitTuru;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSat;
    }
}
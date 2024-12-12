namespace PetrolOtomasyon
{
    partial class Reporting_Screen
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
            this.dgvRaporlar = new System.Windows.Forms.DataGridView();
            this.cmbRaporTuru = new System.Windows.Forms.ComboBox();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.dtpBaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRaporlar
            // 
            this.dgvRaporlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaporlar.Location = new System.Drawing.Point(48, 163);
            this.dgvRaporlar.Name = "dgvRaporlar";
            this.dgvRaporlar.RowHeadersWidth = 51;
            this.dgvRaporlar.RowTemplate.Height = 24;
            this.dgvRaporlar.Size = new System.Drawing.Size(730, 243);
            this.dgvRaporlar.TabIndex = 0;
            // 
            // cmbRaporTuru
            // 
            this.cmbRaporTuru.FormattingEnabled = true;
            this.cmbRaporTuru.Location = new System.Drawing.Point(48, 48);
            this.cmbRaporTuru.Name = "cmbRaporTuru";
            this.cmbRaporTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbRaporTuru.TabIndex = 1;
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Location = new System.Drawing.Point(517, 49);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(75, 23);
            this.btnRaporAl.TabIndex = 2;
            this.btnRaporAl.Text = "RAPOR AL";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // dtpBaslangicTarihi
            // 
            this.dtpBaslangicTarihi.Location = new System.Drawing.Point(225, 47);
            this.dtpBaslangicTarihi.Name = "dtpBaslangicTarihi";
            this.dtpBaslangicTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBaslangicTarihi.TabIndex = 3;
            // 
            // dtpBitisTarihi
            // 
            this.dtpBitisTarihi.Location = new System.Drawing.Point(225, 93);
            this.dtpBitisTarihi.Name = "dtpBitisTarihi";
            this.dtpBitisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpBitisTarihi.TabIndex = 4;
            // 
            // Reporting_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpBitisTarihi);
            this.Controls.Add(this.dtpBaslangicTarihi);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.cmbRaporTuru);
            this.Controls.Add(this.dgvRaporlar);
            this.Name = "Reporting_Screen";
            this.Text = "Reporting_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaporlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRaporlar;
        private System.Windows.Forms.ComboBox cmbRaporTuru;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.DateTimePicker dtpBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBitisTarihi;
    }
}
namespace PetrolOtomasyon
{
    partial class Cash_Register_Screen
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
            this.dgvKasaIslemleri = new System.Windows.Forms.DataGridView();
            this.lblToplamGelir = new System.Windows.Forms.Label();
            this.btnGunuKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKasaIslemleri
            // 
            this.dgvKasaIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKasaIslemleri.Location = new System.Drawing.Point(379, 12);
            this.dgvKasaIslemleri.Name = "dgvKasaIslemleri";
            this.dgvKasaIslemleri.RowHeadersWidth = 51;
            this.dgvKasaIslemleri.RowTemplate.Height = 24;
            this.dgvKasaIslemleri.Size = new System.Drawing.Size(409, 426);
            this.dgvKasaIslemleri.TabIndex = 0;
            // 
            // lblToplamGelir
            // 
            this.lblToplamGelir.AutoSize = true;
            this.lblToplamGelir.Location = new System.Drawing.Point(74, 152);
            this.lblToplamGelir.Name = "lblToplamGelir";
            this.lblToplamGelir.Size = new System.Drawing.Size(17, 16);
            this.lblToplamGelir.TabIndex = 1;
            this.lblToplamGelir.Text = "\"\"";
            // 
            // btnGunuKapat
            // 
            this.btnGunuKapat.Location = new System.Drawing.Point(64, 58);
            this.btnGunuKapat.Name = "btnGunuKapat";
            this.btnGunuKapat.Size = new System.Drawing.Size(139, 23);
            this.btnGunuKapat.TabIndex = 2;
            this.btnGunuKapat.Text = "GÜNÜ KAPAT";
            this.btnGunuKapat.UseVisualStyleBackColor = true;
            this.btnGunuKapat.Click += new System.EventHandler(this.btnGunuKapat_Click);
            // 
            // Cash_Register_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGunuKapat);
            this.Controls.Add(this.lblToplamGelir);
            this.Controls.Add(this.dgvKasaIslemleri);
            this.Name = "Cash_Register_Screen";
            this.Text = "Cash_Register_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKasaIslemleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKasaIslemleri;
        private System.Windows.Forms.Label lblToplamGelir;
        private System.Windows.Forms.Button btnGunuKapat;
    }
}
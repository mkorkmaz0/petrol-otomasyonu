using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolOtomasyon
{
    public partial class Sales_Screen : Form
    {
        public Sales_Screen()
        {
            InitializeComponent();
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            string yakitTuru = cmbYakitTuru.SelectedItem.ToString();
            decimal miktar = Convert.ToDecimal(txtMiktar.Text);
            decimal fiyat = GetYakitFiyati(yakitTuru);
            decimal toplamTutar = miktar * fiyat;

            lblToplamTutar.Text = "Toplam Tutar: " + toplamTutar.ToString("C");

            string connString = "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Satislar (YakitTuru, Miktar, ToplamTutar) VALUES (@YakitTuru, @Miktar, @ToplamTutar)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@YakitTuru", yakitTuru);
                    cmd.Parameters.AddWithValue("@Miktar", miktar);
                    cmd.Parameters.AddWithValue("@ToplamTutar", toplamTutar);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Satış işlemi başarılı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
            private decimal GetYakitFiyati(string yakitTuru)
            {
                // Bu fonksiyon, her yakıt türü için fiyatı döndürür. Örnek olarak sabit fiyatlar kullanabilirsiniz.
                if (yakitTuru == "Benzin")
                    return 7.5m;
                else if (yakitTuru == "Motorin")
                    return 8.0m;
                else
                    return 6.0m;
            }
        }
    }
}

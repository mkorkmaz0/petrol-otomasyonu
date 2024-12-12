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
    public partial class Cash_Register_Screen : Form
    {
        public Cash_Register_Screen()
        {
            InitializeComponent();
        }

        private void btnGunuKapat_Click(object sender, EventArgs e)
        {
            string connString = "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT SUM(ToplamTutar) FROM Satislar WHERE Tarih = @Bugun";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Bugun", DateTime.Now.Date);

                    object result = cmd.ExecuteScalar();
                    decimal toplamGelir = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    lblToplamGelir.Text = "Bugün Toplam Gelir: " + toplamGelir.ToString("C");

                    MessageBox.Show("Gün sonu işlemi başarılı.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}

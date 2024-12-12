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
    public partial class Reporting_Screen : Form
    {
        public Reporting_Screen()
        {
            InitializeComponent();
        }

        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            string raporTuru = cmbRaporTuru.SelectedItem.ToString();
            DateTime baslangicTarihi = dtpBaslangicTarihi.Value;
            DateTime bitisTarihi = dtpBitisTarihi.Value;

            string connString = "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Satislar WHERE Tarih BETWEEN @BaslangicTarihi AND @BitisTarihi";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BaslangicTarihi", baslangicTarihi);
                    cmd.Parameters.AddWithValue("@BitisTarihi", bitisTarihi);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRaporlar.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}

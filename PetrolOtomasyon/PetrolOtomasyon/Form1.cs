using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace PetrolOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //sql connection proje yolu
        //SqlConnection connection=new SqlConnection("Data Source=Veritabanı_Yolu; Inital Catalog=Veritabanı_Adı;Itegrate Security=True");
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7EPCTQ4; Inital Catalog=PetrolOtomasyon;Itegrate Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifreyi text kutularından alıyoruz
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = "";

            // RadioButton'lara göre kullanıcı türünü belirliyoruz
            if (rbAdmin.Checked)
            {
                userType = "Admin";
            }
            else if (rbPompaci.Checked)
            {
                userType = "Pompa Operatörü";
            }
            else if (rbKasiyer.Checked)
            {
                userType = "Kasiyer";
            }

            try
            {
                // SQL bağlantısını aç
                connection.Open();

                // SQL sorgusu
                string query = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @username AND KullaniciSifre = @password AND KullaniciTuru = @userType";
                SqlCommand command = new SqlCommand(query, connection);

                // Parametre ekleme
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@userType", userType);

                // Sorgunun sonucunu kontrol et
                int result = Convert.ToInt32(command.ExecuteScalar());

                if (result > 0)
                {
                    MessageBox.Show($"Hoş geldiniz, {username}! {userType} paneline yönlendiriliyorsunuz.", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kullanıcı türüne göre farklı panellere yönlendirme
                    if (userType == "Admin")
                    {
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                    }
                    else if (userType == "Pompa Operatörü")
                    {
                        OperatorPanel operatorPanel = new OperatorPanel();
                        operatorPanel.Show();
                    }
                    else if (userType == "Kasiyer")
                    {
                        CashierPanel cashierPanel = new CashierPanel();
                        cashierPanel.Show();
                    }

                    // Ana formu gizle
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı, şifre veya kullanıcı türü hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Bağlantıyı kapat
                connection.Close();
            }
        }

    }
}
    
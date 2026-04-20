using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; // SQL işlemleri için gerekli kütüphane

namespace HastaneProjeİlk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bu kısım yanlışlıkla tıklanmış olabilir, boş kalmasında sakınca yok
        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
        }

        // Giriş butonuna basılınca ne olacak?
        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. BAĞLANTI ADRESİ (Telefon Numarası gibi)
            // Data Source=.; (Nokta, yerel sunucu demek)
            // Initial Catalog=SOHATS; (Hangi veritabanına bağlanacağız?)
            // Integrated Security=True; (Şifresiz, Windows girişi ile bağlan)
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SOHATS;Integrated Security=True");

            // Hataları yakalamak için try-catch bloğu kullanıyoruz
            try
            {
                
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open(); // Hattı açıyoruz

                // 2. SORGUYU HAZIRLA
                // Kullanıcı tablosuna git, kutulara yazdığım kod ve şifreyle eşleşen var mı bak.
                string sorgu = "SELECT * FROM Kullanici WHERE KullaniciKodu=@kodu AND Sifre=@sifresi";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                // Kutulardaki verileri güvenli şekilde sorguya ekle (SQL Injection önlemi)
                komut.Parameters.AddWithValue("@kodu", txtAd.Text);
                komut.Parameters.AddWithValue("@sifresi", txtParola.Text);

                // 3. SONUCU KONTROL ET
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read()) // Eğer okuyacak bir kayıt bulduysa (Yani kullanıcı varsa)
                {
                    // 1. Başarılı mesajı ver
                    MessageBox.Show("Giriş Başarılı! Sisteme Yönlendiriliyorsunuz...");

                    // 2. Ana Menüyü (FrmAnaMenu) oluştur ve göster
                    FrmAnaMenu fr = new FrmAnaMenu();
                    fr.Show();

                    // 3. Giriş ekranını gizle (Arka planda dursun ama görünmesin)
                    this.Hide();
                    MessageBox.Show("Giriş Başarılı! Hoşgeldiniz.");
                    // Buraya daha sonra Ana Menü açılma kodunu ekleyeceğiz.
                }
                else
                {
                    // Dökümanda istenen uyarı mesajı
                    MessageBox.Show("Yanlış kullanıcı adı ve/veya şifre");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu: " + hata.Message);
            }
            finally
            {
                // İşimiz bitince hattı kapatıyoruz
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtParola.Text = "";
            txtAd.Focus(); // İmleci tekrar en başa getirir
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

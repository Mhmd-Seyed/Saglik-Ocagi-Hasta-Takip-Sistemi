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
using System.Data.SqlClient;


namespace HastaneProjeİlk
{
    public partial class FrmPoliklinikler : Form
    {
        public FrmPoliklinikler()
        {
            InitializeComponent();
        }
        // Bağlantı Adresi (Giriş formundakiyle aynı)
        SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SOHATS;Integrated Security=True");
        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // ... (MessageBox satırının altı)
            PoliklinikListele(); // Yeni kayıt yapınca listeyi tazele
            try
            {
                baglanti.Open();

                // Veritabanına Ekleme Komutu
                SqlCommand komut = new SqlCommand("INSERT INTO Poliklinikler (PoliklinikAdi, UzmanlikAlani, Durum) VALUES (@p1, @p2, @p3)", baglanti);

                komut.Parameters.AddWithValue("@p1", txtPoliklinikAd.Text);
                komut.Parameters.AddWithValue("@p2", txtAciklama.Text);

                // Eğer kutu işaretliyse True (1), değilse False (0) kaydeder
                komut.Parameters.AddWithValue("@p3", chkDurum.Checked);

                komut.ExecuteNonQuery(); // Komutu çalıştır

                baglanti.Close();

                MessageBox.Show("Poliklinik Başarıyla Kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu: " + hata.Message);
            }
            
        }
        // Bu metot veritabanındaki listeyi çeker ve tabloya doldurur
        void PoliklinikListele()
        {
            // 1. Tabloyu temizle (Eski veriler üst üste binmesin)
            DataTable dt = new DataTable();

            // 2. Verileri çek
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Poliklinikler", baglanti);

            // 3. Verileri sanal tabloya (dt) doldur
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();

            // 4. Tabloyu ekrandaki Grid'e bağla
            dataGridView1.DataSource = dt;
        }
        private void FrmPoliklinikler_Load(object sender, EventArgs e)
        {
            PoliklinikListele(); // Form açılınca listeyi getir
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Seçilen satırın numarasını al
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            // Tablodaki bilgileri yukarıdaki kutulara doldur
            txtPoliklinikAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAciklama.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            // Checkbox durumunu aktar
            chkDurum.Checked = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[3].Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Seçilen satırı ID numarasına göre sil
                SqlCommand komut = new SqlCommand("DELETE FROM Poliklinikler WHERE PoliklinikID=@p1", baglanti);

                // Tablodan seçilen satırın ID'sini (0. hücre) alıp komuta veriyoruz
                komut.Parameters.AddWithValue("@p1", dataGridView1.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Poliklinik Başarıyla Silindi!");

                // Listeyi yenile ki silindiğini görelim
                PoliklinikListele();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // SQL Güncelleme Komutu
                // "Bu ID'ye sahip satırı bul, bilgilerini yenileriyle değiştir" diyoruz.
                SqlCommand komut = new SqlCommand("UPDATE Poliklinikler SET PoliklinikAdi=@p1, UzmanlikAlani=@p2, Durum=@p3 WHERE PoliklinikID=@p4", baglanti);

                // Yeni bilgileri kutulardan al
                komut.Parameters.AddWithValue("@p1", txtPoliklinikAd.Text);
                komut.Parameters.AddWithValue("@p2", txtAciklama.Text);
                komut.Parameters.AddWithValue("@p3", chkDurum.Checked);

                // Hangi satırı değiştireceğini ID'den anlar (Gizli Kahraman)
                komut.Parameters.AddWithValue("@p4", dataGridView1.CurrentRow.Cells[0].Value);

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Poliklinik Bilgileri Başarıyla Güncellendi!");

                // Listeyi yenile ki değişikliği görelim
                PoliklinikListele();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: " + hata.Message);
            }
        }
    }
    }

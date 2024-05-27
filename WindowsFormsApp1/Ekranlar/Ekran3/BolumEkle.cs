using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }

        private void EkleButon_Click(object sender, EventArgs e)
        {
            string bolumAdi = BolumAdiRichText.Text.Trim();
            string bolumID = BIDrichtext.Text.Trim();
            string fakulteID = FIDrichtext.Text.Trim();

            // Bölüm adı, bölüm ID ve fakülte ID boş mu kontrol et
            if (string.IsNullOrWhiteSpace(bolumAdi))
            {
                MessageBox.Show("Bölüm adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Bölüm ID boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(fakulteID))
            {
                MessageBox.Show("Fakülte ID boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();
                // Bölüm eklemek için sorgu
                string query = "INSERT INTO tBolum (bolumID, bolumAd, fakulteID) VALUES (@bolumID, @bolumAd, @fakulteID)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@bolumID", bolumID);
                    cmd.Parameters.AddWithValue("@bolumAd", bolumAdi);
                    cmd.Parameters.AddWithValue("@fakulteID", fakulteID);
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bölüm başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BolumAdiRichText.Clear(); // TextBox'ı temizle
                            FIDrichtext.Clear(); // TextBox'ı temizle
                            BIDrichtext.Clear(); // TextBox'ı temizle
                        }
                        else
                        {
                            MessageBox.Show("Bölüm eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        // SQL Server'dan gelen hatayı daha net görmek için hatayı göster
                        MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

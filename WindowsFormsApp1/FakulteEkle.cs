using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FakulteEkle : Form
    {
        public FakulteEkle()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            string fakulteAdi = FakulteAdı.Text.Trim();
            string fakulteID = FakulteIDRichText.Text.Trim();

            // Fakülte adı boş mu kontrol et
            if (string.IsNullOrWhiteSpace(fakulteAdi))
            {
                MessageBox.Show("Fakülte adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(fakulteID) || string.IsNullOrWhiteSpace(fakulteAdi))
            {
                MessageBox.Show("Fakülte ID ve adı boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS; Initial Catalog=foy5; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;"))
            {
                con.Open();
                // Fakülte eklemek için sorgu
                string query = "INSERT INTO tFakulte (fakulteID, fakulteAd) VALUES (@fakulteID, @fakulteAd)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fakulteID", fakulteID);
                    cmd.Parameters.AddWithValue("@fakulteAd", fakulteAdi);
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Fakülte başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FakulteAdı.Clear(); // TextBox'ı temizle
                        }
                        else
                        {
                            MessageBox.Show("Fakülte eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FakulteAdi_Click(object sender, EventArgs e)
        {
            // İlgili olay işlemi burada gerçekleştirilebilir
        }
    }
}

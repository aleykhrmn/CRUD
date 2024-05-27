using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OgrenciSil : Form
    {
        public OgrenciSil()
        {
            InitializeComponent();
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            string ogrenciID = OgrenciIDrichText.Text.Trim(); // Silinecek öğrencinin ID'sini al

            if (string.IsNullOrWhiteSpace(ogrenciID))
            {
                MessageBox.Show("Öğrenci ID'si girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ogrenciID, out int parsedOgrenciID))
            {
                MessageBox.Show("Öğrenci ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Silinecek öğrenciyi belirten sorgu
                string query = "DELETE FROM tOgrenci WHERE ogrenciID = @ogrenciID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Silme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Öğrenci başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OgrenciIDrichText.Clear(); // TextBox'ı temizle
                        }
                        else
                        {
                            MessageBox.Show("Silinecek öğrenci bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

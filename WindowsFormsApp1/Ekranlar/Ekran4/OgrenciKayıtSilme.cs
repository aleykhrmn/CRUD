using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OgrenciKayıtSilme : Form
    {
        public OgrenciKayıtSilme()
        {
            InitializeComponent();
        }

        private void OnaylaButon_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan giriş verileri
            string ogrenciID = OgrenciIDTextBox.Text.Trim();
            string dersID = DersIDTextBox.Text.Trim();
            string yil = YilTextBox.Text.Trim();
            string yariyil = YariyilTextBox.Text.Trim();

            // Girişlerin doğrulanması
            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(dersID) ||
                string.IsNullOrWhiteSpace(yil) || string.IsNullOrWhiteSpace(yariyil))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ogrenciID, out int parsedOgrenciID) ||
                !int.TryParse(dersID, out int parsedDersID))
            {
                MessageBox.Show("Öğrenci ID ve Ders ID geçerli sayılar olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Silinecek öğrenci-ders ilişkisini kontrol ve silme
                string checkAndDeleteQuery = @"
                    DELETE FROM tOgrenciDers 
                    WHERE ogrenciID = @ogrenciID 
                      AND dersID = @dersID 
                      AND yil = @yil 
                      AND yariyil = @yariyil";
                using (SqlCommand cmd = new SqlCommand(checkAndDeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    cmd.Parameters.AddWithValue("@dersID", parsedDersID);
                    cmd.Parameters.AddWithValue("@yil", yil); // varchar olarak değiştirildi
                    cmd.Parameters.AddWithValue("@yariyil", yariyil); // varchar olarak değiştirildi

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Silme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OgrenciIDTextBox.Clear();
                            DersIDTextBox.Clear();
                            YilTextBox.Clear();
                            YariyilTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Silinecek kayıt bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DersEkleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

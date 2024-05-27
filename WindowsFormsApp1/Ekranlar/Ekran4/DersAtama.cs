using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DersAtama : Form
    {
        public DersAtama()
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

                // Öğrencinin varlığını kontrol et
                string checkOgrenciQuery = "SELECT COUNT(*) FROM tOgrenci WHERE ogrenciID = @ogrenciID";
                using (SqlCommand checkOgrenciCmd = new SqlCommand(checkOgrenciQuery, con))
                {
                    checkOgrenciCmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    int ogrenciCount = (int)checkOgrenciCmd.ExecuteScalar();

                    if (ogrenciCount == 0)
                    {
                        MessageBox.Show("Öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Dersin varlığını kontrol et
                string checkDersQuery = "SELECT COUNT(*) FROM tDers WHERE dersID = @dersID";
                using (SqlCommand checkDersCmd = new SqlCommand(checkDersQuery, con))
                {
                    checkDersCmd.Parameters.AddWithValue("@dersID", parsedDersID);
                    int dersCount = (int)checkDersCmd.ExecuteScalar();

                    if (dersCount == 0)
                    {
                        MessageBox.Show("Ders bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Öğrenci-Ders atama işlemi
                string insertQuery = "INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil) VALUES (@ogrenciID, @dersID, @yil, @yariyil)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    cmd.Parameters.AddWithValue("@dersID", parsedDersID);
                    cmd.Parameters.AddWithValue("@yil", yil);
                    cmd.Parameters.AddWithValue("@yariyil", yariyil);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla atandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OgrenciIDTextBox.Clear();
                            DersIDTextBox.Clear();
                            YilTextBox.Clear();
                            YariyilTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ders atanırken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

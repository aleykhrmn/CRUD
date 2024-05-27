using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DersDegistirme : Form
    {
        public DersDegistirme()
        {
            InitializeComponent();
        }

        private void OnaylaButon_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan verileri al
            string ogrenciID = OgrenciIDTextBox.Text.Trim();
            string yil = yilTextBox.Text.Trim(); // Combobox'tan seçilen değeri al
            string yariyil = yariyilTextBox.Text.Trim(); // Combobox'tan seçilen değeri al
            string eskiDersID = SDersIDTextBox.Text.Trim(); // Kullanıcıdan alınan eski ders ID'si
            string yeniDersID = EDersIDTextBox.Text.Trim(); // Kullanıcıdan alınan yeni ders ID'si

            // Verilerin doğruluğunu kontrol et
            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(yil) ||
                string.IsNullOrWhiteSpace(yariyil) || string.IsNullOrWhiteSpace(eskiDersID) ||
                string.IsNullOrWhiteSpace(yeniDersID))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Öğrencinin aldığı dersi kontrol et ve varsa sil
                string deleteQuery = "DELETE FROM tOgrenciDers WHERE ogrenciID = @ogrenciID AND dersID = @eskiDersID AND yil = @yil AND yariyil = @yariyil";
                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                {
                    deleteCmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    deleteCmd.Parameters.AddWithValue("@eskiDersID", eskiDersID);
                    deleteCmd.Parameters.AddWithValue("@yil", yil);
                    deleteCmd.Parameters.AddWithValue("@yariyil", yariyil);

                    try
                    {
                        int rowsAffected = deleteCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            
                            OgrenciIDTextBox.Clear();
                            // Combobox'ları sıfırla
                        }
                        else
                        {
                            MessageBox.Show("Öğrencinin aldığı ders bulunamadı veya silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Yeni dersi öğrenciye ata
                string insertQuery = "INSERT INTO tOgrenciDers (ogrenciID, dersID, yil, yariyil) VALUES (@ogrenciID, @yeniDersID, @yil, @yariyil)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    insertCmd.Parameters.AddWithValue("@yeniDersID", yeniDersID);
                    insertCmd.Parameters.AddWithValue("@yil", yil);
                    insertCmd.Parameters.AddWithValue("@yariyil", yariyil);

                    try
                    {
                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                           
                        }
                        else
                        {
                            MessageBox.Show("Öğrencinin yeni dersiyle ilişkilendirilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DersDegistirme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'föy5DataSet.tOgrenciDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tOgrenciDersTableAdapter.Fill(this.föy5DataSet.tOgrenciDers);

        }
    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            // Giriş verilerini al ve doğrula
            string ogrenciID = OgrenciNorichText.Text.Trim();
            string ad = OgrenciAdiRichText.Text.Trim();
            string soyad = OgrenciSoyadıRichtext.Text.Trim();
            string bolumID = Bıdrichtext.Text.Trim(); // Bölüm ID'sini ekliyoruz

            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(ogrenciID, out int parsedOgrenciID))
            {
                MessageBox.Show("Öğrenci ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(bolumID, out int parsedBolumID))
            {
                MessageBox.Show("Bölüm ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Öğrencinin var olup olmadığını kontrol et
                string checkStudentQuery = "SELECT COUNT(*) FROM tOgrenci WHERE ogrenciID = @ogrenciID";
                using (SqlCommand checkStudentCmd = new SqlCommand(checkStudentQuery, con))
                {
                    checkStudentCmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    int studentCount = (int)checkStudentCmd.ExecuteScalar();
                    if (studentCount > 0)
                    {
                        MessageBox.Show("Bu öğrenci zaten var.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Bölüm ID'nin geçerli olup olmadığını kontrol et
                string checkDepartmentQuery = "SELECT COUNT(*) FROM tBolum WHERE bolumID = @bolumID";
                using (SqlCommand checkDepartmentCmd = new SqlCommand(checkDepartmentQuery, con))
                {
                    checkDepartmentCmd.Parameters.AddWithValue("@bolumID", parsedBolumID);
                    int departmentCount = (int)checkDepartmentCmd.ExecuteScalar();
                    if (departmentCount == 0)
                    {
                        MessageBox.Show("Geçersiz bölüm ID.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Öğrenciyi ekleme işlemi
                string insertQuery = "INSERT INTO tOgrenci (ogrenciID, ad, soyad, bolumID) VALUES (@ogrenciID, @ad, @soyad, @bolumID)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Öğrenci başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OgrenciNorichText.Clear();
                            OgrenciAdiRichText.Clear();
                            OgrenciSoyadıRichtext.Clear();
                            Bıdrichtext.Clear(); // Bölüm ID'sini de temizle
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void OgrenciEkleLAbel_Click(object sender, EventArgs e)
        {
            // İlgili olay işlemi burada gerçekleştirilebilir
        }
    }
}

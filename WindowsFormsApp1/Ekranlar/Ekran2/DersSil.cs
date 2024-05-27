using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DersSil : Form
    {
        public DersSil()
        {
            InitializeComponent();
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            string dersID = DersIDRichText.Text.Trim(); // Silinecek dersin ID'sini al

            if (string.IsNullOrWhiteSpace(dersID))
            {
                MessageBox.Show("Ders ID'si girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dersID, out int parsedDersID))
            {
                MessageBox.Show("Ders ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // İlk olarak dersi kontrol edelim
                string checkQuery = "SELECT COUNT(*) FROM tDers WHERE dersID = @dersID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@dersID", parsedDersID);

                    try
                    {
                        int dersCount = (int)checkCmd.ExecuteScalar();
                        Console.WriteLine("Check Query Executed: dersID=" + parsedDersID + ", Result=" + dersCount);

                        if (dersCount == 0)
                        {
                            MessageBox.Show("Silinecek ders bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Silinecek dersi belirten sorgu
                string query = "DELETE FROM tDers WHERE dersID = @dersID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@dersID", parsedDersID);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Silme işlemini gerçekleştir
                        Console.WriteLine("Delete Query Executed: dersID=" + parsedDersID + ", RowsAffected=" + rowsAffected);

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DersIDRichText.Clear(); // TextBox'ı temizle
                        }
                        else
                        {
                            MessageBox.Show("Silinecek ders bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

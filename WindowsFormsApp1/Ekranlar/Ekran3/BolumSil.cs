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

namespace WindowsFormsApp1
{
    public partial class BolumSil : Form
    {
        public BolumSil()
        {
            InitializeComponent();
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            // TextBox'tan bolumID'yi al
            string bolumID = BolumIDTextBox.Text.Trim();

            // Boş değer kontrolü
            if (string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Lütfen bölüm ID'sini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bölüm ID'nin doğruluğunu kontrol etme
            if (!int.TryParse(bolumID, out int parsedBolumID))
            {
                MessageBox.Show("Bölüm ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    // SQL sorgusu
                    string query = @"DELETE FROM tbolum WHERE bolumID = @bolumID";

                    // SqlCommand oluştur ve parametreleri ekle
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);

                        // Sorguyu çalıştır ve etkilenen satır sayısını al
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Etkilenen satır varsa, başarılı bir şekilde silindiğini göster
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bölüm başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Bölüm bulunamadı veya silme işlemi gerçekleştirilemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

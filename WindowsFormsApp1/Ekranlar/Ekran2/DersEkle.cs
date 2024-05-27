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
    public partial class DersEkle : Form
    {
        public DersEkle()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            string dersID = DersIDTextBox.Text.Trim();
            string dersAd = DersAdTextBox.Text.Trim();

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Belirtilen ders ID'sine sahip ders var mı kontrol et
                string checkQuery = "SELECT COUNT(*) FROM tDers WHERE dersID = @dersID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@dersID", dersID);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Bu ders ID'si zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Ders eklemek için sorgu
                string insertQuery = "INSERT INTO tDers (dersID, dersAd) VALUES (@dersID, @dersAd)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@dersID", dersID);
                    cmd.Parameters.AddWithValue("@dersAd", dersAd);
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery(); // Ekleme işlemini gerçekleştir
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ders başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DersIDTextBox.Clear(); // TextBox'ları temizle
                            DersAdTextBox.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ders eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

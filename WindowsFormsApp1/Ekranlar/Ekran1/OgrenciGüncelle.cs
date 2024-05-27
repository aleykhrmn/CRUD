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
    public partial class OgrenciGüncelle : Form
    {
        public OgrenciGüncelle()
        {
            InitializeComponent();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki değerleri al
            string ogrenciID = OgrenciIDTextBox.Text.Trim();
            string ad = AdTextBox.Text.Trim();
            string soyad = SoyadTextBox.Text.Trim();
            string bolumID = BolumIDTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(ogrenciID) || string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                try
                {
                    con.Open();

                    string query = @"UPDATE tOgrenci 
                                     SET ad = @ad, soyad = @soyad, bolumID = @bolumID 
                                     WHERE ogrenciID = @ogrenciID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ogrenciID", parsedOgrenciID);
                        cmd.Parameters.AddWithValue("@ad", ad);
                        cmd.Parameters.AddWithValue("@soyad", soyad);
                        cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Öğrenci bulunamadı veya güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            OgrenciListele ogrenciListeleForm = new OgrenciListele();
            ogrenciListeleForm.Show();

        }
    }
}

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
    public partial class DersGuncelleme : Form
    {
        public DersGuncelleme()
        {
            InitializeComponent();
        }

        private void Güncelleme_Click(object sender, EventArgs e)
        {

            // TextBox'lardaki değerleri al
            string dersID = DersIDTextBox.Text.Trim();
            string dersAdi = DersAdiTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(dersID) || string.IsNullOrWhiteSpace(dersAdi))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                try
                {
                    con.Open();

                    string query = @"UPDATE tDers 
                                     SET dersAd = @dersAd
                                     WHERE dersID = @dersID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@dersID", parsedDersID);
                        cmd.Parameters.AddWithValue("@dersAd", dersAdi);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Ders bulunamadı veya güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // DersListele formunu aç
            DersListele dersListeleForm = new DersListele();
            dersListeleForm.Show();

        }

        private void DersGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}

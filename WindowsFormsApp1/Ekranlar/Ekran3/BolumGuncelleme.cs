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
    public partial class BolumGuncelleme : Form
    {
        public BolumGuncelleme()
        {
            InitializeComponent();
        }

        private void GüncelleButon_Click(object sender, EventArgs e)
        {
            // TextBox'lardaki değerleri al
            string fakulteID = FakulteIDTextBox.Text.Trim();
            string bolumAd = BolumAdiTextBox.Text.Trim();
            string bolumID = BolumIDTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(fakulteID) || string.IsNullOrWhiteSpace(bolumAd) || string.IsNullOrWhiteSpace(bolumID))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(bolumID, out int parsedBolumID) || !int.TryParse(fakulteID, out int parsedFakulteID))
            {
                MessageBox.Show("Bölüm ID ve Fakülte ID geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    string query = @"UPDATE tbolum 
                                     SET bolumAd = @bolumAd, fakulteID = @fakulteID
                                     WHERE bolumID = @bolumID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bolumID", parsedBolumID);
                        cmd.Parameters.AddWithValue("@bolumAd", bolumAd);
                        cmd.Parameters.AddWithValue("@fakulteID", parsedFakulteID);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            
                        }
                        else
                        {
                            MessageBox.Show("Bölüm bulunamadı veya güncelleme yapılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            BolumListele bolumListeleForm = new BolumListele();
            bolumListeleForm.Show();
        }
    }
}

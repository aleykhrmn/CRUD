using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ekran6 : Form
    {
        public Ekran6()
        {
            InitializeComponent();
            LoadDersID();
        }

        private void LoadDersID()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT dersID FROM tDers ORDER BY dersID";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DersIDComboBox.DataSource = dt;
                    DersIDComboBox.DisplayMember = "dersID";
                    DersIDComboBox.ValueMember = "dersID";
                    DersIDComboBox.SelectedIndex = -1; // İlk başta boş olmasını sağlar
                }
            }
        }


        
        private void ListeleButon_Click(object sender, EventArgs e)
        {
            if (DersIDComboBox.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir ders seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı tarafından seçilen ders ID'sini al
            string selectedDersID = DersIDComboBox.SelectedValue.ToString();

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Seçilen ders ID'sine göre sorgu
                string query = "SELECT ogrenciID, dersID, vize, final FROM tOgrenciDers WHERE dersID = @selectedDersID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@selectedDersID", selectedDersID);

                    // Sorgudan dönen sonuçları al
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        // DataGridView'e veri yüklerken sütunlar otomatik olarak oluşturulsun
                        dataGridView1.AutoGenerateColumns = true;

                        // Sonuçları DataGridView'e yükle
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }


        private void Ekran6_Load(object sender, EventArgs e)
        {
            // Boş bir DataTable oluştur
            DataTable emptyTable = new DataTable();

            // DataGridView'e veri yüklerken sütunlar otomatik olarak oluşturulsun
            dataGridView1.AutoGenerateColumns = true;

            // DataGridView'in veri kaynağını boş DataTable olarak ayarla
            dataGridView1.DataSource = emptyTable;

            // TODO: Bu kod satırı 'föy5DataSet.tOgrenciDers' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tOgrenciDersTableAdapter.Fill(this.föy5DataSet.tOgrenciDers);
        }

        private void KaydetButon_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;

                    string ogrenciID = row.Cells["ogrenciID"].Value.ToString();
                    string dersID = row.Cells["dersID"].Value.ToString();
                    object vizeValue = row.Cells["vize"].Value ?? DBNull.Value;
                    object finalValue = row.Cells["final"].Value ?? DBNull.Value;

                    // Notları güncelleme sorgusu
                    string query = "UPDATE tOgrenciDers SET vize = @vize, final = @final WHERE ogrenciID = @ogrenciID AND dersID = @dersID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                        cmd.Parameters.AddWithValue("@dersID", dersID);
                        cmd.Parameters.AddWithValue("@vize", vizeValue);
                        cmd.Parameters.AddWithValue("@final", finalValue);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Notlar başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

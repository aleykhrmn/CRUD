using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class YBListe : Form
    {
        public YBListe()
        {
            InitializeComponent();
        }

        private void YBListe_Load(object sender, EventArgs e)
        {
            // Combobox'ları doldur
            LoadYears();
            LoadSemesters();
        }

        private void LoadYears()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT DISTINCT yil FROM tOgrenciDers ORDER BY yil";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    YearComboBox.DataSource = dt;
                    YearComboBox.DisplayMember = "yil";
                    YearComboBox.ValueMember = "yil";
                    YearComboBox.SelectedIndex = -1;
                }
            }
        }

        private void LoadSemesters()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();
                string query = "SELECT DISTINCT yariyil FROM tOgrenciDers ORDER BY yariyil";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    SemesterComboBox.DataSource = dt;
                    SemesterComboBox.DisplayMember = "yariyil";
                    SemesterComboBox.ValueMember = "yariyil";
                    SemesterComboBox.SelectedIndex = -1;
                }
            }
        }

        private void ListeleButon_Click(object sender, EventArgs e)
        {
            // Kullanıcı tarafından seçilen yıl ve yarıyıl bilgisini al
            if (YearComboBox.SelectedItem == null || SemesterComboBox.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yıl ve yarıyıl seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedYear = YearComboBox.SelectedValue.ToString();
            string selectedSemester = SemesterComboBox.SelectedValue.ToString();

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Yıl ve yarıyıla göre derslerin ve kaç öğrenci tarafından seçildiğinin sorgusu
                string query = "SELECT d.dersAd, COUNT(*) AS OgrenciSayisi " +
                               "FROM tOgrenciDers od " +
                               "INNER JOIN tDers d ON od.dersID = d.dersID " +
                               "WHERE od.yil = @selectedYear AND od.yariyil = @selectedSemester " +
                               "GROUP BY d.dersAd";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@selectedYear", selectedYear);
                    cmd.Parameters.AddWithValue("@selectedSemester", selectedSemester);

                    // Sorgudan dönen sonuçları al
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        // Sonuçları DataGridView'e yükle
                        dataGridView1.DataSource = table;
                    }
                }
            }
        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

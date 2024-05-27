using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ODersListesi : Form
    {
        public ODersListesi()
        {
            InitializeComponent();
        }

        private void OBLİSTE_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'föy5DataSet.tOgrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tOgrenciTableAdapter.Fill(this.föy5DataSet.tOgrenci);
            // Form yüklendiğinde DataGridView'i temizle
            dataGridView1.DataSource = null;
        }

        private void Lıstele_Click(object sender, EventArgs e)
        {
            string ogrenciID = OgrenciIDTextBox.Text.Trim();

            // Veritabanı bağlantısı
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-VMO3C7M\\SQLEXPRESS;Initial Catalog=föy5;Integrated Security=True"))
            {
                con.Open();

                // Öğrencinin aldığı derslerin veritabanından seçilmesi ve ders adlarının getirilmesi
                string query = "SELECT d.dersID, d.dersAd, od.yil, od.yariyil, od.vize, od.final FROM tOgrenciDers od INNER JOIN tDers d ON od.dersID = d.dersID WHERE od.ogrenciID = @ogrenciID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ogrenciID", ogrenciID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    // DataGridView'e verilerin yüklenmesi
                    dataGridView1.DataSource = table;
                }
            }
        }
    }
}

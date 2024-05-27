using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OgrenciListele : Form
    {
        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void OgrenciListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'föy5DataSet.tOgrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tOgrenciTableAdapter.Fill(this.föy5DataSet.tOgrenci);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

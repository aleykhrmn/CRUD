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
    public partial class BolumListele : Form
    {
        public BolumListele()
        {
            InitializeComponent();
        }

        private void BolumListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'föy5DataSet.tBolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBolumTableAdapter1.Fill(this.föy5DataSet.tBolum);
            // TODO: Bu kod satırı 'foy5DataSet2.tBolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBolumTableAdapter.Fill(this.foy5DataSet2.tBolum);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

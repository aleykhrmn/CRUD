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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkleForm = new OgrenciEkle();
            ogrenciEkleForm.Show();
        }

        private void OsilButon_Click(object sender, EventArgs e)
        {
            OgrenciSil ogrenciSilForm = new OgrenciSil();
            ogrenciSilForm.Show();
        }

        private void OlisteleButon_Click(object sender, EventArgs e)
        {
            OgrenciListele ogrenciListeleForm = new OgrenciListele();
            ogrenciListeleForm.Show();
        }

        private void Oguncellestirmebuton_Click(object sender, EventArgs e)
        {
            OgrenciGüncelle ogrenciGüncelleForm = new OgrenciGüncelle();
            ogrenciGüncelleForm.Show();
        }

        private void OgrenciYazı_Click(object sender, EventArgs e)
        {

        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {

        }
    }
}

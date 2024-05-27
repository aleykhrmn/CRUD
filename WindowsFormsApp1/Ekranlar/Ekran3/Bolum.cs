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
    public partial class Bolum : Form
    {
        public Bolum()
        {
            InitializeComponent();
        }

        private void BekleButon_Click(object sender, EventArgs e)
        {
            BolumEkle bolumEkleForm = new BolumEkle();
            bolumEkleForm.Show();
        }

        private void BsilButon_Click(object sender, EventArgs e)
        {
            BolumSil bolumSilForm = new BolumSil();
            bolumSilForm.Show();
        }

        private void Bguncellestirmebuton_Click(object sender, EventArgs e)
        {
            BolumGuncelleme bGForm = new BolumGuncelleme();
            bGForm.Show();
        }

        private void BlisteleButon_Click(object sender, EventArgs e)
        {
            BolumListele bolumListeleForm = new BolumListele();
            bolumListeleForm.Show();
        }

        private void Bolum_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Ders : Form
    {
        public Ders()
        {
            InitializeComponent();
        }

        private void Dguncellestirmebuton_Click(object sender, EventArgs e)
        {
            DersGuncelleme dersGuncellemeForm = new DersGuncelleme();
            dersGuncellemeForm.Show();
        }

        private void DekleButon_Click(object sender, EventArgs e)
        {
            DersEkle dersEkleForm = new DersEkle();
            dersEkleForm.Show();
        }

        private void DsilButon_Click(object sender, EventArgs e)
        {
            DersSil dersSilForm = new DersSil();
            dersSilForm.Show();
        }

        private void DlisteleButon_Click(object sender, EventArgs e)
        {
            DersListele dersListeleForm = new DersListele();
            dersListeleForm.Show();

        }

        private void Ders_Load(object sender, EventArgs e)
        {

        }
    }
}

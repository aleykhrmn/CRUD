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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Ekran1buton_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenciForm = new Ogrenci();
            ogrenciForm.Show();
        }

        private void Ekran2buton_Click(object sender, EventArgs e)
        {
            Ders dersForm = new Ders();
            dersForm.Show();
        }

        private void Ekran3buton_Click(object sender, EventArgs e)
        {
            Bolum bolumForm = new Bolum();
            bolumForm.Show();
        }

        private void Ekran4buton_Click(object sender, EventArgs e)
        {
            Kayıt kayıtForm = new Kayıt();
            kayıtForm.Show();
        }

        private void Ekran5buton_Click(object sender, EventArgs e)
        {
            Ekran5 ekran5Form = new Ekran5();
            ekran5Form.Show();
        }

        private void Ekran6buton_Click(object sender, EventArgs e)
        {
            Ekran6 ekran6Form = new Ekran6();
            ekran6Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

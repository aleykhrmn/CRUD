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
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }

        private void DersAtamaButon_Click(object sender, EventArgs e)
        {
            DersAtama dersAtamaForm = new DersAtama();
            dersAtamaForm.Show();
        }

        private void DersSilmeButon_Click(object sender, EventArgs e)
        {
            OgrenciKayıtSilme ogrenciKayıtSilmeForm = new OgrenciKayıtSilme();
            ogrenciKayıtSilmeForm.Show();
        }

        private void DersDegistirmeButon_Click(object sender, EventArgs e)
        {
            DersDegistirme dersDegistirmeForm = new DersDegistirme();
            dersDegistirmeForm.Show();

        }

        private void Kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Ekran5 : Form
    {
        public Ekran5()
        {
            InitializeComponent();
        }


        private void YBListeleme_Click(object sender, EventArgs e)
        {
            YBListe yBListe = new YBListe();
            yBListe.Show();
        }

        private void OBListeleme_Click_1(object sender, EventArgs e)
        {
            ODersListesi oDersListesiForm = new ODersListesi();
            oDersListesiForm.Show();
        }

        private void Ekran5_Load(object sender, EventArgs e)
        {

        }
    }
}

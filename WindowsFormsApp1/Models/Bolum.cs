using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNamespace.Models;

namespace WindowsFormsApp1.Models
{
    public class Bolum
    {
        public int BolumID { get; set; }
        public string BolumAd { get; set; }
        public int FakulteID { get; set; }
        public Fakulte Fakulte { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}

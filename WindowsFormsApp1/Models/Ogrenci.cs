using System.Collections.Generic;
using WindowsFormsApp1.Models;

namespace YourNamespace.Models
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int BolumID { get; set; }
        public Bolum Bolum { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}

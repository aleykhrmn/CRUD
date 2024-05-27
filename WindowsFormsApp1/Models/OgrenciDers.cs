using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourNamespace.Models;

namespace WindowsFormsApp1.Models
{
    public class OgrenciDers
    {
        public int OgrenciID { get; set; }
        public int DersID { get; set; }
        public int Yil { get; set; }
        public string Yariyil { get; set; }
        public int Vize { get; set; }
        public int Final { get; set; }

        public Ogrenci Ogrenci { get; set; }
        public Ders Ders { get; set; }
    }
}

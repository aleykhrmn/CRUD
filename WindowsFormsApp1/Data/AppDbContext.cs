using System.Data.Entity;
using WindowsFormsApp1.Models;
using YourNamespace.Models;

namespace WindowsFormsApp1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
    }
}

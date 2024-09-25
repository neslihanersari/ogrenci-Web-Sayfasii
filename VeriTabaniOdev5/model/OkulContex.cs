using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTabaniOdev5.model
{

    public class OkulContext : DbContext
    {
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<OgrenciDers> OgrenciDers { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }

    }
}

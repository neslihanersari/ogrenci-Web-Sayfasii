﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeriTabaniOdev5.model;

namespace VeriTabaniOdev5.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
        }

        public DbSet<Fakulte> Fakulteler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Bolum> Bolumler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> Ogrencidersler { get; set; }

    }
}

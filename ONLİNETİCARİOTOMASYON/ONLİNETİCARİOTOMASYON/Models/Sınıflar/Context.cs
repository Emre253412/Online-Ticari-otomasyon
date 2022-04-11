using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Context:DbContext
    {
        public DbSet<Admin> admins { get; set; }
        public DbSet<Cari> caris { get; set; }
        public DbSet<Departman> Departmens { get; set; }
        public DbSet<Faturalar> faturalars { get; set; }
        public DbSet<Faturakalem> faturakalems { get; set; }
        public DbSet<Kategori> kategoris { get; set; }
        public DbSet<Personel> personels { get; set; }
        public DbSet<Satışhareketi> satışhareketis { get; set; }
        public DbSet<Ürünler> ürünlers { get; set; }
        public DbSet<Gider> giders{ get; set; }
        public DbSet<Envanter> envanters { get; set; }

    }
}
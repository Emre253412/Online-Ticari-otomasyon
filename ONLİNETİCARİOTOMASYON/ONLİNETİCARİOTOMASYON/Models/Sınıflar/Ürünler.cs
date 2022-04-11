using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Ürünler
    {
        [Key]
        public int ürünid { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(30)]
        public string ürünad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string marka { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string ürüngörsel { get; set; }
        public decimal satışfiyat { get; set; }
        public bool durum { get; set; }
        public int Kategoriid { get; set; }
        public virtual Kategori kategori { get; set; }
        public ICollection<Satışhareketi> satışhareketis { get; set; }
        public ICollection<Envanter> Envanters { get; set; }
        public ICollection<stok> stoks { get; set; }

    }
}
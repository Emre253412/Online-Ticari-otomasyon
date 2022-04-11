using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Satışhareketi
    {
        [Key]
        public int satısid { get; set; }
        public int adet { get; set; }
        public DateTime tarih { get; set; }
        public decimal toplamtutar { get; set; }
        public decimal fiyat { get; set; }
        public int ürünid { get; set; }
        public int cariid { get; set; }
     
        public virtual Cari cari { get; set; }
        public virtual Personel personel { get; set; }
        public virtual Ürünler ürünler { get; set; }

    }
}
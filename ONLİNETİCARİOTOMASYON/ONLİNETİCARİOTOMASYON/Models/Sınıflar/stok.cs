using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class stok
    {
        [Key]
        public int stokid { get; set; }
        public short adet { get; set; }
        public int arızalıürünsayısı { get; set; }
        public Ürünler ürünler { get; set; }
    }
}
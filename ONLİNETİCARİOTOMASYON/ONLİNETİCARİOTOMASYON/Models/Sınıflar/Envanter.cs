using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Envanter
    {
        [Key]
        public int envanterid { get; set; }
        public int alınanadet { get; set; }
        public decimal alisfiyat { get; set; }
        public int arızalıürünsayısı { get; set; }
        [StringLength(30)]
        public string serikod { get; set; }
        public int Ürünlerid { get; set; }
        public virtual Ürünler ürünler { get; set; }
    }
}
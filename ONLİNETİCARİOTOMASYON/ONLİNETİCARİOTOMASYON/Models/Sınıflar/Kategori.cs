using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Kategori
    {
        [Key]
        public int kategoriid { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string kategorıad { get; set; }
        public ICollection<Ürünler>ürünlers { get; set; }
    }
}
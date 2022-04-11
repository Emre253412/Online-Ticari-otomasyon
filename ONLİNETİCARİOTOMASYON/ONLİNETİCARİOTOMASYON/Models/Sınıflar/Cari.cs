using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Cari
    {
        [Key]
        public int cariid { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string cariad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string carisoyad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string carisehir { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string carimail { get; set; }
        public ICollection<Satışhareketi> satışhareketis { get; set; }

    }
}
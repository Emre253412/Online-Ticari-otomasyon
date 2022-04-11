using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int adminid { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string kullanıcıad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string sifre { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string yetki { get; set; }
    }
}
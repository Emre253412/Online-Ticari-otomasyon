using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Faturalar
    {
        [Key]
        public int faturaid { get; set; }
        [Column(TypeName = "char")]
        [StringLength(1)]
        public string faturaserino { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string faturasırano { get; set; }
        public DateTime tarih { get; set; }
        public DateTime saat { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(60)]
        public string vergidairesi{ get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string teslimalan { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string teslimeden { get; set; }
        public ICollection<Faturakalem> faturakalems { get; set; }
    }
}
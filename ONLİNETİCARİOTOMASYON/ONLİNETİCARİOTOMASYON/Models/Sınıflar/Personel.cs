using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ONLİNETİCARİOTOMASYON.Models.Sınıflar
{
    public class Personel
    {
        [Key]
        public int personelid { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string personelad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string personelsoyad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string personelgorsel { get; set; }
        public int departmanid { get; set; }
        public virtual Departman departman { get; set; }
        public ICollection<Satışhareketi> satışhareketis { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrnekEF1.Entities;

namespace OrnekEF1.Entities
{
    public class Personel
    {
        [Key]
        [Column(Order =0)]
        public int PersonelID { get; set; }
        [Column(Order = 1)]
        public string Ad { get; set; }
        [Column(Order = 2)]
        public string Soyad { get; set; }
        [Column(Order = 3)]
        public bool Cinsiyet { get; set; }
        [Column("EPosta",TypeName ="varchar",Order =5)]
        [StringLength(50)]
        public string Posta { get; set; }
        [Column(TypeName ="varchar",Order = 4)]
        [StringLength(250)][MaxLength(50)][MinLength(5)]
        public string Adres { get; set; }
        [NotMapped]
        public int gosterilmeyenAlan { get; set; }


        [InverseProperty("PersonelCVeren")]
        public ICollection<Calisma> Calisma1 { get; set; }

        [InverseProperty("PersonelCAlan")]
        public ICollection<Calisma> Calisma2 { get; set; }
    }
}

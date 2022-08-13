using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrnekEF1.Entities;

namespace OrnekEF1.Entities
{
    public class Calisma
    {
        public int ID { get; set; }
        public string Konu { get; set; }
        public string icerik { get; set; }

        [ForeignKey("PersonelCVeren")]
        public int? PersonelVerenId { get; set; }
        public Personel PersonelCVeren { get; set; }

        [ForeignKey("PersonelCAlan")]
        public int? PersonelAlanId { get; set; }
        public Personel PersonelCAlan { get; set; }
    }
}

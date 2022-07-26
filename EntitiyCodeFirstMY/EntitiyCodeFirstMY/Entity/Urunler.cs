using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyCodeFirstMY.Entity
{
    public class Urunler
    {
        [Key]
        public int ID { get; set; }
        public string UrunAd { get; set; }
        public string UrunMarka { get; set; }
        public int UrunStok { get; set; }
        public string Aciklama { get; set; }

        public Kategori Kategori { get; set; }

    }
}

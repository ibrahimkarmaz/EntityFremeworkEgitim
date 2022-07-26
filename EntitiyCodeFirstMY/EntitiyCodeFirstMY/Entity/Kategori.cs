using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyCodeFirstMY.Entity
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public ICollection<Urunler> Urunler { get; set; }//Bir kategoriyi birden fazla urun sınıfı kullanabilir.
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Personel
    {
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string Ad { get; set; }
        [StringLength(20)]
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        public bool Arsiv { get; set; }

        public int DepartmanID { get; set; }
        public virtual Departman Departmans { get; set; }
    }
}

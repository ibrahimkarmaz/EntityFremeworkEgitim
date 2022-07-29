using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Departman
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string DepartmanAd { get; set; }

        public ICollection<Personel> Personel { get; set; }
    }
}

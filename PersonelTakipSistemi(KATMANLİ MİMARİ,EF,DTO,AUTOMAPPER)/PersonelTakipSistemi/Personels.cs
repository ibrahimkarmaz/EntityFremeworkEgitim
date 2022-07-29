namespace PersonelTakipSistemi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Personels
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Ad { get; set; }

        [StringLength(20)]
        public string Soyad { get; set; }

        public bool Cinsiyet { get; set; }

        public bool Arsiv { get; set; }

        public int DepartmanID { get; set; }

        public virtual Departmen Departmen { get; set; }

        public virtual Departmen Departmen1 { get; set; }
    }
}

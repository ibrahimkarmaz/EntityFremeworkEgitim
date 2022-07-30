namespace CodeFirstSihirbazKullanimi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MusteriTablosu")]
    public partial class MusteriTablosu
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string ad { get; set; }

        [StringLength(20)]
        public string soyad { get; set; }

        [StringLength(20)]
        public string telefon { get; set; }

        [StringLength(350)]
        public string adres { get; set; }

        [StringLength(150)]
        public string resimyolu { get; set; }
    }
}

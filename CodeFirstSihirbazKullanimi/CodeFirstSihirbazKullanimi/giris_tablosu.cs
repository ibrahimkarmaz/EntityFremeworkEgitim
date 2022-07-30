namespace CodeFirstSihirbazKullanimi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class giris_tablosu
    {
        [Key]
        [StringLength(20)]
        public string kullanici_adi { get; set; }

        [StringLength(20)]
        public string parola { get; set; }
    }
}

namespace CodeFirstSihirbazKullanimi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ilceler")]
    public partial class ilceler
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string ilce { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sehir { get; set; }
    }
}

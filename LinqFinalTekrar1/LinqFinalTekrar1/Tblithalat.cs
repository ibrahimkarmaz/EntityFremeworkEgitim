//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqFinalTekrar1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tblithalat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tblithalat()
        {
            this.TblParcaAlisBilgi = new HashSet<TblParcaAlisBilgi>();
        }
    
        public int IthalatID { get; set; }
        public string IthalatUnvan { get; set; }
        public string IthalatTelefon1 { get; set; }
        public string IthalatTelefon2 { get; set; }
        public string IthalatMail { get; set; }
        public string IthalatAdres { get; set; }
        public string IthalatVergiNo { get; set; }
        public Nullable<bool> IthalatArsiv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblParcaAlisBilgi> TblParcaAlisBilgi { get; set; }
    }
}

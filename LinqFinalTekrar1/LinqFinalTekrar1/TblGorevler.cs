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
    
    public partial class TblGorevler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblGorevler()
        {
            this.TblGorevlerDetaylar = new HashSet<TblGorevlerDetaylar>();
        }
    
        public int ID { get; set; }
        public Nullable<int> GorevVeren { get; set; }
        public Nullable<int> GorevAlan { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> Durum { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
    
        public virtual TblPersonel TblPersonel { get; set; }
        public virtual TblPersonel TblPersonel1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblGorevlerDetaylar> TblGorevlerDetaylar { get; set; }
    }
}

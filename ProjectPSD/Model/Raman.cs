//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Raman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Raman()
        {
            this.Details = new HashSet<Detail>();
        }
    
        public int RamenID { get; set; }
        public string RamenName { get; set; }
        public string RamenBroth { get; set; }
        public string RamenPrice { get; set; }
        public Nullable<int> MeatID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detail> Details { get; set; }
        public virtual Meat Meat { get; set; }
    }
}

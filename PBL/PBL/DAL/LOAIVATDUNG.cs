//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBL.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAIVATDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIVATDUNG()
        {
            this.VATDUNGPHONGs = new HashSet<VATDUNGPHONG>();
        }
    
        public string VatDungID { get; set; }
        public string TenVatDung { get; set; }
        public decimal DonGia { get; set; }
        public Nullable<bool> ThietBiCoDinh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VATDUNGPHONG> VATDUNGPHONGs { get; set; }
    }
}

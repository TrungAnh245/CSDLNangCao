//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLGiangVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThanhToanGiangDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ThanhToanGiangDay()
        {
            this.GiangVien_TTGiangDay = new HashSet<GiangVien_TTGiangDay>();
        }
    
        public int MaPhieuTT { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public string TenTK_PDT { get; set; }
        public Nullable<int> MaHK { get; set; }
        public string MaBM { get; set; }
    
        public virtual BoMon BoMon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiangVien_TTGiangDay> GiangVien_TTGiangDay { get; set; }
        public virtual HocKy HocKy { get; set; }
    }
}
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
    
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            this.HocKy_LopHocPhan = new HashSet<HocKy_LopHocPhan>();
        }
    
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public Nullable<int> SoTietHoc { get; set; }
        public string MaBM { get; set; }
    
        public virtual BoMon BoMon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocKy_LopHocPhan> HocKy_LopHocPhan { get; set; }
    }
}

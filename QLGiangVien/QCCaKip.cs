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
    
    public partial class QCCaKip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QCCaKip()
        {
            this.QCCaKip_LopHocPhan = new HashSet<QCCaKip_LopHocPhan>();
        }
    
        public int MaQCCK { get; set; }
        public string CaKip { get; set; }
        public Nullable<float> GioQC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QCCaKip_LopHocPhan> QCCaKip_LopHocPhan { get; set; }
    }
}
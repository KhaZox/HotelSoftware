//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOAN
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUDATPHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDATPHONG()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int MAPHIEU { get; set; }
        public string MAPHONG { get; set; }
        public string TENPHONG { get; set; }
        public Nullable<System.DateTime> NGAYDK { get; set; }
        public Nullable<System.DateTime> NGAYTRA { get; set; }
        public string MANV { get; set; }
        public string MAKH { get; set; }
        public Nullable<int> SONGUOI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}

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
    
    public partial class HOADON
    {
        public int MAHD { get; set; }
        public Nullable<int> MAPHIEU { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
        public Nullable<System.DateTime> NGAYLAP { get; set; }
        public Nullable<System.DateTime> NGAYTRA { get; set; }
        public string MAPHONG { get; set; }
        public string TENPHONG { get; set; }
        public Nullable<double> TRIGIADV { get; set; }
        public Nullable<double> TRIGIAPHONG { get; set; }
        public Nullable<double> TONGHOADON { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual PHIEUDATPHONG PHIEUDATPHONG { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}

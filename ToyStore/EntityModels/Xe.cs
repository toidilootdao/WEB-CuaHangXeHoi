//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Xe
    {
        public Xe()
        {
            this.HoaDon = new HashSet<HoaDon>();
        }
    
        public int MaXe { get; set; }
        public string TenXe { get; set; }
        public Nullable<int> NamSanXuat { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<int> MaLoaiXe { get; set; }
        public Nullable<bool> TrangThai { get; set; }
    
        public virtual LoaiXe LoaiXe { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}

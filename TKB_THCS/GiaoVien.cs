//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TKB_THCS
{
    using System;
    using System.Collections.Generic;
    
    public partial class GiaoVien
    {
        public GiaoVien()
        {
            this.LopHocs = new HashSet<LopHoc>();
        }
    
        public int IDGV { get; set; }
        public Nullable<int> IDMon { get; set; }
        public Nullable<int> ChuyenKhoi { get; set; }
        public string TenGV { get; set; }
        public string NamSinh { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<int> SoTiet { get; set; }
        public string SoDT { get; set; }
        public string DiaChi { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        public virtual MonHoc MonHoc { get; set; }
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}

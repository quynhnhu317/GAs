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
    
    public partial class PhongHoc
    {
        public PhongHoc()
        {
            this.LopHocs = new HashSet<LopHoc>();
        }
    
        public int IDPH { get; set; }
        public string TenPH { get; set; }
        public Nullable<int> SucChua { get; set; }
        public string ViTri { get; set; }
    
        public virtual ICollection<LopHoc> LopHocs { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOffice
{
    using System;
    using System.Collections.Generic;
    
    public partial class VanBanDen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VanBanDen()
        {
            this.VanBanDenFiles = new HashSet<VanBanDenFile>();
        }
    
        public int Id { get; set; }
        public int LoaiVanBanId { get; set; }
        public Nullable<System.DateTime> NgayDen { get; set; }
        public Nullable<int> SoDen { get; set; }
        public int CoQuanId { get; set; }
        public string SoKyHieu { get; set; }
        public Nullable<System.DateTime> NgayBanHanh { get; set; }
        public string TrichYeu { get; set; }
        public string NguoiNhan { get; set; }
        public string GhiChu { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public int UserId { get; set; }
        public string Path { get; set; }
    
        public virtual CoQuan CoQuan { get; set; }
        public virtual LoaiVanBan LoaiVanBan { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VanBanDenFile> VanBanDenFiles { get; set; }
    }
}
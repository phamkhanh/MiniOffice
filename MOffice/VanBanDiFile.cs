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
    
    public partial class VanBanDiFile
    {
        public int Id { get; set; }
        public Nullable<int> VanBanDiId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string FileName { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string ShortFileName { get; set; }
    
        public virtual User User { get; set; }
        public virtual VanBanDi VanBanDi { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Library.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblPunishment
    {
        public int punishmentId { get; set; }
        public Nullable<int> punishmentMember { get; set; }
        public Nullable<int> punishmentOperation { get; set; }
        public Nullable<System.DateTime> punishmentStartDate { get; set; }
        public Nullable<System.DateTime> punishmentEndDate { get; set; }
        public Nullable<decimal> punishmentFine { get; set; }
    
        public virtual TblMember TblMember { get; set; }
        public virtual TblOperation TblOperation { get; set; }
    }
}

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
    
    public partial class TblAuthor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblAuthor()
        {
            this.TblBooks = new HashSet<TblBook>();
        }
    
        public int authorId { get; set; }
        public string authorName { get; set; }
        public string authorSurname { get; set; }
        public string authorDetails { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblBook> TblBooks { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class RFS_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RFS_Type()
        {
            this.RFS_Model_Asset = new HashSet<RFS_Model_Asset>();
        }
    
        public string type_id { get; set; }
        public string type_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RFS_Model_Asset> RFS_Model_Asset { get; set; }
    }
}

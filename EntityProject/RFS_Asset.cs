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
    
    public partial class RFS_Asset
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RFS_Asset()
        {
            this.RFS_Asset_Software = new HashSet<RFS_Asset_Software>();
        }
    
        public string asset_list { get; set; }
        public string service_tag { get; set; }
        public string model_id { get; set; }
        public string processor { get; set; }
        public Nullable<int> warranty_year { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string status { get; set; }
        public string em_id { get; set; }
        public string sup_id { get; set; }
        public string dep_id_2 { get; set; }
        public string IMEI { get; set; }
        public string user_insert { get; set; }
        public string user_update { get; set; }
        public Nullable<System.DateTime> date_insert { get; set; }
        public Nullable<System.DateTime> date_update { get; set; }
        public string img_id { get; set; }
        public string asset_list_m { get; set; }
        public string ip { get; set; }
        public Nullable<int> Activate_id { get; set; }
        public byte[] img { get; set; }
    
        public virtual RFS_Activate RFS_Activate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RFS_Asset_Software> RFS_Asset_Software { get; set; }
        public virtual RFS_Department_2 RFS_Department_2 { get; set; }
        public virtual RFS_Employee RFS_Employee { get; set; }
        public virtual RFS_Img_Asset RFS_Img_Asset { get; set; }
        public virtual RFS_Model_Asset RFS_Model_Asset { get; set; }
        public virtual RFS_Supplier RFS_Supplier { get; set; }
        public virtual RFS_Asset_monitor RFS_Asset_monitor { get; set; }
    }
}

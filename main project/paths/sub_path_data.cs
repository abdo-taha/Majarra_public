//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace paths
{
    using System;
    using System.Collections.Generic;
    
    public partial class sub_path_data
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sub_path_data()
        {
            this.courses_data = new HashSet<courses_data>();
            this.courses_data1 = new HashSet<courses_data>();
            this.courses_data2 = new HashSet<courses_data>();
            this.courses_data3 = new HashSet<courses_data>();
            this.courses_data4 = new HashSet<courses_data>();
            this.courses_data5 = new HashSet<courses_data>();
            this.courses_data6 = new HashSet<courses_data>();
            this.courses_data7 = new HashSet<courses_data>();
            this.courses_data8 = new HashSet<courses_data>();
            this.courses_data9 = new HashSet<courses_data>();
            this.courses_data10 = new HashSet<courses_data>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string about { get; set; }
        public int path_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data9 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<courses_data> courses_data10 { get; set; }
        public virtual path_data path_data { get; set; }
        public virtual path_data path_data1 { get; set; }
        public virtual path_data path_data2 { get; set; }
        public virtual path_data path_data3 { get; set; }
        public virtual path_data path_data4 { get; set; }
        public virtual path_data path_data5 { get; set; }
        public virtual path_data path_data6 { get; set; }
        public virtual path_data path_data7 { get; set; }
        public virtual path_data path_data8 { get; set; }
        public virtual path_data path_data9 { get; set; }
        public virtual path_data path_data10 { get; set; }
    }
}
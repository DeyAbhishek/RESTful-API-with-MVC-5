//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPO.DL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestLimitType
    {
        public TestLimitType()
        {
            this.RawMaterialTests = new HashSet<RawMaterialTest>();
            this.RawMaterialTests1 = new HashSet<RawMaterialTest>();
            this.RawMaterialTests2 = new HashSet<RawMaterialTest>();
            this.RawMaterialTests3 = new HashSet<RawMaterialTest>();
            this.RawMaterialTests4 = new HashSet<RawMaterialTest>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<RawMaterialTest> RawMaterialTests { get; set; }
        public virtual ICollection<RawMaterialTest> RawMaterialTests1 { get; set; }
        public virtual ICollection<RawMaterialTest> RawMaterialTests2 { get; set; }
        public virtual ICollection<RawMaterialTest> RawMaterialTests3 { get; set; }
        public virtual ICollection<RawMaterialTest> RawMaterialTests4 { get; set; }
    }
}

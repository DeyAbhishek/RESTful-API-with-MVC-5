//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPO_Reporting_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TPOExtruder
    {
        public TPOExtruder()
        {
            this.EndOfRunTPOFeeder = new HashSet<EndOfRunTPOFeeder>();
            this.TPORawMaterialFormulation = new HashSet<TPORawMaterialFormulation>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<EndOfRunTPOFeeder> EndOfRunTPOFeeder { get; set; }
        public virtual ICollection<TPORawMaterialFormulation> TPORawMaterialFormulation { get; set; }
    }
}

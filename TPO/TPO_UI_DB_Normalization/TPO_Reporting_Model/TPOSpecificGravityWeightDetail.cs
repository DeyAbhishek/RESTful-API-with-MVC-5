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
    
    public partial class TPOSpecificGravityWeightDetail
    {
        public int ID { get; set; }
        public int TPOSpecGravID { get; set; }
        public int TypeID { get; set; }
        public bool Submerged { get; set; }
        public double Value { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual TPOSpecificGravity TPOSpecificGravity { get; set; }
        public virtual TPOSpecificGravityWeightDetailType TPOSpecificGravityWeightDetailType { get; set; }
    }
}
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
    
    public partial class IMQCDetail
    {
        public int ID { get; set; }
        public int IMQCID { get; set; }
        public double TestWeight { get; set; }
        public Nullable<double> Thick1 { get; set; }
        public Nullable<double> Thick2 { get; set; }
        public Nullable<double> Thick3 { get; set; }
        public string Thick4 { get; set; }
        public Nullable<double> ColorL { get; set; }
        public Nullable<double> ColorDE { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual IMQC IMQC { get; set; }
    }
}

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
    
    public partial class TPOQC2X2Detail
    {
        public int TPOQCID { get; set; }
        public int WeightUoMID { get; set; }
        public Nullable<double> C2X2Weight1 { get; set; }
        public Nullable<double> C2X2Weight2 { get; set; }
        public Nullable<double> C2X2Weight3 { get; set; }
        public Nullable<double> C2X2Weight4 { get; set; }
        public Nullable<double> C2X2Weight5 { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual TPOQC TPOQC { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}

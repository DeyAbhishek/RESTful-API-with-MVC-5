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
    
    public partial class TPOQCGrabTearingDetail
    {
        public int TPOQCID { get; set; }
        public int ForceUoMID { get; set; }
        public Nullable<double> Machine1 { get; set; }
        public Nullable<double> Machine2 { get; set; }
        public Nullable<double> Machine3 { get; set; }
        public Nullable<double> Machine4 { get; set; }
        public Nullable<double> Machine5 { get; set; }
        public Nullable<double> Transverse1 { get; set; }
        public Nullable<double> Transverse2 { get; set; }
        public Nullable<double> Transverse3 { get; set; }
        public Nullable<double> Transverse4 { get; set; }
        public Nullable<double> Transverse5 { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual TPOQC TPOQC { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
    }
}

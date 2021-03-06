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
    
    public partial class EndOfRunTPOFeeder
    {
        public int ID { get; set; }
        public int PlantID { get; set; }
        public int LineID { get; set; }
        public int ShiftID { get; set; }
        public int WorkOrderID { get; set; }
        public int TPOExtruderID { get; set; }
        public int RawMaterialID { get; set; }
        public double QuantityUsed { get; set; }
        public int Feeder { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ProductionShift ProductionShift { get; set; }
        public virtual TPOExtruder TPOExtruder { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}

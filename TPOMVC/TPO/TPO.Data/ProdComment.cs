//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPO.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProdComment
    {
        public int ID { get; set; }
        public int LineID { get; set; }
        public int ShiftID { get; set; }
        public int WorkOrderID { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ProdLine ProdLine { get; set; }
        public virtual ProductionShift ProductionShift { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}

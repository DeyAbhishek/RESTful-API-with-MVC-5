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
    
    public partial class ScrimAction
    {
        public int ID { get; set; }
        public int PlantID { get; set; }
        public Nullable<int> LineID { get; set; }
        public Nullable<int> ShiftID { get; set; }
        public Nullable<int> WorkOrderID { get; set; }
        public Nullable<int> RollID { get; set; }
        public int ScrimRollID { get; set; }
        public int TypeID { get; set; }
        public Nullable<int> ReasonID { get; set; }
        public int UserID { get; set; }
        public double ActionLength { get; set; }
        public double ActionWeight { get; set; }
        public double StartLength { get; set; }
        public double StartWeight { get; set; }
        public double EndLength { get; set; }
        public double EndWeight { get; set; }
        public System.DateTime ActionDate { get; set; }
        public Nullable<bool> FleeceProd { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ProductionShift ProductionShift { get; set; }
        public virtual ScrimActionReason ScrimActionReason { get; set; }
        public virtual ScrimActionType ScrimActionType { get; set; }
        public virtual ScrimRoll ScrimRoll { get; set; }
        public virtual TPOCProductRoll TPOCProductRoll { get; set; }
        public virtual User User { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}

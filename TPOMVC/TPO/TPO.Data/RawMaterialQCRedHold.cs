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
    
    public partial class RawMaterialQCRedHold
    {
        public int ID { get; set; }
        public int PlantID { get; set; }
        public int RawMaterialReceivedID { get; set; }
        public Nullable<int> FailPropertyID { get; set; }
        public string HoldLotNumber { get; set; }
        public Nullable<int> QCTechID { get; set; }
        public Nullable<int> LeadOperatorID { get; set; }
        public Nullable<int> SupervisorID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public Nullable<System.DateTime> RedDate { get; set; }
        public string Zone { get; set; }
        public string RedComments { get; set; }
        public string RedCorrectionAction { get; set; }
        public Nullable<System.DateTime> HoldDate { get; set; }
        public string HoldComments { get; set; }
        public Nullable<System.DateTime> ManagerDate { get; set; }
        public string ManagerComments { get; set; }
        public double PrimeBoxCar { get; set; }
        public double PrimeUOM { get; set; }
        public double ReworkBoxCar { get; set; }
        public double ReworkUOM { get; set; }
        public double ScrapBoxCar { get; set; }
        public double ScrapUOM { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> RawMaterialQCID { get; set; }
    
        public virtual FailProperty FailProperty { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual RawMaterialReceived RawMaterialReceived { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual User User2 { get; set; }
        public virtual User User3 { get; set; }
        public virtual RawMaterialQC RawMaterialQC { get; set; }
    }
}

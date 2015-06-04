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
    
    public partial class DownTimeEquipment
    {
        public DownTimeEquipment()
        {
            this.DownTimes = new HashSet<DownTime>();
        }
    
        public int ID { get; set; }
        public int DownTimeTypeID { get; set; }
        public int PlantID { get; set; }
        public Nullable<int> LineID { get; set; }
        public string Description { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public int DownTimeEquipmentGroupID { get; set; }
    
        public virtual DownTimeEquipmentGroup DownTimeEquipmentGroup { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ProdLine ProdLine { get; set; }
        public virtual ICollection<DownTime> DownTimes { get; set; }
    }
}

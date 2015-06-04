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
    
    public partial class TPOBatch
    {
        public TPOBatch()
        {
            this.TPOCProductRolls = new HashSet<TPOCProductRoll>();
        }
    
        public int ID { get; set; }
        public int PlantID { get; set; }
        public int LineID { get; set; }
        public Nullable<int> RawMaterialID { get; set; }
        public Nullable<int> RawMaterialReceivedID { get; set; }
        public int BatchNumber { get; set; }
        public int FormulationID { get; set; }
        public bool IsScrim { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<int> ScrimRollID { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ProdLine ProdLine { get; set; }
        public virtual RawMaterialReceived RawMaterialReceived { get; set; }
        public virtual RawMaterial RawMaterial { get; set; }
        public virtual TPOFormulation TPOFormulation { get; set; }
        public virtual ICollection<TPOCProductRoll> TPOCProductRolls { get; set; }
        public virtual ScrimRoll ScrimRoll { get; set; }
    }
}

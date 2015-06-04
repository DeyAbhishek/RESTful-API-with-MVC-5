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
    
    public partial class TPOCurrentScrim
    {
        public int ID { get; set; }
        public int PlantID { get; set; }
        public Nullable<int> Scrim1RollID { get; set; }
        public Nullable<int> Scrim1TypeID { get; set; }
        public Nullable<int> Scrim2RollID { get; set; }
        public Nullable<int> Scrim2TypeID { get; set; }
        public Nullable<int> FleeceRollID { get; set; }
        public Nullable<int> FleeceTypeID { get; set; }
        public string LineID { get; set; }
        public string ScrimPos { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ScrimRoll FleeceRoll { get; set; }
        public virtual ScrimRoll Scrim1Roll { get; set; }
        public virtual ScrimRoll Scrim2Roll { get; set; }
        public virtual ScrimType FleeceType { get; set; }
        public virtual ScrimType Scrim1Type { get; set; }
        public virtual ScrimType Scrim2Type { get; set; }
    }
}

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
    
    public partial class User
    {
        public User()
        {
            this.RawMaterialActions = new HashSet<RawMaterialAction>();
            this.RawMaterialQCs = new HashSet<RawMaterialQC>();
            this.RoleAssignments = new HashSet<RoleAssignment>();
            this.ScrimActions = new HashSet<ScrimAction>();
            this.QCRedHolds = new HashSet<QCRedHold>();
            this.QCRedHolds1 = new HashSet<QCRedHold>();
            this.QCRedHolds2 = new HashSet<QCRedHold>();
            this.QCRedHolds3 = new HashSet<QCRedHold>();
            this.RawMaterialQCRedHolds = new HashSet<RawMaterialQCRedHold>();
            this.RawMaterialQCRedHolds1 = new HashSet<RawMaterialQCRedHold>();
            this.RawMaterialQCRedHolds2 = new HashSet<RawMaterialQCRedHold>();
            this.RawMaterialQCRedHolds3 = new HashSet<RawMaterialQCRedHold>();
            this.RawMaterialSpecificGravities = new HashSet<RawMaterialSpecificGravity>();
            this.QCKickouts = new HashSet<QCKickout>();
            this.QCKickouts1 = new HashSet<QCKickout>();
            this.QCKickouts2 = new HashSet<QCKickout>();
        }
    
        public int ID { get; set; }
        public int PlantID { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual ICollection<RawMaterialAction> RawMaterialActions { get; set; }
        public virtual ICollection<RawMaterialQC> RawMaterialQCs { get; set; }
        public virtual ICollection<RoleAssignment> RoleAssignments { get; set; }
        public virtual ICollection<ScrimAction> ScrimActions { get; set; }
        public virtual ICollection<QCRedHold> QCRedHolds { get; set; }
        public virtual ICollection<QCRedHold> QCRedHolds1 { get; set; }
        public virtual ICollection<QCRedHold> QCRedHolds2 { get; set; }
        public virtual ICollection<QCRedHold> QCRedHolds3 { get; set; }
        public virtual ICollection<RawMaterialQCRedHold> RawMaterialQCRedHolds { get; set; }
        public virtual ICollection<RawMaterialQCRedHold> RawMaterialQCRedHolds1 { get; set; }
        public virtual ICollection<RawMaterialQCRedHold> RawMaterialQCRedHolds2 { get; set; }
        public virtual ICollection<RawMaterialQCRedHold> RawMaterialQCRedHolds3 { get; set; }
        public virtual ICollection<RawMaterialSpecificGravity> RawMaterialSpecificGravities { get; set; }
        public virtual ICollection<QCKickout> QCKickouts { get; set; }
        public virtual ICollection<QCKickout> QCKickouts1 { get; set; }
        public virtual ICollection<QCKickout> QCKickouts2 { get; set; }
    }
}

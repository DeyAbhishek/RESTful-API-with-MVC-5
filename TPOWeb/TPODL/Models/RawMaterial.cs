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
    
    public partial class RawMaterial
    {
        public RawMaterial()
        {
            this.IMProducts = new HashSet<IMProduct>();
            this.RawMaterialActions = new HashSet<RawMaterialAction>();
            this.RawMaterialReceiveds = new HashSet<RawMaterialReceived>();
            this.RawMaterialTests = new HashSet<RawMaterialTest>();
            this.TPOFormulationRawMaterials = new HashSet<TPOFormulationRawMaterial>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public double PricePerUOM { get; set; }
        public double Density { get; set; }
        public double Stock { get; set; }
        public string FSBPID { get; set; }
        public int PlantID { get; set; }
        public System.DateTime LastModified { get; set; }
        public int UOMID { get; set; }
        public int RawMaterialVendorID { get; set; }
    
        public virtual ICollection<IMProduct> IMProducts { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual ICollection<RawMaterialAction> RawMaterialActions { get; set; }
        public virtual ICollection<RawMaterialReceived> RawMaterialReceiveds { get; set; }
        public virtual RawMaterialVendor RawMaterialVendor { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual ICollection<RawMaterialTest> RawMaterialTests { get; set; }
        public virtual ICollection<TPOFormulationRawMaterial> TPOFormulationRawMaterials { get; set; }
    }
}

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
    
    public partial class IMProduct
    {
        public IMProduct()
        {
            this.IMProds = new HashSet<IMProd>();
            this.IMQCs = new HashSet<IMQC>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int IMProductTypeID { get; set; }
        public int PartsPerCartoon { get; set; }
        public int CartoonPerLot { get; set; }
        public int RawMaterialID { get; set; }
        public int ThickUOM { get; set; }
        public int WeightUOM { get; set; }
        public double MinimumThick { get; set; }
        public double MinimumWeight { get; set; }
        public string Label1 { get; set; }
        public string Label2 { get; set; }
        public string Label3 { get; set; }
        public System.DateTime LastModified { get; set; }
        public int PlantID { get; set; }
        public bool Active { get; set; }
    
        public virtual ICollection<IMProd> IMProds { get; set; }
        public virtual IMProductType IMProductType { get; set; }
        public virtual Plant Plant { get; set; }
        public virtual RawMaterial RawMaterial { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual UnitOfMeasure UnitOfMeasure1 { get; set; }
        public virtual ICollection<IMQC> IMQCs { get; set; }
    }
}

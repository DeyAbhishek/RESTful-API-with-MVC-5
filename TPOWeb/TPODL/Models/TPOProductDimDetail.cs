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
    
    public partial class TPOProductDimDetail
    {
        public TPOProductDimDetail()
        {
            this.TPOProducts = new HashSet<TPOProduct>();
        }
    
        public int ID { get; set; }
        public Nullable<double> DimStab80 { get; set; }
        public Nullable<double> DimStabTemp { get; set; }
        public Nullable<double> DimStabTempCE { get; set; }
        public int DimStabTempUoM { get; set; }
    
        public virtual UnitOfMeasure UnitOfMeasure { get; set; }
        public virtual ICollection<TPOProduct> TPOProducts { get; set; }
    }
}

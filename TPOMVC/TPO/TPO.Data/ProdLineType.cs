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
    
    public partial class ProdLineType
    {
        public ProdLineType()
        {
            this.ProdLines = new HashSet<ProdLine>();
            this.ProdLineRollConfigs = new HashSet<ProdLineRollConfig>();
        }
    
        public int ID { get; set; }
        public string ProdLineTypeDesc { get; set; }
        public string ProdLineTypeCode { get; set; }
    
        public virtual ICollection<ProdLine> ProdLines { get; set; }
        public virtual ProdLineType ProdLineType11 { get; set; }
        public virtual ProdLineType ProdLineType2 { get; set; }
        public virtual ICollection<ProdLineRollConfig> ProdLineRollConfigs { get; set; }
    }
}

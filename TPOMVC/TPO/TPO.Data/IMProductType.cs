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
    
    public partial class IMProductType
    {
        public IMProductType()
        {
            this.IMProducts = new HashSet<IMProduct>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ThickLabel1 { get; set; }
        public string ThickLabel2 { get; set; }
        public System.DateTime LastModified { get; set; }
    
        public virtual ICollection<IMProduct> IMProducts { get; set; }
    }
}
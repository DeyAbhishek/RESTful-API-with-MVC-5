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
    
    public partial class QCPrintSpecification
    {
        public int PlantID { get; set; }
        public int TypeID { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Plant Plant { get; set; }
        public virtual QCPrintSpecificationType QCPrintSpecificationType { get; set; }
    }
}

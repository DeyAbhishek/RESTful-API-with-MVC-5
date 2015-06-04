﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPO.Common.DTOs
{
    public class TPOLineScrapDto
    {
        public int ID { get; set; }
        public int PlantID { get; set; }
        public int ShiftID { get; set; }
        public int WorkOrderID { get; set; }
        public Nullable<int> ReworkRollID { get; set; }
        public int TypeID { get; set; }
        public string Code { get; set; }
        public string ScrapCode { get; set; }
        public int BatchNumber { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public System.DateTime ProductionDate { get; set; }
        public string Comment { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
        public int LengthUoMID { get; set; }
        public int WeightUoMID { get; set; }
        public int WidthUoMID { get; set; }
        public int LineScrapCodeGroupID { get; set; }
        public int LineScrapCodeID { get; set; }

        public string TPOLineScrapCodeGroupDescription { get; set; }
        public string TPOLineScrapCodeDescription { get; set; }
        public string TPOLineScrapTypeDescription { get; set; }  //Disposition
        public string UnitOfMeasureCode { get; set; } //UoM
        public string UnitOfMeasure1Code { get; set; } //UoM
        public string UnitOfMeasure2Code { get; set; } //UoM
        public string WorkOrderCode { get; set; }
        public string ProductionShiftCode { get; set; }
    }
}

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
    
    public partial class Plant
    {
        public Plant()
        {
            this.IMQCs = new HashSet<IMQC>();
            this.ProdLines = new HashSet<ProdLine>();
            this.ProdLinesPerforms = new HashSet<ProdLinesPerform>();
            this.ProdLinesPerformProds = new HashSet<ProdLinesPerformProd>();
            this.ProdSupervisorOnShifts = new HashSet<ProdSupervisorOnShift>();
            this.ProductionBudgets = new HashSet<ProductionBudget>();
            this.ProductionLineSchedules = new HashSet<ProductionLineSchedule>();
            this.ProductionShifts = new HashSet<ProductionShift>();
            this.ProductionShiftUses = new HashSet<ProductionShiftUse>();
            this.QCKickouts = new HashSet<QCKickout>();
            this.QCPrintSpecifications = new HashSet<QCPrintSpecification>();
            this.QCRedHolds = new HashSet<QCRedHold>();
            this.RawMaterialQCRedHolds = new HashSet<RawMaterialQCRedHold>();
            this.RawMaterialReceiveds = new HashSet<RawMaterialReceived>();
            this.RawMaterials = new HashSet<RawMaterial>();
            this.RawMaterialTests = new HashSet<RawMaterialTest>();
            this.RawMaterialVendors = new HashSet<RawMaterialVendor>();
            this.ScrimActions = new HashSet<ScrimAction>();
            this.ScrimActionTypes = new HashSet<ScrimActionType>();
            this.ScrimRolls = new HashSet<ScrimRoll>();
            this.ScrimTypes = new HashSet<ScrimType>();
            this.TPOCProductRolls = new HashSet<TPOCProductRoll>();
            this.TPOCurrentRawMaterials = new HashSet<TPOCurrentRawMaterial>();
            this.TPOCurrentScrims = new HashSet<TPOCurrentScrim>();
            this.TPOFormulationLineProducts = new HashSet<TPOFormulationLineProduct>();
            this.TPOFormulationRawMaterials = new HashSet<TPOFormulationRawMaterial>();
            this.TPOProductStandardCosts = new HashSet<TPOProductStandardCost>();
            this.WorkOrders = new HashSet<WorkOrder>();
            this.UnitOfMeasureDefaults = new HashSet<UnitOfMeasureDefault>();
            this.TPOLineScrapCodeGroups = new HashSet<TPOLineScrapCodeGroup>();
            this.UserPlants = new HashSet<UserPlant>();
            this.RawMaterialReceivedSizeLimits = new HashSet<RawMaterialReceivedSizeLimit>();
            this.TPOFormulations = new HashSet<TPOFormulation>();
            this.TPOProducts = new HashSet<TPOProduct>();
            this.Users = new HashSet<User>();
            this.TPOReclaimActions = new HashSet<TPOReclaimAction>();
            this.TPOReclaimWIPs = new HashSet<TPOReclaimWIP>();
            this.DownTimeEquipments = new HashSet<DownTimeEquipment>();
            this.DownTimeEquipmentGroups = new HashSet<DownTimeEquipmentGroup>();
            this.DownTimeReasons = new HashSet<DownTimeReason>();
            this.RawMaterialActions = new HashSet<RawMaterialAction>();
            this.IMProducts = new HashSet<IMProduct>();
            this.RawMaterialQCs = new HashSet<RawMaterialQC>();
            this.ProdDateChanges = new HashSet<ProdDateChange>();
            this.TPOLineScraps = new HashSet<TPOLineScrap>();
            this.TPOReworkRolls = new HashSet<TPOReworkRoll>();
            this.DownTimes = new HashSet<DownTime>();
            this.WorkOrderShiftDatas = new HashSet<WorkOrderShiftData>();
            this.WorkOrderShiftDataFormulations = new HashSet<WorkOrderShiftDataFormulation>();
            this.TPOBatches = new HashSet<TPOBatch>();
            this.SupervisorOnShifts = new HashSet<SupervisorOnShift>();
            this.TPOReworkActions = new HashSet<TPOReworkAction>();
            this.IMProds = new HashSet<IMProd>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public System.DateTime DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime LastModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual ICollection<IMQC> IMQCs { get; set; }
        public virtual ICollection<ProdLine> ProdLines { get; set; }
        public virtual ICollection<ProdLinesPerform> ProdLinesPerforms { get; set; }
        public virtual ICollection<ProdLinesPerformProd> ProdLinesPerformProds { get; set; }
        public virtual ICollection<ProdSupervisorOnShift> ProdSupervisorOnShifts { get; set; }
        public virtual ICollection<ProductionBudget> ProductionBudgets { get; set; }
        public virtual ICollection<ProductionLineSchedule> ProductionLineSchedules { get; set; }
        public virtual ICollection<ProductionShift> ProductionShifts { get; set; }
        public virtual ICollection<ProductionShiftUse> ProductionShiftUses { get; set; }
        public virtual ICollection<QCKickout> QCKickouts { get; set; }
        public virtual ICollection<QCPrintSpecification> QCPrintSpecifications { get; set; }
        public virtual ICollection<QCRedHold> QCRedHolds { get; set; }
        public virtual ICollection<RawMaterialQCRedHold> RawMaterialQCRedHolds { get; set; }
        public virtual ICollection<RawMaterialReceived> RawMaterialReceiveds { get; set; }
        public virtual ICollection<RawMaterial> RawMaterials { get; set; }
        public virtual ICollection<RawMaterialTest> RawMaterialTests { get; set; }
        public virtual ICollection<RawMaterialVendor> RawMaterialVendors { get; set; }
        public virtual ICollection<ScrimAction> ScrimActions { get; set; }
        public virtual ICollection<ScrimActionType> ScrimActionTypes { get; set; }
        public virtual ICollection<ScrimRoll> ScrimRolls { get; set; }
        public virtual ICollection<ScrimType> ScrimTypes { get; set; }
        public virtual ICollection<TPOCProductRoll> TPOCProductRolls { get; set; }
        public virtual ICollection<TPOCurrentRawMaterial> TPOCurrentRawMaterials { get; set; }
        public virtual ICollection<TPOCurrentScrim> TPOCurrentScrims { get; set; }
        public virtual ICollection<TPOFormulationLineProduct> TPOFormulationLineProducts { get; set; }
        public virtual ICollection<TPOFormulationRawMaterial> TPOFormulationRawMaterials { get; set; }
        public virtual ICollection<TPOProductStandardCost> TPOProductStandardCosts { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
        public virtual ICollection<UnitOfMeasureDefault> UnitOfMeasureDefaults { get; set; }
        public virtual ICollection<TPOLineScrapCodeGroup> TPOLineScrapCodeGroups { get; set; }
        public virtual ICollection<UserPlant> UserPlants { get; set; }
        public virtual ICollection<RawMaterialReceivedSizeLimit> RawMaterialReceivedSizeLimits { get; set; }
        public virtual ICollection<TPOFormulation> TPOFormulations { get; set; }
        public virtual ICollection<TPOProduct> TPOProducts { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<TPOReclaimAction> TPOReclaimActions { get; set; }
        public virtual ICollection<TPOReclaimWIP> TPOReclaimWIPs { get; set; }
        public virtual ICollection<DownTimeEquipment> DownTimeEquipments { get; set; }
        public virtual ICollection<DownTimeEquipmentGroup> DownTimeEquipmentGroups { get; set; }
        public virtual ICollection<DownTimeReason> DownTimeReasons { get; set; }
        public virtual ICollection<RawMaterialAction> RawMaterialActions { get; set; }
        public virtual ICollection<IMProduct> IMProducts { get; set; }
        public virtual ICollection<RawMaterialQC> RawMaterialQCs { get; set; }
        public virtual ICollection<ProdDateChange> ProdDateChanges { get; set; }
        public virtual ICollection<TPOLineScrap> TPOLineScraps { get; set; }
        public virtual ICollection<TPOReworkRoll> TPOReworkRolls { get; set; }
        public virtual ICollection<DownTime> DownTimes { get; set; }
        public virtual ICollection<WorkOrderShiftData> WorkOrderShiftDatas { get; set; }
        public virtual ICollection<WorkOrderShiftDataFormulation> WorkOrderShiftDataFormulations { get; set; }
        public virtual ICollection<TPOBatch> TPOBatches { get; set; }
        public virtual ICollection<SupervisorOnShift> SupervisorOnShifts { get; set; }
        public virtual ICollection<TPOReworkAction> TPOReworkActions { get; set; }
        public virtual ICollection<IMProd> IMProds { get; set; }
    }
}

﻿CREATE TABLE [dbo].[IMProd] (
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PlantID] [int] NOT NULL,
	[LineID] [int] NOT NULL,
	[ShiftID] [int] NOT NULL,
	[ProductionDate] [date] NOT NULL,
	[WorkOrderID] [int] NOT NULL,
	[IMProductID] [int] NOT NULL,
	[BatchID] [int] NULL,
	[IMQCID] [int] NULL,
	[Code] [nvarchar](15) NOT NULL,
	[PartsCarton] [int] NOT NULL,
	[CartonWeight] [float] NOT NULL,
	[WeightUoMID] [int] NOT NULL,
	[AdhesionManufacturesDate] [date] NULL,
	[Comment] [nvarchar](500) NULL,
	[DateEntered] [datetime] NOT NULL,
	[EnteredBy] [nvarchar](100) NOT NULL,
	[LastModified] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](100) NOT NULL,
	CONSTRAINT [PK_IMProd] PRIMARY KEY CLUSTERED ([ID] ASC), 
	CONSTRAINT [FK_IMProd_IMProducts] FOREIGN KEY([IMProductID]) REFERENCES [dbo].[IMProducts] ([ID]),
	CONSTRAINT [FK_IMProd_IMQC] FOREIGN KEY([IMQCID]) REFERENCES [dbo].[IMQC] ([ID]),
	CONSTRAINT [FK_IMProd_Plant] FOREIGN KEY([PlantID]) REFERENCES [dbo].[Plant] ([ID]),
	CONSTRAINT [FK_IMProd_ProdLines] FOREIGN KEY([LineID]) REFERENCES [dbo].[ProdLines] ([ID]),
	CONSTRAINT [FK_IMProd_ProductionShift] FOREIGN KEY([ShiftID]) REFERENCES [dbo].[ProductionShift] ([ID]),
	CONSTRAINT [FK_IMProd_UnitOfMeasure] FOREIGN KEY([WeightUoMID]) REFERENCES [dbo].[UnitOfMeasure] ([ID]),
	CONSTRAINT [FK_IMProd_WorkOrder] FOREIGN KEY([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([ID])

);


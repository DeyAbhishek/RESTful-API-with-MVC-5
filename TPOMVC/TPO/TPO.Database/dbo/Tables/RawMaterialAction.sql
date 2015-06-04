﻿CREATE TABLE [dbo].[RawMaterialAction] (
    [ID]               INT            IDENTITY (1, 1) NOT NULL,
    [PlantID]          INT            NOT NULL,
    [TypeID]           INT            NOT NULL,
    [ReasonID]         INT            NULL,
    [LineID]           INT            NULL,
    [WorkOrderID]      INT            NULL,
    [ShiftID]          INT            NULL,
    [UserID]           INT            NOT NULL,
    [LotNumber]        INT            NULL,
    [ProductionDate]   DATETIME       NULL,
    [Quantity]         FLOAT (53)     NOT NULL,
    [DateEntered]      DATETIME       NOT NULL,
    [EnteredBy]        NVARCHAR (100) NOT NULL,
    [LastModified]     DATETIME       NOT NULL,
    [ModifiedBy]       NVARCHAR (100) NOT NULL,
    [RawMaterialID]    INT            NOT NULL,
    [ActionReasonText] NVARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_RawMaterialAction_Plant] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[Plant] ([ID]),
    CONSTRAINT [FK_RawMaterialAction_ProdLines] FOREIGN KEY ([LineID]) REFERENCES [dbo].[ProdLines] ([ID]),
    CONSTRAINT [FK_RawMaterialAction_ProductionShift] FOREIGN KEY ([ShiftID]) REFERENCES [dbo].[ProductionShift] ([ID]),
    CONSTRAINT [FK_RawMaterialAction_RawMaterialActionReason] FOREIGN KEY ([ReasonID]) REFERENCES [dbo].[RawMaterialActionReason] ([ID]),
    CONSTRAINT [FK_RawMaterialAction_RawMaterialActionType] FOREIGN KEY ([TypeID]) REFERENCES [dbo].[RawMaterialActionType] ([ID]),
    CONSTRAINT [FK_RawMaterialAction_RawMaterials] FOREIGN KEY ([RawMaterialID]) REFERENCES [dbo].[RawMaterials] ([ID]),
    CONSTRAINT [FK_RawMaterialAction_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([ID]),
    CONSTRAINT [FK_RawMaterialAction_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([ID])
);


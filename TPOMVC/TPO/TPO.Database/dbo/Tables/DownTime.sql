﻿CREATE TABLE [dbo].[DownTime] (
    [ID]                       INT            IDENTITY (1, 1) NOT NULL,
    [PlantID]                  INT            NOT NULL,
    [LineID]                   INT            NOT NULL,
    [ProductID]                INT            NULL,
    [WorkOrderID]              INT            NOT NULL,
    [TypeID]                   INT            NOT NULL,
    [ReasonID]                 INT            NULL,
    [ShiftID]                  INT            NOT NULL,
    [EquipmentID]              INT            NULL,
    [DateOccurred]             DATETIME       NOT NULL,
    [Comment]                  NVARCHAR (MAX) NULL,
    [DateEntered]              DATETIME       NOT NULL,
    [EnteredBy]                NVARCHAR (100) NOT NULL,
    [LastModified]             DATETIME       NOT NULL,
    [ModifiedBy]               NVARCHAR (100) NOT NULL,
    [DownTimeEquipmentGroupID] INT            NULL,
    [DownTimeMinutes]          INT            NOT NULL,
    [ProductionDate]           DATE           DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_DownTime_DownTimeEquipment] FOREIGN KEY ([EquipmentID]) REFERENCES [dbo].[DownTimeEquipment] ([ID]),
    CONSTRAINT [FK_DownTime_DownTimeEquipmentGroup] FOREIGN KEY ([DownTimeEquipmentGroupID]) REFERENCES [dbo].[DownTimeEquipmentGroup] ([ID]),
    CONSTRAINT [FK_DownTime_DownTimeReason] FOREIGN KEY ([ReasonID]) REFERENCES [dbo].[DownTimeReason] ([ID]),
    CONSTRAINT [FK_DownTime_DownTimeType] FOREIGN KEY ([TypeID]) REFERENCES [dbo].[DownTimeType] ([ID]),
    CONSTRAINT [FK_DownTime_Plant] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[Plant] ([ID]),
    CONSTRAINT [FK_DownTime_ProdLine] FOREIGN KEY ([LineID]) REFERENCES [dbo].[ProdLines] ([ID]),
    CONSTRAINT [FK_DownTime_ProductionShiftType] FOREIGN KEY ([ShiftID]) REFERENCES [dbo].[ProductionShiftType] ([ID]),
    CONSTRAINT [FK_DownTime_TPOProducts] FOREIGN KEY ([ProductID]) REFERENCES [dbo].[TPOProducts] ([ID]),
    CONSTRAINT [FK_DownTime_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([ID])
);

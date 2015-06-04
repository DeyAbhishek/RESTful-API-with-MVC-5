﻿CREATE TABLE [dbo].[DownTimeReason] (
    [ID]             INT            IDENTITY (1, 1) NOT NULL,
    [PlantID]        INT            NOT NULL,
    [LineID]         INT            NULL,
    [DownTimeTypeID] INT            NOT NULL,
    [Description]    NVARCHAR (100) NOT NULL,
    [Scheduled]      BIT            NOT NULL,
    [SortOrder]      INT            DEFAULT ((0)) NOT NULL,
    [DateEntered]    DATETIME       NOT NULL,
    [EnteredBy]      NVARCHAR (100) NOT NULL,
    [LastModified]   DATETIME       NOT NULL,
    [ModifiedBy]     NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_DownTimeReason_DownTimeType] FOREIGN KEY ([DownTimeTypeID]) REFERENCES [dbo].[DownTimeType] ([ID]),
    CONSTRAINT [FK_DownTimeReason_Plant] FOREIGN KEY ([PlantID]) REFERENCES [dbo].[Plant] ([ID]),
    CONSTRAINT [FK_DownTimeReason_ProdLine] FOREIGN KEY ([LineID]) REFERENCES [dbo].[ProdLines] ([ID])
);

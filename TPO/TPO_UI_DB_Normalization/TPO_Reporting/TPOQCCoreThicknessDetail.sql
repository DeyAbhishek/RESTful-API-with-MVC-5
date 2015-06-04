﻿CREATE TABLE [dbo].[TPOQCCoreThicknessDetail]
(
	[TPOQCID] INT NOT NULL PRIMARY KEY, 
	[WidthUoMID] INT NOT NULL,
    [Thick1] FLOAT NULL, 
    [Thick2] FLOAT NULL, 
    [Thick3] FLOAT NULL, 
    [Thick4] NCHAR(10) NULL, 
    [Thick5] FLOAT NULL, 
    [Thick6] FLOAT NULL, 
    [Thick7] FLOAT NULL, 
    [Thick8] FLOAT NULL, 
    [Thick9] FLOAT NULL, 
    [Thick10] FLOAT NULL, 
    [Thick11] FLOAT NULL, 
    [DateEntered] DATETIME NOT NULL, 
    [EnteredBy] NVARCHAR(100) NOT NULL, 
    [LastModified] DATETIME NOT NULL, 
    [ModifiedBy] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_TPOQCCoreThicknessDetail_TPOQC] FOREIGN KEY ([TPOQCID]) REFERENCES [TPOQC]([ID]),
	CONSTRAINT [FK_TPOQCCoreThicknessDetail_WidthUnitOfMeasure] FOREIGN KEY ([WidthUoMID]) REFERENCES [UnitOfMeasure]([ID])
)

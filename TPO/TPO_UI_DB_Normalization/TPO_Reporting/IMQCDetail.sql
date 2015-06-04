﻿CREATE TABLE [dbo].[IMQCDetail]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IMQCID] INT NOT NULL, 
    [TestWeight] FLOAT NOT NULL, 
    [Thick1] FLOAT NULL, 
    [Thick2] FLOAT NULL, 
    [Thick3] FLOAT NULL, 
    [Thick4] NCHAR(10) NULL, 
    [ColorL] FLOAT NULL, 
    [ColorDE] FLOAT NULL, 
	[DateEntered] DATETIME NOT NULL,
	[EnteredBy] NVARCHAR(100) NOT NULL,
    [LastModified] DATETIME NOT NULL, 
    [ModifiedBy] NVARCHAR(100) NOT NULL, 
    CONSTRAINT [FK_IMQCDetail_IMQC] FOREIGN KEY ([IMQCID]) REFERENCES [IMQC]([ID])
)

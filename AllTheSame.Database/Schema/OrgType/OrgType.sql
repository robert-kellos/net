﻿CREATE TABLE [dbo].[OrgType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Label] NVARCHAR(50) NULL, 
    [Code] CHAR(50) NOT NULL, 
    [CreatedOn] DATETIME NULL DEFAULT GETUTCDATE(), 
    [UpdatedOn] DATETIME NULL
)
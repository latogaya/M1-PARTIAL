﻿CREATE TABLE [dbo].[RAM]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(MAX) NOT NULL, 
    [Code] NVARCHAR(MAX) NOT NULL, 
    [Brand] NVARCHAR(MAX) NOT NULL, 
    [UnitPrice] DECIMAL(10, 2) NOT NULL
)

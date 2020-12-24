CREATE TABLE [dbo].[livre]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [code] VARCHAR(50) NULL, 
    [titre] VARCHAR(50) NULL, 
    [prix] FLOAT NULL
)

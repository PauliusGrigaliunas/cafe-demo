CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Cafe] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Free Tables] INT NOT NULL, 
    [rating] INT NULL, 
    [comments] NVARCHAR(MAX) NULL
)

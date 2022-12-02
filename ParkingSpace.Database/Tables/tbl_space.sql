CREATE TABLE [dbo].[tbl_space]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Symbol] NVARCHAR(50) NULL, 
    [Width] INT NULL, 
    [Height] INT NULL, 
)

CREATE TABLE [dbo].[tbl_car]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Model] INT NULL, 
    [Version] NVARCHAR(50) NULL, 
    [Color] NVARCHAR(50) NULL, 
    [Width] NVARCHAR(50) NULL, 
    [Height] NVARCHAR(50) NULL, 
)

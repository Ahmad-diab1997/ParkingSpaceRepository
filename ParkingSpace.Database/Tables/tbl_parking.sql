CREATE TABLE [dbo].[tbl_parking]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Symbol] NVARCHAR(50) NULL, 
    [ParkingType] NVARCHAR(50) NULL, 
    [Width] INT NULL, 
    [Height] INT NULL, 
    [PricePerHour] INT NULL, 
)

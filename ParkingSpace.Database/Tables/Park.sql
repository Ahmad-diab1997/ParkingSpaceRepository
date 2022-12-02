CREATE TABLE [dbo].[Park]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] UNIQUEIDENTIFIER NULL, 
    [CarId] UNIQUEIDENTIFIER NULL, 
    [ParkingId] UNIQUEIDENTIFIER NULL, 
    [SpaceId] UNIQUEIDENTIFIER NULL, 
    [StartDate] DATETIME NULL, 
    [EndDate] DATETIME NULL, 
    [ParkUnpark] INT NULL, 
    CONSTRAINT [FK_Park_ToCar] FOREIGN KEY ([CarId]) REFERENCES [tbl_car]([Id]), 
    CONSTRAINT [FK_Park_ToUser] FOREIGN KEY ([UserId]) REFERENCES [tbl_user]([Id]), 
    CONSTRAINT [FK_Park_ToParking] FOREIGN KEY ([ParkingId]) REFERENCES [tbl_parking]([Id]), 
    CONSTRAINT [FK_Park_ToSpace] FOREIGN KEY ([SpaceId]) REFERENCES [tbl_space]([Id])
)

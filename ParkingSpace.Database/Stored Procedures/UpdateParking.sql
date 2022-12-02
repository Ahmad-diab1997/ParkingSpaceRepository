CREATE PROCEDURE [dbo].[UpdateParking]
 @Id  uniqueidentifier,  
 @Name nvarchar(50),  
 @Symbol nvarchar(50),  
 @ParkingType nvarchar(50),  
 @Width int,  
 @Height int, 
 @PricePerHour int   
AS
 BEGIN  

 update tbl_parking
 set Name = @Name, Symbol = @Symbol , ParkingType = @ParkingType , Width = @width ,Height = @Height , PricePerHour = @PricePerHour
 where Id = @Id
 
 END

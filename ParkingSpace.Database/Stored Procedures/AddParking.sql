CREATE PROCEDURE [dbo].[AddParking]
 @Id  uniqueidentifier,  
 @Name nvarchar(50),  
 @Symbol nvarchar(50),  
 @ParkingType nvarchar(50),  
 @Width int,  
 @Height int, 
 @PricePerColor int  

AS
 BEGIN 
 Insert into tbl_parking(Name,Symbol,ParkingType,Width,Height,PricePerHour)  
 values(@Name,@Symbol,@ParkingType,@Width,@Height,@PricePerColor)  
 END
         
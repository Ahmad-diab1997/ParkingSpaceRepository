CREATE PROCEDURE [dbo].[UpdateCar]
 @id uniqueidentifier,
 @Model  int,  
 @Version nvarchar(50),  
 @Color nvarchar(50),  
 @Width int,
 @Height int
 
AS
 BEGIN 
 

 update tbl_car
 set Id = @id,Model = @Model , Version = @Version
 where Id = @id

 END

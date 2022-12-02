CREATE PROCEDURE [dbo].[AddCar]
 @Id  uniqueidentifier,
 @Model   int,  
 @Version nvarchar(50),  
 @Color datetime,  
 @Width nvarchar(50),
 @Height nvarchar(50)

AS
 BEGIN 
 Insert into tbl_car(Id,Model,Version,Color,Width,Height)  
 values(@Id,@Model,@Version,@Color,@Width,@Height)  
 END
      
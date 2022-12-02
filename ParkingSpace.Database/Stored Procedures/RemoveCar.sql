CREATE PROCEDURE [dbo].[RemoveCar]
 @id uniqueidentifier 

AS
 BEGIN 
  delete from tbl_car where id = @id 
 END
CREATE PROCEDURE [dbo].[RemoveUser]
 @id uniqueidentifier 

AS
 BEGIN 
  delete from tbl_user where Id = @id 
 END
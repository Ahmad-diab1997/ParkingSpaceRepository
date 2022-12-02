CREATE PROCEDURE [dbo].[RemoveSpace]
 @Id uniqueidentifier 

AS
 BEGIN 
  delete from tbl_space where Id = @Id 
 END

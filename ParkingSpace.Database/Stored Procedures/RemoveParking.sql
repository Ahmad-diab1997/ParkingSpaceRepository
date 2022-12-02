CREATE PROCEDURE [dbo].[DeleteStudent]
 @Id uniqueidentifier 

AS
 BEGIN 
  delete from tbl_parking where Id = @Id 
 END

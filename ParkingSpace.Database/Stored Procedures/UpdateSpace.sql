CREATE PROCEDURE [dbo].[UpdateSpace]
 @Id  uniqueidentifier,  
 @Symbol nvarchar(50),  
 @Width int,  
 @Height int   
AS
 BEGIN  

 update tbl_space
 set Symbol = @Symbol , Width = @width ,Height = @Height
 where Id = @Id
 
 END



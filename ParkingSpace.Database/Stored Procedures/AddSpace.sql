CREATE PROCEDURE [dbo].[AddSpace]
 @Id  uniqueidentifier,  
 @Symbol nvarchar(50),  
 @Width int,  
 @Height int 

AS
 BEGIN 
 Insert into tbl_space(Symbol,Width,Height)  
 values(@Symbol,@Width,@Height)  
 END
         
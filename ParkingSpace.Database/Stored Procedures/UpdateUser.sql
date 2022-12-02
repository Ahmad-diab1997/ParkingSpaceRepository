CREATE PROCEDURE [dbo].[UpdateUser]
 @id uniqueidentifier,
 @FirstName  nvarchar(50),  
 @LastName nvarchar(50),  
 @Money int
 
AS
 BEGIN 
 

 update tbl_user
 set Id = @id,FirstName = @FirstName , LastName = @LastName
 where Id = @id

 END

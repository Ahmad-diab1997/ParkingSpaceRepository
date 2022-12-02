CREATE PROCEDURE [dbo].[AddUser]
 @Id  uniqueidentifier,
 @FirstName  nvarchar(50),  
 @LastName nvarchar(50),  
 @Money int

AS
 BEGIN 
 Insert into tbl_user(Id,FirstName,LastName,Money)  
 values(@Id,@FirstName,@LastName,@Money)  
 END
      
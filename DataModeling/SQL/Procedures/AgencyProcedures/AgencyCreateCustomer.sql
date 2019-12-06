CREATE OR ALTER PROCEDURE Agency.CreateCustomer
   @Budget FLOAT,
   @Phone NVARCHAR(30),
   @Name NVARCHAR(20),
   @Age INT,
   @Sex NVARCHAR(10),
   @CustomerID INT OUTPUT
  
AS
INSERT Agency.Customer([Budget], Phone, [Name], Age, Sex)
VALUES(@Budget,@Phone,@Name, @Age, @Sex)

SET @ContactID = SCOPE_IDENTITY();
GO

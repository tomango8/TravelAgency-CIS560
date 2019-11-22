


CREATE OR ALTER PROCEDURE Agency.CreateCustomer
   @CustomerID INT OUTPUT,
   @Budget FLOAT,
   @Name NVARCHAR(100),
   @Age INT,
   @Sex NVARCHAR(100),
   @ContactID INT,
   @IsDeleted BIT
AS

INSERT Agency.Customer(Budget, [Name], Age, Sex, ContactID, IsDeleted)
VALUES(@Budget, @tName, @Age, @Sex, @ContactID, @IsDeleted);

SET @CustomerID = SCOPE_IDENTITY();
GO

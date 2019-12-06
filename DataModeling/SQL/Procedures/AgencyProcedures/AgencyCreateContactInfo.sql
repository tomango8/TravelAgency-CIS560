CREATE OR ALTER PROCEDURE Agency.CreateContactInfo
   @Address NVARCHAR(200),
   @Phone NVARCHAR(30),
   @Email NVARCHAR(20),
   @CityID INT,
   @CustomerID INT
  
AS
INSERT Agency.ContactInfo([Address], Phone, Email, CityID, CustomerID)
VALUES([Address], Phone, Email, CityID, CustomerID);

SET @CustomerID = SCOPE_IDENTITY();
GO

CREATE OR ALTER PROCEDURE Agency.CreateContactInfo
   @Address NVARCHAR(200),
   @Phone NVARCHAR(30),
   @Email NVARCHAR(20),
   @CityID INT,
   @ContactID INT OUTPUT
  
AS
INSERT Agency.ContactInfo([Address], Phone, Email, CityID)
VALUES([Address], Phone, Email, CityID)

SET @ContactID = SCOPE_IDENTITY();
GO

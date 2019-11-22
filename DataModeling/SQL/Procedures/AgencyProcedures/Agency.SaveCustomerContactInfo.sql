CREATE OR ALTER PROCEDURE Agency.SaveCustomerContactInfo
   @ContactID INT,
   @BillingAddress NVARCHAR(100),
   @Phone INT,
   @Email NVARCHAR(100),
   @CityID INT
AS

MERGE Agency.ContactInfo CI
USING
      (
         VALUES(@ContactID, @BillingAddress, @Phone, @Email, @CityID)
      ) S(ContactID, BillingAddress, Phone, Email, CityID)
   ON S.ContactID = CI.ContactID
WHEN MATCHED AND NOT EXISTS
      (
         SELECT S.BillingAddress, S.Phone, S.Email, S.CityID
         INTERSECT
         SELECT  T.BillingAddress, T.Phone, T.Email, T.CityID
      ) THEN
   UPDATE
   SET
      BillingAddress = S.BillingAddress,
      Phone = S.Phone,
      Email = S.Email,
      CityID = S.CityID
WHEN NOT MATCHED THEN
   INSERT(ContactID, BillingAddress, Phone, Email, CityID)
   VALUES(S.ContactID, S.BillingAddress, S.Phone, S.Email, S.CityID);
GO

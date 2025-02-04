﻿CREATE OR ALTER PROCEDURE Agency.SaveCustomerContactInfo
   @ContactID INT,
   @BillingAddress NVARCHAR(200),
   @Phone NVARCHAR(30),
   @Email NVARCHAR(120),
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
         SELECT  CI.BillingAddress, CI.Phone, CI.Email, CI.CityID
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

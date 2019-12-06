--search for customer by their customer ID
USE TravelAgency;
GO
CREATE OR ALTER PROCEDURE Agency.GetCustomer
   @CustomerID INT
AS

SELECT C.[Name], C.Budget, C.Age, C.Sex, C.ContactID
FROM Agency.Customer C
WHERE C.CustomerID = @CustomerID
AND C.IsDeleted = 0;
GO

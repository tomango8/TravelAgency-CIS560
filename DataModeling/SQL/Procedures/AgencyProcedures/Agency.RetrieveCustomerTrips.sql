CREATE OR ALTER PROCEDURE Agency.RetrieveCustomerTrips
 @CustomerID INT
AS 

SELECT T.TripID
FROM Agency.Trips T
WHERE @CustomerID = T.CustomerID
GO
CREATE OR ALTER PROCEDURE Agency.RetrieveCustomerTrips
 @CustomerID INT
AS 

SELECT T.TripID, T.CustomerID, T.DateCreated, T.AgentID
FROM Agency.Trips T
WHERE @CustomerID = T.CustomerID
AND T.IsDeleted = 0;
GO
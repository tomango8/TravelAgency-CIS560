CREATE OR ALTER PROCEDURE Agency.RetrieveAgentTrips
 @AgentID INT
AS 

SELECT T.TripID, T.CustomerID, T.DateCreated, T.AgentID
FROM Agency.Trips T
WHERE @AgentID = T.AgentID
AND T.IsDeleted = 0;
GO
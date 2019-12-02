CREATE OR ALTER PROCEDURE Agency.RetrieveAgentTrips
 @AgentID INT
AS 

SELECT T.TripID
FROM Agency.Trips T
WHERE @AgentID = T.AgentID
GO
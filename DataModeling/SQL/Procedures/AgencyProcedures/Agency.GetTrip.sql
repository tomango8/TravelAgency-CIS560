USE TravelAgency;
GO
CREATE OR ALTER PROCEDURE Agency.GetTrip
	@AgentID INT,
	@CustomerID INT
AS
SELECT T.TripID, T.CustomerID, T.DateCreated, T.AgentID
FROM Agency.Trips T
WHERE T.AgentID = @AgentID AND
	T.CustomerID = @CustomerID AND
	T.IsDeleted != 1;
GO
CREATE OR ALTER PROCEDURE Agency.CreateTrip
	@TripID INT OUTPUT,
	@CustomerID INT,
	@AgentID INT
AS

INSERT Agency.Trips(CustomerID, AgentID)
VALUES (@CustomerID, @AgentID)
SET @TripID = SCOPE_IDENTITY();
GO
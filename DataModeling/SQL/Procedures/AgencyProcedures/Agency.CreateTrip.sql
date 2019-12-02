CREATE OR ALTER PROCEDURE Agency.CreateTrip
	@TripID INT OUTPUT,
	@CustomerID INT,
	@IsDeleted BIT,
	@DateCreated DATE,
	@AgentID INT
AS

INSERT Agency.Trips(CustomerID, IsDeleted, DateCreated, AgentID)
VALUES (@CustomerID, @IsDeleted, @DateCreated, @AgentID)
SET @TripID = SCOPE_IDENTITY();
GO
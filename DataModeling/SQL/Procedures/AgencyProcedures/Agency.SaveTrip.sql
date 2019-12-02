CREATE OR ALTER PROCEDURE Agency.SaveTrip
   @TripID INT,
   @CustomerID INT,
   @IsDeleted BIT,
   @DateCreated DATE,
   @AgentID INT
AS

MERGE Agency.Trips T
USING (
		VALUES(@TripID, @CustomerID, @IsDeleted, @DateCreated, @AgentID)
		) S (TripID, CustomerID, IsDeleted, DateCreated, AgentID)
		ON S.TripID = T.TripID
	WHEN MATCHED AND NOT EXISTS
		(
			SELECT S.CustomerID, S.IsDeleted, S.DateCreated, S.AgentID
			INTERSECT
			SELECT T.CustomerID, T.IsDeleted, T.DateCreated, T.AgentID
		) THEN
		UPDATE
		SET
		CustomerID = S.CustomerID,
		IsDeleted = S.IsDeleted,
		DateCreated = S.DateCreated,
		AgentID = S.AgentID
	WHEN NOT MATCHED THEN
	INSERT(TripID, CustomerID, IsDeleted, DateCreated, AgentID)
	VALUES (S.TripID, S.CustomerID, S.IsDeleted, S.DateCreated, S.AgentID)
GO
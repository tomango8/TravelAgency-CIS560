CREATE OR ALTER PROCEDURE Airlines.CreateBoardingPass
	@ReservationID INT OUTPUT,
	@FlightID INT,
	@Price FLOAT
AS
INSERT Airlines.BoardingPass(Price, FlightID)
VALUES(@Price, @FlightID)

SET @ReservationID = SCOPE_IDENTITY();
GO
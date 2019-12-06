CREATE OR ALTER PROCEDURE Airlines.CreateBoardingPass
	@ReservationID INT OUTPUT,
	@FlightID INT,
	@Price FLOAT
AS
INSERT Airlines.BoardingPass(ReservationID, Price, FlightID)
VALUES(@ReservationID, @Price, @FlightID)

SET @ReservationID = SCOPE_IDENTITY();
GO
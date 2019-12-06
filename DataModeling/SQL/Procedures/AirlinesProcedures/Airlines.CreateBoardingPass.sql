CREATE OR ALTER PROCEDURE Airlines.CreateBoardingPass
	@ReservationID INT,
	@FlightID INT,
	@Price FLOAT
AS
INSERT Airlines.BoardingPass(ReservationID, Price, FlightID)
VALUES(@ReservationID, @Price, @FlightID)
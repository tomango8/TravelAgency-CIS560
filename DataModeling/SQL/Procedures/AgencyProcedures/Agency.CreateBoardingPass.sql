CREATE OR ALTER PROCEDURE Agency.CreateBoardingPass
	@ReservationID INT,
	@FlightID INT,
	@Price FLOAT

AS
INSERT Airlines.BoardingPass(ReservationID, FlightID, Price)
	VALUES(@ReservationID, @FlightID, @Price);
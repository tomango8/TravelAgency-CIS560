CREATE OR ALTER PROCEDURE Agency.CreateBoardingPass
	@ReservationID INT,
	@FlightID INT,
	@Price FLOAT

AS
INSERT Airlines.BoardingPass(ReservationID, CheckinDate, Price)
	VALUES(@ReservationID, @FlightID, @Price);
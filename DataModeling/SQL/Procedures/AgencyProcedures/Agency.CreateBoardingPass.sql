CREATE OR ALTER PROCEDURE Agency.CreateBoardingPass
	@ReservationID INT OUTPUT,
	@FlightID INT,
	@Price FLOAT

AS
INSERT Airlines.BoardingPass(HotelID, CheckinDate, Price)
	VALUES(@HotelID, @CheckinDate, @Price)

SET @ReservationID = SCOPE_IDENTITY();
GO
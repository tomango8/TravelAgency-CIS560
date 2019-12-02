CREATE OR ALTER PROCEDURE Agency.CreateHotelReservation
	@ReservationID INT OUTPUT,
	@HotelID INT,
	@CheckinDate DATE,
	@Price FLOAT
AS
INSERT Hotels.HotelReservation(HotelID, CheckinDate, Price)
	VALUES(@HotelID, @CheckinDate, @Price)

SET @ReservationID = SCOPE_IDENTITY();
GO
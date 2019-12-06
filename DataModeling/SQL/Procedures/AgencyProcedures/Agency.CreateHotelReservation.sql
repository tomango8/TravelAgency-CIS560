CREATE OR ALTER PROCEDURE Agency.CreateHotelReservation
	@ReservationID INT,
	@HotelID INT,
	@CheckinDate DATE,
	@Price FLOAT
AS
INSERT Hotels.HotelReservation(HotelID, CheckInDate, Price)
	VALUES(@HotelID, @CheckinDate, @Price);
	
SET @ReservationID = SCOPE_IDENTITY();
GO


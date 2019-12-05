CREATE OR ALTER PROCEDURE Agency.CreateHotelReservation
	@ReservationID INT,
	@HotelID INT,
	@CheckinDate DATE,
	@Price FLOAT
AS
INSERT Hotels.HotelReservation(HotelID, CheckinDate, Price)
	VALUES(@HotelID, @CheckinDate, @Price);

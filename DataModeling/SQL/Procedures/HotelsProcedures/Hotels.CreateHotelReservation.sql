CREATE OR ALTER PROCEDURE Hotels.CreateHotelReservation
	@ReservationID INT OUTPUT,
	@HotelID INT,
	@DateofReservation DATE,
	@Price FLOAT
AS
INSERT Hotels.HotelReservation(HotelID, DateOfReservation, Price)
	VALUES(@HotelID, @DateOfReservation, @Price)

SET @ReservationID = SCOPE_IDENTITY();
GO
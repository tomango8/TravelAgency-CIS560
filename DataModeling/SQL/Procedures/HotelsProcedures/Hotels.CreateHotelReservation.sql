CREATE OR ALTER PROCEDURE Hotels.CreateHotelReservation
	@ReservationID INT OUTPUT,
	@HotelID INT,
	@DateofReservation DATE,
	@Price FLOAT,
	@TripID INT
AS
INSERT Agency.Reservation(TripID, IsDeleted, CarReservation, BoardingPass, AttractionTicket, RestaurantReservation)
	VALUES(@TripID, 0, 0, 0, 0, 1)
INSERT Hotels.HotelReservation(HotelID, DateOfReservation, Price)
	VALUES(@HotelID, @DateOfReservation, @Price)

SET @ReservationID = SCOPE_IDENTITY();
GO
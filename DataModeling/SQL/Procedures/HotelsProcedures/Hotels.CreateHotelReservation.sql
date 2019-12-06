CREATE OR ALTER PROCEDURE Hotels.CreateHotelReservation
	@ReservationID INT OUTPUT,
	@HotelID INT,
	@CheckInDate DATE,
	@Price FLOAT,
	@TripID INT
AS
INSERT Agency.Reservations(TripID, IsDeleted, CarReservation, BoardingPass, AttractionTicket, RestaurantReservation)
	VALUES(@TripID, 0, 0, 0, 0, 1)
SET @ReservationID = SCOPE_IDENTITY()
INSERT Hotels.HotelReservation(ReservationID, HotelID, CheckInDate, Price)
	VALUES(@ReservationID, @HotelID, @CheckInDate, @Price);
GO
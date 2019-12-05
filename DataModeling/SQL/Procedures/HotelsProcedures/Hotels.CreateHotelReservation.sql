CREATE OR ALTER PROCEDURE Hotels.CreateHotelReservation
	@ReservationID INT OUTPUT,
	@HotelID INT,
	@DateofReservation DATE,
	@Price FLOAT,
	@TripID INT
AS
INSERT Agency.Reservation(TripID, IsDeleted, CarReservation, BoardingPass, AttractionTicket, RestaurantReservation)
	VALUES(@TripID, 0, 0, 0, 0, 1)
SET @ReservationID = SCOPE_IDENTITY()
INSERT Hotels.HotelReservation(ReservationID, HotelID, DateOfReservation, Price)
	VALUES(@ReservationID, @HotelID, @DateOfReservation, @Price);
GO
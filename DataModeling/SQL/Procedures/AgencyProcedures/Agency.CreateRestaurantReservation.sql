CREATE OR ALTER PROCEDURE Agency.CreateRestaurantReservation
	@ReservationID INT OUTPUT,
	@ReservationDate DATE,
	@RestaurantID INT,
	@ReservationTime TIME
AS
INSERT Restaurant.RestaurantReservation(RestaurantDate, RestaurantID, ReservationTime)
	VALUES(@ReservationDate, @RestaurantID, @ReservationTime)

SET @ReservationID = SCOPE_IDENTITY();
GO
CREATE OR ALTER PROCEDURE Agency.CreateRestaurantReservation
	@ReservationID INT,
	@ReservationDate DATETIME,
	@RestaurantID INT	
AS
INSERT Restaurant.RestaurantReservation(ReservationID, RestaurantDate, RestaurantID)
	VALUES(@ReservationID, @ReservationDate, @RestaurantID)

SET @ReservationID = SCOPE_IDENTITY();
GO
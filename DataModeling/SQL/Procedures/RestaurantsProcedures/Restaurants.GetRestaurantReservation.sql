CREATE OR ALTER PROCEDURE Restaurants.GetRestaurantReservation
	@ReservationID INT
AS

SELECT ReservationID, ReservationDate, RestaurantID, ReservationTime
FROM Restaurants.RestaurantReservation
WHERE ReservationID = @ReservationID;
GO
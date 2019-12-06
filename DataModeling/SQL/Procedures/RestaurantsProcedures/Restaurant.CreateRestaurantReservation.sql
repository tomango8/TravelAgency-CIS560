CREATE OR ALTER PROCEDURE Restaurants.CreateRestaurantReservation
 @ReservationID INT,
 @ReservationDate INT, 
 @RestaurantID INT
AS

INSERT Restaurants.Restaurant(ReservationID,ReservationDate,RestaurantID)
VALUES (@ReservationID,@ReservationDate,@RestaurantID);

GO

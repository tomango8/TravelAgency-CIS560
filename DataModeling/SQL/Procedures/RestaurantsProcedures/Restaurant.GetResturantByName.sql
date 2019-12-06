CREATE OR ALTER PROCEDURE Restaurants.GetRestaurant
	@RestaurantName NVARCHAR(120),
	@CityID INT

AS

SELECT RestaurantID
FROM Restaurants.Restaurant
WHERE @RestaurantName = RestaurantName and @CityID = CityID
GO
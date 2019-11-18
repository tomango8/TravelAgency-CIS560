CREATE OR ALTER PROCEDURE Hotels.GetHotel
	@HotelID
AS

SELECT HO.[Name], HO.CityID, HO.FullAddress
FROM Hotels.Hotel HO
WHERE HO.HotelID = @HotelID
GO
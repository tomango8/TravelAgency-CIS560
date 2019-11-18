CREATE OR ALTER PROCEDURE Hotels.CreateHotel
	@HotelID INT OUTPUT,
	@Name NVARCHAR(100),
	@CityID INT,
	@FullAddress NVARCHAR(100)
AS

INSERT Hotels.Hotel(Name, CityID, FullAddress)
	VALUES(@Name, @CityID, @FullAddress)

SET @HotelID = SCOPE_IDENTITY();
GO
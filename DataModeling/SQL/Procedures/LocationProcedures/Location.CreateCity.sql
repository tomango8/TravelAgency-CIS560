CREATE OR ALTER PROCEDURE [Location].CreateCity
	@CityID INT OUTPUT,
	@CityName NVARCHAR(100),
	@Region NVARCHAR(100),
	@Country NVARCHAR(100)
AS

INSERT [Location].Cities(CityName, Region, Country)
	VALUES(@CityName, @Region, @Country)

SET @CityID = SCOPE_IDENTITY();
GO
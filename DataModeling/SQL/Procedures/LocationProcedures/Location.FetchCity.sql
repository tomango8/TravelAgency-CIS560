CREATE OR ALTER PROCEDURE Hotels.FetchCity
	@CityID INT
AS

SELECT C.[Name], C.Country, C.Region
FROM [Location].Cities C
WHERE C.CityID = @CityID
GO
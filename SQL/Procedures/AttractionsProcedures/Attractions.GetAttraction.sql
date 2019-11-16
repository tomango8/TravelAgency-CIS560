CREATE OR ALTER PROCEDURE Attractions.GetAttraction
	@AttractionID INT
AS

SELECT AttractionID, [Name], CityID
FROM Attractions.Attraction
WHERE AttractionID = @AttractionID;
GO
CREATE OR ALTER PROCEDURE Attractions.CreateAttraction
	@Name NVARCHAR(100),
	@CityID INT,
	@AttractionID INT OUTPUT
AS

INSERT Attractions.Attraction([Name], CityID)
VALUES(@Name, @CityID);

SET @AttractionID = SCOPE_IDENTITY();
GO
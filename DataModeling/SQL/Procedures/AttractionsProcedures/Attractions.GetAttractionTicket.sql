CREATE OR ALTER PROCEDURE Attractions.GetAttractionTicket
	@ReservationID INT
AS

SELECT ReservationID, AttractionID, DateForTicket, Price
FROM Attractions.AttractionTicket
WHERE ReservationID = @ReservationID;
GO
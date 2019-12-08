USE TravelAgency;
GO
CREATE OR ALTER PROC Agency.TopTenAttractions AS
WITH attraction AS 
(
SELECT A.AttractionID, COUNT(T.CustomerID) AS Customers, C.CityName, C.Country 
FROM Attractions.Attraction A
	INNER JOIN Attractions.AttractionTicket [AT] ON AT.AttractionID = A.AttractionID
	INNER JOIN [Location].Cities C ON C.CityID = A.CityID
	INNER JOIN Agency.Reservations R ON R.ReservationID = [AT].ReservationID
	INNER JOIN Agency.Trips T ON T.TripID = R.TripID
	INNER JOIN Hotels.HotelReservation HR ON HR.ReservationID = R.ReservationID
	INNER JOIN Hotels.Hotel H ON HR.HotelID = H.HotelID
GROUP BY A.AttractionID, COUNT(T.CustomerID), C.CityName, C.Country
)
SELECT TOP 10 AttractionID, CityName, Country
FROM attraction A
ORDER BY Customers DESC;

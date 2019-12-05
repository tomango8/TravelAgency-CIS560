CREATE OR ALTER PROC ReportQuery4.CheapestOptions
SELECT A.AttractionID, COUNT(T.CustomerID) AS Customers, C.CityName, C.Country, [AT].Price, H.[Name]
FROM Attractions.Attraction A
	INNER JOIN Attractions.AttractionTicket [AT] ON AT.AttractionID = A.AttractionID
	INNER JOIN Locations.Cities C ON C.CityID = A.CityID
	INNER JOIN Agency.Reservations R ON R.ReservationID = [AT].ReservationID
	INNER JOIN Agency.Trips T ON T.TripID = R.TripID
	INNER JOIN Hotels.HotelReservation HR ON HR.ReservationID = R.ReservationID
	INNER JOIN Hotels.Hotel H ON HR.HotelID = H.HotelID
WHERE MAX
ORDER BY Customers DESC
LIMIT 10;



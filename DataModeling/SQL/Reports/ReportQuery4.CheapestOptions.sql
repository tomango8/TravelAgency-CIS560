CREATE OR ALTER PROC ReportQuery4.CheapestOptions
AS
SELECT CityID, CityName, Region, Country,
	IFF(HR.Price = MIN(HR.Price), H.[Name], ' ') AS CheapestHotel,
	MIN(HR.Price) AS CheapestHotelPrice,
	IFF(ATi.Price = MIN(ATi.Price), A.[Name], ' ') AS CheapestAttraction,
	MIN(ATi.Price) AS CheapestAttractionPrice,
	IFF(CRR.Price = MIN(CRR.Price), CRR.[Name], ' ') AS CheapestModelCarRentalPlace,
	IFF(CRR.Price = MIN(CRR.Price), CRR.Model, ' ') AS CheapestModel,
	MIN(CRR.Price) AS CheapestCar
FROM [Location].Cities LC 
	LEFT JOIN Hotel.Hotel H ON LC.CityID = H.CityID
	LEFT JOIN Attractions.Attractions A ON LC.CityID = A.CityID
	LEFT JOIN Hotels.HotelReservation HR ON HR.HotelID = H.HotelID
	LEFT JOIN Attractions.AttractionTicket ATi ON ATi.AttractionID = A.AttractionID
	LEFT JOIN Cars.CarRental CR ON CR.CityID = LC.CityID
	LEFT JOIN Cars.CarRentalReservation CRR ON CRR.CarRentalID = CR.CarRentalID
GROUP BY CityID, CityName, Region, Country
ORDER BY CityID ASC;


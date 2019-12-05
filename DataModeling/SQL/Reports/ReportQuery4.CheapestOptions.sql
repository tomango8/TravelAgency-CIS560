USE TravelAgency;
GO
CREATE OR ALTER PROC Agency.CheapestOptions
AS
SELECT LC.CityID, LC.CityName, LC.Region, LC.Country,
	IIF(HR.Price = MIN(HR.Price), H.[Name], ' ') AS CheapestHotel,
	MIN(HR.Price) AS CheapestHotelPrice,
	IIF(ATi.Price = MIN(ATi.Price), A.[Name], ' ') AS CheapestAttraction,
	MIN(ATi.Price) AS CheapestAttractionPrice,
	IIF(CRR.Price = MIN(CRR.Price), CR.AgencyName, ' ') AS CheapestModelCarRentalAgency,
	IIF(CRR.Price = MIN(CRR.Price), CRR.Model, ' ') AS CheapestModel,
	MIN(CRR.Price) AS CheapestCar
FROM [Location].Cities LC 
	LEFT JOIN Hotels.Hotel H ON LC.CityID = H.CityID
	LEFT JOIN Attractions.Attraction A ON LC.CityID = A.CityID
	LEFT JOIN Hotels.HotelReservation HR ON HR.HotelID = H.HotelID
	LEFT JOIN Attractions.AttractionTicket ATi ON ATi.AttractionID = A.AttractionID
	LEFT JOIN Cars.CarRental CR ON CR.CityID = LC.CityID
	LEFT JOIN Cars.CarRentalReservation CRR ON CRR.CarRentalID = CR.CarRentalID
GROUP BY LC.CityID, LC.CityName, LC.Region, LC.Country, HR.Price, H.[Name], Ati.Price, A.[Name], CRR.Price, CR.AgencyName, CRR.Model
ORDER BY CityID ASC;


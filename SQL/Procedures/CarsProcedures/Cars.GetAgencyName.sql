CREATE OR ALTER PROCEDURE Cars.GetAttraction
	@ReservationID INT
AS

SELECT CC.CarRentalID, CC.AgencyName, CC.CityID
FROM Cars.CarRentalReservation CR
INNER JOIN Cars.CarRental CC ON CC.CarRentalID =  CR.CarRentalID
GO
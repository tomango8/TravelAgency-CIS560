CREATE OR ALTER PROCEDURE Cars.GetAgencyByID
	@CarRentalID INT
AS

SELECT  CC.AgencyName, CC.CityID
FROM  Cars.CarRental CC 
where CC.CarRental = @CarRental
GO
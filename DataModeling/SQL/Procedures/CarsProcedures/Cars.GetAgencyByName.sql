CREATE OR ALTER PROCEDURE Cars.GetAgencyByID
	@AgencyName NVARCHAR(120),
	@CityID  int
AS

SELECT  CC.CarRentalID
FROM  Cars.CarRental CC 
where CC.AgencyName = @AgencyName and @CityID = CC.CityID
GO
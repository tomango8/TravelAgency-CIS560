CREATE OR ALTER PROCEDURE Cars.CreateCarRental
	@CarRentalID INT OUTPUT,
	@AgencyName NVARCHAR(100),
	@CityID INT
AS

INSERT Cars.CarRental(AgencyName, CityID)
VALUES (@AgencyName, @CityID)

SET @CarRentalID = SCOPE_IDENTITY();
GO
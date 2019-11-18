CREATE OR ALTER PROCEDURE Cars.GetAttraction
	@ReservationID INT
AS

SELECT ReservationID, CarRentalID, RentalDate,Model,Price
FROM Cars.CarRentalReservation 
GO
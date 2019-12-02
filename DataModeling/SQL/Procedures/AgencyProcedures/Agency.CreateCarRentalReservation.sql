CREATE OR ALTER PROCEDURE Cars.CarRentalReservation
	@ReservationID INT OUTPUT,
	@CarRentalID INT,
	@RentalDate DATE,
	@Model NVARCHAR(100),
	@Price FLOAT

AS
INSERT Cars.CarRentalReservation(CarRentalID, RentalDate, Model, Price)
	VALUES(@HoCarRentalID, @RentalDate, @Model, @Price)

SET @ReservationID = SCOPE_IDENTITY();
GO
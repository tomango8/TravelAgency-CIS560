﻿USE TravelAgency;
GO
CREATE OR ALTER PROCEDURE Agency.CarRentalReservation
	@ReservationID INT,
	@CarRentalID INT,
	@RentalDate DATE,
	@Model NVARCHAR(120),
	@Price FLOAT

AS
INSERT Cars.CarRentalReservation(ReservationID, CarRentalID, RentalDate, Model, Price)
	VALUES(@ReservationID, @CarRentalID, @RentalDate, @Model, @Price)
	
SET @ReservationID = SCOPE_IDENTITY();
GO

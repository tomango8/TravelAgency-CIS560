CREATE OR ALTER PROCEDURE Agency.DeleteReservation
	@ReservationID INT
AS
UPDATE Agency.Reservations
SET IsDeleted = 1
WHERE @Reservation = R.Reservation;
GO
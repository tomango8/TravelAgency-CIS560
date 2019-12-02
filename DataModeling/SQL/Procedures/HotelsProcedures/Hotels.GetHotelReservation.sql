CREATE OR ALTER PROCEDURE Hotels.HotelReservation
	@ReservationID INT
AS

SELECT HR.HotelID, HR.DateOfReservation, HR.Price
	FROM Hotels.HotelReservation HR
WHERE HR.ReservationID = @ReservationID
GO
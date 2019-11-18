CREATE OR ALTER Hotels.HotelReservation
	@ReservationID
AS

SELECT HR.HotelID, HR.DateOfReservation, HR.Price
	FROM Hotels.HotelReservation HR
WHERE HR.ReservationID = @ReservationID
GO
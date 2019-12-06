CREATE OR ALTER PROCEDURE Attractions.CreateTicket
	@ReservationID INT OUTPUT,
	@AttractionID INT,
	@TicketDate DATE,
	@Price FLOAT
AS
INSERT Airlines.BoardingPass(AttractionID, TicketDate, Price)
VALUES(@AttractionID, @TicketDate, @Price)

SET @ReservationID = SCOPE_IDENTITY();
GO
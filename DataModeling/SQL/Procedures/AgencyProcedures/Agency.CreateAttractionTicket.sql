CREATE OR ALTER PROCEDURE Agency.CreateAttractionTicket
 @ReservationID INT OUTPUT,
 @AttractionID INT,
 @TicketDate DATE,
 @Price FLOAT
 AS
 INSERT ATTRACTIONS.AttractionTicket(AttractionID, TicketDate, Price)
	VALUES(@AttractionID, @TicketDate, @Price)

SET @ReservationID = SCOPE_IDENTITY();
GO
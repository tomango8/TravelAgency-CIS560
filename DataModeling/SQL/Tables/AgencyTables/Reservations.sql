CREATE TABLE Agency.Reservations
(
	ReservationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	DataCreated DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	IsDeleted BIT NOT NULL DEFAULT(0),
	CarReservation BIT NOT NULL,
	HotelReservation BIT NOT NULL,
	BoardingPass BIT NOT NULL,
	AttractionTicket BIT NOT NULL,
	RestaurantReservation BIT NOT NULL,
	TripID INT FOREIGN KEY
	REFERENCES Agency.Trips(TripID),
	CONSTRAINT CHECK_RESERVATION_TYPE CHECK((CarReservation = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0)) 
	AND (HotelReservation = 0 OR (CarReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0))
	AND (BoardingPass = 0 OR (HotelReservation = 0 AND CarReservation = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0))
	AND (AttractionTicket = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND CarReservation = 0 AND RestaurantReservation = 0))
	AND (RestaurantReservation = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND CarReservation = 0)))
)
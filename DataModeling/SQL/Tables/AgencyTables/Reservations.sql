CREATE TABLE Agency.Reservations
(
	ReservationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	DataCreated DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	IsDeleted BIT NOT NULL DEFAULT(0),
	CarReservation BIT NOT NULL CHECK(CarReservation = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0)),
	HotelReservation BIT NOT NULL CHECK(HotelReservation = 0 OR (CarReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0)),
	BoardingPass BIT NOT NULL CHECK(BoardingPass = 0 OR (HotelReservation = 0 AND CarReservation = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0)),
	AttractionTicket BIT NOT NULL CHECK(AttractionTicket = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND CarReservation = 0 AND RestaurantReservation = 0)),
	RestaurantReservation BIT NOT NULL CHECK(RestaurantReservation = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND CarReservation = 0)),
	TripID INT FOREIGN KEY
	REFERENCES Agency.Trips(TripID)
)
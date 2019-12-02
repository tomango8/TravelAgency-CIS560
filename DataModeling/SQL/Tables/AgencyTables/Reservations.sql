CREATE TABLE Agency.Reservations
(
	ReservationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	DataCreated DATE,
	IsDeleted BIT,
	CarReservation BIT,
	HotelReservation BIT,
	BoardingPass BIT,
	AttractionTicket BIT,
	RestaurantReservation BIT,
	TripID INT FOREIGN KEY
	REFERENCES Agency.Trips(TripID)
)
CREATE TABLE Attractions.AttractionTicket
(
	ReservationID INT NOT NULL FOREIGN KEY REFERENCES Agency.Reservations(ReservationID),
	AttractionID INT NOT NULL FOREIGN KEY REFERENCES Attractions.Attraction(AttractionID),
	TicketDate DATE NOT NULL,
	Price FLOAT,
	PRIMARY KEY(ReservationID, AttractionID)
);
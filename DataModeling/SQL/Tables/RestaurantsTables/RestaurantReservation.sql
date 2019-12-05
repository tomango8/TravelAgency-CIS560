CREATE TABLE Restaurants.RestaurantReservation
(
	ReservationID INT NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Agency.Reservations(ReservationID),
	ReservationDate DATETIME NOT NULL,
	RestaurantID INT NOT NULL FOREIGN KEY REFERENCES Restaurants.Restaurant(RestaurantID),
);
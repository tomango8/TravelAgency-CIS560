CREATE TABLE Hotels.HotelReservation 
(
    ReservationID INT NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Agency.Reservations(ReservationID),
    HotelID INT NOT NULL FOREIGN KEY REFERENCES Hotels.Hotel(HotelID),
    CheckInDate DATE NOT NULL,
    Price FLOAT NOT NULL
);
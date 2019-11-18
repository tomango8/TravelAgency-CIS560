CREATE TABLE Hotels.HotelReservation 
(
    ReservationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    HotelID INT NOT NULL IDENTITY(1, 1) FOREIGN KEY
        REFERENCES Hotels.Hotel(HotelID),
    DateOfReservation DATE NOT NULL,
    Price FLOAT NOT NULL
);
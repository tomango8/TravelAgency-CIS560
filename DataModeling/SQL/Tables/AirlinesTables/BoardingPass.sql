CREATE TABLE Airlines.BoardingPass 
(
    ReservationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY
        REFERENCES Agency.Reservation(ReservationID),
    FlightID INT NOT NULL FOREIGN KEY
        REFERENCES Airlines.Flight(FlightID),
    Price FLOAT NOT NULL
);
CREATE TABLE Cars.CarRentalReservation
(
    ReservationId INT NOT NULL PRIMARY KEY,
    CarRentalID INT NOT NULL,
    RentalDate DATE NOT NULL,
    Model  NVARCHAR(120) NOT NULL,
    Price FLOAT NOT NULL,
    
   FOREIGN KEY
   (
		CarRentalID 
   )
   REFERENCES Cars.CarRental(CarRentalID),

    FOREIGN KEY
   (
		ReservationID 
   )
   REFERENCES Agency.Reservations(ReservationID)
      
)

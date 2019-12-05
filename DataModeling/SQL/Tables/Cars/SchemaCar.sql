
CREATE TABLE Cars.CarRentalReservation
(
    ReservationId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
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

CREATE TABLE Cars.CarRental
(
    CarRentalID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    AgencyName NVARCHAR(120) NOT NULL,
    CityID INT NOT NULL FOREIGN KEY REFERENCES [Location].Cities(CityID)
)



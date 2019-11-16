
CREATE TABLE Cars.CarRentalReservation
(
    ReservationId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    CarRentalID INT,
    [DATE]   DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
    Model  NVARCHAR(100) NOT NULL,
    PRICE FLOAT,
    [Delete] BIT,
    CarRentalID INT,
    ReservationID INT,
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

CREATE TABLE Cars.CarRental(
    CarRentalID INT PRIMARY KEY IDENTITY(1, 1),
    [Name] NVARCHAR(120),
    CityID INT
)



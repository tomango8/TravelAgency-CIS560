--Build DataBase--
USE TravelAgency;
GO

DROP TABLE IF EXISTS Restaurants.RestaurantReservation;
DROP TABLE IF EXISTS Attractions.AttractionTicket;
DROP TABLE IF EXISTS Airlines.BoardingPass;
DROP TABLE IF EXISTS Hotels.HotelReservation;
DROP Table IF EXISTS Cars.CarRentalReservation;
DROP TABLE IF EXISTS Agency.Reservations;
DROP TABLE IF EXISTS Agency.Trips;
DROP TABLE IF EXISTS Agency.Agents;
DROP TABLE IF EXISTS Agency.Customer;
DROP TABLE IF EXISTS Agency.ContactInfo;
DROP TABLE IF EXISTS Restaurants.Restaurant;
DROP TABLE IF EXISTS Cars.CarRental;
DROP TABLE IF EXISTS Attractions.Attraction;
DROP TABLE IF EXISTS Airlines.Flight;
DROP TABLE IF EXISTS Hotels.Hotel;
DROP TABLE IF EXISTS [Location].Cities;

CREATE TABLE [Location].Cities
(
    CityID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    CityName NVARCHAR(120) NOT NULL,
    Region NVARCHAR(120) NOT NULL,
    Country NVARCHAR(120) NOT NULL
);

CREATE TABLE Hotels.Hotel 
(
    HotelID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    [Name] NVARCHAR(120) NOT NULL,
    CityID INT NOT NULL FOREIGN KEY REFERENCES [Location].Cities(CityID),
    FullAddress NVARCHAR(120) NOT NULL
);

CREATE TABLE Airlines.Flight 
(
    FlightID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    AirlineName NVARCHAR(120) NOT NULL,
    DepartureTime DATETIME NOT NULL,
    ArrivalTime DATETIME NOT NULL,
    CityDepartureID INT NOT NULL,
    CityArrivalID INT NOT NULL,
);

CREATE TABLE Attractions.Attraction
(
	AttractionID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(100) NOT NULL,
	CityID INT NOT NULL FOREIGN KEY REFERENCES [Location].Cities(CityID)
);

CREATE TABLE Restaurants.Restaurant
(
	RestaurantID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(120) NOT NULL,
	CityID INT NOT NULL FOREIGN KEY REFERENCES [Location].Cities(CityID)
);

CREATE TABLE Cars.CarRental
(
    CarRentalID INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    AgencyName NVARCHAR(120) NOT NULL,
    CityID INT NOT NULL FOREIGN KEY REFERENCES [Location].Cities(CityID)
);

CREATE TABLE Agency.ContactInfo
(
	ContactID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	BillingAddress NVARCHAR(200) NOT NULL,
	Phone NVARCHAR(30) NOT NULL,
	Email NVARCHAR(120) NOT NULL,
	CityID INT NOT NULL,
	FOREIGN KEY
	(
		CityID
	)
	REFERENCES [Location].Cities(CityID),	
);

CREATE TABLE Agency.Customer 
(
	CustomerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Budget FLOAT NOT NULL,
	[Name] NVARCHAR(120) NOT NULL,
	Age INT NOT NULL, 
	Sex NVARCHAR(7) NOT NULL,
	ContactID INT NOT NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),

	FOREIGN KEY
	(
		ContactID
	)
	REFERENCES Agency.ContactInfo(ContactID),
);

CREATE TABLE Agency.Agents
(
	AgentID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(120) NOT NULL,
	Salary FLOAT NOT NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
);

CREATE TABLE Agency.Trips
(
	TripID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CustomerID INT NOT NULL FOREIGN KEY
	REFERENCES Agency.Customer(CustomerID),
	
	IsDeleted BIT NOT NULL DEFAULT(0),
	DateCreated DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	AgentID INT FOREIGN KEY
	REFERENCES Agency.Agents(AgentID), 
);

CREATE TABLE Agency.Reservations
(
	ReservationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	DataCreated DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	IsDeleted BIT NOT NULL DEFAULT(0),
	CarReservation BIT NOT NULL,
	HotelReservation BIT NOT NULL,
	BoardingPass BIT NOT NULL,
	AttractionTicket BIT NOT NULL,
	RestaurantReservation BIT NOT NULL,
	TripID INT FOREIGN KEY
	REFERENCES Agency.Trips(TripID),
	CONSTRAINT CHECK_RESERVATION_TYPE CHECK((CarReservation = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0)) 
	AND (HotelReservation = 0 OR (CarReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0))
	AND (BoardingPass = 0 OR (HotelReservation = 0 AND CarReservation = 0 AND AttractionTicket = 0 AND RestaurantReservation = 0))
	AND (AttractionTicket = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND CarReservation = 0 AND RestaurantReservation = 0))
	AND (RestaurantReservation = 0 OR (HotelReservation = 0 AND BoardingPass = 0 AND AttractionTicket = 0 AND CarReservation = 0)))
);

CREATE TABLE Airlines.BoardingPass 
(
    ReservationID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY FOREIGN KEY
        REFERENCES Agency.Reservations(ReservationID),
    FlightID INT NOT NULL FOREIGN KEY
        REFERENCES Airlines.Flight(FlightID),
    Price FLOAT NOT NULL
);

CREATE TABLE Attractions.AttractionTicket
(
	ReservationID INT NOT NULL FOREIGN KEY REFERENCES Agency.Reservations(ReservationID),
	AttractionID INT NOT NULL FOREIGN KEY REFERENCES Attractions.Attraction(AttractionID),
	TicketDate DATE NOT NULL,
	Price FLOAT,
	PRIMARY KEY(ReservationID, AttractionID)
);

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
      
);

CREATE TABLE Hotels.HotelReservation 
(
    ReservationID INT NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Agency.Reservations(ReservationID),
    HotelID INT NOT NULL IDENTITY(1, 1) FOREIGN KEY REFERENCES Hotels.Hotel(HotelID),
    CheckInDate DATE NOT NULL,
    Price FLOAT NOT NULL
);

CREATE TABLE Restaurants.RestaurantReservation
(
	ReservationID INT NOT NULL PRIMARY KEY FOREIGN KEY REFERENCES Agency.Reservations(ReservationID),
	ReservationDate DATETIME NOT NULL,
	RestaurantID INT NOT NULL FOREIGN KEY REFERENCES Restaurants.Restaurant(RestaurantID),
);
CREATE TABLE Airlines.Flight 
(
    FlightID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    AirlineName NVARCHAR(120) NOT NULL,
    DepartureTime DATETIME NOT NULL,
    ArrivalTime DATETIME NOT NULL,
    CityDepartureID INT NOT NULL,
    CityArrivalID INT NOT NULL,
);
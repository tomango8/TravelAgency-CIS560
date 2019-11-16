CREATE TABLE Airlines.Flight 
(
    FlightID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    AirlineName NVARCHAR(64) NOT NULL,
    DepartureTime DATETIMEOFFSET NOT NULL,
    ArrivalTime DATETIMEOFFSET NOT NULL,
    CityDepartureID INT NOT NULL,
    CityArrivalID INT NOT NULL,
    DateOfFlight DATE NOT NULL
);
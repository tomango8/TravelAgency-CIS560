CREATE OR ALTER PROCEDURE Airlines.CreateFlight
	@FlightID INT OUTPUT,
	@AirlineName NVARCHAR(64),
	@DepartureTime TIME,
	@ArrivalTime TIME,
	@CityDepartureID INT,
	@CityArrivalID INT,
	@DateOfFlight DATE
AS
INSERT Airlines.Flight(AirlineName, DepartureTime, ArrivalTime, DateOfFlight)
VALUES(@AirlineName, @DepartureTime, @ArrivalTime, @DateOfFlight)

SET @FlightID = SCOPE_IDENTITY();
GO
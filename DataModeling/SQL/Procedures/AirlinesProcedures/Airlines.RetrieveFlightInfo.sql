CREATE OR ALTER PROCEDURE Airlines.RetrieveFlightInfo
	@FlightID INT
AS

SELECT 
	FL.FlightID,
	FL.AirlineName,
	FL.DepartureTime,
	FL.ArrivalTime,
	FL.DepartureTime,
	FL.CityDepatureID,
	FL.CityArrivalID,
	FL.DateofFlight
FROM Airlines.Flight FL
WHERE FL.FlightID = @FlightID
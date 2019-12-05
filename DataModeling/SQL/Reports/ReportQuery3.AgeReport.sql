USE TravelAgency;
GO
CREATE OR ALTER PROC Agency.AgeReport
AS
WITH CustomerData (
    Trips,
    Age,
    AgeGroup,
    Budget

)

AS (
    SELECT
        COUNT(T.TripID) AS Trip_Count,
        C.Age,
        CASE WHEN C.Age BETWEEN 18 AND 29 THEN "Young Adult"
        WHEN C.Age BETWEEN 30 AND 59 THEN "Middle Aged"
        WHEN C.Age >59 THEN "Senior"
        END AS AgeGroup,
        AVG(C.Budget) AS Average_Budget
    FROM Agency.Customers C
        INNER JOIN Agency.Trips T ON C.CustomerID = T.CustomerID
        INNER JOIN Agency.Reservation R ON T.TripID = R.TripID
)

SELECT 
    CD.AgeGroup,
    AVG(CD.Trips) AS Average_Trip_Count,
    CD.Budget AS Average_Budget
FROM CustomerData CD
GROUP BY CD.AgeGroup


--not done
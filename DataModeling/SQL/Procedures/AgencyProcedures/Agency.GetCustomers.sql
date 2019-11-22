CREATE OR ALTER PROCEDURE Agency.GetCustomers
AS

SELECT C.[Name], C.CustomerID
FROM Agency.Customer C;
GO

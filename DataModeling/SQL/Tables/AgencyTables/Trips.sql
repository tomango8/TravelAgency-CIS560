CREATE TABLE Agency.Trips
(
	TripID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CustomerID INT FOREIGN KEY
	REFERENCES Agency.Customer(CustomerID),
	REFERENCES Agency.Reservations(TripID),
	
	IsDeleted BIT,
	DataCreated DATE,
	AgentID INT FOREIGN KEY
	REFERENCES Agency.Agents(AgentID), 
)

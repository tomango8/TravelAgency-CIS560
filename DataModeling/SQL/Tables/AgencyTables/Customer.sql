CREATE TABLE Agency.Customer 
(
	CustomerID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Budget FLOAT,
	[Name] NVARCHAR(100) NOT NULL,
	Age INT, 
	Sex NVARCHAR(100),
	ContactID INT,
	IsDeleted BIT,

	FOREIGN KEY
	(
		ContactID
	)
	REFERENCES Agency.ContactInfo(CityID),
);



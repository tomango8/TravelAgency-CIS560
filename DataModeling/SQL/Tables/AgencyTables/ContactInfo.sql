CREATE TABLE Agency.ContactInfo
(
	ContactID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	BillingAddress NVARCHAR,
	Phone INT,
	Email NVARCHAR,
	CityID INT,
	FOREIGN KEY
	(
		CityID
	)
	REFERENCES [Location].Cities(CityID),
	FOREIGN KEY
	(
		ContactID
	)
	REFERENCES Agency.Customer(ContactID)

)
CREATE OR ALTER PROCEDURE Agency.CreateAgent
	@AgentID INT OUTPUT,
	@Name NVARCHAR(100),
	@Salary FLOAT
AS

INSERT Agency.Agent([Name], Salary)
VALUES (@Name, @Salary)

SET @AgentID = SCOPE_IDENTITY();
GO
CREATE OR ALTER PROCEDURE Agency.CreateAgent
	@AgentID INT OUTPUT,
	@Name NVARCHAR(100),
	@Salary FLOAT,
	@IsDeleted BIT
AS

INSERT Agency.Agent([Name], Salary, IsDeleted)
VALUES (@Name, @Salary, @IsDeleted)

SET @AgentID = SCOPE_IDENTITY();
GO
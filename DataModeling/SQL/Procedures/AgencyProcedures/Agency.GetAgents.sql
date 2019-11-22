CREATE OR ALTER PROCEDURE Agency.GetAgents
AS

SELECT A.AgentID, A.[Name]
FROM Agency.Agents A;
GO

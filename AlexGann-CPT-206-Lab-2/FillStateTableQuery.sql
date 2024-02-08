TRUNCATE TABLE dbo.State;
GO

BULK INSERT dbo.State
FROM 'StateTable.csv'
WITH
(
	FORMAT = 'CSV',
	FIRSTROW = 1
)
GO
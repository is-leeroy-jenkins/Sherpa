CREATE TABLE Reports
(
	ReportsId INT NOT NULL UNIQUE,
	Name NVARCHAR(150) NULL DEFAULT ('NS'),
	Title NVARCHAR(150) NULL DEFAULT ('NS'),
	CONSTRAINT ReportsPrimaryKey PRIMARY KEY
	(
		ReportsId
	)
);

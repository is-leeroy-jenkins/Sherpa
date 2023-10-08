CREATE TABLE ResponsibilityCenters
(
	ResponsibilityCentersId INT NOT NULL UNIQUE,
	Code NVARCHAR(150) NULL DEFAULT ('NS'),
	Name NVARCHAR(150) NULL DEFAULT ('NS'),
	Title NVARCHAR(150) NULL DEFAULT ('NS'),
	CONSTRAINT ResponsibilityCentersPrimaryKey PRIMARY KEY
	(
		ResponsibilityCentersId
	)
);

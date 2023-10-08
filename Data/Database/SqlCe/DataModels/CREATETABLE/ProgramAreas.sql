CREATE TABLE ProgramAreas
(
	ProgramAreasId INT NOT NULL UNIQUE,
	Code NVARCHAR(150) NULL DEFAULT ('NS'),
	Name NVARCHAR(150) NULL DEFAULT ('NS'),
	CONSTRAINT ProgramAreasPrimaryKey PRIMARY KEY
	(
		ProgramAreasId
	)
);

CREATE TABLE BudgetObjectClasses
(
	BudgetObjectClassesId INT           NOT NULL UNIQUE,
	Code                  NVARCHAR(150) NULL DEFAULT ('NS'),
	Name                  NVARCHAR(150) NULL DEFAULT ('NS'),
	CONSTRAINT BudgetObjectClassesPrimaryKey PRIMARY KEY
		(
		  BudgetObjectClassesId
			)
);

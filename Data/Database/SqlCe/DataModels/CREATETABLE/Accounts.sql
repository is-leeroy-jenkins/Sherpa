CREATE TABLE Accounts
(
	AccountsId         INT           NOT NULL UNIQUE,
	Code               NVARCHAR(150) NULL DEFAULT ('NS'),
	GoalCode           NVARCHAR(150) NULL DEFAULT ('NS'),
	ObjectiveCode      NVARCHAR(150) NULL DEFAULT ('NS'),
	NpmCode            NVARCHAR(150) NULL DEFAULT ('NS'),
	NpmName            NVARCHAR(150) NULL DEFAULT ('NS'),
	ProgramProjectCode NVARCHAR(150) NULL DEFAULT ('NS'),
	ProgramProjectName NVARCHAR(150) NULL DEFAULT ('NS'),
	ProgramAreaCode    NVARCHAR(150) NULL DEFAULT ('NS'),
	ProgramAreaName    NVARCHAR(150) NULL DEFAULT ('NS'),
	ActivityCode       NVARCHAR(150) NULL DEFAULT ('NS'),
	ActivityName       NVARCHAR(150) NULL DEFAULT ('NS'),
	AgencyActivity     NVARCHAR(150) NULL DEFAULT ('NS'),
	CONSTRAINT AccountsPrimaryKey PRIMARY KEY
		(
		  AccountsId
			)
);

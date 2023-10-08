CREATE TABLE Earmarks
(
	EarmarksId AUTOINCREMENT NOT NULL UNIQUE,
	RpioCode TEXT(150) NULL DEFAULT NS,
	RpioName TEXT(150) NULL DEFAULT NS,
	FundCode TEXT(150) NULL DEFAULT NS,
	FundName TEXT(150) NULL DEFAULT NS,
	StateCode TEXT(150) NULL DEFAULT NS,
	Description TEXT(150) NULL DEFAULT NS,
	Amount DOUBLE NULL DEFAULT 0.0,
	ProjectOfficerLastName TEXT(150) NULL DEFAULT NS,
	ProjectOfficerFirstName TEXT(150) NULL DEFAULT NS,
	ProjectOfficerPhoneNumber TEXT(150) NULL DEFAULT NS,
	ProjectOfficerMailCode TEXT(150) NULL DEFAULT NS,
	CommitmentDate DATETIME NULL,
	ObligationDate DATETIME NULL,
	ProjectStatus TEXT(150) NULL DEFAULT NS,
	ProjectOfficerComments TEXT(150) NULL DEFAULT NS,
	CONSTRAINT(EarmarksPrimaryKey) 
		PRIMARY KEY(EarmarksId )
);

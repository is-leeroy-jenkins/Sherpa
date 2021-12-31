CREATE TABLE Deobligations
(
	DeobligationId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyDeobligations PRIMARY KEY,
	RpioCode TEXT(255) NULL,
	RpioName TEXT(255) NULL,
	BFY TEXT(255) NULL,
	FundCode TEXT(255) NULL,
	DocumentNumber TEXT(255) NULL,
	CalendarYear TEXT(255) NULL,
	OrgCode TEXT(255) NULL,
	ProgramProjectCode TEXT(255) NULL,
	AccountCode TEXT(255) NULL,
	BocCode TEXT(255) NULL,
	ProcessedDate DATETIME NULL,
	Amount DOUBLE NULL
);



CREATE TABLE StatusOfFunds
(
	StatusOfFundsId AUTOINCREMENT NOT NULL UNIQUE,
	BudgetLevel TEXT(150) NULL DEFAULT NS,
	BFY TEXT(150) NULL DEFAULT NS,
	EFY TEXT(150) NULL DEFAULT NS,
	FundCode TEXT(150) NULL DEFAULT NS,
	FundName TEXT(150) NULL DEFAULT NS,
	RpioCode TEXT(150) NULL DEFAULT NS,
	RpioName TEXT(150) NULL DEFAULT NS,
	AhCode TEXT(150) NULL DEFAULT NS,
	AhName TEXT(150) NULL DEFAULT NS,
	OrgCode TEXT(150) NULL DEFAULT NS,
	OrgName TEXT(150) NULL DEFAULT NS,
	AccountCode TEXT(150) NULL DEFAULT NS,
	BocCode TEXT(150) NULL DEFAULT NS,
	BocName TEXT(150) NULL DEFAULT NS,
	ProgramProjectCode TEXT(150) NULL DEFAULT NS,
	ProgramProjectName TEXT(150) NULL DEFAULT NS,
	ProgramAreaCode TEXT(150) NULL DEFAULT NS,
	ProgramAreaName TEXT(150) NULL DEFAULT NS,
	RcCode TEXT(150) NULL DEFAULT NS,
	RcName TEXT(150) NULL DEFAULT NS,
	LowerName TEXT(150) NULL DEFAULT NS,
	Amount DOUBLE NULL DEFAULT 0.0,
	Budgeted DOUBLE NULL DEFAULT 0.0,
	Posted DOUBLE NULL DEFAULT 0.0,
	OpenCommitments DOUBLE NULL DEFAULT 0.0,
	UnliquidatedObligations DOUBLE NULL DEFAULT 0.0,
	Expenditures DOUBLE NULL DEFAULT 0.0,
	Obligations DOUBLE NULL DEFAULT 0.0,
	Used DOUBLE NULL DEFAULT 0.0,
	Available DOUBLE NULL DEFAULT 0.0,
	NpmCode TEXT(150) NULL DEFAULT NS,
	NpmName TEXT(150) NULL DEFAULT NS,
	TreasuryAccountCode TEXT(150) NULL DEFAULT NS,
	TreasuryAccountName TEXT(MAX) NULL DEFAULT NS,
	BudgetAccountCode TEXT(150) NULL DEFAULT NS,
	BudgetAccountName TEXT(MAX) NULL DEFAULT NS,
	CONSTRAINT(StatusOfFundsPrimaryKey) 
		PRIMARY KEY(StatusOfFundsId )
) ;

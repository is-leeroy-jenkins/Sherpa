﻿CREATE TABLE EarmarkAccounts 
(
	EarmarkAccountsId AUTOINCREMENT NOT NULL UNIQUE,
	BFY	NVARCHAR(100) NULL DEFAULT ('NS'),
	EFY	NVARCHAR(100) NULL DEFAULT ('NS'),
	FundCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	FundName	NVARCHAR(100) NULL DEFAULT ('NS'),
	RpioCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	RpioName	NVARCHAR(100) NULL DEFAULT ('NS'),
	AhCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	AhName	NVARCHAR(100) NULL DEFAULT ('NS'),
	NpmCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	NpmName	NVARCHAR(100) NULL DEFAULT ('NS'),
	AccountCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	BocCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	BocName	NVARCHAR(100) NULL DEFAULT ('NS'),
	ProgramProjectCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	ProgramProjectName	NVARCHAR(100) NULL DEFAULT ('NS'),
	ProgramAreaCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	ProgramAreaName	NVARCHAR(100) NULL DEFAULT ('NS'),
	StateCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	StateName	NVARCHAR(100) NULL DEFAULT ('NS'),
	Project	NVARCHAR(100) NULL DEFAULT ('NS'),
	Amount	DOUBLE DEFAULT 0.0,
	TreasuryAccountCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	TreasuryAccountName	NVARCHAR(100) NULL DEFAULT ('NS'),
	BudgetAccountCode	NVARCHAR(100) NULL DEFAULT ('NS'),
	BudgetAccountName	NVARCHAR(100) NULL DEFAULT ('NS'),
	CONSTRAINT EarmarkAccountPrimaryKey PRIMARY KEY
	(
		EarmarkAccountsId  ASC
	)
);
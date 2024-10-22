CREATE TABLE CarryoverApportionments
(
	CarryoverApportionmentsId INT           NOT NULL UNIQUE,
	BudgetAccount             NVARCHAR(150) NULL DEFAULT ('NS'),
	TreasuryAccount           NVARCHAR(150) NULL DEFAULT ('NS'),
	BFY                       NVARCHAR(150) NULL DEFAULT ('NS'),
	EFY                       NVARCHAR(150) NULL DEFAULT ('NS'),
	Group                     NVARCHAR(150) NULL DEFAULT ('NS'),
	Description               NVARCHAR(150) NULL DEFAULT ('NS'),
	LineName                  NVARCHAR(150) NULL DEFAULT ('NS'),
	AuthorityType             NVARCHAR(150) NULL DEFAULT ('NS'),
	Request                   FLOAT         NULL DEFAULT (0.0),
	Balance                   FLOAT         NULL DEFAULT (0.0),
	Deobligations             FLOAT         NULL DEFAULT (0.0),
	Amount                    FLOAT         NULL DEFAULT (0.0),
	LineNumber                NVARCHAR(150) NULL DEFAULT ('NS'),
	LineSplit                 NVARCHAR(150) NULL DEFAULT ('NS'),
	ApportionmentAccountCode  NVARCHAR(150) NULL DEFAULT ('NS'),
	TreasuryAccountCode       NVARCHAR(150) NULL DEFAULT ('NS'),
	TreasuryAccountName       NVARCHAR(150) NULL DEFAULT ('NS'),
	BudgetAccountCode         NVARCHAR(150) NULL DEFAULT ('NS'),
	BudgetAccountName         NVARCHAR(150) NULL DEFAULT ('NS'),
	CONSTRAINT CarryoverApportionmentsPrimaryKey PRIMARY KEY
		(
		  CarryoverApportionmentsId
			)
);

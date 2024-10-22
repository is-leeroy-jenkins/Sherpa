CREATE TABLE RegionalAuthority
(
	RegionalAuthorityId INT           NOT NULL UNIQUE,
	AllocationsId       INT           NULL,
	StatusOfFundsId     INT           NULL,
	BudgetLevel         NVARCHAR(255) NULL,
	BFY                 NVARCHAR(255) NULL,
	EFY                 NVARCHAR(255) NULL,
	FundCode            NVARCHAR(255) NULL,
	FundName            NVARCHAR(255) NULL,
	RpioCode            NVARCHAR(255) NULL,
	RpioName            NVARCHAR(255) NULL,
	AhCode              NVARCHAR(255) NULL,
	AhName              NVARCHAR(255) NULL,
	OrgCode             NVARCHAR(255) NULL,
	OrgName             NVARCHAR(255) NULL,
	AccountCode         NVARCHAR(255) NULL,
	RcCode              NVARCHAR(255) NULL,
	RcName              NVARCHAR(255) NULL,
	BocCode             NVARCHAR(255) NULL,
	BocName             NVARCHAR(255) NULL,
	Amount              FLOAT         NULL DEFAULT (0.0),
	ProgramProjectCode  NVARCHAR(255) NULL,
	ProgramProjectName  NVARCHAR(255) NULL,
	ProgramAreaCode     NVARCHAR(255) NULL,
	ProgramAreaName     NVARCHAR(255) NULL,
	NpmCode             NVARCHAR(255) NULL,
	NpmName             NVARCHAR(255) NULL,
	TreasuryAccountCode NVARCHAR(255) NULL,
	TreasuryAccountName NVARCHAR(255) NULL,
	BudgetAccountCode   NVARCHAR(255) NULL,
	BudgetAccountName   NVARCHAR(255) NULL,
	CONSTRAINT RegrionalAuthorityPrimaryKey PRIMARY KEY
		(
		  RegionalAuthorityId
			)
);

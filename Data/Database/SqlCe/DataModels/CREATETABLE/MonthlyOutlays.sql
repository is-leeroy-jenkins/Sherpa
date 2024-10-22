CREATE TABLE MonthlyOutlays
(
	MonthlyOutlaysId    INT           NOT NULL UNIQUE,
	FiscalYear          NVARCHAR(150) NULL DEFAULT ('NS'),
	LineNumber          NVARCHAR(150) NULL DEFAULT ('NS'),
	LineTitle           NVARCHAR(150) NULL DEFAULT ('NS'),
	TaxationCode        NVARCHAR(150) NULL DEFAULT ('NS'),
	TreasuryAgencyCode  NVARCHAR(150) NULL DEFAULT ('NS'),
	TreasuryAccountCode NVARCHAR(150) NULL DEFAULT ('NS'),
	SubAccount          NVARCHAR(150) NULL DEFAULT ('NS'),
	BFY                 NVARCHAR(150) NULL DEFAULT ('NS'),
	EFY                 NVARCHAR(150) NULL DEFAULT ('NS'),
	BudgetAgencyCode    NVARCHAR(150) NULL DEFAULT ('NS'),
	BudgetBureauCode    NVARCHAR(150) NULL DEFAULT ('NS'),
	BudgetAccountCode   NVARCHAR(150) NULL DEFAULT ('NS'),
	AgencySequence      NVARCHAR(150) NULL DEFAULT ('NS'),
	BureauSequence      NVARCHAR(150) NULL DEFAULT ('NS'),
	AccountSequence     NVARCHAR(150) NULL DEFAULT ('NS'),
	AgencyTitle         NVARCHAR(150) NULL DEFAULT ('NS'),
	BureauTitle         NVARCHAR(150) NULL DEFAULT ('NS'),
	BudgetAccountName   NVARCHAR(150) NULL DEFAULT ('NS'),
	TreasuryAccountName NVARCHAR(150) NULL DEFAULT ('NS'),
	October             FLOAT         NULL DEFAULT (0.0),
	November            FLOAT         NULL DEFAULT (0.0),
	December            FLOAT         NULL DEFAULT (0.0),
	January             FLOAT         NULL DEFAULT (0.0),
	Feburary            FLOAT         NULL DEFAULT (0.0),
	March               FLOAT         NULL DEFAULT (0.0),
	April               FLOAT         NULL DEFAULT (0.0),
	May                 FLOAT         NULL DEFAULT (0.0),
	June                FLOAT         NULL DEFAULT (0.0),
	July                FLOAT         NULL DEFAULT (0.0),
	August              FLOAT         NULL DEFAULT (0.0),
	September           FLOAT         NULL DEFAULT (0.0),
	CONSTRAINT MonthlyOutlaysPrimaryKey PRIMARY KEY
		(
		  MonthlyOutlaysId
			)
);

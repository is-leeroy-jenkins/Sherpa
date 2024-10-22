CREATE TABLE UnobligatedBalances
(
	UnobligatedBalancesId AUTOINCREMENT NOT NULL UNIQUE,
	BudgetYear            TEXT( 150 )   NULL DEFAULT NS,
	BFY                   TEXT( 150 )   NULL DEFAULT NS,
	EFY                   TEXT( 150 )   NULL DEFAULT NS,
	BudgetAccount         TEXT( 150 )   NULL DEFAULT NS,
	TreasuryAccountCode   TEXT( 150 )   NULL DEFAULT NS,
	TreasuryAccountName   TEXT( 150 )   NULL DEFAULT NS,
	BudgetAccountCode     TEXT( 150 )   NULL DEFAULT NS,
	BudgetAccountName     TEXT( 150 )   NULL DEFAULT NS,
	FundCode              TEXT( 150 )   NULL DEFAULT NS,
	FundName              TEXT( 150 )   NULL DEFAULT NS,
	AccountNumber         TEXT( 150 )   NULL DEFAULT NS,
	AccountName           TEXT( 150 )   NULL DEFAULT NS,
	Amount                DOUBLE        NULL DEFAULT 0.0, CONSTRAINT
(
	UnobligatedBalancesPrimaryKey
)
	PRIMARY KEY
(
	UnobligatedBalancesId
)
	);

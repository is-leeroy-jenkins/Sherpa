CREATE TABLE IF NOT EXISTS "ReimbursableFunds" 
(
	"ReimbursableFundsId"	INTEGER NOT NULL UNIQUE,
	"RpioCode"	TEXT(80) NULL DEFAULT "NS",
	"BFY"	TEXT(80) NULL DEFAULT "NS",
	"FundCode"	TEXT(80) NULL DEFAULT "NS",
	"AccountCode"	TEXT(80) NULL DEFAULT "NS",
	"RcCode"	TEXT(80) NULL DEFAULT "NS",
	"RcName"	TEXT(80) NULL DEFAULT "NS",
	"BocCode"	TEXT(80) NULL DEFAULT "NS",
	"DocumentControlNumber"	TEXT(80) NULL DEFAULT "NS",
	"AgreeementNumber"	TEXT(80) NULL DEFAULT "NS",
	"Amount"	REAL DEFAULT 0.0,
	"OpenCommitments"	REAL DEFAULT 0.0,
	"Obligations"	REAL DEFAULT 0.0,
	"ULO"	REAL DEFAULT 0.0,
	"Available"	REAL DEFAULT 0.0,
	PRIMARY KEY("ReimbursableFundsId" AUTOINCREMENT)
);
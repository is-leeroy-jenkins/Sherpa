CREATE TABLE IF NOT EXISTS "ReimbursableFunds" 
(
	"ReimbursableFundsId"	INTEGER NOT NULL UNIQUE,
	"RpioCode"	TEXT(255) DEFAULT "NS",
	"BFY"	TEXT(255) DEFAULT "NS",
	"FundCode"	TEXT(255) DEFAULT "NS",
	"AccountCode"	TEXT(255) DEFAULT "NS",
	"RcCode"	TEXT(255) DEFAULT "NS",
	"RcName"	TEXT(255) DEFAULT "NS",
	"BocCode"	TEXT(255) DEFAULT "NS",
	"DocumentControlNumber"	TEXT(255) DEFAULT "NS",
	"AgreeementNumber"	TEXT(255) DEFAULT "NS",
	"Amount"	REAL DEFAULT 0.0,
	"OpenCommitments"	REAL DEFAULT 0.0,
	"Obligations"	REAL DEFAULT 0.0,
	"ULO"	REAL DEFAULT 0.0,
	"Available"	REAL DEFAULT 0.0,
	PRIMARY KEY("ReimbursableFundsId" AUTOINCREMENT)
);
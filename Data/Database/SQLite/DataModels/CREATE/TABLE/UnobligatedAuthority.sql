CREATE TABLE IF NOT EXISTS "UnobligatedAuthority" 
(
	"UnobligatedAuthorityId"	INTEGER NOT NULL UNIQUE,
	"BudgetYear"	TEXT(255) DEFAULT "NS",
	"AgencyTitle"	TEXT(255) DEFAULT "NS",
	"BureauTitle"	TEXT(255) DEFAULT "NS",
	"OmbAccount"	TEXT(255) DEFAULT "NS",
	"AgencyCode"	TEXT(255) DEFAULT "NS",
	"BureauCode"	TEXT(255) DEFAULT "NS",
	"AccountCode"	TEXT(255) DEFAULT "NS",
	"Transmit"	TEXT(255) DEFAULT "NS",
	"AgencySequence"	TEXT(255) DEFAULT "NS",
	"OmbAccountTitle"	TEXT(255) DEFAULT "NS",
	"LineName"	TEXT(255) DEFAULT "NS",
	"LineNumber"	TEXT(255) DEFAULT "NS",
	"PriorYearAmount"	REAL DEFAULT 0.0,
	"CurrentYearAmount"	REAL DEFAULT 0.0,
	"BudgetYearAmount"	REAL DEFAULT 0.0,
	PRIMARY KEY("UnobligatedAuthorityId" AUTOINCREMENT)
);
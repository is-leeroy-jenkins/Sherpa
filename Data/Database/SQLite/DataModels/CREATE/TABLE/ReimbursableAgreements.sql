CREATE TABLE IF NOT EXISTS "ReimbursableAgreements" 
(
	"ReimbursableAgreementsId"	INTEGER NOT NULL,
	"RPIO"	TEXT(255) DEFAULT "NS",
	"BFY"	TEXT(255) DEFAULT "NS",
	"FundCode"	TEXT(255) DEFAULT "NS",
	"AgreementNumber"	TEXT(255) DEFAULT "NS",
	"StartDate"	TEXT(255) DEFAULT "NS",
	"EndDate"	TEXT(255) DEFAULT "NS",
	"RcCode"	TEXT(255) DEFAULT "NS",
	"OrgCode"	TEXT(255) DEFAULT "NS",
	"RcName"	TEXT(255) DEFAULT "NS",
	"SiteProjectCode"	TEXT(255) DEFAULT "NS",
	"AccountCode"	TEXT(255) DEFAULT "NS",
	"VendorCode"	TEXT(255) DEFAULT "NS",
	"VendorName"	TEXT(255) DEFAULT "NS",
	"Amount"	REAL DEFAULT 0.0,
	"OpenCommitments"	REAL DEFAULT 0.0,
	"Obligations"	REAL DEFAULT 0.0,
	"ULO"	REAL DEFAULT 0.0,
	"Available"	REAL DEFAULT 0.0
);
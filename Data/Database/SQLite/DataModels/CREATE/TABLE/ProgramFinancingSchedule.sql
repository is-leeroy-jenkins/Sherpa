CREATE TABLE IF NOT EXISTS "ProgramFinancingSchedule" 
(
	"ProgramFinancingScheduleId"	INTEGER NOT NULL UNIQUE,
	"ReportYear"	TEXT(255) DEFAULT "NS",
	"TreasuryAgencyCode"	TEXT(255) DEFAULT "NS",
	"TreasuryAccountCode"	TEXT(255) DEFAULT "NS",
	"LedgerAccountCode"	TEXT(255) DEFAULT "NS",
	"SectionNumber"	TEXT(255) DEFAULT "NS",
	"SectionName"	TEXT(255) DEFAULT "NS",
	"LineNumber"	TEXT(255) DEFAULT "NS",
	"LineDescription"	TEXT(255) DEFAULT "NS",
	"OmbAgencyCode"	TEXT(255) DEFAULT "NS",
	"OmbFundCode"	TEXT(255) DEFAULT "NS",
	"OmbAccountTitle"	TEXT(255) DEFAULT "NS",
	"AgencySequence"	TEXT(255) DEFAULT "NS",
	"AccountSequence"	TEXT(255) DEFAULT "NS",
	"AgencyName"	TEXT(255) DEFAULT "NS",
	"FundName"	TEXT(255) DEFAULT "NS",
	"OriginalAmount"	REAL DEFAULT 0.0,
	"BudgetAmount"	REAL DEFAULT 0.0,
	"AgencyAmount"	REAL DEFAULT 0.0,
	"Amount"	REAL DEFAULT 0.0,
	PRIMARY KEY("ProgramFinancingScheduleId" AUTOINCREMENT)
);
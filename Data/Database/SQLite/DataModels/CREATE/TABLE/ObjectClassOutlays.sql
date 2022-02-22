CREATE TABLE IF NOT EXISTS "ObjectClassOutlays" 
(
	"ObjectClassOutlaysId"	INTEGER NOT NULL UNIQUE,
	"ReportYear"	TEXT(255) DEFAULT "NS",
	"OmbAgencyCode"	TEXT(255) DEFAULT "NS",
	"OmbAgencyName"	TEXT(255) DEFAULT "NS",
	"OmbBureauCode"	TEXT(255) DEFAULT "NS",
	"OmbBureauName"	TEXT(255) DEFAULT "NS",
	"OmbAccountCode"	TEXT(255) DEFAULT "NS",
	"OmbAccountName"	TEXT(255) DEFAULT "NS",
	"Direct/Reimbursable"	TEXT(255) DEFAULT "NS",
	"DirectReimbursableTitle"	TEXT(255) DEFAULT "NS",
	"ObjectClassGroupNumber"	TEXT(255) DEFAULT "NS",
	"ObjectClassGroupName"	TEXT(255) DEFAULT "NS",
	"FinanceObjectClass"	TEXT(255) DEFAULT "NS",
	"PriorYear"	REAL DEFAULT 0.0,
	"CurrentYear"	REAL DEFAULT 0.0,
	"BudgetYear"	REAL DEFAULT 0.0,
	PRIMARY KEY("ObjectClassOutlaysId" AUTOINCREMENT)
);
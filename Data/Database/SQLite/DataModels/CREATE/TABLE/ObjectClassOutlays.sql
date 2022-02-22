CREATE TABLE IF NOT EXISTS "ObjectClassOutlays" 
(
	"ObjectClassOutlaysId"	INTEGER NOT NULL UNIQUE,
	"ReportYear"	TEXT(80) NULL DEFAULT "NS",
	"OmbAgencyCode"	TEXT(80) NULL DEFAULT "NS",
	"OmbAgencyName"	TEXT(80) NULL DEFAULT "NS",
	"OmbBureauCode"	TEXT(80) NULL DEFAULT "NS",
	"OmbBureauName"	TEXT(80) NULL DEFAULT "NS",
	"OmbAccountCode"	TEXT(80) NULL DEFAULT "NS",
	"OmbAccountName"	TEXT(80) NULL DEFAULT "NS",
	"Direct/Reimbursable"	TEXT(80) NULL DEFAULT "NS",
	"DirectReimbursableTitle"	TEXT(80) NULL DEFAULT "NS",
	"ObjectClassGroupNumber"	TEXT(80) NULL DEFAULT "NS",
	"ObjectClassGroupName"	TEXT(80) NULL DEFAULT "NS",
	"FinanceObjectClass"	TEXT(80) NULL DEFAULT "NS",
	"PriorYear"	REAL DEFAULT 0.0,
	"CurrentYear"	REAL DEFAULT 0.0,
	"BudgetYear"	REAL DEFAULT 0.0,
	PRIMARY KEY("ObjectClassOutlaysId" AUTOINCREMENT)
);
CREATE TABLE IF NOT EXISTS "Obligations" 
(
	"ObligationsId"	INTEGER NOT NULL UNIQUE,
	"BFY"	TEXT(255),
	"EFY"	TEXT(255),
	"RpioCode"	TEXT(255),
	"RpioName"	TEXT(255),
	"AhCode"	TEXT(255),
	"AhName"	TEXT(255),
	"FundCode"	TEXT(255),
	"FundName"	TEXT(255),
	"OrgCode"	TEXT(255),
	"OrgName"	TEXT(255),
	"AccountCode"	TEXT(255),
	"ProgramProjectCode"	TEXT(255),
	"ProgramProjectName"	TEXT(255),
	"RcCode"	TEXT(255),
	"RcName"	TEXT(255),
	"DocumentType"	TEXT(255),
	"DocumentNumber"	TEXT(255),
	"DocumentControlNumber"	TEXT(255),
	"ReferenceDocumentNumber"	TEXT(255),
	"ProcessedDate"	TEXT(255),
	"LastActivityDate"	TEXT(255),
	"Age"	TEXT(255),
	"BocCode"	TEXT(255),
	"BocName"	TEXT(255),
	"FocCode"	TEXT(255),
	"FocName"	TEXT(255),
	"NpmCode"	TEXT(255),
	"NpmName"	TEXT(255),
	"VendorCode"	TEXT(255),
	"VendorName"	TEXT(255),
	"OpenCommitments"	REAL,
	"Obligations"	REAL,
	"ULO"	REAL,
	"Expenditures"	REAL,
	PRIMARY KEY("ObligationsId" AUTOINCREMENT)
)
CREATE TABLE IF NOT EXISTS "PayrollActivity" 
(
	"PayrollActivityId"	INTEGER NOT NULL UNIQUE,
	"BFY"	TEXT(255),
	"EFY"	TEXT(255),
	"RpioCode"	TEXT(255),
	"RpioName"	TEXT(255),
	"FundCode"	TEXT(255),
	"FundName"	TEXT(255),
	"AhCode"	TEXT(255),
	"AhName"	TEXT(255),
	"RcCode"	TEXT(255),
	"RcName"	TEXT(255),
	"SubRcCode"	TEXT(255),
	"SubRcName"	TEXT(255),
	"AccountCode"	TEXT(255),
	"ProgramProjectCode"	TEXT(255),
	"ProgramProjectName"	TEXT(255),
	"ProgramAreaCode"	TEXT(255),
	"ProgramAreaName"	TEXT(255),
	"NpmCode"	TEXT(255),
	"NpmName"	TEXT(255),
	"FocCode"	TEXT(255),
	"FocName"	TEXT(255),
	"HrOrgCode"	TEXT(255),
	"HrOrgName"	TEXT(255),
	"WorkCode"	TEXT(255),
	"WorkCodeName"	TEXT(255),
	"PayPeriod"	TEXT(255),
	"StartDate"	TEXT(255),
	"EndDate"	TEXT(255),
	"CheckDate"	TEXT(255),
	"Amount"	REAL,
	"Hours"	REAL,
	"BasePaid"	REAL,
	"BaseHours"	REAL,
	"Benefits"	REAL,
	"OvertimePaid"	REAL,
	"OvertimeHours"	REAL,
	PRIMARY KEY("PayrollActivityId")
);
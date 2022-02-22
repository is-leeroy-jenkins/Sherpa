CREATE TABLE "ProjectCostCodes" 
(
	"ProjectCostCodesId" INTEGER NOT NULL UNIQUE,
	"BFY"	TEXT(255) DEFAULT "NS",
	"RpioCode"	TEXT(255) DEFAULT "NS",
	"RpioName"	TEXT(255) DEFAULT "NS",
	"AhCode"	TEXT(255) DEFAULT "NS",
	"AhName"	TEXT(255) DEFAULT "NS",
	"FundCode"	TEXT(255) DEFAULT "NS",
	"FundName"	TEXT(255) DEFAULT "NS",
	"AccountCode"	TEXT(255) DEFAULT "NS",
	"ProgramProjectName"	TEXT(255) DEFAULT "NS",
	"BocCode"	TEXT(255) DEFAULT "NS",
	"BocName"	TEXT(255) DEFAULT "NS",
	"OrgCode"	TEXT(255) DEFAULT "NS",
	"OrgName"	TEXT(255) DEFAULT "NS",
	"VendorCode"	TEXT(255) DEFAULT "NS",
	"VendorName"	TEXT(255) DEFAULT "NS",
	PRIMARY KEY("ProjectCostCodeId" AUTOINCREMENT)
);
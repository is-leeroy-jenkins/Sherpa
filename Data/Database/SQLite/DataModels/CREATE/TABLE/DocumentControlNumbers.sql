CREATE TABLE IF NOT EXISTS "DocumentControlNumbers" 
(
	"DocumentControlNumberId"	INTEGER NOT NULL UNIQUE,
	"RpioCode"	TEXT(255) DEFAULT "NS",
	"RpioName"	TEXT(255) DEFAULT "NS",
	"DocumentType"	TEXT(255) DEFAULT "NS",
	"DocumentNumber"	TEXT(255) DEFAULT "NS",
	"DocumentPrefix"	TEXT(255) DEFAULT "NS",
	"DocumentControlNumber"	TEXT(255) DEFAULT "NS",
	PRIMARY KEY("DocumentControlNumberId" AUTOINCREMENT)
);
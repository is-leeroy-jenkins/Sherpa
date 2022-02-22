CREATE TABLE IF NOT EXISTS "DataRuleDescriptions" 
(
	"DataRuleDescriptionsId"	INTEGER NOT NULL UNIQUE,
	"Schedule"	TEXT(255) DEFAULT "NS",
	"LineNumber"	TEXT(255) DEFAULT "NS",
	"RuleNumber"	TEXT(255) DEFAULT "NS",
	"RuleDescription"	TEXT(255) DEFAULT "NS",
	"ScheduleOrder"	TEXT(255) DEFAULT "NS",
	PRIMARY KEY("DataRuleDescriptionsId" AUTOINCREMENT)
);
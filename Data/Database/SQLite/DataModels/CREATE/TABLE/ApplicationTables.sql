CREATE TABLE IF NOT EXISTS "ApplicationTables" 
(
	"ApplicationTablesId"	INTEGER NOT NULL UNIQUE,
	"TableName"	TEXT(255) NULL DEFAULT 'NS',
	"Model"	TEXT(255) NULL DEFAULT 'NS',
	CONSTRAINT "PrimaryKeyApplicationTables" PRIMARY KEY("ApplicationTablesId")
);
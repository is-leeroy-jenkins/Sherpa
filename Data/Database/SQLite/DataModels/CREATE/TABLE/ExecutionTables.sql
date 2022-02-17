CREATE TABLE ExecutionTables
(
	ExecutionTablesId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyExecutionTables PRIMARY KEY,
	TableName TEXT(255) NULL,
	TableType TEXT(50) NULL
);

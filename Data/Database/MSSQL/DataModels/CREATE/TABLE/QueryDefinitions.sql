CREATE TABLE QueryDefinitions
(
	QueryDefinitionsId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyQueryDefinitions PRIMARY KEY,
	Name TEXT(255) NULL,
	Type TEXT(255) NULL
);


CREATE TABLE Appropriations
(
	AppropriationsId AUTOINCREMENT NOT NULL UNIQUE,
	Code TEXT(150) NULL DEFAULT NS,
	Name TEXT(150) NULL DEFAULT NS,
	CONSTRAINT(AppropriationsPrimaryKey) 
		PRIMARY KEY(AppropriationsId )
);

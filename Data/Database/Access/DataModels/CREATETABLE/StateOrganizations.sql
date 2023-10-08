CREATE TABLE StateOrganizations
(
	StateOrganizationsId AUTOINCREMENT NOT NULL UNIQUE,
	Name TEXT(150) NULL DEFAULT NS,
	Code TEXT(150) NULL DEFAULT NS,
	OrgCode TEXT(150) NULL DEFAULT NS,
	RpioName TEXT(150) NULL DEFAULT NS,
	RpioCode TEXT(150) NULL DEFAULT NS,
	CONSTRAINT(StateOrganizationsPrimaryKey) 
		PRIMARY KEY(StateOrganizationsId )
);

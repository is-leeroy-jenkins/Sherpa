CREATE TABLE RegionalOffices
(
	RegionalOfficesId         AUTOINCREMENT NOT NULL UNIQUE,
	ResourcePlanningOfficesId INT           NULL,
	Code                      TEXT( 150 )   NULL DEFAULT NS,
	Name                      TEXT( 150 )   NULL DEFAULT NS, CONSTRAINT
(
	RegionalOfficesPrimaryKey
)
	PRIMARY KEY
(
	RegionalOfficesId
)
	);

CREATE TABLE Documents
(
	DocumentsId AUTOINCREMENT NOT NULL UNIQUE,
	Code        TEXT( 150 )   NULL DEFAULT NS,
	Category    TEXT( 150 )   NULL DEFAULT NS,
	Name        TEXT( 150 )   NULL DEFAULT NS,
	System      TEXT( 150 )   NULL DEFAULT NS, CONSTRAINT
(
	DocumentsPrimaryKey
)
	PRIMARY KEY
(
	DocumentsId
)
	);

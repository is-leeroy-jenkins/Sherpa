CREATE TABLE SchemaTypes
(
	SchemaTypesId INT NOT NULL UNIQUE,
	TypeName NVARCHAR(150) NULL DEFAULT ('NS'),
	Database NVARCHAR(150) NULL DEFAULT ('NS'),
	CONSTRAINT SchemaTypesPrimaryKey PRIMARY KEY
	(
		SchemaTypesId
	)
);

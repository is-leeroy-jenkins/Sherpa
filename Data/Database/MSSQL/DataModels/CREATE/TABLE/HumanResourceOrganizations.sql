IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'HumanResourceOrganizations' )
BEGIN
CREATE TABLE [dbo].[HumanResourceOrganizations]
(
	[HumanResourceOrganizationsId] INT NOT NULL,
	[Code] VARCHAR(80) NULL DEFAULT ('NS'),
	[Name] VARCHAR(80) NULL
);
END


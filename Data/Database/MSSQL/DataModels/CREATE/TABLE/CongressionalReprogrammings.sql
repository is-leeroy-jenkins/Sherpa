IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'CongressionalReprogrammings' )
BEGIN
CREATE TABLE [dbo].[CongressionalReprogrammings]
(
	[CongressionalReprogrammingsId] INT NOT NULL,
	[ReprogrammingNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[AhCode] VARCHAR(50) NULL,
	[AhName] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(80) NULL DEFAULT ('NS'),
	[OrgCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OrgName] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[FromTo] VARCHAR(80) NULL DEFAULT ('NS'),
	[ActivityCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[Amount] FLOAT NULL,
	[Description] VARCHAR(max) NULL,
	[ExtendedDescription] VARCHAR(max) NULL,
	[Cycle] VARCHAR(80) NULL
);
END


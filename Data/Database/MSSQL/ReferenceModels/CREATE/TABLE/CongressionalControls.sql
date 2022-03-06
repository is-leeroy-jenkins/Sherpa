IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'CongressionalControls' )
BEGIN
CREATE TABLE [dbo].[CongressionalControls]
(
	[CongressionalControlsId] INT IDENTITY(1,1) NOT NULL,
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(80) NULL DEFAULT ('NOT SPECIFIED'),
	[ProgramProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NOT SPECIFIED'),
	[SubProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[SubProjectName] VARCHAR(80) NULL DEFAULT ('NOT SPECIFIED'),
	[ReprogrammingRestriction] VARCHAR(80) NULL DEFAULT ('NS'),
	[IncreaseRestriction] VARCHAR(80) NULL DEFAULT ('NS'),
	[DecreaseRestriction] VARCHAR(80) NULL DEFAULT ('NS'),
	[MemoRequirement] VARCHAR(80) NULL DEFAULT ('NS')
);
END

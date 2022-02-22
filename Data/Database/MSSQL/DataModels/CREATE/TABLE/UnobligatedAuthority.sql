IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'UnobligatedAuthority' )
BEGIN
CREATE TABLE [dbo].[UnobligatedAuthority]
(
	[UnobligatedAuthorityId] INT IDENTITY(1,1) NOT NULL,
	[BudgetYear] VARCHAR(80) NULL DEFAULT ('NS'),
	[AgencyTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[BureauTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccount] VARCHAR(100) NULL,
	[AgencyCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BureauCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[Transmit] VARCHAR(80) NULL DEFAULT ('NS'),
	[Agency_Sequence] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccountTitle] VARCHAR(150) NULL DEFAULT ('NS'),
	[LineName] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[PriorYearAmount] FLOAT NULL DEFAULT 0,
	[CurrentYearAmount] FLOAT NULL DEFAULT 0,
	[BudgetYearAmount] FLOAT NULL DEFAULT 0
);
END
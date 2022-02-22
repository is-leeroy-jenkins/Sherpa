IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'CarryoverEstimates' )
BEGIN
CREATE TABLE [dbo].[CarryoverEstimates]
(
	[CarryoverEstimatesId] INT NOT NULL,
	[BudgetLevel] VARCHAR(80) NULL DEFAULT ('NS'),
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AhCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[AhName] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundName] VARCHAR(80) NULL DEFAULT ('NS'),
	[OrgCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AvailableBalance] FLOAT NULL,
	[OpenCommitments] FLOAT NULL,
	[UnobligatedAuthority] FLOAT NULL
);
END


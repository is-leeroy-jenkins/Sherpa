IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'StatusOfJobsActFunding' )
BEGIN
CREATE TABLE [dbo].[StatusOfJobsActFunding]
(
	[StatusOfJobsActFundingId] [int] NOT NULL,
	[StatusOfFundsId] [float] NOT NULL,
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
	[OrgName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(80) NULL DEFAULT ('NS'),
	[NpmCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[NpmName] VARCHAR(80) NULL DEFAULT ('NS'),
	[RcCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[RcName] VARCHAR(80) NULL DEFAULT ('NS'),
	[LowerName] VARCHAR(80) NULL DEFAULT ('NS'),
	[Amount] [float] NULL,
	[Budgeted] [float] NULL,
	[Posted] [float] NULL,
	[OpenCommitments] [float] NULL,
	[ULO] [float] NULL,
	[Expenditures] [float] NULL,
	[Obligations] [float] NULL,
	[Used] [float] NULL,
	[Available] [float] NULL
);
END


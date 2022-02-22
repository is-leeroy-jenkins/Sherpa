IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'InfrastructureAccounts' )
BEGIN
CREATE TABLE [dbo].[InfrastructureAccounts]
(
	[InfrastructureAccountsId] [int] NOT NULL,
	[StrategicPlan] VARCHAR(80) NULL DEFAULT ('NS'),
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[GoalCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ObjectiveCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[NpmCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[NpmName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ActivityCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ActivityName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramDescription] VARCHAR(80) NULL DEFAULT ('NS')
);
END


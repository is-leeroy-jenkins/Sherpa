IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'ObjectClassOutlays' )
BEGIN
CREATE TABLE [dbo].[ObjectClassOutlays]
(
	[ObjectClassOutlaysId] INT IDENTITY(1,1) NOT NULL,
	[ReportYear] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAgencyCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAgencyName] VARCHAR(100) NULL DEFAULT ('NS'),
	[OmbBureauCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbBureauName] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccountName] VARCHAR(MAX) NULL DEFAULT ('NS'),
	[Direct_Reimbursable] VARCHAR(80) NULL DEFAULT ('NS'),
	[DirectReimbursableTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[ObjectClassGroupNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[ObjectClassGroupName] VARCHAR(80) NULL DEFAULT ('NS'),
	[FinanceObjectClass] VARCHAR(80) NULL DEFAULT ('NS'),
	[PriorYear] MONEY NULL DEFAULT 0,
	[CurrentYear] MONEY NULL DEFAULT 0,
	[BudgetYear] MONEY NULL DEFAULT 0
 );
END
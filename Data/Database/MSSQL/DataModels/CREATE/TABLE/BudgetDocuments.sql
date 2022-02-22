IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'BudgetDocuments' )
BEGIN
CREATE TABLE [dbo].[BudgetDocuments]
(
	[BudgetDocumentsId] INT IDENTITY(1,1) NOT NULL,
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetLevel] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentDate] [datetime] NULL,
	[LastDocumentDate] [datetime] NULL,
	[DocumentType] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundName] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AhCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[AhName] VARCHAR(80) NULL DEFAULT ('NS'),
	[OrgCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OrgName] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramProjectName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[ProgramAreaName] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ReimbursableAgreementControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetingControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[PostingControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[PreCommitmentControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[CommitmentControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ObligationControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ExpenditureControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ExpenseControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccrualControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ReimbursementControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[Budgeted] FLOAT NULL DEFAULT 0,
	[Posted] FLOAT NULL DEFAULT 0,
	[CarryOut] FLOAT NULL DEFAULT 0,
	[CarryIn] FLOAT NULL DEFAULT 0,
	[EstimatedRecoveries] FLOAT NULL DEFAULT 0,
	[EstimatedReimbursements] FLOAT NULL DEFAULT 0
);
END
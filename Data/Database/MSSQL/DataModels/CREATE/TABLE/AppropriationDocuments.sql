IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'AppropriationDocuments' )
BEGIN
CREATE TABLE [dbo].[AppropriationDocuments]
(
	[[AppropriationDocumentsId] INT IDENTITY(1,1) NOT NULL DEFAULT ('NS'),
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[Fund] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentType] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentDate] [date] NOT NULL,
	[LastDocumentDate] [date] NOT NULL,
	[BudgetLevel] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetingControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[PostingControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[PreCommitmentControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[CommitmentControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ObligationControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccrualControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ExpenditureControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ExpenseControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ReimbursementControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[ReimbursableAgreementControls] VARCHAR(80) NULL DEFAULT ('NS'),
	[Budgeted] FLOAT NOT NULL DEFAULT 0,
	[Posted] FLOAT NOT NULL DEFAULT 0,
	[CarryOut] FLOAT NOT NULL DEFAULT 0,
	[CarryIn] FLOAT NOT NULL DEFAULT 0,
	[EstimatedReimbursements] FLOAT NOT NULL DEFAULT 0,
	[EstimatedRecoveries] FLOAT NOT NULL DEFAULT 0
);
END
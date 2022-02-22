IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'SpecialAccounts' )
BEGIN
CREATE TABLE [dbo].[SpecialAccounts]
(
	[SpecialAccountsId] INT IDENTITY(1,1) NOT NULL,
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[SpecialAccountFund] VARCHAR(80) NULL DEFAULT ('NS'),
	[SpecialAccountNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[SpecialAccountName] VARCHAR(100) NULL,
	[AccountStatus] VARCHAR(80) NULL DEFAULT ('NS'),
	[NplStatusCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[NplStatusName] VARCHAR(80) NULL DEFAULT ('NS'),
	[SiteId] VARCHAR(80) NULL DEFAULT ('NS'),
	[CerclisId] VARCHAR(80) NULL DEFAULT ('NS'),
	[SiteCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[SiteName] VARCHAR(100) NULL,
	[OperableUnit] VARCHAR(80) NULL DEFAULT ('NS'),
	[PipelineCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[PipelineDescription] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[TransactionType] VARCHAR(80) NULL DEFAULT ('NS'),
	[TransactionTypeName] VARCHAR(80) NULL DEFAULT ('NS'),
	[FocCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[FocName] VARCHAR(80) NULL DEFAULT ('NS'),
	[TransactionDate] DATE NULL,
	[AvailableBalance] FLOAT NULL DEFAULT 0,
	[OpenCommitments] FLOAT NULL DEFAULT 0,
	[Obligations] FLOAT NULL DEFAULT 0,
	[ULO] FLOAT NULL DEFAULT 0,
	[Disbursements] FLOAT NULL DEFAULT 0,
	[UnpaidBalances] FLOAT NULL DEFAULT 0,
	[Collections] FLOAT NULL DEFAULT 0,
	[CumulativeReceipts] FLOAT NULL DEFAULT 0
);
END



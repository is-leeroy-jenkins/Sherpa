IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'Apportionments' )
BEGIN
CREATE TABLE [dbo].[Apportionments]
(
	[ApportionmentsId] INT IDENTITY(1,1) NOT NULL,
	[Year] VARCHAR(80) NULL DEFAULT ('NS'),
	[ActivityId] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryFundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryFundSymbol] VARCHAR(100) DEFAULT ('NS'),
	[TreasuryAgency] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[AvailabilityType] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAccountTitle] VARCHAR(100) DEFAULT ('NS'),
	[BudgetAgency] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetBureau] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetAccount] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetAgencyTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetBureauTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[BudgetAccountTitle] VARCHAR(100) DEFAULT ('NS'),
	[DateApproved] [date] NULL,
	[LineNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineSort] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineDescription] VARCHAR(255) DEFAULT ('NS'),
	[Amount] FLOAT NOT NULL DEFAULT 0
);
END
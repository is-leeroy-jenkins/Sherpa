IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'Apportionments' )
BEGIN
CREATE TABLE [dbo].[Apportionments]
(
	[ApportionmentsId] INT IDENTITY(1,1) NOT NULL,
	[FiscalYear] VARCHAR(80) NULL DEFAULT ('NS'),
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[Availability] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryFundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryFundName] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAgencyCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAccountName] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAgencyCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbBureauCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccountCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAgencyName] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccountName] VARCHAR(80) NULL DEFAULT ('NS'),
	[ApprovalDate] [datetime] NULL,
	[LineNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineName] VARCHAR(80) NULL DEFAULT ('NS'),
	[Amount] FLOAT NULL,
	[Footnote] VARCHAR(80) NULL DEFAULT ('NS'),
	[Narrative] VARCHAR(max) NULL DEFAULT ('NOT SPECIFIED')
);
END

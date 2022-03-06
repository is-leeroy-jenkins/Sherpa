IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'TransTypes' )
BEGIN
CREATE TABLE [dbo].[TransTypes]
(
	[TransTypesId] INT IDENTITY(1,1) NOT NULL,
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[Appropriation] VARCHAR(max) NULL,
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasurySymbol] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocType] VARCHAR(80) NULL DEFAULT ('NS'),
	[AppropriationBill] VARCHAR(80) NULL DEFAULT ('NS'),
	[ContinuingResolution] VARCHAR(80) NULL DEFAULT ('NS'),
	[RescissionCurrentYear] VARCHAR(80) NULL DEFAULT ('NS'),
	[RescissionPriorYear] VARCHAR(80) NULL DEFAULT ('NS'),
	[SequesterReduction] VARCHAR(80) NULL DEFAULT ('NS'),
	[SequesterReturn] VARCHAR(80) NULL
);
END


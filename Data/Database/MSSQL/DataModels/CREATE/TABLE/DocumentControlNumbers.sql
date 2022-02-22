IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'DocumentControlNumbers' )
BEGIN
CREATE TABLE [dbo].[DocumentControlNumbers]
(
	[DocumentControlNumbersId] [int] NOT NULL,
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioName] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentType] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentPrefix] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentControlNumber] VARCHAR(80) NULL
);
END


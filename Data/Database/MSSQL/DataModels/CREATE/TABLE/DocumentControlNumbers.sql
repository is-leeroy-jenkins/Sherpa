IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'DocumentControlNumbers' )
BEGIN
CREATE TABLE [dbo].[DocumentControlNumbers]
(
	[DocumentControlNumbersId]  INT IDENTITY(1,1) NOT NULL,
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioName] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentType] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentPrefix] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentControlNumber] VARCHAR(80) NULL DEFAULT ('NS')
);
END


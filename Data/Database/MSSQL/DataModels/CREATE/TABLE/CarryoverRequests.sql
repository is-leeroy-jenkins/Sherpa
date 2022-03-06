IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'CarryoverRequests' )
BEGIN
CREATE TABLE [dbo].[CarryoverRequests]
(
	[CarryoverRequestsId] INT IDENTITY(1,1) NOT NULL,
	[ControlTeamAnalyst] VARCHAR(80) NULL DEFAULT ('NS'),
	[RpioCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[DocumentTitle] VARCHAR(100) NULL,
	[Amount] FLOAT NULL DEFAULT (0),
	[FundCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[Status] VARCHAR(80) NULL DEFAULT ('NS'),
	[OriginalRequestDate] DATETIME NULL,
	[LastActivityDate] DATETIME NULL,
	[BFS] VARCHAR(80) NULL DEFAULT ('NS'),
	[Comments] VARCHAR(80) NULL DEFAULT ('NS'),
	[RequestDocument] VARCHAR(80) NULL DEFAULT ('NS'),
	[Duration] VARCHAR(80) NULL DEFAULT ('NS')
);
ENd


IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'DataRuleDescriptions' )
BEGIN
CREATE TABLE [dbo].[DataRuleDescriptions]
(
	[DataRuleDescriptionsId]  INT IDENTITY(1,1) NOT NULL,
	[Schedule] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[RuleNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[RuleDescription] VARCHAR(max) NULL DEFAULT ('NS'),
	[ScheduleOrder] VARCHAR(80) NULL DEFAULT ('NS')
);
END


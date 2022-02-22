IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'DataRuleDescriptions' )
BEGIN
CREATE TABLE [dbo].[DataRuleDescriptions]
(
	[DataRuleDescriptionsId] [int] NOT NULL,
	[Schedule] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[RuleNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[RuleDescription] VARCHAR(max) NULL,
	[ScheduleOrder] VARCHAR(80) NULL
);
END


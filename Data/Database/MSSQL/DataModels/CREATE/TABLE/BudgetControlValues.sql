IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'BudgetControlValues' )
BEGIN
CREATE TABLE [dbo].[BudgetControlValues]
(
	[BudgetControlValuesId] INT IDENTITY(1,1) NOT NULL,
	[Code] VARCHAR(80) DEFAULT ('NS'),
	[Name] VARCHAR(80) DEFAULT ('NS'),
	[SecOrg] VARCHAR(80) DEFAULT ('NS'),
	[BdgtTransType] VARCHAR(80) DEFAULT ('NS'),
	[PstdTransType] VARCHAR(80) DEFAULT ('NS'),
	[EstReimTransType] VARCHAR(80) DEFAULT ('NS'),
	[SpngAdjTransType] VARCHAR(80) NULL DEFAULT ('NS'),
	[EstRecTransType] VARCHAR(80) DEFAULT ('NS'),
	[ActlRecTransType] VARCHAR(80) NULL DEFAULT ('NS'),
	[StatRsrvTransType] VARCHAR(80) DEFAULT ('NS'),
	[ProfLossTransType] VARCHAR(80) DEFAULT ('NS'),
	[EstReimSpngOpt] VARCHAR(80) DEFAULT ('NS'),
	[EstReimBdgtOpt] VARCHAR(80) DEFAULT ('NS'),
	[TrckAgreLowerLevel] VARCHAR(80) DEFAULT ('NS'),
	[BdgtEstLowerLevel] VARCHAR(80) DEFAULT ('NS'),
	[EstRecSpngOpt] VARCHAR(80) DEFAULT ('NS'),
	[EstRecBdgtOpt] VARCHAR(80) DEFAULT ('NS'),
	[RecNextLevel] VARCHAR(80) DEFAULT ('NS'),
	[RecBdgtMismatch] VARCHAR(80) DEFAULT ('NS'),
	[ProfitLossSpngOpt] VARCHAR(80) DEFAULT ('NS'),
	[ProfitLossBdgtOpt] VARCHAR(80) DEFAULT ('NS'),
	[RecCrryInLowerLevel] VARCHAR(80) DEFAULT ('NS'),
	[RecCrryInLowerLevelCtrl] VARCHAR(80) DEFAULT ('NS'),
	[RecCrryInAMCtrl] VARCHAR(80) DEFAULT ('NS'),
	[BdgtCtrl] VARCHAR(80) DEFAULT ('NS'),
	[PstdCtrl] VARCHAR(80) DEFAULT ('NS'),
	[PreCommSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[CommSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[ObligSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[AccrSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[ExpndSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[ExpnsSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[ReimSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[ReimAgreSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[FteBdgtCtrl] VARCHAR(80) DEFAULT ('NS'),
	[FteSpngCtrl] VARCHAR(80) DEFAULT ('NS'),
	[TransactionTypeCtrl] VARCHAR(80) DEFAULT ('NS'),
	[AuthorityDistributionCtrl] VARCHAR(80) DEFAULT ('NS')
);
END

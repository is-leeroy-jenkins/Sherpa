// <copyright file = "Source.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Identifies the Source
    /// </summary>
    public enum Source
    {
        /// <summary>
        /// The ns
        /// </summary>
        NS = 0,

        /// <summary>
        /// The accounting events
        /// </summary>
        AccountingEvents,

        /// <summary>
        /// Identifies the Appropriations
        /// </summary>
        Appropriations,

        /// <summary>
        /// Identifies the Activity
        /// </summary>
        Activity,

        /// <summary>
        /// Identifies the AppropriationBills
        /// </summary>
        AppropriationBills,

        /// <summary>
        /// Identifies the ARD
        /// </summary>
        ARD,

        /// <summary>
        /// Identifies the AllowanceHolders
        /// </summary>
        AllowanceHolders,

        /// <summary>
        /// Identifies the Allocations
        /// </summary>
        Allocations,

        /// <summary>
        /// Identifies the Accounts
        /// </summary>
        Accounts,

        /// <summary>
        /// Identifies the Awards
        /// </summary>
        Awards,

        /// <summary>
        /// The balances
        /// </summary>
        Balances,

        /// <summary>
        /// Identifies the BudgetObjectClasses
        /// </summary>
        BudgetObjectClasses,

        /// <summary>
        /// Identifies the ControlNumbers
        /// </summary>
        ControlNumbers,

        /// <summary>
        /// Identifies the CategoricalGrants
        /// </summary>
        CategoricalGrants,

        /// <summary>
        /// The carry over
        /// </summary>
        CarryOver,

        /// <summary>
        /// The commitments
        /// </summary>
        Commitments,

        /// <summary>
        /// Identifies the Contracts
        /// </summary>
        Contracts,

        /// <summary>
        /// Identifies the CleanWaterStateRevolvingFund
        /// </summary>
        CleanWaterStateRevolvingFund,

        /// <summary>
        /// Identifies the DivisionAuthority
        /// </summary>
        DivisionAuthority,

        /// <summary>
        /// Identifies the DrinkingWaterStateRevolvingFund
        /// </summary>
        DrinkingWaterStateRevolvingFund,

        /// <summary>
        /// The division execution
        /// </summary>
        DivisionExecution,

        /// <summary>
        /// Identifies the Divisions
        /// </summary>
        Divisions,

        /// <summary>
        /// The deobligations
        /// </summary>
        Deobligations,

        /// <summary>
        /// Identifies the DeepWaterHorizon
        /// </summary>
        DeepWaterHorizon,

        /// <summary>
        /// The documents
        /// </summary>
        Documents,

        /// <summary>
        /// Identifies the EJ
        /// </summary>
        EJ,

        /// <summary>
        /// Identifies the Employees
        /// </summary>
        Employees,

        /// <summary>
        /// Identifies the Expenses
        /// </summary>
        Expenses,

        /// <summary>
        /// Identifies the External
        /// </summary>
        External,

        /// <summary>
        /// Identifies the ECAD
        /// </summary>
        ECAD,

        /// <summary>
        /// Identifies the EPM
        /// </summary>
        EPM,

        /// <summary>
        /// Identifies the ExternalTransfers
        /// </summary>
        ExternalTransfers,

        /// <summary>
        /// The expenditures
        /// </summary>
        Expenditures,

        /// <summary>
        /// Identifies the Funds
        /// </summary>
        Funds,

        /// <summary>
        /// Identifies the FullTimeEquivalent
        /// </summary>
        FTE,

        /// <summary>
        /// Identifies the FiscalYears
        /// </summary>
        FiscalYears,

        /// <summary>
        /// Identifies the FinanceObjectClass
        /// </summary>
        FinanceObjectClass,

        /// <summary>
        /// Identifies the FullTimeUtilization Table
        /// </summary>
        FullTimeUtilization,

        /// <summary>
        /// Identifies the Grants
        /// </summary>
        Grants,

        /// <summary>
        /// Identifies the Goals
        /// </summary>
        Goals,

        /// <summary>
        /// The human resource data
        /// </summary>
        HumanResourceData,

        /// <summary>
        /// Identifies the HumanResourceOrganizations
        /// </summary>
        HumanResourceOrganizations,

        /// <summary>
        /// Identifies the TIM
        /// </summary>
        InformationTechnology,

        /// <summary>
        /// Identifies the InternalTransfers
        /// </summary>
        InternalTransfers,

        /// <summary>
        /// Identifies the LUST
        /// </summary>
        LUST,

        /// <summary>
        /// Identifies the LCARD
        /// </summary>
        LCARD,

        /// <summary>
        /// Identifies the LSASD
        /// </summary>
        LSASD,

        /// <summary>
        /// Identifies the LeaveProjections
        /// </summary>
        LeaveProjections,

        /// <summary>
        /// Identifies the LustSupplemental
        /// </summary>
        LustSupplemental,

        /// <summary>
        /// Identifies the MDR
        /// </summary>
        MSR,

        /// <summary>
        /// Identifies the MSD
        /// </summary>
        MSD,

        /// <summary>
        /// Creates new obligationalauthority.
        /// </summary>
        NewObligationalAuthority,

        /// <summary>
        /// Identifies the NationalPrograms
        /// </summary>
        NationalPrograms,

        /// <summary>
        /// Identifies the NonSiteTravel
        /// </summary>
        NonSiteTravel,

        /// <summary>
        /// Identifies the OilSpill
        /// </summary>
        OilSpill,

        /// <summary>
        /// Identifies the ORC
        /// </summary>
        ORC,

        /// <summary>
        /// Identifies the ORA
        /// </summary>
        ORA,

        /// <summary>
        /// Identifies the Objectives
        /// </summary>
        Objectives,

        /// <summary>
        /// Identifies the Organizations
        /// </summary>
        Organizations,

        /// <summary>
        /// Identifies the Outlays
        /// </summary>
        Outlays,

        /// <summary>
        /// The obligations
        /// </summary>
        Obligations,

        /// <summary>
        /// The open commitments
        /// </summary>
        OpenCommitments,

        /// <summary>
        /// Identifies the Overtime
        /// </summary>
        Overtime,

        /// <summary>
        /// Identifies the PayrollObligations
        /// </summary>
        PayrollObligations,

        /// <summary>
        /// Identifies the ProgramAreas
        /// </summary>
        ProgramAreas,

        /// <summary>
        /// Identifies the Payroll
        /// </summary>
        Payroll,

        /// <summary>
        /// The payroll hours
        /// </summary>
        PayrollHours,

        /// <summary>
        /// The procurements
        /// </summary>
        Procurements,

        /// <summary>
        /// The payments
        /// </summary>
        Payments,

        /// <summary>
        /// The purchase activity
        /// </summary>
        PurchaseActivity,

        /// <summary>
        /// Identifies the ProgramResultsCode
        /// </summary>
        PRC,

        /// <summary>
        /// Identifies the ProgramProjects
        /// </summary>
        ProgramProjects,

        /// <summary>
        /// Identifies the Programs
        /// </summary>
        Programs,

        /// <summary>
        /// Identifies the Purchases
        /// </summary>
        Purchases,

        /// <summary>
        /// Identifies the Reimbursables
        /// </summary>
        Reimbursables,

        /// <summary>
        /// The requisitions
        /// </summary>
        Requisitions,

        /// <summary>
        /// Identifies the ResourcePlanningOffices
        /// </summary>
        ResourcePlanningOffices,

        /// <summary>
        /// Identifies the ResponsibilityCenters
        /// </summary>
        ResponsibilityCenters,

        /// <summary>
        /// Identifies the Reprogrammings
        /// </summary>
        Reprogrammings,

        /// <summary>
        /// Identifies the RegionAuthority
        /// </summary>
        RegionAuthority,

        /// <summary>
        /// Identifies the STAG
        /// </summary>
        STAG,

        /// <summary>
        /// Identifies the SF6A
        /// </summary>
        SF6A,

        /// <summary>
        /// Identifies the Sites
        /// </summary>
        Sites,

        /// <summary>
        /// Identifies the Superfund
        /// </summary>
        Superfund,

        /// <summary>
        /// Identifies the SpecialAccounts
        /// </summary>
        SpecialAccounts,

        /// <summary>
        /// Identifies the SuperfundSupplemental
        /// </summary>
        SuperfundSupplemental,

        /// <summary>
        /// Identifies the SpecialProjectsAndEarmarks
        /// </summary>
        SpecialProjects,

        /// <summary>
        /// Identifies the SiteTravel
        /// </summary>
        SiteTravel,

        /// <summary>
        /// Identifies the SEMD
        /// </summary>
        SEMD,

        /// <summary>
        /// Identifies the Supplemental
        /// </summary>
        Supplemental,

        /// <summary>
        /// Identifies the Transfers
        /// </summary>
        Transfers,

        /// <summary>
        /// Identifies the TravelObligations
        /// </summary>
        TravelObligations,

        /// <summary>
        /// Identifies the TimeOff
        /// </summary>
        TimeOff,

        /// <summary>
        /// Identifies the Travel
        /// </summary>
        Travel,

        /// <summary>
        /// Identifies the Utilization
        /// </summary>
        Utilization,

        /// <summary>
        /// The unliquidated obligations
        /// </summary>
        ULO,

        /// <summary>
        /// The vendors
        /// </summary>
        Vendors,

        /// <summary>
        /// Identifies the WD
        /// </summary>
        WD,

        /// <summary>
        /// Identifies the WSA
        /// </summary>
        WSA,

        /// <summary>
        /// Identifies the WCF
        /// </summary>
        WCF,

        /// <summary>
        /// Identifies the WorkforceData
        /// </summary>
        WorkforceData,

        /// <summary>
        /// Identifies the WorkCodes
        /// </summary>
        WorkCodes,

        /// <summary>
        /// Identifies the XA
        /// </summary>
        XA
    }
}

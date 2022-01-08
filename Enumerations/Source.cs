// <copyright file = "Source.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
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
        /// The appropriations
        /// </summary>
        Appropriations,

        /// <summary>
        /// The activity
        /// </summary>
        ActivityCodes,

        /// <summary>
        /// The appropriation bills
        /// </summary>
        AppropriationBills,

        /// <summary>
        /// The appropriation documents
        /// </summary>
        AppropriationDocuments,

        /// <summary>
        /// The allowance holders
        /// </summary>
        AllowanceHolders,

        /// <summary>
        /// The application tables
        /// </summary>
        ApplicationTables,

        /// <summary>
        /// The apportionments
        /// </summary>
        Apportionments,

        /// <summary>
        /// The allocations
        /// </summary>
        Allocations,

        /// <summary>
        /// The accounts
        /// </summary>
        Accounts,
        
        /// <summary>
        /// The budget documents
        /// </summary>
        BudgetDocuments,

        /// <summary>
        /// The budget controls
        /// </summary>
        BudgetControls,

        /// <summary>
        /// The budget outlays
        /// </summary>
        BudgetOutlays,

        /// <summary>
        /// The budget object classes
        /// </summary>
        BudgetObjectClasses,

        /// <summary>
        /// The carryover balances
        /// </summary>
        CarryoverBalances,

        /// <summary>
        /// The carryover outlays
        /// </summary>
        CarryoverOutlays,

        /// <summary>
        /// The carryover survey
        /// </summary>
        CarryoverSurvey,

        /// <summary>
        /// The changes
        /// </summary>
        Changes,

        /// <summary>
        /// The congressional reprogrammings
        /// </summary>
        CongressionalReprogrammings,

        /// <summary>
        /// The cost areas
        /// </summary>
        CostAreas,

        /// <summary>
        /// The cpic
        /// </summary>
        CPIC,

        /// <summary>
        /// The data rule descriptions
        /// </summary>
        DataRuleDescriptions,

        /// <summary>
        /// The defactos
        /// </summary>
        Defactos,

        /// <summary>
        /// The document control numbers
        /// </summary>
        DocumentControlNumbers,

        /// <summary>
        /// The execution tables
        /// </summary>
        ExecutionTables,

        /// <summary>
        /// The federal holidays
        /// </summary>
        FederalHolidays,
        
        /// <summary>
        /// The deobligations
        /// </summary>
        Deobligations,

        /// <summary>
        /// The documents
        /// </summary>
        Documents,

        /// <summary>
        /// The external
        /// </summary>
        External,

        /// <summary>
        /// The funds
        /// </summary>
        Funds,

        /// <summary>
        /// The full time equivalents
        /// </summary>
        FullTimeEquivalents,

        /// <summary>
        /// The fiscal years
        /// </summary>
        FiscalYears,

        /// <summary>
        /// The finance object class
        /// </summary>
        FinanceObjectClasses,

        /// <summary>
        /// The growth rates
        /// </summary>
        GrowthRates,

        /// <summary>
        /// The gs pay scale
        /// </summary>
        GsPayScale,

        /// <summary>
        /// The headquarters authority
        /// </summary>
        HeadquartersAuthority,

        /// <summary>
        /// The images
        /// </summary>
        Images,

        /// <summary>
        /// The messages
        /// </summary>
        Messages,

        /// <summary>
        /// The goals
        /// </summary>
        Goals,

        /// <summary>
        /// The human resource organizations
        /// </summary>
        HumanResourceOrganizations,

        /// <summary>
        /// The information technology
        /// </summary>
        InformationTechnology,

        /// <summary>
        /// The regional authority
        /// </summary>
        RegionalAuthority,

        /// <summary>
        /// The monthly outlays
        /// </summary>
        MonthlyOutlays,

        /// <summary>
        /// The national programs
        /// </summary>
        NationalPrograms,

        /// <summary>
        /// The objectives
        /// </summary>
        Objectives,

        /// <summary>
        /// The organizations
        /// </summary>
        Organizations,

        /// <summary>
        /// The obligations
        /// </summary>
        Obligations,

        /// <summary>
        /// The object class outlays
        /// </summary>
        ObjectClassOutlays,

        /// <summary>
        /// The operating plans
        /// </summary>
        OperatingPlans,

        /// <summary>
        /// The payroll activity
        /// </summary>
        PayrollActivity,

        /// <summary>
        /// The program areas
        /// </summary>
        ProgramAreas,

        /// <summary>
        /// The payroll authority
        /// </summary>
        PayrollAuthority,

        /// <summary>
        /// The payroll cost codes
        /// </summary>
        PayrollCostCodes,

        /// <summary>
        /// The project cost codes
        /// </summary>
        ProjectCostCodes,

        /// <summary>
        /// The program projects
        /// </summary>
        ProgramProjects,

        /// <summary>
        /// The program descriptions
        /// </summary>
        ProgramDescriptions,

        /// <summary>
        /// The projects
        /// </summary>
        Projects,

        /// <summary>
        /// The providers
        /// </summary>
        Providers,

        /// <summary>
        /// The pay periods
        /// </summary>
        PayPeriods,

        /// <summary>
        /// The program finance schedule
        /// </summary>
        ProgramFinanceSchedule,

        /// <summary>
        /// The query definitions
        /// </summary>
        QueryDefinitions,

        /// <summary>
        /// The reimbursable funds
        /// </summary>
        ReimbursableFunds,

        /// <summary>
        /// The reimbursable agreements
        /// </summary>
        ReimbursableAgreements,

        /// <summary>
        /// The reimbursable survey
        /// </summary>
        ReimbursableSurvey,

        /// <summary>
        /// The reports
        /// </summary>
        Reports,

        /// <summary>
        /// The requisitions
        /// </summary>
        ReferenceTables,

        /// <summary>
        /// The resource planning offices
        /// </summary>
        ResourcePlanningOffices,

        /// <summary>
        /// The responsibility centers
        /// </summary>
        ResponsibilityCenters,

        /// <summary>
        /// The reprogrammings
        /// </summary>
        Reprogrammings,

        /// <summary>
        /// The region authority
        /// </summary>
        RegionAuthority,

        /// <summary>
        /// The schema types
        /// </summary>
        SchemaTypes,

        /// <summary>
        /// The status of appropriations
        /// </summary>
        StatusOfAppropriations,

        /// <summary>
        /// The status of funds
        /// </summary>
        StatusOfFunds,

        /// <summary>
        /// The spending rates
        /// </summary>
        SpendingRates,

        /// <summary>
        /// The s F133
        /// </summary>
        SF133,

        /// <summary>
        /// The state organizations
        /// </summary>
        StateOrganizations,

        /// <summary>
        /// The state grant obligations
        /// </summary>
        StateGrantObligations,

        /// <summary>
        /// The site activity
        /// </summary>
        SiteActivity,

        /// <summary>
        /// The site project codes
        /// </summary>
        SiteProjectCodes,

        /// <summary>
        /// The superfund sites
        /// </summary>
        SuperfundSites,

        /// <summary>
        /// The special accounts
        /// </summary>
        SpecialAccounts,

        /// <summary>
        /// The supplementals
        /// </summary>
        Supplementals,

        /// <summary>
        /// The transfers
        /// </summary>
        Transfers,

        /// <summary>
        /// The trans types
        /// </summary>
        TransTypes,

        /// <summary>
        /// The travel activity
        /// </summary>
        TravelActivity,
        
        /// <summary>
        /// The work codes
        /// </summary>
        WorkCodes
    }
}

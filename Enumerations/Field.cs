// <copyright file = "Field.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public enum Field
    {
        //************************************************************************************ */
        //*******************                  Actuals           **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The rpio activity code
        /// </summary>
        RpioActivityCode,

        /// <summary>
        /// The rpio activity name
        /// </summary>
        RpioActivityName,

        //************************************************************************************ */
        //*******************     Administrative   Requests      **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The BFS
        /// </summary>
        BFS,

        /// <summary>
        /// The comments
        /// </summary>
        Comments,

        /// <summary>
        /// The type code
        /// </summary>
        TypeCode,

        /// <summary>
        /// The decision
        /// </summary>
        Decision,

        /// <summary>
        /// The request type
        /// </summary>
        RequestType,

        /// <summary>
        /// The last activity date
        /// </summary>
        LastActivityDate,

        /// <summary>
        /// The original request date
        /// </summary>
        OriginalRequestDate,

        //************************************************************************************ */
        //*******************            Apportionments           **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The treasury fund code
        /// </summary>
        TreasuryFundCode,

        /// <summary>
        /// The treasury fund name
        /// </summary>
        TreasuryFundName,

        /// <summary>
        /// The treasury agency code
        /// </summary>
        TreasuryAgencyCode,

        /// <summary>
        /// The treasury account code
        /// </summary>
        TreasuryAccountCode,

        /// <summary>
        /// The treasury account name
        /// </summary>
        TreasuryAccountName,

        /// <summary>
        /// The omb agency code
        /// </summary>
        OmbAgencyCode,

        /// <summary>
        /// The omb agency name
        /// </summary>
        OmbAgencyName,

        /// <summary>
        /// The omb account code
        /// </summary>
        OmbAccountCode,

        /// <summary>
        /// The omb account name
        /// </summary>
        OmbAccountName,

        /// <summary>
        /// The foot note
        /// </summary>
        FootNote,

        /// <summary>
        /// The line number
        /// </summary>
        LineNumber,

        /// <summary>
        /// The line name
        /// </summary>
        LineName,

        //************************************************************************************ */
        //*******************   Appropriation Documents          **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The budgeting controls
        /// </summary>
        BudgetingControls,

        /// <summary>
        /// The posting controls
        /// </summary>
        PostingControls,

        /// <summary>
        /// The pre commitment controls
        /// </summary>
        PreCommitmentControls,

        /// <summary>
        /// The commitment controls
        /// </summary>
        CommitmentControls,

        /// <summary>
        /// The obligation controls
        /// </summary>
        ObligationControls,

        /// <summary>
        /// The accrual controls
        /// </summary>
        AccrualControls,

        /// <summary>
        /// The expenditure controls
        /// </summary>
        ExpenditureControls,

        /// <summary>
        /// The reimbursement controls
        /// </summary>
        ReimbursementControls,

        /// <summary>
        /// The reimbursable agreement controls
        /// </summary>
        ReimbursableAgreementControls,

        /// <summary>
        /// The carry in
        /// </summary>
        CarryIn,

        /// <summary>
        /// The carry out
        /// </summary>
        CarryOut,

        /// <summary>
        /// The budgeted
        /// </summary>
        Budgeted,

        /// <summary>
        /// The posted
        /// </summary>
        Posted,

        /// <summary>
        /// The estimated reimbursments
        /// </summary>
        EstimatedReimbursments,

        /// <summary>
        /// The estimated recoveries
        /// </summary>
        EstimatedRecoveries,

        //************************************************************************************ */
        //*******************                 WorkCodes           **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The ns
        /// </summary>
        NS = 0,

        /// <summary>
        /// The duns number
        /// </summary>
        DunsNumber,

        /// <summary>
        /// The closed date
        /// </summary>
        ClosedDate,

        /// <summary>
        /// The vendor name
        /// </summary>
        VendorName,

        /// <summary>
        /// The vendor code
        /// </summary>
        VendorCode,

        /// <summary>
        /// The security org
        /// </summary>
        SecurityOrg,
        
        /// <summary>
        /// The description
        /// </summary>
        Description,

        /// <summary>
        /// The requested by
        /// </summary>
        RequestedBy,

        //************************************************************************************ */
        //*******************              ReferenceTables             ************************** */
        //************************************************************************************ */

        /// <summary>
        /// The request date
        /// </summary>
        RequestDate,

        /// <summary>
        /// The modified by
        /// </summary>
        ModifiedBy,

        /// <summary>
        /// The created by
        /// </summary>
        CreatedBy,

        /// <summary>
        /// The document date
        /// </summary>
        DocumentDate,

        /// <summary>
        /// The request number
        /// </summary>
        RequestNumber,

        //************************************************************************************ */
        //*******************          Program Elements           **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The code
        /// </summary>
        Code,

        /// <summary>
        /// The name
        /// </summary>
        Name,

        /// <summary>
        /// The title
        /// </summary>
        Title,

        //************************************************************************************ */
        //*******************     HumanResourceOrganizations      **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The hr org code
        /// </summary>
        HrOrgCode,
        
        /// <summary>
        /// The hr org name
        /// </summary>
        HrOrgName,
        
        //************************************************************************************ */
        //*******************          WorkCodes                  **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The work code
        /// </summary>
        WorkCode,

        /// <summary>
        /// The work code name
        /// </summary>
        WorkCodeName,
        
        /// <summary>
        /// The short name
        /// </summary>
        ShortName,

        /// <summary>
        /// The charge type
        /// </summary>
        ChargeType,

        /// <summary>
        /// The prevent new use
        /// </summary>
        PreventNewUse,

        /// <summary>
        /// The re org code
        /// </summary>
        ReOrgCode,

        /// <summary>
        /// The active
        /// </summary>
        Active,

        /// <summary>
        /// The budget year
        /// </summary>
        BudgetYear,
        
        /// <summary>
        /// The approver user name
        /// </summary>
        ApprovedBy,

        /// <summary>
        /// The approved date
        /// </summary>
        ApprovalDate,

        /// <summary>
        /// The modifier user name
        /// </summary>
        ModifiedDate,
        
        /// <summary>
        /// The work project code
        /// </summary>
        WorkProjectCode,

        /// <summary>
        /// The work project name
        /// </summary>
        WorkProjectName,

        /// <summary>
        /// The percentage
        /// </summary>
        Percentage,

        //************************************************************************************ */
        //*******************      PayrollCostCodes                   ************************ */
        //************************************************************************************ */
        
        /// <summary>
        /// The employee number
        /// </summary>
        SubRcCode,

        /// <summary>
        /// The sub rc name
        /// </summary>
        SubRcName,

        //************************************************************************************ */
        //*******************      TravelActivity              **************************** */
        //************************************************************************************ */
        
        /// <summary>
        /// The address
        /// </summary>
        Duration,

        /// <summary>
        /// The departure date
        /// </summary>
        StartDate,

        /// <summary>
        /// The return date
        /// </summary>
        EndDate,

        /// <summary>
        /// The document control number
        /// </summary>
        DocumentControlNumber,

        /// <summary>
        /// The document type
        /// </summary>
        DocumentType,

        /// <summary>
        /// The document prefix
        /// </summary>
        DocumentPrefix,

        /// <summary>
        /// The original action date
        /// </summary>
        OriginalActionDate,

        /// <summary>
        /// The grant number
        /// </summary>
        GrantNumber,

        /// <summary>
        /// The obligating document number
        /// </summary>
        ObligatingDocumentNumber,

        /// <summary>
        /// The system
        /// </summary>
        System,

        /// <summary>
        /// The transaction number
        /// </summary>
        TransactionNumber,

        /// <summary>
        /// The purchase request
        /// </summary>
        PurchaseRequest,

        //************************************************************************************ */
        //*******************                Employees            **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The first name
        /// </summary>
        FirstName,

        /// <summary>
        /// The last name
        /// </summary>
        LastName,

        /// <summary>
        /// The section
        /// </summary>
        Section,

        /// <summary>
        /// The email
        /// </summary>
        Email,

        /// <summary>
        /// The office
        /// </summary>
        Office,

        /// <summary>
        /// The phone number
        /// </summary>
        PhoneNumber,

        /// <summary>
        /// The cell number
        /// </summary>
        CellNumber,

        /// <summary>
        /// The status
        /// </summary>
        Status,
        
        //************************************************************************************ */
        //*******************        ReimbursableFunds                **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The reimbursable agreement number
        /// </summary>
        ReimbursableAgreementNumber,

        /// <summary>
        /// The agreement number
        /// </summary>
        AgreementNumber,

        //************************************************************************************ */
        //*******************                Transfers            **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The document type
        /// </summary>
        DocType,

        /// <summary>
        /// The document number
        /// </summary>
        DocumentNumber,

        /// <summary>
        /// The reprogramming number
        /// </summary>
        ReprogrammingNumber,

        /// <summary>
        /// The processed date
        /// </summary>
        ProcessedDate,

        /// <summary>
        /// The resource type
        /// </summary>
        ResourceType,

        /// <summary>
        /// The line
        /// </summary>
        Line,

        /// <summary>
        /// The subline
        /// </summary>
        Subline,

        /// <summary>
        /// From to
        /// </summary>
        FromTo,

        /// <summary>
        /// The purpose
        /// </summary>
        Purpose,

        //************************************************************************************ */
        //*******************    PayrollActivity               **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The pay period
        /// </summary>
        PayPeriod,

        /// <summary>
        /// The calendar date
        /// </summary>
        CalendarDate,

        //************************************************************************************ */
        //*******************          Allocations                **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The allocation identifier
        /// </summary>
        AllocationsId,
        
        //************************************************************************************ */
        //*******************         ProgramProjects             **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The program project code
        /// </summary>
        ProgramProjectCode,

        /// <summary>
        /// The program project name
        /// </summary>
        ProgramProjectName,

        /// <summary>
        /// The laws
        /// </summary>
        Laws,

        /// <summary>
        /// The narrative
        /// </summary>
        Narrative,

        /// <summary>
        /// The definition
        /// </summary>
        Definition,

        //************************************************************************************ */
        //*******************                ProgramResultsCode   **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The budget level
        /// </summary>
        BudgetLevel,

        //************************************************************************************ */
        //*******************              Accounts               **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The account code
        /// </summary>
        AccountCode,

        /// <summary>
        /// The account name
        /// </summary>
        AccountName,

        //************************************************************************************ */
        //*******************    AppropriationBills               **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The public law
        /// </summary>
        PublicLaw,

        /// <summary>
        /// The enacted date
        /// </summary>
        EnactedDate,

        //************************************************************************************ */
        //*******************       FinanceObjectClasses            **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The foc code
        /// </summary>
        FocCode,

        /// <summary>
        /// The finance object class code
        /// </summary>
        FinanceObjectClassCode,

        /// <summary>
        /// The foc name
        /// </summary>
        FocName,

        /// <summary>
        /// The finance object class name
        /// </summary>
        FinanceObjectClassName,

        //************************************************************************************ */
        //*******************         BudgetObjectClasses           **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The boc code
        /// </summary>
        BocCode,

        /// <summary>
        /// The budget object class code
        /// </summary>
        BudgetObjectClassCode,

        /// <summary>
        /// The boc name
        /// </summary>
        BocName,

        /// <summary>
        /// The budget object class name
        /// </summary>
        BudgetObjectClassName,

        //************************************************************************************ */
        //*******************       SubAppropriations          **************************** */
        //************************************************************************************ */
        /// <summary>
        /// The sub appropriation code
        /// </summary>
        SubAppropriationCode,

        /// <summary>
        /// The sub appropriation name
        /// </summary>
        SubAppropriationName,

        //************************************************************************************ */
        //*******************   ResponsibilityCenter              **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The rc code
        /// </summary>
        RcCode,

        /// <summary>
        /// The responsibility center code
        /// </summary>
        ResponsibilityCenterCode,

        /// <summary>
        /// The rc name
        /// </summary>
        RcName,

        /// <summary>
        /// The responsibility center name
        /// </summary>
        ResponsibilityCenterName,

        //************************************************************************************ */
        //*******************           Appropriations            **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The appropriation code
        /// </summary>
        AppropriationCode,

        /// <summary>
        /// The appropriation name
        /// </summary>
        AppropriationName,

        //************************************************************************************ */
        //*******************            Funds                    **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The fund code
        /// </summary>
        FundCode,

        /// <summary>
        /// The fund name
        /// </summary>
        FundName,

        /// <summary>
        /// The treasury symbol
        /// </summary>
        TreasurySymbol,

        //************************************************************************************ */
        //*******************          ActivityCodes                   **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The activity code
        /// </summary>
        ActivityCode,

        /// <summary>
        /// The activity name
        /// </summary>
        ActivityName,

        //************************************************************************************ */
        //*******************            FiscalYears              **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The bfy
        /// </summary>
        BFY,

        /// <summary>
        /// The bbfy
        /// </summary>
        BBFY,

        /// <summary>
        /// The ebfy
        /// </summary>
        EBFY,

        /// <summary>
        /// The first year
        /// </summary>
        FirstYear,

        /// <summary>
        /// The last year
        /// </summary>
        LastYear,

        /// <summary>
        /// The cancellation date
        /// </summary>
        CancellationDate,

        /// <summary>
        /// The expiring year
        /// </summary>
        ExpiringYear,

        /// <summary>
        /// The availability
        /// </summary>
        Availability,

        /// <summary>
        /// The fiscal year
        /// </summary>
        FiscalYear,

        /// <summary>
        /// The work days
        /// </summary>
        WorkDays,

        /// <summary>
        /// The week days
        /// </summary>
        WeekDays,

        /// <summary>
        /// The week ends
        /// </summary>
        WeekEnds,

        //************************************************************************************ */
        //*******************             Holidays                 **************************** */
        //************************************************************************************ */

        /// <summary>
        /// Creates new years.
        /// </summary>
        NewYears,

        /// <summary>
        /// The martin luther king
        /// </summary>
        MartinLutherKing,

        /// <summary>
        /// The presidents
        /// </summary>
        Presidents,

        /// <summary>
        /// The memorial
        /// </summary>
        Memorial,
        
        /// <summary>
        /// The juneteenth
        /// </summary>
        Juneteenth,

        /// <summary>
        /// The independence
        /// </summary>
        Independence,

        /// <summary>
        /// The veterans
        /// </summary>
        Veterans,

        /// <summary>
        /// The labor
        /// </summary>
        Labor,

        /// <summary>
        /// The columbus
        /// </summary>
        Columbus,

        /// <summary>
        /// The thanksgiving
        /// </summary>
        Thanksgiving,

        /// <summary>
        /// The christmas
        /// </summary>
        Christmas,

        //************************************************************************************ */
        //*******************             Supplementals            **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The type
        /// </summary>
        Type,

        /// <summary>
        /// The time
        /// </summary>
        Time,

        //************************************************************************************ */
        //*******************            NationalPrograms         **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The NPM code
        /// </summary>
        NpmCode,
        
        /// <summary>
        /// The NPM name
        /// </summary>
        NpmName,
        
        //************************************************************************************ */
        //*******************           Organizations             **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The org code
        /// </summary>
        OrgCode,

        /// <summary>
        /// The organization code
        /// </summary>
        OrganizationCode,

        /// <summary>
        /// The org name
        /// </summary>
        OrgName,

        /// <summary>
        /// The organization name
        /// </summary>
        OrganizationName,

        /// <summary>
        /// The cost org code
        /// </summary>
        CostOrgCode,
        
        /// <summary>
        /// The cost org name
        /// </summary>
        CostOrgName,
        
        //************************************************************************************ */
        //*******************    ResourcePlanningOffices          **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The rpio code
        /// </summary>
        RpioCode,
        
        /// <summary>
        /// The rpio name
        /// </summary>
        RpioName,
        
        //************************************************************************************ */
        //*******************        AllowanceHolders             **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The ah code
        /// </summary>
        AhCode,
        
        /// <summary>
        /// The ah name
        /// </summary>
        AhName,
        
        //************************************************************************************ */
        //*******************              Divisions              **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The division
        /// </summary>
        Division,

        /// <summary>
        /// The division name
        /// </summary>
        DivisionName,

        /// <summary>
        /// The caption
        /// </summary>
        Caption,

        //************************************************************************************ */
        //*******************                 Objectives        **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The objective code
        /// </summary>
        ObjectiveCode,

        /// <summary>
        /// The objective name
        /// </summary>
        ObjectiveName,

        //************************************************************************************ */
        //*******************                 Goals               **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The goal code
        /// </summary>
        GoalCode,

        /// <summary>
        /// The goal name
        /// </summary>
        GoalName,

        //************************************************************************************ */
        //*******************             ProgramAreas            **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The program area code
        /// </summary>
        ProgramAreaCode,

        /// <summary>
        /// The program area name
        /// </summary>
        ProgramAreaName,

        //************************************************************************************ */
        //*******************          Projects                   **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The project code
        /// </summary>
        ProjectCode,

        /// <summary>
        /// The project name
        /// </summary>
        ProjectName,

        /// <summary>
        /// The site project code
        /// </summary>
        SiteProjectCode,

        /// <summary>
        /// The site project name
        /// </summary>
        SiteProjectName,

        //************************************************************************************ */
        //*******************                   SiteActivity             ********************* */
        //************************************************************************************ */

        /// <summary>
        /// The site name
        /// </summary>
        SiteName,

        /// <summary>
        /// The epa site identifier
        /// </summary>
        EpaSiteId,

        /// <summary>
        /// The city
        /// </summary>
        City,

        /// <summary>
        /// The district
        /// </summary>
        District,

        /// <summary>
        /// The county
        /// </summary>
        County,

        /// <summary>
        /// The state name
        /// </summary>
        StateName,

        /// <summary>
        /// The state code
        /// </summary>
        StateCode,

        /// <summary>
        /// The street address line1
        /// </summary>
        StreetAddressLine1,

        /// <summary>
        /// The street address line2
        /// </summary>
        StreetAddressLine2,

        /// <summary>
        /// The zip code
        /// </summary>
        ZipCode,

        //************************************************************************************ */
        //*******************     INFORMATION TECHNOLOGY            ************************** */
        //************************************************************************************ */

        /// <summary>
        /// The cost area code
        /// </summary>
        CostAreaCode,

        /// <summary>
        /// The cost area name
        /// </summary>
        CostAreaName
    }
}

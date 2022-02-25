// <copyright file = "Numeric.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public enum Numeric
    {
        //************************************************************************************ */
        //*******************          Program Elements           **************************** */
        //************************************************************************************ */

        NS = 0,

        /// <summary>
        /// The identifier
        /// </summary>
        Id,

        /// <summary>
        /// The year to date earned
        /// </summary>
        YearToDateEarned,

        /// <summary>
        /// The year to date used
        /// </summary>
        YearToDateUsed,

        /// <summary>
        /// The maximum leave carryover
        /// </summary>
        MaxLeaveCarryover,

        /// <summary>
        /// The maximum carryover excess
        /// </summary>
        MaxCarryoverExcess,

        /// <summary>
        /// The projected pay period
        /// </summary>
        ProjectedPayPeriod,

        /// <summary>
        /// The projected annual
        /// </summary>
        ProjectedAnnual,

        /// <summary>
        /// The use or lose
        /// </summary>
        UseOrLose,

        /// <summary>
        /// The available hours
        /// </summary>
        AvailableHours,

        /// <summary>
        /// The annual base hours
        /// </summary>
        AnnualBaseHours,

        /// <summary>
        /// The cumulative benefits
        /// </summary>
        CumulativeBenefits,

        /// <summary>
        /// The annual other paid
        /// </summary>
        AnnualOtherPaid,

        /// <summary>
        /// The annual overtime hours
        /// </summary>
        AnnualOvertimeHours,

        /// <summary>
        /// The expended
        /// </summary>
        Expended,

        //************************************************************* */
        //**************       ProgramResultsCode-   ****************** */
        //************************************************************* */

        /// <summary>
        /// The amount
        /// </summary>
        Amount,

        //************************************************************* */
        //**************        OUTLAY  FIELDS       ****************** */
        //************************************************************* */

        /// <summary>
        /// The rate
        /// </summary>
        Rate,

        /// <summary>
        /// The obligations
        /// </summary>
        Obligations,

        /// <summary>
        /// The unliquidated obligations
        /// </summary>
        ULO,

        /// <summary>
        /// The deobligations
        /// </summary>
        Deobligations,

        /// <summary>
        /// The commitments
        /// </summary>
        Commitments,

        /// <summary>
        /// The open commitments
        /// </summary>
        OpenCommitments,
        
        /// <summary>
        /// The expenditures
        /// </summary>
        Expenditures,

        /// <summary>
        /// The authority
        /// </summary>
        Authority,

        /// <summary>
        /// The budgeted
        /// </summary>
        Budgeted,

        /// <summary>
        /// The posted
        /// </summary>
        Posted,

        /// <summary>
        /// The balance
        /// </summary>
        Balance,

        /// <summary>
        /// The hours
        /// </summary>
        Hours,

        /// <summary>
        /// The carry in
        /// </summary>
        CarryIn,

        /// <summary>
        /// The carry out
        /// </summary>
        CarryOut,

        /// <summary>
        /// The available
        /// </summary>
        Available,
        
        /// <summary>
        /// The estimated reimbursments
        /// </summary>
        EstimatedReimbursments,

        /// <summary>
        /// The estimated recoveries
        /// </summary>
        EstimatedRecoveries,

        //************************************************************* */
        //**************  PAYROLL ACTIVITY NUMERIC FIELDS  ************ */
        //************************************************************* */

        /// <summary>
        /// The annual overtime paid
        /// </summary>
        Benefits,

        /// <summary>
        /// The annual base paid
        /// </summary>
        BasePaid,

        /// <summary>
        /// The annual other hours
        /// </summary>
        BaseHours,

        /// <summary>
        /// The allocation percentage
        /// </summary>
        OvertimePaid,

        /// <summary>
        /// The compensation rate
        /// </summary>
        OvertimeHours,

        //************************************************************************************ */
        //*******************              Procurements             ************************** */
        //************************************************************************************ */

        /// <summary>
        /// The ordered
        /// </summary>
        Ordered,

        //************************************************************************************ */
        //*******************              ReferenceTables             ************************** */
        //************************************************************************************ */   

        /// <summary>
        /// The requested
        /// </summary>
        Requested,

        /// <summary>
        /// The closed
        /// </summary>
        Closed,

        /// <summary>
        /// The outstanding
        /// </summary>
        Outstanding,

        /// <summary>
        /// The reversed
        /// </summary>
        Reversed,

        /// <summary>
        /// The disbursed
        /// </summary>
        Disbursements,
        
        //************************************************************************************ */
        //*******************       CarryoverOutlays              **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The carryover
        /// </summary>
        Carryover,

        /// <summary>
        /// The carryover outlays
        /// </summary>
        CarryoverOutlays,

        /// <summary>
        /// The delta
        /// </summary>
        Delta,

        /// <summary>
        /// The available balance
        /// </summary>
        AvailableBalance,

        /// <summary>
        /// The current year adjustment
        /// </summary>
        CurrentYearAdjustment,

        /// <summary>
        /// The budget year adjustment
        /// </summary>
        BudgetYearAdjustment,

        /// <summary>
        /// The current year
        /// </summary>
        CurrentYear,
        
        //************************************************************************************ */
        //*******************      BudgetResourceExectuion        **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The november
        /// </summary>
        November,

        /// <summary>
        /// The january
        /// </summary>
        January,

        /// <summary>
        /// The feburary
        /// </summary>
        Feburary,

        /// <summary>
        /// The april
        /// </summary>
        April,

        /// <summary>
        /// The may
        /// </summary>
        May,

        /// <summary>
        /// The june
        /// </summary>
        June,

        /// <summary>
        /// The august
        /// </summary>
        August,

        /// <summary>
        /// The october
        /// </summary>
        October,

        /// <summary>
        /// The amount1
        /// </summary>
        Amount1,

        /// <summary>
        /// The amount2
        /// </summary>
        Amount2,

        /// <summary>
        /// The amount3
        /// </summary>
        Amount3,

        /// <summary>
        /// The amount4
        /// </summary>
        Amount4,

        //************************************************************************************ */
        //*******************            SF Site Activity         **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The accepted
        /// </summary>
        Accepted,

        /// <summary>
        /// The refunded
        /// </summary>
        Refunded,

        /// <summary>
        /// The reversal
        /// </summary>
        Reversal,

        //************************************************************************************ */
        //*******************            BudgetOutlays           **************************** */
        //************************************************************************************ */
        
        /// <summary>
        /// The prior year
        /// </summary>
        PriorYear,

        /// <summary>
        /// The out year1
        /// </summary>
        OutYear1,

        /// <summary>
        /// The out year2
        /// </summary>
        OutYear2,

        /// <summary>
        /// The out year3
        /// </summary>
        OutYear3,

        /// <summary>
        /// The out year4
        /// </summary>
        OutYear4,

        /// <summary>
        /// The out year5
        /// </summary>
        OutYear5,

        /// <summary>
        /// The out year6
        /// </summary>
        OutYear6,

        /// <summary>
        /// The out year7
        /// </summary>
        OutYear7,

        /// <summary>
        /// The out year8
        /// </summary>
        OutYear8,

        /// <summary>
        /// The out year9
        /// </summary>
        OutYear9,

        /// <summary>
        /// The out year10
        /// </summary>
        OutYear10,

        /// <summary>
        /// The out year11
        /// </summary>
        OutYear11,

        //************************************************************************************ */
        //*******************           SF Site Obligations       **************************** */
        //************************************************************************************ */

        /// <summary>
        /// The collections
        /// </summary>
        Collections,

        /// <summary>
        /// The unpaid balances
        /// </summary>
        UnpaidBalances,

        /// <summary>
        /// The cumulative reciepts
        /// </summary>
        CumulativeReciepts
    }
}

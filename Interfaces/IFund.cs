// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IFund.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   IFund.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;

    public interface IFund
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        string Efy { get; set; }

        /// <summary> Gets or sets the code </summary>
        string Code { get; set; }

        /// <summary> Gets or sets the name. </summary>
        string Name { get; set; }

        /// <summary> Gets or sets the short name. </summary>
        /// <value> The short name. </value>
        string ShortName { get; set; }

        /// <summary> Gets or sets the status. </summary>
        /// <value> The status. </value>
        string Status { get; set; }

        /// <summary> Gets or sets the start date. </summary>
        /// <value> The start date. </value>
        DateOnly StartDate { get; set; }

        /// <summary> Gets or sets the end date. </summary>
        /// <value> The end date. </value>
        DateOnly EndDate { get; set; }

        /// <summary> Gets or sets the sub level prefix. </summary>
        /// <value> The sub level prefix. </value>
        string SubLevelPrefix { get; set; }

        /// <summary> Gets or sets the ata. </summary>
        /// <value> The ata. </value>
        string AllocationTransferAgency { get; set; }

        /// <summary> Gets or sets the aid. </summary>
        /// <value> The aid. </value>
        string AgencyIdentifier { get; set; }

        /// <summary> Gets or sets the beginning period of availability. </summary>
        /// <value> The beginning period of availability. </value>
        string BeginningPeriodOfAvailability { get; set; }

        /// <summary> Gets or sets the ending period of availability. </summary>
        /// <value> The ending period of availability. </value>
        string EndingPeriodOfAvailability { get; set; }

        /// <summary> Gets or sets a. </summary>
        /// <value> a. </value>
        string MultiYearIndicator { get; set; }

        /// <summary> Gets or sets the main. </summary>
        /// <value> The main. </value>
        string MainAccount { get; set; }

        /// <summary> Gets or sets the sub. </summary>
        /// <value> The sub. </value>
        string SubAccount { get; set; }

        /// <summary> Gets or sets the fund category. </summary>
        /// <value> The fund category. </value>
        string FundCategory { get; set; }

        /// <summary> Gets or sets the appropriation code. </summary>
        /// <value> The appropriation code. </value>
        string AppropriationCode { get; set; }

        /// <summary> Gets or sets the sub appropriation code. </summary>
        /// <value> The sub appropriation code. </value>
        string SubAppropriationCode { get; set; }

        /// <summary> Gets or sets the fund group. </summary>
        /// <value> The fund group. </value>
        string FundGroup { get; set; }

        /// <summary> Gets or sets the no year. </summary>
        /// <value> The no year. </value>
        string NoYear { get; set; }

        /// <summary> Gets or sets the carryover. </summary>
        /// <value> The carryover. </value>
        string Carryover { get; set; }

        /// <summary> Gets or sets the canceled year spending account. </summary>
        /// <value> The canceled year spending account. </value>
        string CancelledYearSpendingAccount { get; set; }

        /// <summary> Gets or sets the apply at all levels. </summary>
        /// <value> The apply at all levels. </value>
        string ApplyAtAllLevels { get; set; }

        /// <summary> Gets or sets the bats fund. </summary>
        /// <value> The bats fund. </value>
        string BatsFund { get; set; }

        /// <summary> Gets or sets the bats end date. </summary>
        /// <value> The bats end date. </value>
        DateOnly BatsEndDate { get; set; }

        /// <summary> Gets or sets the bats option identifier. </summary>
        /// <value> The bats option identifier. </value>
        string BatsOptionId { get; set; }

        /// <summary> Gets or sets the security org. </summary>
        /// <value> The security org. </value>
        string SecurityOrg { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the name of the treasury account. </summary>
        /// <value> The name of the treasury account. </value>
        string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the apportionment account code. </summary>
        /// <value> The apportionment account code. </value>
        string ApportionmentAccountCode { get; set; }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-12-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="BudgetControl.cs" company="Terry D. Eppler">
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
//   BudgetControl.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.DataUnit" />
    [SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    public abstract class BudgetControls : DataUnit
    {
        /// <summary>
        /// Gets or sets the security org.
        /// </summary>
        /// <value>
        /// The security org.
        /// </value>
        public virtual string SecurityOrg { get; set; }

        /// <summary>
        /// Gets or sets the type of the budgeting trans.
        /// </summary>
        /// <value>
        /// The type of the budgeting trans.
        /// </value>
        public virtual string BudgetingTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the posted trans.
        /// </summary>
        /// <value>
        /// The type of the posted trans.
        /// </value>
        public virtual string PostedTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the estimated reimbursable trans.
        /// </summary>
        /// <value>
        /// The type of the estimated reimbursable trans.
        /// </value>
        public virtual string EstimatedReimbursableTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the spending adjustment trans.
        /// </summary>
        /// <value>
        /// The type of the spending adjustment trans.
        /// </value>
        public virtual string SpendingAdjustmentTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the estimated recoveries trans.
        /// </summary>
        /// <value>
        /// The type of the estimated recoveries trans.
        /// </value>
        public virtual string EstimatedRecoveriesTransType { get; set; }

        /// <summary>
        /// Gets or sets the actual type of the recoveries trans.
        /// </summary>
        /// <value>
        /// The actual type of the recoveries trans.
        /// </value>
        public virtual string ActualRecoveriesTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the strategic reserve trans.
        /// </summary>
        /// <value>
        /// The type of the strategic reserve trans.
        /// </value>
        public virtual string StrategicReserveTransType { get; set; }

        /// <summary>
        /// Gets or sets the type of the profit loss trans.
        /// </summary>
        /// <value>
        /// The type of the profit loss trans.
        /// </value>
        public virtual string ProfitLossTransType { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursable spending option.
        /// </summary>
        /// <value>
        /// The estimated reimbursable spending option.
        /// </value>
        public virtual string EstimatedReimbursableSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the estimated reimbursable budgeting option.
        /// </summary>
        /// <value>
        /// The estimated reimbursable budgeting option.
        /// </value>
        public virtual string EstimatedReimbursableBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the track agreement lower level.
        /// </summary>
        /// <value>
        /// The track agreement lower level.
        /// </value>
        public virtual string TrackAgreementLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the budget estimate lower level.
        /// </summary>
        /// <value>
        /// The budget estimate lower level.
        /// </value>
        public virtual string BudgetEstimateLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries spending option.
        /// </summary>
        /// <value>
        /// The estimated recoveries spending option.
        /// </value>
        public virtual string EstimatedRecoveriesSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the estimated recoveries budgeting option.
        /// </summary>
        /// <value>
        /// The estimated recoveries budgeting option.
        /// </value>
        public virtual string EstimatedRecoveriesBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the record next level.
        /// </summary>
        /// <value>
        /// The record next level.
        /// </value>
        public virtual string RecordNextLevel { get; set; }

        /// <summary>
        /// Gets or sets the record budgeting mismatch.
        /// </summary>
        /// <value>
        /// The record budgeting mismatch.
        /// </value>
        public virtual string RecordBudgetingMismatch { get; set; }

        /// <summary>
        /// Gets or sets the profit loss spending option.
        /// </summary>
        /// <value>
        /// The profit loss spending option.
        /// </value>
        public virtual string ProfitLossSpendingOption { get; set; }

        /// <summary>
        /// Gets or sets the profit loss budgeting option.
        /// </summary>
        /// <value>
        /// The profit loss budgeting option.
        /// </value>
        public virtual string ProfitLossBudgetingOption { get; set; }

        /// <summary>
        /// Gets or sets the record carry in lower level.
        /// </summary>
        /// <value>
        /// The record carry in lower level.
        /// </value>
        public virtual string RecordCarryInLowerLevel { get; set; }

        /// <summary>
        /// Gets or sets the record carry in lower level control.
        /// </summary>
        /// <value>
        /// The record carry in lower level control.
        /// </value>
        public virtual string RecordCarryInLowerLevelControl { get; set; }

        /// <summary>
        /// Gets or sets the record carry in amount control.
        /// </summary>
        /// <value>
        /// The record carry in amount control.
        /// </value>
        public virtual string RecordCarryInAmountControl { get; set; }

        /// <summary>
        /// Gets or sets the budgeting control.
        /// </summary>
        /// <value>
        /// The budgeting control.
        /// </value>
        public virtual string BudgetingControl { get; set; }

        /// <summary>
        /// Gets or sets the posting control.
        /// </summary>
        /// <value>
        /// The posting control.
        /// </value>
        public virtual string PostingControl { get; set; }

        /// <summary>
        /// Gets or sets the pre commitment spending control.
        /// </summary>
        /// <value>
        /// The pre commitment spending control.
        /// </value>
        public virtual string PreCommitmentSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the commitment spending control.
        /// </summary>
        /// <value>
        /// The commitment spending control.
        /// </value>
        public virtual string CommitmentSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the obligation spending control.
        /// </summary>
        /// <value>
        /// The obligation spending control.
        /// </value>
        public virtual string ObligationSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the accrual spending control.
        /// </summary>
        /// <value>
        /// The accrual spending control.
        /// </value>
        public virtual string AccrualSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the expenditure spending control.
        /// </summary>
        /// <value>
        /// The expenditure spending control.
        /// </value>
        public virtual string ExpenditureSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the expense spending control.
        /// </summary>
        /// <value>
        /// The expense spending control.
        /// </value>
        public virtual string ExpenseSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable spending control.
        /// </summary>
        /// <value>
        /// The reimbursable spending control.
        /// </value>
        public virtual string ReimbursableSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the reimbursable agreement spending control.
        /// </summary>
        /// <value>
        /// The reimbursable agreement spending control.
        /// </value>
        public virtual string ReimbursableAgreementSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the fte budgeting control.
        /// </summary>
        /// <value>
        /// The fte budgeting control.
        /// </value>
        public virtual string FteBudgetingControl { get; set; }

        /// <summary>
        /// Gets or sets the fte spending control.
        /// </summary>
        /// <value>
        /// The fte spending control.
        /// </value>
        public virtual string FteSpendingControl { get; set; }

        /// <summary>
        /// Gets or sets the transaction type control.
        /// </summary>
        /// <value>
        /// The transaction type control.
        /// </value>
        public virtual string TransactionTypeControl { get; set; }

        /// <summary>
        /// Gets or sets the authority distribution control.
        /// </summary>
        /// <value>
        /// The authority distribution control.
        /// </value>
        public virtual string AuthorityDistributionControl { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetControls"/> class.
        /// </summary>
        protected BudgetControls( )
        {
        }
    }
}
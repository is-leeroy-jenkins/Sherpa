// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="BudgetControlValue.cs" company="Terry D. Eppler">
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
//   BudgetControlValue.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class BudgetControlValues : BudgetControls
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetControlValue"/>
        /// class.
        /// </summary>
        public BudgetControlValues( )
        {
            Source = Source.BudgetControls;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetControlValue"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public BudgetControlValues( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "BudgetControlValuesId" ].ToString( ) ?? "0" );
            Name = Record?[ "Name" ].ToString( );
            Code = Record?[ "Code" ].ToString( );
            SecurityOrg = Record?[ "" ].ToString( );
            BudgetingTransType = Record?[ "SecurityOrg" ].ToString( );
            PostedTransType = Record?[ "PostedTransType" ].ToString( );
            EstimatedReimbursableTransType =
                Record?[ "EstimatedReimbursableTransType" ].ToString( );

            SpendingAdjustmentTransType = Record?[ "SpendingAdjustmentTransType" ].ToString( );
            EstimatedRecoveriesTransType = Record?[ "EstimatedRecoveriesTransType" ].ToString( );
            ActualRecoveriesTransType = Record?[ "ActualRecoveriesTransType" ].ToString( );
            StrategicReserveTransType = Record?[ "StrategicReserveTransType" ].ToString( );
            SpendingAdjustmentTransType = Record?[ "SpendingAdjustmentTransType" ].ToString( );
            ProfitLossTransType = Record?[ "ProfitLossTransType" ].ToString( );
            EstimatedReimbursableBudgetingOption =
                Record?[ "EstimatedReimbursableBudgetingOption" ].ToString( );

            EstimatedReimbursableSpendingOption =
                Record?[ "EstimatedReimbursableSpendingOption" ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                Record?[ "EstimatedRecoveriesBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record?[ "EstimatedRecoveriesSpendingOption" ].ToString( );

            RecordNextLevel = Record?[ "RecordNextLevel" ].ToString( );
            RecordBudgetingMismatch = Record?[ "RecordBudgetingMismatch" ].ToString( );
            ProfitLossBudgetingOption = Record?[ "ProfitLossBudgetingOption" ].ToString( );
            ProfitLossSpendingOption = Record?[ "ProfitLossSpendingOption" ].ToString( );
            RecordCarryInLowerLevel = Record?[ "RecordCarryInLowerLevel" ].ToString( );
            RecordCarryInLowerLevelControl =
                Record?[ "RecordCarryInLowerLevelControl" ].ToString( );

            RecordCarryInAmountControl = Record?[ "RecordCarryInAmountControl" ].ToString( );
            BudgetingControl = Record?[ "BudgetingControl" ].ToString( );
            PostingControl = Record?[ "PostingControl" ].ToString( );
            PreCommitmentSpendingControl = Record?[ "PreCommitmentSpendingControl" ].ToString( );
            CommitmentSpendingControl = Record?[ "CommitmentSpendingControl" ].ToString( );
            ObligationSpendingControl = Record?[ "ObligationSpendingControl" ].ToString( );
            AccrualSpendingControl = Record?[ "" ].ToString( );
            ExpenditureSpendingControl = Record?[ "ExpenditureSpendingControl" ].ToString( );
            ExpenseSpendingControl = Record?[ "ExpenseSpendingControl" ].ToString( );
            ReimbursableSpendingControl = Record?[ "ReimbursableSpendingControl" ].ToString( );
            ReimbursableAgreementSpendingControl =
                Record?[ "ReimbursableAgreementSpendingControl" ].ToString( );

            FteBudgetingControl = Record?[ "FteBudgetingControl" ].ToString( );
            FteSpendingControl = Record?[ "FteSpendingControl" ].ToString( );
            TransactionTypeControl = Record?[ "TransactionTypeControl" ].ToString( );
            AuthorityDistributionControl = Record?[ "AuthorityDistributionControl" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetControlValue"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public BudgetControlValues( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "BudgetControlValuesId" ].ToString( ) ?? "0" );
            Name = Record[ "Name" ].ToString( );
            Code = Record[ "Code" ].ToString( );
            SecurityOrg = Record[ "" ].ToString( );
            BudgetingTransType = Record[ "SecurityOrg" ].ToString( );
            PostedTransType = Record[ "PostedTransType" ].ToString( );
            EstimatedReimbursableTransType = Record[ "EstimatedReimbursableTransType" ].ToString( );
            SpendingAdjustmentTransType = Record[ "SpendingAdjustmentTransType" ].ToString( );
            EstimatedRecoveriesTransType = Record[ "EstimatedRecoveriesTransType" ].ToString( );
            ActualRecoveriesTransType = Record[ "ActualRecoveriesTransType" ].ToString( );
            StrategicReserveTransType = Record[ "StrategicReserveTransType" ].ToString( );
            SpendingAdjustmentTransType = Record[ "SpendingAdjustmentTransType" ].ToString( );
            ProfitLossTransType = Record[ "ProfitLossTransType" ].ToString( );
            EstimatedReimbursableBudgetingOption =
                Record[ "EstimatedReimbursableBudgetingOption" ].ToString( );

            EstimatedReimbursableSpendingOption =
                Record[ "EstimatedReimbursableSpendingOption" ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                Record[ "EstimatedRecoveriesBudgetingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record[ "EstimatedRecoveriesSpendingOption" ].ToString( );

            RecordNextLevel = Record[ "RecordNextLevel" ].ToString( );
            RecordBudgetingMismatch = Record[ "RecordBudgetingMismatch" ].ToString( );
            ProfitLossBudgetingOption = Record[ "ProfitLossBudgetingOption" ].ToString( );
            ProfitLossSpendingOption = Record[ "ProfitLossSpendingOption" ].ToString( );
            RecordCarryInLowerLevel = Record[ "RecordCarryInLowerLevel" ].ToString( );
            RecordCarryInLowerLevelControl = Record[ "RecordCarryInLowerLevelControl" ].ToString( );
            RecordCarryInAmountControl = Record[ "RecordCarryInAmountControl" ].ToString( );
            BudgetingControl = Record[ "BudgetingControl" ].ToString( );
            PostingControl = Record[ "PostingControl" ].ToString( );
            PreCommitmentSpendingControl = Record[ "PreCommitmentSpendingControl" ].ToString( );
            CommitmentSpendingControl = Record[ "CommitmentSpendingControl" ].ToString( );
            ObligationSpendingControl = Record[ "ObligationSpendingControl" ].ToString( );
            AccrualSpendingControl = Record[ "" ].ToString( );
            ExpenditureSpendingControl = Record[ "ExpenditureSpendingControl" ].ToString( );
            ExpenseSpendingControl = Record[ "ExpenseSpendingControl" ].ToString( );
            ReimbursableSpendingControl = Record[ "ReimbursableSpendingControl" ].ToString( );
            ReimbursableAgreementSpendingControl =
                Record[ "ReimbursableAgreementSpendingControl" ].ToString( );

            FteBudgetingControl = Record[ "FteBudgetingControl" ].ToString( );
            FteSpendingControl = Record[ "FteSpendingControl" ].ToString( );
            TransactionTypeControl = Record[ "TransactionTypeControl" ].ToString( );
            AuthorityDistributionControl = Record[ "AuthorityDistributionControl" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetControlValue"/>
        /// class.
        /// </summary>
        /// <param name="row"> The data row. </param>
        public BudgetControlValues( DataRow row )
            : this( )
        {
            Record = row;
            Data = row.ToDictionary( );
            ID = int.Parse( row[ "BudgetControlValuesId" ].ToString( ) ?? "0" );
            Name = row?[ "Name" ].ToString( );
            Code = row?[ "Code" ].ToString( );
            SecurityOrg = row[ "" ].ToString( );
            BudgetingTransType = row[ "SecurityOrg" ].ToString( );
            PostedTransType = row[ "PostedTransType" ].ToString( );
            EstimatedReimbursableTransType = row[ "EstimatedReimbursableTransType" ].ToString( );
            SpendingAdjustmentTransType = row[ "SpendingAdjustmentTransType" ].ToString( );
            EstimatedRecoveriesTransType = row[ "EstimatedRecoveriesTransType" ].ToString( );
            ActualRecoveriesTransType = row[ "ActualRecoveriesTransType" ].ToString( );
            StrategicReserveTransType = row[ "StrategicReserveTransType" ].ToString( );
            SpendingAdjustmentTransType = row[ "SpendingAdjustmentTransType" ].ToString( );
            ProfitLossTransType = row[ "ProfitLossTransType" ].ToString( );
            EstimatedReimbursableBudgetingOption =
                row[ "EstimatedReimbursableBudgetingOption" ].ToString( );

            EstimatedReimbursableSpendingOption =
                Record[ "EstimatedReimbursableSpendingOption" ].ToString( );

            EstimatedRecoveriesSpendingOption =
                row[ "EstimatedRecoveriesSpendingOption" ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                row[ "EstimatedRecoveriesBudgetingOption" ].ToString( );

            RecordNextLevel = row[ "NextLevel" ].ToString( );
            RecordBudgetingMismatch = row[ "BudgetingMismatch" ].ToString( );
            ProfitLossBudgetingOption = row[ "ProfitLossBudgetingOption" ].ToString( );
            ProfitLossSpendingOption = row[ "ProfitLossSpendingOption" ].ToString( );
            RecordCarryInLowerLevel = row[ "CarryInLowerLevel" ].ToString( );
            RecordCarryInLowerLevelControl = row[ "CarryInLowerLevelControl" ].ToString( );
            RecordCarryInAmountControl = row[ "CarryInAmountControl" ].ToString( );
            BudgetingControl = row[ "BudgetingControl" ].ToString( );
            PostingControl = row[ "PostingControl" ].ToString( );
            PreCommitmentSpendingControl = row[ "PreCommitmentSpendingControl" ].ToString( );
            CommitmentSpendingControl = row[ "CommitmentSpendingControl" ].ToString( );
            ObligationSpendingControl = row[ "ObligationSpendingControl" ].ToString( );
            AccrualSpendingControl = row[ "" ].ToString( );
            ExpenditureSpendingControl = row[ "ExpenditureSpendingControl" ].ToString( );
            ExpenseSpendingControl = row[ "ExpenseSpendingControl" ].ToString( );
            ReimbursableSpendingControl = row[ "ReimbursableSpendingControl" ].ToString( );
            ReimbursableAgreementSpendingControl =
                row[ "ReimbursableAgreementSpendingControl" ].ToString( );

            FteBudgetingControl = row[ "FteBudgetingControl" ].ToString( );
            FteSpendingControl = row[ "FteSpendingControl" ].ToString( );
            TransactionTypeControl = row[ "TransactionTypeControl" ].ToString( );
            AuthorityDistributionControl = row[ "AuthorityDistributionControl" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetControlValue"/>
        /// class.
        /// </summary>
        /// <param name="control"> The control. </param>
        public BudgetControlValues( BudgetControls control )
        {
            ID = control.ID;
            Code = control.Code;
            Name = control.Name;
            SecurityOrg = control.SecurityOrg;
            BudgetingTransType = control.BudgetingTransType;
            PostedTransType = control.PostedTransType;
            EstimatedReimbursableTransType = control.EstimatedReimbursableTransType;
            SpendingAdjustmentTransType = control.SpendingAdjustmentTransType;
            EstimatedReimbursableBudgetingOption = control.EstimatedReimbursableBudgetingOption;
            EstimatedReimbursableSpendingOption = control.EstimatedReimbursableSpendingOption;
            EstimatedRecoveriesBudgetingOption = control.EstimatedRecoveriesBudgetingOption;
            EstimatedRecoveriesSpendingOption = control.EstimatedRecoveriesSpendingOption;
            RecordNextLevel = control.RecordNextLevel;
            RecordBudgetingMismatch = control.RecordBudgetingMismatch;
            ProfitLossBudgetingOption = control.ProfitLossBudgetingOption;
            RecordCarryInLowerLevel = control.RecordCarryInLowerLevel;
            RecordCarryInLowerLevelControl = control.RecordCarryInLowerLevelControl;
            RecordCarryInAmountControl = control.RecordCarryInAmountControl;
            BudgetingControl = control.BudgetingControl;
            PostingControl = control.PostingControl;
            PreCommitmentSpendingControl = control.PreCommitmentSpendingControl;
            CommitmentSpendingControl = control.CommitmentSpendingControl;
            ObligationSpendingControl = control.ObligationSpendingControl;
            AccrualSpendingControl = control.AccrualSpendingControl;
            ExpenditureSpendingControl = control.ExpenditureSpendingControl;
            ExpenseSpendingControl = control.ExpenditureSpendingControl;
            ReimbursableSpendingControl = control.ReimbursableSpendingControl;
            ReimbursableAgreementSpendingControl = control.ReimbursableAgreementSpendingControl;
            FteBudgetingControl = control.FteBudgetingControl;
            FteSpendingControl = control.FteSpendingControl;
            TransactionTypeControl = control.TransactionTypeControl;
            AuthorityDistributionControl = control.AuthorityDistributionControl;
        }
    }
}
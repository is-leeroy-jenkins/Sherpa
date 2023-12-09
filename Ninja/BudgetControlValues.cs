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
            Name = Record?[ nameof( Name ) ].ToString( );
            Code = Record?[ nameof( Code ) ].ToString( );
            SecurityOrg = Record?[ "" ].ToString( );
            BudgetingTransType = Record?[ nameof( SecurityOrg ) ].ToString( );
            PostedTransType = Record?[ nameof( PostedTransType ) ].ToString( );
            EstimatedReimbursableTransType =
                Record?[ nameof( EstimatedReimbursableTransType ) ].ToString( );

            SpendingAdjustmentTransType = Record?[ nameof( SpendingAdjustmentTransType ) ].ToString( );
            EstimatedRecoveriesTransType = Record?[ nameof( EstimatedRecoveriesTransType ) ].ToString( );
            ActualRecoveriesTransType = Record?[ nameof( ActualRecoveriesTransType ) ].ToString( );
            StrategicReserveTransType = Record?[ nameof( StrategicReserveTransType ) ].ToString( );
            SpendingAdjustmentTransType = Record?[ nameof( SpendingAdjustmentTransType ) ].ToString( );
            ProfitLossTransType = Record?[ nameof( ProfitLossTransType ) ].ToString( );
            EstimatedReimbursableBudgetingOption =
                Record?[ nameof( EstimatedReimbursableBudgetingOption ) ].ToString( );

            EstimatedReimbursableSpendingOption =
                Record?[ nameof( EstimatedReimbursableSpendingOption ) ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                Record?[ nameof( EstimatedRecoveriesBudgetingOption ) ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record?[ nameof( EstimatedRecoveriesSpendingOption ) ].ToString( );

            RecordNextLevel = Record?[ nameof( RecordNextLevel ) ].ToString( );
            RecordBudgetingMismatch = Record?[ nameof( RecordBudgetingMismatch ) ].ToString( );
            ProfitLossBudgetingOption = Record?[ nameof( ProfitLossBudgetingOption ) ].ToString( );
            ProfitLossSpendingOption = Record?[ nameof( ProfitLossSpendingOption ) ].ToString( );
            RecordCarryInLowerLevel = Record?[ nameof( RecordCarryInLowerLevel ) ].ToString( );
            RecordCarryInLowerLevelControl =
                Record?[ nameof( RecordCarryInLowerLevelControl ) ].ToString( );

            RecordCarryInAmountControl = Record?[ nameof( RecordCarryInAmountControl ) ].ToString( );
            BudgetingControl = Record?[ nameof( BudgetingControl ) ].ToString( );
            PostingControl = Record?[ nameof( PostingControl ) ].ToString( );
            PreCommitmentSpendingControl = Record?[ nameof( PreCommitmentSpendingControl ) ].ToString( );
            CommitmentSpendingControl = Record?[ nameof( CommitmentSpendingControl ) ].ToString( );
            ObligationSpendingControl = Record?[ nameof( ObligationSpendingControl ) ].ToString( );
            AccrualSpendingControl = Record?[ "" ].ToString( );
            ExpenditureSpendingControl = Record?[ nameof( ExpenditureSpendingControl ) ].ToString( );
            ExpenseSpendingControl = Record?[ nameof( ExpenseSpendingControl ) ].ToString( );
            ReimbursableSpendingControl = Record?[ nameof( ReimbursableSpendingControl ) ].ToString( );
            ReimbursableAgreementSpendingControl =
                Record?[ nameof( ReimbursableAgreementSpendingControl ) ].ToString( );

            FteBudgetingControl = Record?[ nameof( FteBudgetingControl ) ].ToString( );
            FteSpendingControl = Record?[ nameof( FteSpendingControl ) ].ToString( );
            TransactionTypeControl = Record?[ nameof( TransactionTypeControl ) ].ToString( );
            AuthorityDistributionControl = Record?[ nameof( AuthorityDistributionControl ) ].ToString( );
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
            Name = Record[ nameof( Name ) ].ToString( );
            Code = Record[ nameof( Code ) ].ToString( );
            SecurityOrg = Record[ "" ].ToString( );
            BudgetingTransType = Record[ nameof( SecurityOrg ) ].ToString( );
            PostedTransType = Record[ nameof( PostedTransType ) ].ToString( );
            EstimatedReimbursableTransType = Record[ nameof( EstimatedReimbursableTransType ) ].ToString( );
            SpendingAdjustmentTransType = Record[ nameof( SpendingAdjustmentTransType ) ].ToString( );
            EstimatedRecoveriesTransType = Record[ nameof( EstimatedRecoveriesTransType ) ].ToString( );
            ActualRecoveriesTransType = Record[ nameof( ActualRecoveriesTransType ) ].ToString( );
            StrategicReserveTransType = Record[ nameof( StrategicReserveTransType ) ].ToString( );
            SpendingAdjustmentTransType = Record[ nameof( SpendingAdjustmentTransType ) ].ToString( );
            ProfitLossTransType = Record[ nameof( ProfitLossTransType ) ].ToString( );
            EstimatedReimbursableBudgetingOption =
                Record[ nameof( EstimatedReimbursableBudgetingOption ) ].ToString( );

            EstimatedReimbursableSpendingOption =
                Record[ nameof( EstimatedReimbursableSpendingOption ) ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                Record[ nameof( EstimatedRecoveriesBudgetingOption ) ].ToString( );

            EstimatedRecoveriesSpendingOption =
                Record[ nameof( EstimatedRecoveriesSpendingOption ) ].ToString( );

            RecordNextLevel = Record[ nameof( RecordNextLevel ) ].ToString( );
            RecordBudgetingMismatch = Record[ nameof( RecordBudgetingMismatch ) ].ToString( );
            ProfitLossBudgetingOption = Record[ nameof( ProfitLossBudgetingOption ) ].ToString( );
            ProfitLossSpendingOption = Record[ nameof( ProfitLossSpendingOption ) ].ToString( );
            RecordCarryInLowerLevel = Record[ nameof( RecordCarryInLowerLevel ) ].ToString( );
            RecordCarryInLowerLevelControl = Record[ nameof( RecordCarryInLowerLevelControl ) ].ToString( );
            RecordCarryInAmountControl = Record[ nameof( RecordCarryInAmountControl ) ].ToString( );
            BudgetingControl = Record[ nameof( BudgetingControl ) ].ToString( );
            PostingControl = Record[ nameof( PostingControl ) ].ToString( );
            PreCommitmentSpendingControl = Record[ nameof( PreCommitmentSpendingControl ) ].ToString( );
            CommitmentSpendingControl = Record[ nameof( CommitmentSpendingControl ) ].ToString( );
            ObligationSpendingControl = Record[ nameof( ObligationSpendingControl ) ].ToString( );
            AccrualSpendingControl = Record[ "" ].ToString( );
            ExpenditureSpendingControl = Record[ nameof( ExpenditureSpendingControl ) ].ToString( );
            ExpenseSpendingControl = Record[ nameof( ExpenseSpendingControl ) ].ToString( );
            ReimbursableSpendingControl = Record[ nameof( ReimbursableSpendingControl ) ].ToString( );
            ReimbursableAgreementSpendingControl =
                Record[ nameof( ReimbursableAgreementSpendingControl ) ].ToString( );

            FteBudgetingControl = Record[ nameof( FteBudgetingControl ) ].ToString( );
            FteSpendingControl = Record[ nameof( FteSpendingControl ) ].ToString( );
            TransactionTypeControl = Record[ nameof( TransactionTypeControl ) ].ToString( );
            AuthorityDistributionControl = Record[ nameof( AuthorityDistributionControl ) ].ToString( );
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
            Name = row?[ nameof( Name ) ].ToString( );
            Code = row?[ nameof( Code ) ].ToString( );
            SecurityOrg = row[ "" ].ToString( );
            BudgetingTransType = row[ nameof( SecurityOrg ) ].ToString( );
            PostedTransType = row[ nameof( PostedTransType ) ].ToString( );
            EstimatedReimbursableTransType = row[ nameof( EstimatedReimbursableTransType ) ].ToString( );
            SpendingAdjustmentTransType = row[ nameof( SpendingAdjustmentTransType ) ].ToString( );
            EstimatedRecoveriesTransType = row[ nameof( EstimatedRecoveriesTransType ) ].ToString( );
            ActualRecoveriesTransType = row[ nameof( ActualRecoveriesTransType ) ].ToString( );
            StrategicReserveTransType = row[ nameof( StrategicReserveTransType ) ].ToString( );
            SpendingAdjustmentTransType = row[ nameof( SpendingAdjustmentTransType ) ].ToString( );
            ProfitLossTransType = row[ nameof( ProfitLossTransType ) ].ToString( );
            EstimatedReimbursableBudgetingOption =
                row[ nameof( EstimatedReimbursableBudgetingOption ) ].ToString( );

            EstimatedReimbursableSpendingOption =
                Record[ nameof( EstimatedReimbursableSpendingOption ) ].ToString( );

            EstimatedRecoveriesSpendingOption =
                row[ nameof( EstimatedRecoveriesSpendingOption ) ].ToString( );

            EstimatedRecoveriesBudgetingOption =
                row[ nameof( EstimatedRecoveriesBudgetingOption ) ].ToString( );

            RecordNextLevel = row[ "NextLevel" ].ToString( );
            RecordBudgetingMismatch = row[ "BudgetingMismatch" ].ToString( );
            ProfitLossBudgetingOption = row[ nameof( ProfitLossBudgetingOption ) ].ToString( );
            ProfitLossSpendingOption = row[ nameof( ProfitLossSpendingOption ) ].ToString( );
            RecordCarryInLowerLevel = row[ "CarryInLowerLevel" ].ToString( );
            RecordCarryInLowerLevelControl = row[ "CarryInLowerLevelControl" ].ToString( );
            RecordCarryInAmountControl = row[ "CarryInAmountControl" ].ToString( );
            BudgetingControl = row[ nameof( BudgetingControl ) ].ToString( );
            PostingControl = row[ nameof( PostingControl ) ].ToString( );
            PreCommitmentSpendingControl = row[ nameof( PreCommitmentSpendingControl ) ].ToString( );
            CommitmentSpendingControl = row[ nameof( CommitmentSpendingControl ) ].ToString( );
            ObligationSpendingControl = row[ nameof( ObligationSpendingControl ) ].ToString( );
            AccrualSpendingControl = row[ "" ].ToString( );
            ExpenditureSpendingControl = row[ nameof( ExpenditureSpendingControl ) ].ToString( );
            ExpenseSpendingControl = row[ nameof( ExpenseSpendingControl ) ].ToString( );
            ReimbursableSpendingControl = row[ nameof( ReimbursableSpendingControl ) ].ToString( );
            ReimbursableAgreementSpendingControl =
                row[ nameof( ReimbursableAgreementSpendingControl ) ].ToString( );

            FteBudgetingControl = row[ nameof( FteBudgetingControl ) ].ToString( );
            FteSpendingControl = row[ nameof( FteSpendingControl ) ].ToString( );
            TransactionTypeControl = row[ nameof( TransactionTypeControl ) ].ToString( );
            AuthorityDistributionControl = row[ nameof( AuthorityDistributionControl ) ].ToString( );
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
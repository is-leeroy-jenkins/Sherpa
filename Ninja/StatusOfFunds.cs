// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StatusOfFunds.cs" company="Terry D. Eppler">
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
//   StatusOfFunds.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.PRC"/>
    /// <seealso cref="T:BudgetExecution.IStatusOfFunds"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class StatusOfFunds : PRC, IStatusOfFunds
    {
        /// <inheritdoc/>
        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        public virtual double Amount { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the budgeted. </summary>
        /// <value> The budgeted. </value>
        public virtual double Budgeted { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the posted. </summary>
        /// <value> The posted. </value>
        public virtual double Posted { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the open commitments. </summary>
        /// <value> The open commitments. </value>
        public virtual double OpenCommitments { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the unliquidated obligations. </summary>
        /// <value> The unliquidated obligations. </value>
        public virtual double UnliquidatedObligations { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the expenditures. </summary>
        /// <value> The expenditures. </value>
        public virtual double Expenditures { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the obligations. </summary>
        /// <value> The obligations. </value>
        public virtual double Obligations { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the used. </summary>
        /// <value> The used. </value>
        public virtual double Used { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets the available. </summary>
        /// <value> The available. </value>
        public virtual double Available { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds"/>
        /// class.
        /// </summary>
        public StatusOfFunds( )
        {
            Source = Source.StatusOfFunds;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StatusOfFunds( IQuery query )
            : base( query )
        {
            Source = query.Source;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) ?? "0" );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ nameof( OpenCommitments ) ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ nameof( UnliquidatedObligations ) ].ToString( ) ?? "0" );

            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? "0" );
            Expenditures = double.Parse( Record[ nameof( Expenditures ) ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? "0" );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
            NpmName = Record[ nameof( NpmName ) ].ToString( );
            GoalCode = Record[ nameof( GoalCode ) ].ToString( );
            GoalName = Record[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = Record[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = Record[ nameof( ObjectiveName ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The data builder. </param>
        public StatusOfFunds( IDataModel dataBuilder )
            : base( dataBuilder )
        {
            Source = dataBuilder.Source;
            Record = dataBuilder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) ?? "0" );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ nameof( OpenCommitments ) ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ nameof( UnliquidatedObligations ) ].ToString( ) ?? "0" );

            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? "0" );
            Expenditures = double.Parse( Record[ nameof( Expenditures ) ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? "0" );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
            NpmName = Record[ nameof( NpmName ) ].ToString( );
            GoalCode = Record[ nameof( GoalCode ) ].ToString( );
            GoalName = Record[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = Record[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = Record[ nameof( ObjectiveName ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StatusOfFunds( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.StatusOfFunds;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "StatusOfFundsId" ].ToString( ) ?? "0" );
            BudgetLevel = dataRow[ nameof( BudgetLevel ) ].ToString( );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            FundName = dataRow[ nameof( FundName ) ].ToString( );
            RpioCode = dataRow[ nameof( RpioCode ) ].ToString( );
            RpioName = dataRow[ nameof( RpioName ) ].ToString( );
            AhCode = dataRow[ nameof( AhCode ) ].ToString( );
            AhName = dataRow[ nameof( AhName ) ].ToString( );
            OrgCode = dataRow[ nameof( OrgCode ) ].ToString( );
            OrgName = dataRow[ nameof( OrgName ) ].ToString( );
            AccountCode = dataRow[ nameof( AccountCode ) ].ToString( );
            BocCode = dataRow[ nameof( BocCode ) ].ToString( );
            BocName = dataRow[ nameof( BocName ) ].ToString( );
            Amount = double.Parse( dataRow[ nameof( Amount ) ].ToString( ) ?? "0" );
            Budgeted = double.Parse( dataRow[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Posted = double.Parse( dataRow[ nameof( Posted ) ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( dataRow[ nameof( OpenCommitments ) ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( dataRow[ nameof( UnliquidatedObligations ) ].ToString( ) ?? "0" );

            Obligations = double.Parse( dataRow[ nameof( Obligations ) ].ToString( ) ?? "0" );
            Expenditures = double.Parse( dataRow[ nameof( Expenditures ) ].ToString( ) ?? "0" );
            Used = double.Parse( dataRow[ nameof( Used ) ].ToString( ) ?? "0" );
            Available = double.Parse( dataRow[ nameof( Available ) ].ToString( ) ?? "0" );
            ProgramProjectCode = dataRow[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = dataRow[ nameof( ProgramProjectName ) ].ToString( );
            ProgramAreaCode = dataRow[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = dataRow[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = dataRow[ nameof( NpmCode ) ].ToString( );
            NpmName = dataRow[ nameof( NpmName ) ].ToString( );
            GoalCode = dataRow[ nameof( GoalCode ) ].ToString( );
            GoalName = dataRow[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = dataRow[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = dataRow[ nameof( ObjectiveName ) ].ToString( );
            TreasuryAccountCode = dataRow[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = dataRow[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = dataRow[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = dataRow[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds"/>
        /// class.
        /// </summary>
        /// <param name="map"> The map. </param>
        public StatusOfFunds( IDictionary<string, object> map )
            : base( map )
        {
            Record = new DataBuilder( Source, map )?.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "StatusOfFundsId" ].ToString( ) ?? "0" );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? "0" );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ nameof( OpenCommitments ) ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ nameof( UnliquidatedObligations ) ].ToString( ) ?? "0" );

            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? "0" );
            Expenditures = double.Parse( Record[ nameof( Expenditures ) ].ToString( ) ?? "0" );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? "0" );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? "0" );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
            NpmCode = Record[ nameof( NpmCode ) ].ToString( );
            NpmName = Record[ nameof( NpmName ) ].ToString( );
            GoalCode = Record[ nameof( GoalCode ) ].ToString( );
            GoalName = Record[ nameof( GoalName ) ].ToString( );
            ObjectiveCode = Record[ nameof( ObjectiveCode ) ].ToString( );
            ObjectiveName = Record[ nameof( ObjectiveName ) ].ToString( );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfFunds"/>
        /// class.
        /// </summary>
        /// <param name="status"> The status. </param>
        public StatusOfFunds( IStatusOfFunds status )
        {
            ID = status.ID;
            BudgetLevel = status.BudgetLevel;
            BFY = status.BFY;
            EFY = status.EFY;
            FundCode = status.FundCode;
            FundName = status.FundName;
            RpioCode = status.RpioCode;
            RpioName = status.RpioName;
            AhCode = status.AhCode;
            AhName = status.AhName;
            OrgCode = status.OrgCode;
            OrgName = status.OrgName;
            AccountCode = status.AccountCode;
            BocCode = status.BocCode;
            BocName = status.BocName;
            Amount = status.Amount;
            Budgeted = status.Budgeted;
            Posted = status.Posted;
            OpenCommitments = status.OpenCommitments;
            UnliquidatedObligations = status.UnliquidatedObligations;
            Obligations = status.Obligations;
            Expenditures = status.Expenditures;
            Used = status.Used;
            Available = status.Available;
            ProgramProjectCode = status.ProgramProjectCode;
            ProgramProjectName = status.ProgramProjectName;
            ProgramAreaCode = status.ProgramAreaCode;
            ProgramAreaName = status.ProgramAreaName;
            NpmCode = status.NpmCode;
            NpmName = status.NpmName;
            TreasuryAccountCode = status.TreasuryAccountCode;
            TreasuryAccountName = status.TreasuryAccountName;
            BudgetAccountCode = status.BudgetAccountCode;
            BudgetAccountName = status.BudgetAccountName;
        }
    }
}
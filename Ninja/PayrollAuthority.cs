// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="PayrollAuthority.cs" company="Terry D. Eppler">
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
//   PayrollAuthority.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    public class PayrollAuthority : Allocations
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PayrollAuthority"/>
        /// class.
        /// </summary>
        public PayrollAuthority( )
        {
            Source = Source.PayrollAuthority;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PayrollAuthority"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public PayrollAuthority( IQuery query )
        {
            Source = query.Source;
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PayrollAuthorityId" ].ToString( ) ?? "0" );
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
            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
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

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PayrollAuthority"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public PayrollAuthority( IDataModel builder )
        {
            Source = builder.Source;
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "PayrollAuthorityId" ].ToString( ) ?? "0" );
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
            UnliquidatedObligations = double.Parse( Record[ "ULO" ].ToString( ) ?? "0" );
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

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PayrollAuthority"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public PayrollAuthority( DataRow dataRow )
        {
            Source = Source.PayrollAuthority;
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "PayrollAuthorityId" ].ToString( ) ?? "0" );
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
            UnliquidatedObligations = double.Parse( dataRow[ "ULO" ].ToString( ) ?? "0" );
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

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PayrollAuthority"/>
        /// class.
        /// </summary>
        /// <param name="pay"> The pay. </param>
        public PayrollAuthority( PayrollAuthority pay )
        {
            ID = pay.ID;
            BudgetLevel = pay.BudgetLevel;
            BFY = pay.BFY;
            EFY = pay.EFY;
            FundCode = pay.FundCode;
            FundName = pay.FundName;
            RpioCode = pay.RpioCode;
            RpioName = pay.RpioName;
            AhCode = pay.AhCode;
            AhName = pay.AhName;
            OrgCode = pay.OrgCode;
            OrgName = pay.OrgName;
            AccountCode = pay.AccountCode;
            BocCode = pay.BocCode;
            BocName = pay.BocName;
            Amount = pay.Amount;
            Budgeted = pay.Budgeted;
            Posted = pay.Posted;
            OpenCommitments = pay.OpenCommitments;
            UnliquidatedObligations = pay.UnliquidatedObligations;
            Obligations = pay.Obligations;
            Expenditures = pay.Expenditures;
            Used = pay.Used;
            Available = pay.Available;
            ProgramProjectCode = pay.ProgramProjectCode;
            ProgramProjectName = pay.ProgramProjectName;
            ProgramAreaCode = pay.ProgramAreaCode;
            ProgramAreaName = pay.ProgramAreaName;
            NpmCode = pay.NpmCode;
            NpmName = pay.NpmName;
            TreasuryAccountCode = pay.TreasuryAccountCode;
            TreasuryAccountName = pay.TreasuryAccountName;
            BudgetAccountCode = pay.BudgetAccountCode;
            BudgetAccountName = pay.BudgetAccountName;
        }
    }
}
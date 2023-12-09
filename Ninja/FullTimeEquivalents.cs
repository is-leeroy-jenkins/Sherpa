// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="FullTimeEquivalent.cs" company="Terry D. Eppler">
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
//   FullTimeEquivalent.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary>
    /// Full-time equivalent (FullTimeEquivalents) or whole time equivalent (WTE) is a unit that indicates
    /// the workload of an employed person (or student) in a way that makes workloads or class loads
    /// comparable across various contexts. FullTimeEquivalent is often used to measure a worker's or
    /// student's involvement in a project, or to track cost reductions in an organization. An
    /// FullTimeEquivalent of 1.0 is equivalent to a full-time worker or student, while an
    /// FullTimeEquivalent of 0.5 signals half of a full work or school load.
    /// </summary>
    /// <seealso cref="T:BudgetExecution.ProgramResultsCode"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class FullTimeEquivalents : OperatingPlans
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FullTimeEquivalent"/>
        /// class.
        /// </summary>
        public FullTimeEquivalents( )
        {
            Source = Source.FullTimeEquivalents;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FullTimeEquivalent"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public FullTimeEquivalents( IQuery query )
            : base( query )
        {
            Source = Source.FullTimeEquivalents;
            Record = new DataBuilder( query ).Record;
            ID = int.Parse( Record[ "FullTimeEquivalentsId" ].ToString( ) );
            Data = Record.ToDictionary( );
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
        /// <see cref="T:BudgetExecution.FullTimeEquivalent"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The databuilder. </param>
        public FullTimeEquivalents( IDataModel builder )
            : base( builder )
        {
            Source = Source.FullTimeEquivalents;
            Record = builder.Record;
            ID = int.Parse( Record[ "FullTimeEquivalentsId" ].ToString( ) );
            Data = Record.ToDictionary( );
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
        /// <see cref="T:BudgetExecution.FullTimeEquivalent"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The dataRow. </param>
        public FullTimeEquivalents( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.FullTimeEquivalents;
            Record = dataRow;
            ID = int.Parse( dataRow[ "FullTimeEquivalentsId" ].ToString( ) );
            Data = dataRow.ToDictionary( );
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
        /// <summary> </summary>
        /// <param name="allocations"> </param>
        public FullTimeEquivalents( Allocations allocations )
        {
            ID = allocations.ID;
            BudgetLevel = allocations.BudgetLevel;
            BFY = allocations.BFY;
            EFY = allocations.EFY;
            FundCode = allocations.FundCode;
            FundName = allocations.FundName;
            RpioCode = allocations.RpioCode;
            RpioName = allocations.RpioName;
            AhCode = allocations.AhCode;
            AhName = allocations.AhName;
            OrgCode = allocations.OrgCode;
            OrgName = allocations.OrgName;
            AccountCode = allocations.AccountCode;
            BocCode = allocations.BocCode;
            BocName = allocations.BocName;
            Amount = allocations.Amount;
            ProgramProjectCode = allocations.ProgramProjectCode;
            ProgramProjectName = allocations.ProgramProjectName;
            ProgramAreaCode = allocations.ProgramAreaCode;
            ProgramAreaName = allocations.ProgramAreaName;
            NpmCode = allocations.NpmCode;
            NpmName = allocations.NpmName;
            TreasuryAccountCode = allocations.TreasuryAccountCode;
            TreasuryAccountName = allocations.TreasuryAccountName;
            BudgetAccountCode = allocations.BudgetAccountCode;
            BudgetAccountName = allocations.BudgetAccountName;
        }

        /// <inheritdoc/>
        /// <summary> Gets the ProgramResultCodes identifier. </summary>
        /// <returns> </returns>
        public override int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString( ) )
                    : -1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( int );
            }
        }
    }
}
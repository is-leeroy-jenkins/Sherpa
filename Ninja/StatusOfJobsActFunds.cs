//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                StatusOfJobsActFunds.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="StatusOfJobsActFunds.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    StatusOfJobsActFunds.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class StatusOfJobsActFunds : StatusOfFunds
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfJobsActFunds" />
        /// class.
        /// </summary>
        public StatusOfJobsActFunds( )
        {
            Source = Source.StatusOfJobsActFunds;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfJobsActFunds" />
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StatusOfJobsActFunds( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
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
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? string.Empty );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? string.Empty );
            OpenCommitments =
                double.Parse( Record[ nameof( OpenCommitments ) ].ToString( ) ?? string.Empty );

            UnliquidatedObligations =
                double.Parse( Record[ nameof( UnliquidatedObligations ) ].ToString( ) ?? string.Empty );

            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( Record[ nameof( Expenditures ) ].ToString( ) ?? string.Empty );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? string.Empty );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? string.Empty );
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
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfJobsActFunds" />
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The builder. </param>
        public StatusOfJobsActFunds( IDataModel dataBuilder )
            : base( dataBuilder )
        {
            Record = dataBuilder.Record;
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
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? string.Empty );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? string.Empty );
            OpenCommitments =
                double.Parse( Record[ nameof( OpenCommitments ) ].ToString( ) ?? string.Empty );

            UnliquidatedObligations =
                double.Parse( Record[ nameof( UnliquidatedObligations ) ].ToString( ) ?? string.Empty );

            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( Record[ nameof( Expenditures ) ].ToString( ) ?? string.Empty );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? string.Empty );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? string.Empty );
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
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfJobsActFunds" />
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StatusOfJobsActFunds( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = Record.ToDictionary( );
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
            Amount = double.Parse( dataRow[ nameof( Amount ) ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( dataRow[ nameof( Budgeted ) ].ToString( ) ?? string.Empty );
            Posted = double.Parse( dataRow[ nameof( Posted ) ].ToString( ) ?? string.Empty );
            OpenCommitments =
                double.Parse( dataRow[ nameof( OpenCommitments ) ].ToString( ) ?? string.Empty );

            UnliquidatedObligations =
                double.Parse( Record[ nameof( UnliquidatedObligations ) ].ToString( ) ?? string.Empty );

            Obligations = double.Parse( dataRow[ nameof( Obligations ) ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( dataRow[ nameof( Expenditures ) ].ToString( ) ?? string.Empty );
            Used = double.Parse( dataRow[ nameof( Used ) ].ToString( ) ?? string.Empty );
            Available = double.Parse( dataRow[ nameof( Available ) ].ToString( ) ?? string.Empty );
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfJobsActFunds"/> class.
        /// </summary>
        /// <param name="map">The map.</param>
        /// <inheritdoc />
        public StatusOfJobsActFunds( IDictionary<string, object> map )
            : base( map )
        {
            Record = new DataBuilder( Source, map )?.Record;
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
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? string.Empty );
            Budgeted = double.Parse( Record[ nameof( Budgeted ) ].ToString( ) ?? string.Empty );
            Posted = double.Parse( Record[ nameof( Posted ) ].ToString( ) ?? string.Empty );
            OpenCommitments =
                double.Parse( Record[ nameof( OpenCommitments ) ].ToString( ) ?? string.Empty );

            UnliquidatedObligations =
                double.Parse( Record[ nameof( UnliquidatedObligations ) ].ToString( ) ?? string.Empty );

            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? string.Empty );
            Expenditures = double.Parse( Record[ nameof( Expenditures ) ].ToString( ) ?? string.Empty );
            Used = double.Parse( Record[ nameof( Used ) ].ToString( ) ?? string.Empty );
            Available = double.Parse( Record[ nameof( Available ) ].ToString( ) ?? string.Empty );
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusOfJobsActFunds"/> class.
        /// </summary>
        /// <param name="allocation">The allocation.</param>
        public StatusOfJobsActFunds( StatusOfJobsActFunds allocation )
            : this( )
        {
            ID = allocation.ID;
            BudgetLevel = allocation.BudgetLevel;
            BFY = allocation.BFY;
            EFY = allocation.EFY;
            FundCode = allocation.FundCode;
            FundName = allocation.FundName;
            RpioCode = allocation.RpioCode;
            RpioName = allocation.RpioName;
            AhCode = allocation.AhCode;
            AhName = allocation.AhName;
            OrgCode = allocation.OrgCode;
            OrgName = allocation.OrgName;
            AccountCode = allocation.AccountCode;
            BocCode = allocation.BocCode;
            BocName = allocation.BocName;
            Amount = allocation.Amount;
            ProgramProjectCode = allocation.ProgramProjectCode;
            ProgramProjectName = allocation.ProgramProjectName;
            ProgramAreaCode = allocation.ProgramAreaCode;
            ProgramAreaName = allocation.ProgramAreaName;
            NpmCode = allocation.NpmCode;
            NpmName = allocation.NpmName;
            TreasuryAccountCode = allocation.TreasuryAccountCode;
            TreasuryAccountName = allocation.TreasuryAccountName;
            BudgetAccountCode = allocation.BudgetAccountCode;
            BudgetAccountName = allocation.BudgetAccountName;
        }
    }
}
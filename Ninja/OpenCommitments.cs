// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="OpenCommitment.cs" company="Terry D. Eppler">
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
//   OpenCommitment.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class OpenCommitments : Obligations
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.OpenCommitments" />
        /// class.
        /// </summary>
        public OpenCommitments( )
        {
            Source = Source.OpenCommitments;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.OpenCommitments" />
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public OpenCommitments( IQuery query )
            : base( query )
        {
            Source = Source.OpenCommitments;
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.OpenCommitments" />
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public OpenCommitments( IDataModel builder )
            : base( builder )
        {
            Source = Source.OpenCommitments;
            Record = builder.Record;
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.OpenCommitments" />
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public OpenCommitments( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.OpenCommitments;
            Record = dataRow;
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
            Amount = double.Parse( Record[ nameof( Amount ) ].ToString( ) ?? "0" );
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.OpenCommitments" /> class.
        /// </summary>
        /// <param name="commitment">The commitment.</param>
        public OpenCommitments( OpenCommitments commitment )
        {
            ID = commitment.ID;
            BFY = commitment.BFY;
            EFY = commitment.EFY;
            FundCode = commitment.FundCode;
            FundName = commitment.FundName;
            RpioCode = commitment.RpioCode;
            RpioName = commitment.RpioName;
            AhCode = commitment.AhCode;
            AhName = commitment.AhName;
            OrgCode = commitment.OrgCode;
            OrgName = commitment.OrgName;
            AccountCode = commitment.AccountCode;
            BocCode = commitment.BocCode;
            BocName = commitment.BocName;
            Amount = commitment.Amount;
            ProgramProjectCode = commitment.ProgramProjectCode;
            ProgramProjectName = commitment.ProgramProjectName;
            ProgramAreaCode = commitment.ProgramAreaCode;
            ProgramAreaName = commitment.ProgramAreaName;
            NpmCode = commitment.NpmCode;
            NpmName = commitment.NpmName;
            GoalCode = commitment.GoalCode;
            GoalName = commitment.GoalName;
            ObjectiveCode = commitment.ObjectiveCode;
            ObjectiveName = commitment.ObjectiveName;
            TreasuryAccountCode = commitment.TreasuryAccountCode;
            TreasuryAccountName = commitment.TreasuryAccountName;
            BudgetAccountCode = commitment.BudgetAccountCode;
            BudgetAccountName = commitment.BudgetAccountName;
        }
    }
}
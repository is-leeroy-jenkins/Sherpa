// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="MonthlyActual.cs" company="Terry D. Eppler">
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
//   MonthlyActual.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.Actual" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class MonthlyActuals : Actual
    {
        /// <summary>
        /// Gets or sets the net outlays.
        /// </summary>
        /// <value>
        /// The net outlays.
        /// </value>
        public double NetOutlays { get; set; }

        /// <summary>
        /// Gets or sets the gross outlays.
        /// </summary>
        /// <value>
        /// The gross outlays.
        /// </value>
        public double GrossOutlays { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.MonthlyActuals" /> class.
        /// </summary>
        public MonthlyActuals( )
        {
            Source = Source.MonthlyActuals;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.MonthlyActuals" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public MonthlyActuals( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            AppropriationName = Record[ nameof( AppropriationName ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            SubAppropriationName = Record[ nameof( SubAppropriationName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            ActivityCode = Record[ nameof( ActivityCode ) ].ToString( );
            ActivityName = Record[ nameof( ActivityName ) ].ToString( );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? "0" );
            GrossOutlays = double.Parse( Record[ nameof( GrossOutlays ) ].ToString( ) ?? "0" );
            NetOutlays = double.Parse( Record[ nameof( NetOutlays ) ].ToString( ) ?? "0" );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
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
        /// <see cref="T:BudgetExecution.MonthlyActuals" /> class.
        /// </summary>
        /// <param name="builder"></param>
        public MonthlyActuals( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            AhCode = Record[ nameof( AhCode ) ].ToString( );
            AhName = Record[ nameof( AhName ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            AppropriationName = Record[ nameof( AppropriationName ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            SubAppropriationName = Record[ nameof( SubAppropriationName ) ].ToString( );
            OrgCode = Record[ nameof( OrgCode ) ].ToString( );
            OrgName = Record[ nameof( OrgName ) ].ToString( );
            AccountCode = Record[ nameof( AccountCode ) ].ToString( );
            BocCode = Record[ nameof( BocCode ) ].ToString( );
            BocName = Record[ nameof( BocName ) ].ToString( );
            ActivityCode = Record[ nameof( ActivityCode ) ].ToString( );
            ActivityName = Record[ nameof( ActivityName ) ].ToString( );
            ProgramProjectCode = Record[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = Record[ nameof( ProgramProjectName ) ].ToString( );
            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? "0" );
            GrossOutlays = double.Parse( Record[ nameof( GrossOutlays ) ].ToString( ) ?? "0" );
            NetOutlays = double.Parse( Record[ nameof( NetOutlays ) ].ToString( ) ?? "0" );
            ProgramAreaCode = Record[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = Record[ nameof( ProgramAreaName ) ].ToString( );
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
        /// <see cref="T:BudgetExecution.MonthlyActuals" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public MonthlyActuals( DataRow dataRow )
            : base( dataRow )
        {
            Source = Source.MonthlyActuals;
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            FundName = dataRow[ nameof( FundName ) ].ToString( );
            RpioCode = dataRow[ nameof( RpioCode ) ].ToString( );
            RpioName = dataRow[ nameof( RpioName ) ].ToString( );
            AhCode = dataRow[ nameof( AhCode ) ].ToString( );
            AhName = dataRow[ nameof( AhName ) ].ToString( );
            AppropriationCode = dataRow[ nameof( AppropriationCode ) ].ToString( );
            AppropriationName = dataRow[ nameof( AppropriationName ) ].ToString( );
            SubAppropriationCode = dataRow[ nameof( SubAppropriationCode ) ].ToString( );
            SubAppropriationName = dataRow[ nameof( SubAppropriationName ) ].ToString( );
            OrgCode = dataRow[ nameof( OrgCode ) ].ToString( );
            OrgName = dataRow[ nameof( OrgName ) ].ToString( );
            AccountCode = dataRow[ nameof( AccountCode ) ].ToString( );
            BocCode = dataRow[ nameof( BocCode ) ].ToString( );
            BocName = dataRow[ nameof( BocName ) ].ToString( );
            ActivityCode = dataRow[ nameof( ActivityCode ) ].ToString( );
            ActivityName = dataRow[ nameof( ActivityName ) ].ToString( );
            ProgramProjectCode = dataRow[ nameof( ProgramProjectCode ) ].ToString( );
            ProgramProjectName = dataRow[ nameof( ProgramProjectName ) ].ToString( );
            Obligations = double.Parse( Record[ nameof( Obligations ) ].ToString( ) ?? "0" );
            GrossOutlays = double.Parse( Record[ nameof( GrossOutlays ) ].ToString( ) ?? "0" );
            NetOutlays = double.Parse( Record[ nameof( NetOutlays ) ].ToString( ) ?? "0" );
            ProgramAreaCode = dataRow[ nameof( ProgramAreaCode ) ].ToString( );
            ProgramAreaName = dataRow[ nameof( ProgramAreaName ) ].ToString( );
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
        /// <see cref="T:BudgetExecution.MonthlyActuals" /> class.
        /// </summary>
        /// <param name="actual">The actual.</param>
        public MonthlyActuals( MonthlyActuals actual )
        {
            Source = Source.MonthlyActuals;
            ID = actual.ID;
            BFY = actual.BFY;
            EFY = actual.EFY;
            FundCode = actual.FundCode;
            FundName = actual.FundName;
            RpioCode = actual.RpioCode;
            RpioName = actual.RpioName;
            AhCode = actual.AhCode;
            AhName = actual.AhName;
            AppropriationCode = actual.AppropriationCode;
            AppropriationName = actual.AppropriationName;
            SubAppropriationCode = actual.SubAppropriationCode;
            SubAppropriationName = actual.SubAppropriationName;
            OrgCode = actual.OrgCode;
            OrgName = actual.OrgName;
            AccountCode = actual.AccountCode;
            BocCode = actual.BocCode;
            BocName = actual.BocName;
            ActivityCode = actual.ActivityCode;
            ActivityName = actual.ActivityName;
            ProgramProjectCode = actual.ProgramProjectCode;
            ProgramProjectName = actual.ProgramProjectName;
            Obligations = actual.Obligations;
            GrossOutlays = actual.GrossOutlays;
            NetOutlays = actual.NetOutlays;
            ProgramAreaCode = actual.ProgramAreaCode;
            ProgramAreaName = actual.ProgramAreaName;
            GoalCode = actual.GoalCode;
            GoalName = actual.GoalName;
            ObjectiveCode = actual.ObjectiveCode;
            ObjectiveName = actual.ObjectiveName;
            TreasuryAccountCode = actual.TreasuryAccountCode;
            TreasuryAccountName = actual.TreasuryAccountName;
            BudgetAccountCode = actual.BudgetAccountCode;
            BudgetAccountName = actual.BudgetAccountName;
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CompassLevel.cs" company="Terry D. Eppler">
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
//   CompassLevel.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    /// <seealso cref="BudgetExecution.PRC"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CompassLevel : PRC
    {
        /// <summary> Gets or sets the type of the document. </summary>
        /// <value> The type of the document. </value>
        public string DocumentType { get; set; }

        /// <summary> Gets or sets the document date. </summary>
        /// <value> The document date. </value>
        public DateOnly DocumentDate { get; set; }

        /// <summary> Gets or sets the appropriation code. </summary>
        /// <value> The appropriation code. </value>
        public string AppropriationCode { get; set; }

        /// <summary> Gets or sets the sub appropriation code. </summary>
        /// <value> The sub appropriation code. </value>
        public string SubAppropriationCode { get; set; }

        /// <summary> Gets or sets the name of the appropriation. </summary>
        /// <value> The name of the appropriation. </value>
        public string AppropriationName { get; set; }

        /// <summary> Gets or sets the treasury symbol. </summary>
        /// <value> The treasury symbol. </value>
        public string TreasurySymbol { get; set; }

        /// <summary> Gets or sets the authority. </summary>
        /// <value> The authority. </value>
        public double Authority { get; set; }

        /// <summary> Gets or sets the carryover in. </summary>
        /// <value> The carryover in. </value>
        public double CarryoverIn { get; set; }

        /// <summary> Gets or sets the carryover out. </summary>
        /// <value> The carryover out. </value>
        public double CarryoverOut { get; set; }

        /// <summary> Gets or sets the recoveries. </summary>
        /// <value> The recoveries. </value>
        public double Recoveries { get; set; }

        /// <summary> Gets or sets the reimbursements. </summary>
        /// <value> The reimbursements. </value>
        public double Reimbursements { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CompassLevel"/>
        /// class.
        /// </summary>
        public CompassLevel( )
        {
            Source = Source.CompassLevels;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CompassLevel"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public CompassLevel( IQuery query )
            : base( query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CompassLevelsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            TreasurySymbol = Record[ nameof( TreasurySymbol ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            AppropriationName = Record[ nameof( AppropriationName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            Authority = double.Parse( Record[ nameof( Authority ) ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ nameof( CarryoverOut ) ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ nameof( CarryoverIn ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CompassLevel"/>
        /// class.
        /// </summary>
        /// <param name="builder"> </param>
        public CompassLevel( IDataModel builder )
            : base( builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "CompassLevelsId" ].ToString( ) ?? "0" );
            BFY = Record[ nameof( BFY ) ].ToString( );
            EFY = Record[ nameof( EFY ) ].ToString( );
            TreasurySymbol = Record[ nameof( TreasurySymbol ) ].ToString( );
            FundCode = Record[ nameof( FundCode ) ].ToString( );
            FundName = Record[ nameof( FundName ) ].ToString( );
            AppropriationCode = Record[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = Record[ nameof( SubAppropriationCode ) ].ToString( );
            AppropriationName = Record[ nameof( AppropriationName ) ].ToString( );
            RpioCode = Record[ nameof( RpioCode ) ].ToString( );
            RpioName = Record[ nameof( RpioName ) ].ToString( );
            BudgetLevel = Record[ nameof( BudgetLevel ) ].ToString( );
            Authority = double.Parse( Record[ nameof( Authority ) ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( Record[ nameof( CarryoverOut ) ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( Record[ nameof( CarryoverIn ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( Record[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( Record[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = Record[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = Record[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = Record[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CompassLevel"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public CompassLevel( DataRow dataRow )
            : base( dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "CompassLevelsId" ].ToString( ) ?? "0" );
            BFY = dataRow[ nameof( BFY ) ].ToString( );
            EFY = dataRow[ nameof( EFY ) ].ToString( );
            TreasurySymbol = dataRow[ nameof( TreasurySymbol ) ].ToString( );
            FundCode = dataRow[ nameof( FundCode ) ].ToString( );
            FundName = dataRow[ nameof( FundName ) ].ToString( );
            AppropriationCode = dataRow[ nameof( AppropriationCode ) ].ToString( );
            SubAppropriationCode = dataRow[ nameof( SubAppropriationCode ) ].ToString( );
            AppropriationName = dataRow[ nameof( AppropriationName ) ].ToString( );
            RpioCode = dataRow[ nameof( RpioCode ) ].ToString( );
            RpioName = dataRow[ nameof( RpioName ) ].ToString( );
            BudgetLevel = dataRow[ nameof( BudgetLevel ) ].ToString( );
            Authority = double.Parse( dataRow[ nameof( Authority ) ].ToString( ) ?? "0" );
            CarryoverOut = double.Parse( dataRow[ nameof( CarryoverOut ) ].ToString( ) ?? "0" );
            CarryoverIn = double.Parse( dataRow[ nameof( CarryoverIn ) ].ToString( ) ?? "0" );
            Recoveries = double.Parse( dataRow[ nameof( Recoveries ) ].ToString( ) ?? "0" );
            Reimbursements = double.Parse( dataRow[ nameof( Reimbursements ) ].ToString( ) ?? "0" );
            TreasuryAccountCode = dataRow[ nameof( TreasuryAccountCode ) ].ToString( );
            TreasuryAccountName = dataRow[ nameof( TreasuryAccountName ) ].ToString( );
            BudgetAccountCode = dataRow[ nameof( BudgetAccountCode ) ].ToString( );
            BudgetAccountName = dataRow[ nameof( BudgetAccountName ) ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CompassLevel"/>
        /// class.
        /// </summary>
        /// <param name="level"> The compass level. </param>
        public CompassLevel( CompassLevel level )
        {
            ID = level.ID;
            BFY = level.BFY;
            EFY = level.EFY;
            AppropriationCode = level.AppropriationCode;
            SubAppropriationCode = level.SubAppropriationCode;
            AppropriationName = level.AppropriationName;
            FundCode = level.FundCode;
            FundName = level.FundName;
            RpioCode = level.RpioCode;
            RpioName = level.RpioName;
            AccountCode = level.AccountCode;
            ProgramProjectCode = level.ProgramProjectCode;
            ProgramAreaCode = level.ProgramAreaCode;
            ProgramAreaName = level.ProgramAreaName;
            BudgetLevel = level.BudgetLevel;
            Authority = level.Authority;
            CarryoverOut = level.CarryoverOut;
            CarryoverIn = level.CarryoverIn;
            Recoveries = level.Recoveries;
            Reimbursements = level.Reimbursements;
            TreasuryAccountCode = level.TreasuryAccountCode;
            TreasuryAccountName = level.TreasuryAccountName;
            BudgetAccountCode = level.BudgetAccountName;
            BudgetAccountName = level.BudgetAccountName;
        }
    }
}
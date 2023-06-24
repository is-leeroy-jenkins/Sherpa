// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CompassOutlay.cs" company="Terry D. Eppler">
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
//   CompassOutlay.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.BudgetUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CompassOutlay : BudgetUnit 
    {
        /// <summary>
        /// Gets or sets the appropriation code.
        /// </summary>
        /// <value>
        /// The appropriation code.
        /// </value>
        public string AppropriationCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the appropriation.
        /// </summary>
        /// <value>
        /// The name of the appropriation.
        /// </value>
        public string AppropriationName { get; set; }

        /// <summary>
        /// Gets or sets the month processed.
        /// </summary>
        /// <value>
        /// The month processed.
        /// </value>
        public string MonthProcessed { get; set; }

        /// <summary>
        /// Gets or sets the total obligations.
        /// </summary>
        /// <value>
        /// The total obligations.
        /// </value>
        public double TotalObligations { get; set; }

        /// <summary>
        /// Gets or sets the unliquidated obligations.
        /// </summary>
        /// <value>
        /// The unliquidated obligations.
        /// </value>
        public double UnliquidatedObligations { get; set; }

        /// <summary>
        /// Gets or sets the obligations paid.
        /// </summary>
        /// <value>
        /// The obligations paid.
        /// </value>
        public double ObligationsPaid { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        public CompassOutlay( )
        {
            Source = Source.CompassOutlays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public CompassOutlay( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            MonthProcessed = Record[ "MonthProcessed" ].ToString( );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString( ) ?? "0" );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public CompassOutlay( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            MonthProcessed = Record[ "MonthProcessed" ].ToString( );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString( ) ?? "0" );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public CompassOutlay( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            AppropriationCode = Record[ "AppropriationCode" ].ToString( );
            AppropriationName = Record[ "AppropriationName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            MonthProcessed = Record[ "MonthProcessed" ].ToString( );
            TotalObligations = double.Parse( Record[ "TotalObligations" ].ToString( ) ?? "0" );
            ObligationsPaid = double.Parse( Record[ "ObligationsPaid" ].ToString( ) ?? "0" );
            UnliquidatedObligations = double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompassOutlay"/> class.
        /// </summary>
        /// <param name="outlay">The outlay.</param>
        public CompassOutlay( CompassOutlay outlay )
        {
            ID = outlay.ID;
            BFY = outlay.BFY;
            EFY = outlay.EFY;
            FundCode = outlay.FundCode;
            FundName = outlay.FundName;
            AppropriationCode = outlay.AppropriationCode;
            AppropriationName = outlay.AppropriationName;
            TreasuryAccountCode = outlay.TreasuryAccountCode;
            TreasuryAccountName = outlay.TreasuryAccountName;
            BudgetAccountCode = outlay.BudgetAccountCode;
            BudgetAccountName = outlay.BudgetAccountName;
            MonthProcessed = outlay.MonthProcessed;
            TotalObligations = outlay.TotalObligations;
            ObligationsPaid = outlay.ObligationsPaid;
            UnliquidatedObligations = outlay.UnliquidatedObligations;
        }
    }
}
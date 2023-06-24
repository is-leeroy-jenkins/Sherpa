// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="MonthlyOutlay.cs" company="Terry D. Eppler">
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
//   MonthlyOutlay.cs
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
    public class MonthlyOutlay : BudgetUnit 
    {
        /// <summary>
        /// Gets or sets the fiscal year.
        /// </summary>
        /// <value>
        /// The fiscal year.
        /// </value>
        public string FiscalYear { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the line title.
        /// </summary>
        /// <value>
        /// The line title.
        /// </value>
        public string LineTitle { get; set; }

        /// <summary>
        /// Gets or sets the taxation code.
        /// </summary>
        /// <value>
        /// The taxation code.
        /// </value>
        public string TaxationCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury agency code.
        /// </summary>
        /// <value>
        /// The treasury agency code.
        /// </value>
        public string TreasuryAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the treasury bureau code.
        /// </summary>
        /// <value>
        /// The treasury bureau code.
        /// </value>
        public string TreasuryBureauCode { get; set; }

        /// <summary>
        /// Gets or sets the budget agency code.
        /// </summary>
        /// <value>
        /// The budget agency code.
        /// </value>
        public string BudgetAgencyCode { get; set; }

        /// <summary>
        /// Gets or sets the budget bureau code.
        /// </summary>
        /// <value>
        /// The budget bureau code.
        /// </value>
        public string BudgetBureauCode { get; set; }

        /// <summary>
        /// Gets or sets the sub account.
        /// </summary>
        /// <value>
        /// The sub account.
        /// </value>
        public string SubAccount { get; set; }

        /// <summary>
        /// Gets or sets the agency sequence.
        /// </summary>
        /// <value>
        /// The agency sequence.
        /// </value>
        public string AgencySequence { get; set; }

        /// <summary>
        /// Gets or sets the bureau sequence.
        /// </summary>
        /// <value>
        /// The bureau sequence.
        /// </value>
        public string BureauSequence { get; set; }

        /// <summary>
        /// Gets or sets the account sequence.
        /// </summary>
        /// <value>
        /// The account sequence.
        /// </value>
        public string AccountSequence { get; set; }

        /// <summary>
        /// Gets or sets the agency title.
        /// </summary>
        /// <value>
        /// The agency title.
        /// </value>
        public string AgencyTitle { get; set; }

        /// <summary>
        /// Gets or sets the bureau title.
        /// </summary>
        /// <value>
        /// The bureau title.
        /// </value>
        public string BureauTitle { get; set; }

        /// <summary>
        /// Gets or sets the october.
        /// </summary>
        /// <value>
        /// The october.
        /// </value>
        public double October { get; set; }

        /// <summary>
        /// Gets or sets the november.
        /// </summary>
        /// <value>
        /// The november.
        /// </value>
        public double November { get; set; }

        /// <summary>
        /// Gets or sets the december.
        /// </summary>
        /// <value>
        /// The december.
        /// </value>
        public double December { get; set; }

        /// <summary>
        /// Gets or sets the january.
        /// </summary>
        /// <value>
        /// The january.
        /// </value>
        public double January { get; set; }

        /// <summary>
        /// Gets or sets the february.
        /// </summary>
        /// <value>
        /// The february.
        /// </value>
        public double February { get; set; }

        /// <summary>
        /// Gets or sets the march.
        /// </summary>
        /// <value>
        /// The march.
        /// </value>
        public double March { get; set; }

        /// <summary>
        /// Gets or sets the april.
        /// </summary>
        /// <value>
        /// The april.
        /// </value>
        public double April { get; set; }

        /// <summary>
        /// Gets or sets the may.
        /// </summary>
        /// <value>
        /// The may.
        /// </value>
        public double May { get; set; }

        /// <summary>
        /// Gets or sets the june.
        /// </summary>
        /// <value>
        /// The june.
        /// </value>
        public double June { get; set; }

        /// <summary>
        /// Gets or sets the july.
        /// </summary>
        /// <value>
        /// The july.
        /// </value>
        public double July { get; set; }

        /// <summary>
        /// Gets or sets the august.
        /// </summary>
        /// <value>
        /// The august.
        /// </value>
        public double August { get; set; }

        /// <summary>
        /// Gets or sets the september.
        /// </summary>
        /// <value>
        /// The september.
        /// </value>
        public double September { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        public MonthlyOutlay( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public MonthlyOutlay( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "MonthlyOutlaysId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineTitle = Record[ "LineTitle" ].ToString( );
            TaxationCode = Record[ "TaxationCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgency" ].ToString( );
            TreasuryBureauCode = Record[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = Record[ "BudgetAgencyCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgencyCode" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            December = double.Parse( Record[ "December" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            March = double.Parse( Record[ "March" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ "May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            July = double.Parse( Record[ "July" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            September = double.Parse( Record[ "September" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public MonthlyOutlay( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "MonthlyOutlaysId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineTitle = Record[ "LineTitle" ].ToString( );
            TaxationCode = Record[ "TaxationCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgency" ].ToString( );
            TreasuryBureauCode = Record[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = Record[ "BudgetAgencyCode" ].ToString( );
            TreasuryAgencyCode = Record[ "TreasuryAgencyCode" ].ToString( );
            SubAccount = Record[ "SubAccount" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            December = double.Parse( Record[ "December" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            March = double.Parse( Record[ "March" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ "May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            July = double.Parse( Record[ "July" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            September = double.Parse( Record[ "September" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public MonthlyOutlay( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "MonthlyOutlaysId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            FiscalYear = dataRow[ "FiscalYear" ].ToString( );
            LineNumber = dataRow[ "LineNumber" ].ToString( );
            LineTitle = dataRow[ "LineTitle" ].ToString( );
            TaxationCode = dataRow[ "TaxationCode" ].ToString( );
            TreasuryBureauCode = dataRow[ "TreasuryBureauCode" ].ToString( );
            BudgetAgencyCode = dataRow[ "BudgetAgencyCode" ].ToString( );
            TreasuryAgencyCode = dataRow[ "TreasuryAgencyCode" ].ToString( );
            SubAccount = dataRow[ "SubAccount" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            October = double.Parse( dataRow[ "October" ].ToString( ) ?? "0" );
            November = double.Parse( dataRow[ "November" ].ToString( ) ?? "0" );
            December = double.Parse( dataRow[ "December" ].ToString( ) ?? "0" );
            January = double.Parse( dataRow[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( dataRow[ "February" ].ToString( ) ?? "0" );
            March = double.Parse( dataRow[ "March" ].ToString( ) ?? "0" );
            April = double.Parse( dataRow[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( dataRow[ "May" ].ToString( ) ?? "0" );
            June = double.Parse( dataRow[ "June" ].ToString( ) ?? "0" );
            July = double.Parse( dataRow[ "July" ].ToString( ) ?? "0" );
            August = double.Parse( dataRow[ "August" ].ToString( ) ?? "0" );
            September = double.Parse( dataRow[ "September" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyOutlay"/> class.
        /// </summary>
        /// <param name="outlays">The outlays.</param>
        public MonthlyOutlay( MonthlyOutlay outlays )
        {
            ID = outlays.ID;
            BFY = outlays.BFY;
            EFY = outlays.EFY;
            FiscalYear = outlays.FiscalYear;
            LineNumber = outlays.LineNumber;
            LineTitle = outlays.LineTitle;
            TaxationCode = outlays.TaxationCode;
            TreasuryAgencyCode = outlays.TreasuryAgencyCode;
            TreasuryBureauCode = outlays.TreasuryBureauCode;
            BudgetAgencyCode = outlays.BudgetAgencyCode;
            SubAccount = outlays.SubAccount;
            TreasuryAccountCode = outlays.TreasuryAccountCode;
            TreasuryAccountName = outlays.TreasuryAccountName;
            BudgetAccountCode = outlays.BudgetAccountCode;
            BudgetAccountName = outlays.BudgetAccountName;
            October = outlays.October;
            November = outlays.November;
            December = outlays.December;
            January = outlays.January;
            February = outlays.February;
            March = outlays.March;
            April = outlays.April;
            May = outlays.May;
            June = outlays.June;
            July = outlays.July;
            August = outlays.August;
            September = outlays.September;
        }
    }
}
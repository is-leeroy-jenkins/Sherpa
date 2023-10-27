// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StatusOfBudgetaryResources.cs" company="Terry D. Eppler">
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
//   StatusOfBudgetaryResources.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.BudgetUnit"/>
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class BudgetaryResourceExecution : BudgetUnit
    {
        /// <summary> Gets or sets the fiscal year. </summary>
        /// <value> The fiscal year. </value>
        public string FiscalYear { get; set; }

        /// <summary> Gets or sets the last update. </summary>
        /// <value> The last update. </value>
        public DateOnly LastUpdate { get; set; }

        /// <summary> Gets or sets the stat. </summary>
        /// <value> The stat. </value>
        public string STAT { get; set; }

        /// <summary> Gets or sets the credit indicator. </summary>
        /// <value> The credit indicator. </value>
        public string CreditIndicator { get; set; }

        /// <summary> Gets or sets the line number. </summary>
        /// <value> The line number. </value>
        public string LineNumber { get; set; }

        /// <summary> Gets or sets the line description. </summary>
        /// <value> The line description. </value>
        public string LineDescription { get; set; }

        /// <summary> Gets or sets the name of the section. </summary>
        /// <value> The name of the section. </value>
        public string SectionName { get; set; }

        /// <summary> Gets or sets the section number. </summary>
        /// <value> The section number. </value>
        public string SectionNumber { get; set; }

        /// <summary> Gets or sets the type of the line. </summary>
        /// <value> The type of the line. </value>
        public string LineType { get; set; }

        /// <summary> Gets or sets the financing accounts. </summary>
        /// <value> The financing accounts. </value>
        public string FinancingAccounts { get; set; }

        /// <summary> Gets or sets the november. </summary>
        /// <value> The november. </value>
        public double November { get; set; }

        /// <summary> Gets or sets the january. </summary>
        /// <value> The january. </value>
        public double January { get; set; }

        /// <summary> Gets or sets the february. </summary>
        /// <value> The february. </value>
        public double February { get; set; }

        /// <summary> Gets or sets the april. </summary>
        /// <value> The april. </value>
        public double April { get; set; }

        /// <summary> Gets or sets the may. </summary>
        /// <value> The may. </value>
        public double May { get; set; }

        /// <summary> Gets or sets the june. </summary>
        /// <value> The june. </value>
        public double June { get; set; }

        /// <summary> Gets or sets the august. </summary>
        /// <value> The august. </value>
        public double August { get; set; }

        /// <summary> Gets or sets the october. </summary>
        /// <value> The october. </value>
        public double October { get; set; }

        /// <summary> Gets or sets the march. </summary>
        /// <value> The march. </value>
        public double March { get; set; }

        /// <summary> Gets or sets the july. </summary>
        /// <value> The july. </value>
        public double July { get; set; }

        /// <summary> Gets or sets the september. </summary>
        /// <value> The september. </value>
        public double September { get; set; }

        /// <summary> Gets or sets the december. </summary>
        /// <value> The december. </value>
        public double December { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetaryResourceExecution"/>
        /// class.
        /// </summary>
        public BudgetaryResourceExecution( )
        {
            Source = Source.BudgetaryResourceExecution;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetaryResourceExecution"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public BudgetaryResourceExecution( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            LastUpdate = DateOnly.Parse( Record[ "LastUpdate" ].ToString( ) ?? "" );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            STAT = Record[ "STAT" ].ToString( );
            CreditIndicator = Record[ "CreditIndicator" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineDescription = Record[ "LineDescription" ].ToString( );
            SectionName = Record[ "SectionName" ].ToString( );
            SectionNumber = Record[ "SectionNumber" ].ToString( );
            LineType = Record[ "LineType" ].ToString( );
            FinancingAccounts = Record[ "FinancingAccounts" ].ToString( );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ " May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            March = double.Parse( Record[ "March" ].ToString( ) ?? "0" );
            July = double.Parse( Record[ "July" ].ToString( ) ?? "0" );
            September = double.Parse( Record[ "September" ].ToString( ) ?? "0" );
            December = double.Parse( Record[ "December" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetaryResourceExecution"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public BudgetaryResourceExecution( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            FiscalYear = Record[ "FiscalYear" ].ToString( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            LastUpdate = DateOnly.Parse( Record[ "LastUpdate" ].ToString( ) ?? "" );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            STAT = Record[ "STAT" ].ToString( );
            CreditIndicator = Record[ "CreditIndicator" ].ToString( );
            LineNumber = Record[ "LineNumber" ].ToString( );
            LineDescription = Record[ "LineDescription" ].ToString( );
            SectionName = Record[ "SectionName" ].ToString( );
            SectionNumber = Record[ "SectionNumber" ].ToString( );
            LineType = Record[ "LineType" ].ToString( );
            FinancingAccounts = Record[ "FinancingAccounts" ].ToString( );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ " May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            March = double.Parse( Record[ "March" ].ToString( ) ?? "0" );
            July = double.Parse( Record[ "July" ].ToString( ) ?? "0" );
            September = double.Parse( Record[ "September" ].ToString( ) ?? "0" );
            December = double.Parse( Record[ "December" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetaryResourceExecution"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public BudgetaryResourceExecution( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            FiscalYear = dataRow[ "FiscalYear" ].ToString( );
            BFY = dataRow[ "BFY" ].ToString( );
            EFY = dataRow[ "EFY" ].ToString( );
            LastUpdate = DateOnly.Parse( dataRow[ "LastUpdate" ].ToString( ) ?? "" );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            STAT = dataRow[ "STAT" ].ToString( );
            CreditIndicator = dataRow[ "CreditIndicator" ].ToString( );
            LineNumber = dataRow[ "LineNumber" ].ToString( );
            LineDescription = dataRow[ "LineDescription" ].ToString( );
            SectionName = dataRow[ "SectionName" ].ToString( );
            SectionNumber = dataRow[ "SectionNumber" ].ToString( );
            LineType = dataRow[ "LineType" ].ToString( );
            FinancingAccounts = dataRow[ "FinancingAccounts" ].ToString( );
            November = double.Parse( Record[ "November" ].ToString( ) ?? "0" );
            January = double.Parse( Record[ "January" ].ToString( ) ?? "0" );
            February = double.Parse( Record[ "February" ].ToString( ) ?? "0" );
            April = double.Parse( Record[ "April" ].ToString( ) ?? "0" );
            May = double.Parse( Record[ " May" ].ToString( ) ?? "0" );
            June = double.Parse( Record[ "June" ].ToString( ) ?? "0" );
            August = double.Parse( Record[ "August" ].ToString( ) ?? "0" );
            October = double.Parse( Record[ "October" ].ToString( ) ?? "0" );
            March = double.Parse( Record[ "March" ].ToString( ) ?? "0" );
            July = double.Parse( Record[ "July" ].ToString( ) ?? "0" );
            September = double.Parse( Record[ "September" ].ToString( ) ?? "0" );
            December = double.Parse( Record[ "December" ].ToString( ) ?? "0" );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetaryResourceExecution"/>
        /// class.
        /// </summary>
        /// <param name="budget"> The budget. </param>
        public BudgetaryResourceExecution( BudgetaryResourceExecution budget )
            : this( )
        {
            ID = budget.ID;
            FiscalYear = budget.FiscalYear;
            BFY = budget.BFY;
            EFY = budget.EFY;
            LastUpdate = budget.LastUpdate;
            BudgetAccountCode = budget.BudgetAccountCode;
            BudgetAccountName = budget.BudgetAccountName;
            TreasuryAccountCode = budget.TreasuryAccountCode;
            TreasuryAccountName = budget.TreasuryAccountName;
            STAT = budget.STAT;
            CreditIndicator = budget.CreditIndicator;
            LineNumber = budget.LineNumber;
            LineDescription = budget.LineDescription;
            SectionName = budget.SectionName;
            SectionNumber = budget.SectionNumber;
            LineType = budget.LineType;
            FinancingAccounts = budget.FinancingAccounts;
            November = budget.November;
            January = budget.January;
            February = budget.February;
            April = budget.April;
            May = budget.May;
            June = budget.June;
            August = budget.August;
            October = budget.October;
            March = budget.March;
            July = budget.July;
            September = budget.September;
            December = budget.December;
        }
    }
}
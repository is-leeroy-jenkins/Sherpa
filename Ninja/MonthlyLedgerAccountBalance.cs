// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="MonthlyLedgerAccountBalance.cs" company="Terry D. Eppler">
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
//   MonthlyLedgerAccountBalance.cs
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
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class MonthlyLedgerAccountBalance : BudgetUnit
    {
        /// <summary>
        /// Gets or sets the fiscal year.
        /// </summary>
        /// <value>
        /// The fiscal year.
        /// </value>
        public string FiscalYear { get; set; }

        /// <summary>
        /// Gets or sets the ledger account.
        /// </summary>
        /// <value>
        /// The ledger account.
        /// </value>
        public string LedgerAccount { get; set; }

        /// <summary>
        /// Gets or sets the name of the ledger.
        /// </summary>
        /// <value>
        /// The name of the ledger.
        /// </value>
        public string LedgerName { get; set; }

        /// <summary>
        /// Gets or sets the apportionment account code.
        /// </summary>
        /// <value>
        /// The apportionment account code.
        /// </value>
        public string ApportionmentAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the fiscal month.
        /// </summary>
        /// <value>
        /// The fiscal month.
        /// </value>
        public string FiscalMonth { get; set; }

        /// <summary>
        /// Gets or sets the credit balance.
        /// </summary>
        /// <value>
        /// The credit balance.
        /// </value>
        public double CreditBalance { get; set; }

        /// <summary>
        /// Gets or sets the debit balance.
        /// </summary>
        /// <value>
        /// The debit balance.
        /// </value>
        public double DebitBalance { get; set; }

        /// <summary>
        /// Gets or sets the year to date amount.
        /// </summary>
        /// <value>
        /// The year to date amount.
        /// </value>
        public double YearToDateAmount { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyLedgerAccountBalance"/> class.
        /// </summary>
        public MonthlyLedgerAccountBalance( )
        {
            Source = Source.MonthlyLedgerAccountBalances;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyLedgerAccountBalance"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public MonthlyLedgerAccountBalance( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            LedgerAccount = Record[ "LedgerAccount" ].ToString( );
            LedgerName = Record[ "LedgerName" ].ToString( );
            CreditBalance = double.Parse( Record[ "CreditBalance" ].ToString( ) ?? "0" );
            DebitBalance = double.Parse( Record[ "DebitBalance" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyLedgerAccountBalance"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public MonthlyLedgerAccountBalance( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            Efy = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            LedgerAccount = Record[ "LedgerAccount" ].ToString( );
            LedgerName = Record[ "LedgerName" ].ToString( );
            CreditBalance = double.Parse( Record[ "CreditBalance" ].ToString( ) ?? "0" );
            DebitBalance = double.Parse( Record[ "DebitBalance" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyLedgerAccountBalance"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public MonthlyLedgerAccountBalance( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = dataRow[ "BFY" ].ToString( );
            Efy = dataRow[ "EFY" ].ToString( );
            FundCode = dataRow[ "FundCode" ].ToString( );
            FundName = dataRow[ "FundName" ].ToString( );
            LedgerAccount = dataRow[ "LedgerAccount" ].ToString( );
            LedgerName = dataRow[ "LedgerName" ].ToString( );
            CreditBalance = double.Parse( dataRow[ "CreditBalance" ].ToString( ) ?? "0" );
            DebitBalance = double.Parse( dataRow[ "DebitBalance" ].ToString( ) ?? "0" );
            TreasuryAccountCode = dataRow[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = dataRow[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = dataRow[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = dataRow[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyLedgerAccountBalance"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public MonthlyLedgerAccountBalance( MonthlyLedgerAccountBalance account )
        {
            ID = account.ID;
            BFY = account.BFY;
            Efy = account.Efy;
            FundCode = account.FundCode;
            FundName = account.FundName;
            LedgerAccount = account.LedgerAccount;
            LedgerName = account.LedgerName;
            CreditBalance = account.CreditBalance;
            DebitBalance = account.DebitBalance;
            TreasuryAccountCode = account.TreasuryAccountCode;
            TreasuryAccountName = account.TreasuryAccountName;
            BudgetAccountCode = account.BudgetAccountCode;
            BudgetAccountName = account.BudgetAccountName;
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="GeneralLedgerAccount.cs" company="Terry D. Eppler">
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
//   GeneralLedgerAccount.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class GeneralLedgerAccount  
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the account classification.
        /// </summary>
        /// <value>
        /// The account classification.
        /// </value>
        public string AccountClassification { get; set; }

        /// <summary>
        /// Gets or sets the short name.
        /// </summary>
        /// <value>
        /// The short name.
        /// </value>
        public string ShortName { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the normal balance.
        /// </summary>
        /// <value>
        /// The normal balance.
        /// </value>
        public string NormalBalance { get; set; }

        /// <summary>
        /// Gets or sets the real or closing account.
        /// </summary>
        /// <value>
        /// The real or closing account.
        /// </value>
        public string RealOrClosingAccount { get; set; }

        /// <summary>
        /// Gets or sets the summary account.
        /// </summary>
        /// <value>
        /// The summary account.
        /// </value>
        public string SummaryAccount { get; set; }

        /// <summary>
        /// Gets or sets the cash account.
        /// </summary>
        /// <value>
        /// The cash account.
        /// </value>
        public string CashAccount { get; set; }

        /// <summary>
        /// Gets or sets the reportable account.
        /// </summary>
        /// <value>
        /// The reportable account.
        /// </value>
        public string ReportableAccount { get; set; }

        /// <summary>
        /// Gets or sets the cost allocation indicator.
        /// </summary>
        /// <value>
        /// The cost allocation indicator.
        /// </value>
        public string CostAllocationIndicator { get; set; }

        /// <summary>
        /// Gets or sets the federal non federal.
        /// </summary>
        /// <value>
        /// The federal non federal.
        /// </value>
        public string FederalNonFederal { get; set; }

        /// <summary>
        /// Gets or sets the attribute value.
        /// </summary>
        /// <value>
        /// The attribute value.
        /// </value>
        public string AttributeValue { get; set; }

        /// <summary>
        /// Gets or sets the usage.
        /// </summary>
        /// <value>
        /// The usage.
        /// </value>
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets the deposit.
        /// </summary>
        /// <value>
        /// The deposit.
        /// </value>
        public string Deposit { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        public GeneralLedgerAccount( )
        {
            Source = Source.GeneralLedgerAccounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public GeneralLedgerAccount( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "GeneralLedgerAccountsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Number = Record[ "Number" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            NormalBalance = Record[ "NormalBalance" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            SummaryAccount = Record[ "SummaryAccount" ].ToString( );
            AccountClassification = Record[ "AccountClassification" ].ToString( );
            CashAccount = Record[ "CashAccount" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            RealOrClosingAccount = Record[ "RealOrClosingAccount" ].ToString( );
            FederalNonFederal = Record[ "FederalNonFederal" ].ToString( );
            AttributeValue = Record[ "AttributeValue" ].ToString( );
            Usage = Record[ "Usage" ].ToString( );
            Deposit = Record[ "Deposit" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public GeneralLedgerAccount( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "GeneralLedgerAccountsId" ].ToString( ) ?? "0" );
            BFY = Record[ "BFY" ].ToString( );
            Number = Record[ "Number" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            ShortName = Record[ "ShortName" ].ToString( );
            NormalBalance = Record[ "NormalBalance" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            SummaryAccount = Record[ "SummaryAccount" ].ToString( );
            AccountClassification = Record[ "AccountClassification" ].ToString( );
            CashAccount = Record[ "CashAccount" ].ToString( );
            ReportableAccount = Record[ "ReportableAccount" ].ToString( );
            RealOrClosingAccount = Record[ "RealOrClosingAccount" ].ToString( );
            FederalNonFederal = Record[ "FederalNonFederal" ].ToString( );
            AttributeValue = Record[ "AttributeValue" ].ToString( );
            Usage = Record[ "Usage" ].ToString( );
            Deposit = Record[ "Deposit" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public GeneralLedgerAccount( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( dataRow[ "GeneralLedgerAccountsId" ].ToString( ) ?? "0" );
            BFY = dataRow[ "BFY" ].ToString( );
            Number = dataRow[ "Number" ].ToString( );
            Name = dataRow[ "Name" ].ToString( );
            ShortName = dataRow[ "ShortName" ].ToString( );
            NormalBalance = dataRow[ "NormalBalance" ].ToString( );
            ReportableAccount = dataRow[ "ReportableAccount" ].ToString( );
            SummaryAccount = dataRow[ "SummaryAccount" ].ToString( );
            AccountClassification = dataRow[ "AccountClassification" ].ToString( );
            CashAccount = dataRow[ "CashAccount" ].ToString( );
            ReportableAccount = dataRow[ "ReportableAccount" ].ToString( );
            RealOrClosingAccount = dataRow[ "RealOrClosingAccount" ].ToString( );
            FederalNonFederal = dataRow[ "FederalNonFederal" ].ToString( );
            AttributeValue = dataRow[ "AttributeValue" ].ToString( );
            Usage = dataRow[ "Usage" ].ToString( );
            Deposit = dataRow[ "Deposit" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralLedgerAccount"/> class.
        /// </summary>
        /// <param name="account">The account.</param>
        public GeneralLedgerAccount( GeneralLedgerAccount account )
        {
            ID = account.ID;
            BFY = account.BFY;
            Number = account.Number;
            Name = account.Name;
            ShortName = account.ShortName;
            NormalBalance = account.NormalBalance;
            ReportableAccount = account.ReportableAccount;
            SummaryAccount = account.SummaryAccount;
            AccountClassification = account.AccountClassification;
            CashAccount = account.CashAccount;
            ReportableAccount = account.ReportableAccount;
            RealOrClosingAccount = account.RealOrClosingAccount;
            FederalNonFederal = account.FederalNonFederal;
            AttributeValue = account.AttributeValue;
            Usage = account.Usage;
            Deposit = account.Deposit;
        }
    }
}
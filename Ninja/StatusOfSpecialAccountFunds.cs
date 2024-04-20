// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StatusOfSpecialAccountFunds.cs" company="Terry D. Eppler">
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
//   StatusOfSpecialAccountFunds.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.PRC"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class StatusOfSpecialAccountFunds : PRC
    {
        /// <summary> </summary>
        public string SpecialAccountNumber { get; set; }

        /// <summary> Gets or sets the name of the special account. </summary>
        /// <value> The name of the special account. </value>
        public string SpecialAccountName { get; set; }

        /// <summary> Gets or sets the account status. </summary>
        /// <value> The account status. </value>
        public string AccountStatus { get; set; }

        /// <summary> Gets or sets the NPL status code. </summary>
        /// <value> The NPL status code. </value>
        public string NplStatusCode { get; set; }

        /// <summary> Gets or sets the name of the NPL status. </summary>
        /// <value> The name of the NPL status. </value>
        public string NplStatusName { get; set; }

        /// <summary> Gets or sets the site identifier. </summary>
        /// <value> The site identifier. </value>
        public string SiteId { get; set; }

        /// <summary> Gets or sets the cerclis identifier. </summary>
        /// <value> The cerclis identifier. </value>
        public string CerclisSiteId { get; set; }

        /// <summary> Gets or sets the site code. </summary>
        /// <value> The site code. </value>
        public string SiteCode { get; set; }

        /// <summary> Gets or sets the name of the site. </summary>
        /// <value> The name of the site. </value>
        public string SiteName { get; set; }

        /// <summary> Gets or sets the operable unit. </summary>
        /// <value> The operable unit. </value>
        public string OperableUnit { get; set; }

        /// <summary> Gets or sets the pipeline code. </summary>
        /// <value> The pipeline code. </value>
        public string PipelineCode { get; set; }

        /// <summary> Gets or sets the pipeline description. </summary>
        /// <value> The pipeline description. </value>
        public string PipelineDescription { get; set; }

        /// <summary> </summary>
        public string ProgramCode { get; set; }

        /// <summary> Gets or sets the type of the transaction. </summary>
        /// <value> The type of the transaction. </value>
        public string TransactionType { get; set; }

        /// <summary> Gets or sets the name of the transaction type. </summary>
        /// <value> The name of the transaction type. </value>
        public string TransactionDescription { get; set; }

        /// <summary> Gets or sets the name of the foc. </summary>
        /// <value> The name of the foc. </value>
        public string SpecialAccountStatus { get; set; }

        /// <summary> </summary>
        public string StatusDescription { get; set; }

        /// <summary> </summary>
        public string EpaSiteId { get; set; }

        /// <summary> Gets or sets the transaction date. </summary>
        /// <value> The transaction date. </value>
        public DateOnly InterestDate { get; set; }

        /// <summary> Gets or sets the available balance. </summary>
        /// <value> The available balance. </value>
        public double AvailableBalance { get; set; }

        /// <summary> Gets or sets the open commitments. </summary>
        /// <value> The open commitments. </value>
        public double OpenCommitments { get; set; }

        /// <summary> Gets or sets the obligations. </summary>
        /// <value> The obligations. </value>
        public double Obligations { get; set; }

        /// <summary> Gets or sets the ulo. </summary>
        /// <value> The ulo. </value>
        public double UnliquidatedObligations { get; set; }

        /// <summary> Gets or sets the disbursements. </summary>
        /// <value> The disbursements. </value>
        public double Disbursements { get; set; }

        /// <summary> Gets or sets the unpaid balances. </summary>
        /// <value> The unpaid balances. </value>
        public double UnpaidBalances { get; set; }

        /// <summary> Gets or sets the collections. </summary>
        /// <value> The collections. </value>
        public double TrustfundTransfers { get; set; }

        /// <summary> </summary>
        public double Interest { get; set; }

        /// <summary> Gets or sets the cumulative receipts. </summary>
        /// <value> The cumulative receipts. </value>
        public double CumulativeReceipts { get; set; }

        /// <summary> </summary>
        public double NetReceipts { get; set; }

        /// <summary> </summary>
        public double CollectionsAndInterest { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets the source. </summary>
        public Source Source { get; set; }

        /// <inheritdoc/>
        /// <summary> </summary>
        public DataRow Record { get; set; }

        /// <summary> Gets or sets the data. </summary>
        /// <value> The data. </value>
        public IDictionary<string, object> Data { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.StatusOfSpecialAccountFunds"/>
        /// class.
        /// </summary>
        public StatusOfSpecialAccountFunds( )
        {
            Source = Source.StatusOfSpecialAccountFunds;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfSpecialAccountFunds"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StatusOfSpecialAccountFunds( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            CerclisSiteId = Record[ "CerclisSiteId" ].ToString( );
            SiteId = Record[ "SiteId" ].ToString( );
            ProgramCode = Record[ "ProgramCode" ].ToString( );
            SpecialAccountNumber = Record[ "SpecialAccountNumber" ].ToString( );
            SpecialAccountName = Record[ "SpecialAccountName" ].ToString( );
            SpecialAccountStatus = Record[ "SpecialAccountStatus" ].ToString( );
            NplStatusCode = Record[ "NplStatusCode" ].ToString( );
            InterestDate = DateOnly.Parse( Record[ "InterestDate" ].ToString( ) );
            TrustfundTransfers = double.Parse( Record[ "TrustfundTransfers" ].ToString( ) ?? "0" );
            Interest = double.Parse( Record[ "Interest" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) );

            Disbursements = double.Parse( Record[ "Disbursements" ].ToString( ) ?? "0" );
            CumulativeReceipts = double.Parse( Record[ "CumulativeReceipts" ].ToString( ) ?? "0" );
            NetReceipts = double.Parse( Record[ "NetReceipts" ].ToString( ) ?? "0" );
            CollectionsAndInterest = double.Parse( Record[ "CollectionsAndInterest" ].ToString( ) );
            AvailableBalance = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfSpecialAccountFunds"/>
        /// class.
        /// </summary>
        /// <param name="builder"> </param>
        public StatusOfSpecialAccountFunds( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            CerclisSiteId = Record[ "CerclisSiteId" ].ToString( );
            SiteId = Record[ "SiteId" ].ToString( );
            ProgramCode = Record[ "ProgramCode" ].ToString( );
            SpecialAccountNumber = Record[ "SpecialAccountNumber" ].ToString( );
            SpecialAccountName = Record[ "SpecialAccountName" ].ToString( );
            SpecialAccountStatus = Record[ "SpecialAccountStatus" ].ToString( );
            NplStatusCode = Record[ "NplStatusCode" ].ToString( );
            InterestDate = DateOnly.Parse( Record[ "InterestDate" ].ToString( ) );
            TrustfundTransfers = double.Parse( Record[ "TrustfundTransfers" ].ToString( ) ?? "0" );
            Interest = double.Parse( Record[ "Interest" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) );

            Disbursements = double.Parse( Record[ "Disbursements" ].ToString( ) ?? "0" );
            CumulativeReceipts = double.Parse( Record[ "CumulativeReceipts" ].ToString( ) ?? "0" );
            NetReceipts = double.Parse( Record[ "NetReceipts" ].ToString( ) ?? "0" );
            CollectionsAndInterest = double.Parse( Record[ "CollectionsAndInterest" ].ToString( ) );
            AvailableBalance = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StatusOfSpecialAccountFunds"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StatusOfSpecialAccountFunds( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            BFY = Record[ "BFY" ].ToString( );
            EFY = Record[ "EFY" ].ToString( );
            FundCode = Record[ "FundCode" ].ToString( );
            FundName = Record[ "FundName" ].ToString( );
            RpioCode = Record[ "RpioCode" ].ToString( );
            RpioName = Record[ "RpioName" ].ToString( );
            CerclisSiteId = Record[ "CerclisSiteId" ].ToString( );
            SiteId = Record[ "SiteId" ].ToString( );
            ProgramCode = Record[ "ProgramCode" ].ToString( );
            SpecialAccountNumber = Record[ "SpecialAccountNumber" ].ToString( );
            SpecialAccountName = Record[ "SpecialAccountName" ].ToString( );
            SpecialAccountStatus = Record[ "SpecialAccountStatus" ].ToString( );
            NplStatusCode = Record[ "NplStatusCode" ].ToString( );
            InterestDate = DateOnly.Parse( Record[ "InterestDate" ].ToString( ) );
            TrustfundTransfers = double.Parse( Record[ "TrustfundTransfers" ].ToString( ) ?? "0" );
            Interest = double.Parse( Record[ "Interest" ].ToString( ) ?? "0" );
            OpenCommitments = double.Parse( Record[ "OpenCommitments" ].ToString( ) ?? "0" );
            Obligations = double.Parse( Record[ "Obligations" ].ToString( ) ?? "0" );
            UnliquidatedObligations =
                double.Parse( Record[ "UnliquidatedObligations" ].ToString( ) );

            Disbursements = double.Parse( Record[ "Disbursements" ].ToString( ) ?? "0" );
            CumulativeReceipts = double.Parse( Record[ "CumulativeReceipts" ].ToString( ) ?? "0" );
            NetReceipts = double.Parse( Record[ "NetReceipts" ].ToString( ) ?? "0" );
            CollectionsAndInterest = double.Parse( Record[ "CollectionsAndInterest" ].ToString( ) );
            AvailableBalance = double.Parse( Record[ "Expenditures" ].ToString( ) ?? "0" );
            TreasuryAccountCode = Record[ "TreasuryAccountCode" ].ToString( );
            TreasuryAccountName = Record[ "TreasuryAccountName" ].ToString( );
            BudgetAccountCode = Record[ "BudgetAccountCode" ].ToString( );
            BudgetAccountName = Record[ "BudgetAccountName" ].ToString( );
        }

        /// <summary> </summary>
        /// <param name="special"> </param>
        public StatusOfSpecialAccountFunds( StatusOfSpecialAccountFunds special )
        {
            BFY = special.BFY;
            EFY = special.EFY;
            FundCode = special.FundCode;
            FundName = special.FundName;
            RpioCode = special.RpioCode;
            RpioName = special.RpioName;
            CerclisSiteId = special.CerclisSiteId;
            SiteId = special.SiteId;
            ProgramCode = special.ProgramCode;
            SpecialAccountNumber = special.SpecialAccountNumber;
            SpecialAccountName = special.SpecialAccountName;
            SpecialAccountStatus = special.SpecialAccountStatus;
            NplStatusCode = special.NplStatusCode;
            InterestDate = special.InterestDate;
            TrustfundTransfers = special.TrustfundTransfers;
            Interest = special.Interest;
            OpenCommitments = special.OpenCommitments;
            Obligations = special.Obligations;
            UnliquidatedObligations = special.UnliquidatedObligations;
            Disbursements = special.Disbursements;
            CumulativeReceipts = special.CumulativeReceipts;
            NetReceipts = special.NetReceipts;
            CollectionsAndInterest = special.CollectionsAndInterest;
            AvailableBalance = special.AvailableBalance;
            TreasuryAccountCode = special.TreasuryAccountCode;
            TreasuryAccountName = special.TreasuryAccountName;
            BudgetAccountCode = special.BudgetAccountCode;
            BudgetAccountName = special.BudgetAccountName;
        }
    }
}
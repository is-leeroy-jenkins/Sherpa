// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="SpecialAccount.cs" company="Terry D. Eppler">
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
//   SpecialAccount.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class SpecialAccount : PRC
    {
        /// <summary> Gets or sets the special account fund. </summary>
        /// <value> The special account fund. </value>
        public string SpecialAccountFund { get; set; }

        /// <summary> Gets or sets the special account number. </summary>
        /// <value> The special account number. </value>
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
        public string CerclisId { get; set; }

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

        /// <summary> Gets or sets the type of the transaction. </summary>
        /// <value> The type of the transaction. </value>
        public string TransactionType { get; set; }

        /// <summary> Gets or sets the name of the transaction type. </summary>
        /// <value> The name of the transaction type. </value>
        public string TransactionTypeName { get; set; }

        /// <summary> Gets or sets the foc code. </summary>
        /// <value> The foc code. </value>
        public string FocCode { get; set; }

        /// <summary> Gets or sets the name of the foc. </summary>
        /// <value> The name of the foc. </value>
        public string FocName { get; set; }

        /// <summary> Gets or sets the transaction date. </summary>
        /// <value> The transaction date. </value>
        public DateOnly TransactionDate { get; set; }

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
        public double ULO { get; set; }

        /// <summary> Gets or sets the disbursements. </summary>
        /// <value> The disbursements. </value>
        public double Disbursements { get; set; }

        /// <summary> Gets or sets the unpaid balances. </summary>
        /// <value> The unpaid balances. </value>
        public double UnpaidBalances { get; set; }

        /// <summary> Gets or sets the collections. </summary>
        /// <value> The collections. </value>
        public double Collections { get; set; }

        /// <summary> Gets or sets the cumulative receipts. </summary>
        /// <value> The cumulative receipts. </value>
        public double CumulativeReceipts { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public override Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public override DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SpecialAccount"/>
        /// class.
        /// </summary>
        public SpecialAccount( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SpecialAccount"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public SpecialAccount( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SpecialAccount"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public SpecialAccount( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SpecialAccount"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public SpecialAccount( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
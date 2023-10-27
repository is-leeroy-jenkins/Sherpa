// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="UnobligatedBalance.cs" company="Terry D. Eppler">
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
//   UnobligatedBalance.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class UnobligatedBalance
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the budget year. </summary>
        /// <value> The budget year. </value>
        public string BudgetYear { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public string Efy { get; set; }

        /// <summary> Gets or sets the budget account. </summary>
        /// <value> The budget account. </value>
        public string BudgetAccount { get; set; }

        /// <summary> Gets or sets the treasury account code. </summary>
        /// <value> The treasury account code. </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary> Gets or sets the name of the treasury account. </summary>
        /// <value> The name of the treasury account. </value>
        public string TreasuryAccountName { get; set; }

        /// <summary> Gets or sets the budget account code. </summary>
        /// <value> The budget account code. </value>
        public string BudgetAccountCode { get; set; }

        /// <summary> Gets or sets the name of the budget account. </summary>
        /// <value> The name of the budget account. </value>
        public string BudgetAccountName { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public string FundName { get; set; }

        /// <summary> Gets or sets the account number. </summary>
        /// <value> The account number. </value>
        public string AccountNumber { get; set; }

        /// <summary> Gets or sets the name of the account. </summary>
        /// <value> The name of the account. </value>
        public string AccountName { get; set; }

        /// <summary> Gets or sets the amount. </summary>
        /// <value> The amount. </value>
        public double Amount { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the Record property. </summary>
        /// <value> The data row. </value>
        public DataRow Record { get; set; }

        /// <summary> Gets the arguments. </summary>
        /// <value> The arguments. </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnobligatedBalance"/>
        /// class.
        /// </summary>
        public UnobligatedBalance( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnobligatedBalance"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public UnobligatedBalance( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnobligatedBalance"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public UnobligatedBalance( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnobligatedBalance"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public UnobligatedBalance( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
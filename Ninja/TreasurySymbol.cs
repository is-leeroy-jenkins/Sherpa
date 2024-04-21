// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="TreasurySymbol.cs" company="Terry D. Eppler">
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
//   TreasurySymbol.cs
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
    /// <seealso cref="T:BudgetExecution.Fund" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class TreasurySymbol : Fund
    {
        /// <summary>
        /// Gets or sets the short key.
        /// </summary>
        /// <value>
        /// The short key.
        /// </value>
        public string ShortKey { get; set; }

        /// <summary>
        /// Gets or sets the lapsed.
        /// </summary>
        /// <value>
        /// The lapsed.
        /// </value>
        public string Lapsed { get; set; }

        /// <summary>
        /// Gets or sets the use cancelled year spending accounts.
        /// </summary>
        /// <value>
        /// The use cancelled year spending accounts.
        /// </value>
        public string UseCancelledYearSpendingAccounts { get; set; }

        /// <summary>
        /// Gets or sets the agency treasury symbol.
        /// </summary>
        /// <value>
        /// The agency treasury symbol.
        /// </value>
        public string AgencyTreasurySymbol { get; set; }

        /// <summary>
        /// Gets or sets the in use.
        /// </summary>
        /// <value>
        /// The in use.
        /// </value>
        public string InUse { get; set; }

        /// <summary>
        /// Gets or sets the prevent new use.
        /// </summary>
        /// <value>
        /// The prevent new use.
        /// </value>
        public string PreventNewUse { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        public TreasurySymbol( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <inheritdoc />
        public TreasurySymbol( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <inheritdoc />
        public TreasurySymbol( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TreasurySymbol"/> class.
        /// </summary>
        /// <param name="dataRow">The Data.</param>
        /// <inheritdoc />
        public TreasurySymbol( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
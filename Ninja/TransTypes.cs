// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="TransType.cs" company="Terry D. Eppler">
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
//   TransType.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class TransTypes : DataUnit
    {
        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override int ID { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public string BFY { get; set; }

        /// <summary>
        /// Gets or sets the efy.
        /// </summary>
        /// <value>
        /// The efy.
        /// </value>
        public string EFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the name of the fund.
        /// </summary>
        /// <value>
        /// The name of the fund.
        /// </value>
        public string FundName { get; set; }

        /// <summary>
        /// Gets or sets the treasury account code.
        /// </summary>
        /// <value>
        /// The treasury account code.
        /// </value>
        public string TreasuryAccountCode { get; set; }

        /// <summary>
        /// Gets or sets the type of the document.
        /// </summary>
        /// <value>
        /// The type of the document.
        /// </value>
        public string DocType { get; set; }

        /// <summary>
        /// Gets or sets the appropriation bill.
        /// </summary>
        /// <value>
        /// The appropriation bill.
        /// </value>
        public string AppropriationBill { get; set; }

        /// <summary>
        /// Gets or sets the continuing resolution.
        /// </summary>
        /// <value>
        /// The continuing resolution.
        /// </value>
        public string ContinuingResolution { get; set; }

        /// <summary>
        /// Gets or sets the rescission current year.
        /// </summary>
        /// <value>
        /// The rescission current year.
        /// </value>
        public string RescissionCurrentYear { get; set; }

        /// <summary>
        /// Gets or sets the rescission prior year.
        /// </summary>
        /// <value>
        /// The rescission prior year.
        /// </value>
        public string RescissionPriorYear { get; set; }

        /// <summary>
        /// Gets or sets the sequester reduction.
        /// </summary>
        /// <value>
        /// The sequester reduction.
        /// </value>
        public string SequesterReduction { get; set; }

        /// <summary>
        /// Gets or sets the sequester return.
        /// </summary>
        /// <value>
        /// The sequester return.
        /// </value>
        public string SequesterReturn { get; set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <inheritdoc />
        public override Source Source { get; set; }

        /// <summary>
        /// </summary>
        /// <inheritdoc />
        public override DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public override IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransTypes"/> class.
        /// </summary>
        public TransTypes( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransTypes"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public TransTypes( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransTypes"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public TransTypes( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransTypes"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public TransTypes( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
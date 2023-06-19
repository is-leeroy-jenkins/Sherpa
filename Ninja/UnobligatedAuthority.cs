// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="UnobligatedAuthority.cs" company="Terry D. Eppler">
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
//   UnobligatedAuthority.cs
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
    public class UnobligatedAuthority
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the report year. </summary>
        /// <value> The report year. </value>
        public string ReportYear { get; set; }

        /// <summary> Gets or sets the agency code. </summary>
        /// <value> The agency code. </value>
        public string AgencyCode { get; set; }

        /// <summary> Gets or sets the name of the agency. </summary>
        /// <value> The name of the agency. </value>
        public string AgencyName { get; set; }

        /// <summary> Gets or sets the bureau code. </summary>
        /// <value> The bureau code. </value>
        public string BureauCode { get; set; }

        /// <summary> Gets or sets the name of the bureau. </summary>
        /// <value> The name of the bureau. </value>
        public string BureauName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        public string AccountCode { get; set; }

        /// <summary> Gets or sets the omb account. </summary>
        /// <value> The omb account. </value>
        public string OmbAccount { get; set; }

        /// <summary> Gets or sets the name of the omb account. </summary>
        /// <value> The name of the omb account. </value>
        public string OmbAccountName { get; set; }

        /// <summary> Gets or sets the name of the line. </summary>
        /// <value> The name of the line. </value>
        public string LineName { get; set; }

        /// <summary> Gets or sets the line number. </summary>
        /// <value> The line number. </value>
        public string LineNumber { get; set; }

        /// <summary> Gets or sets the budget year. </summary>
        /// <value> The budget year. </value>
        public double BudgetYear { get; set; }

        /// <summary> Gets or sets the prior year. </summary>
        /// <value> The prior year. </value>
        public double PriorYear { get; set; }

        /// <summary> Gets or sets the current year. </summary>
        /// <value> The current year. </value>
        public double CurrentYear { get; set; }

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
        /// <see cref="UnobligatedAuthority"/>
        /// class.
        /// </summary>
        public UnobligatedAuthority( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnobligatedAuthority"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public UnobligatedAuthority( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnobligatedAuthority"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public UnobligatedAuthority( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="UnobligatedAuthority"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public UnobligatedAuthority( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
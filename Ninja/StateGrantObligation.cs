// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StateGrantObligation.cs" company="Terry D. Eppler">
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
//   StateGrantObligation.cs
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
    public class StateGrantObligation
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public string RpioName { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public string FundName { get; set; }

        /// <summary> Gets or sets the ah code. </summary>
        /// <value> The ah code. </value>
        public string AhCode { get; set; }

        /// <summary> Gets or sets the name of the ah. </summary>
        /// <value> The name of the ah. </value>
        public string AhName { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        public string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        public string OrgName { get; set; }

        /// <summary> Gets or sets the state code. </summary>
        /// <value> The state code. </value>
        public string StateCode { get; set; }

        /// <summary> Gets or sets the name of the state. </summary>
        /// <value> The name of the state. </value>
        public string StateName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        public string AccountCode { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        public string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        public string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the rc code. </summary>
        /// <value> The rc code. </value>
        public string RcCode { get; set; }

        /// <summary> Gets or sets the name of the rc. </summary>
        /// <value> The name of the rc. </value>
        public string RcName { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        public string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        public string BocName { get; set; }

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
        /// <see cref="StateGrantObligation"/>
        /// class.
        /// </summary>
        public StateGrantObligation( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StateGrantObligation"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StateGrantObligation( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StateGrantObligation"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public StateGrantObligation( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StateGrantObligation"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StateGrantObligation( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
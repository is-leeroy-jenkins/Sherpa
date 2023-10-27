// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="StateOrganization.cs" company="Terry D. Eppler">
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
//   StateOrganization.cs
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
    public class StateOrganization
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public string Name { get; set; }

        /// <summary> Gets or sets the code. </summary>
        /// <value> The code. </value>
        public string Code { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        public string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public string RpioName { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public string RpioCode { get; set; }

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
        /// <see cref="StateOrganization"/>
        /// class.
        /// </summary>
        public StateOrganization( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StateOrganization"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public StateOrganization( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StateOrganization"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public StateOrganization( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="StateOrganization"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public StateOrganization( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
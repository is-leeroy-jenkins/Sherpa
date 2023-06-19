// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="SiteActivity.cs" company="Terry D. Eppler">
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
//   SiteActivity.cs
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
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class SiteActivity
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        public string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        public string Efy { get; set; }

        /// <summary> Gets or sets the rpio code. </summary>
        /// <value> The rpio code. </value>
        public string RpioCode { get; set; }

        /// <summary> Gets or sets the name of the rpio. </summary>
        /// <value> The name of the rpio. </value>
        public string RpioName { get; set; }

        /// <summary> Gets or sets the ah code. </summary>
        /// <value> The ah code. </value>
        public string AhCode { get; set; }

        /// <summary> Gets or sets the fund code. </summary>
        /// <value> The fund code. </value>
        public string FundCode { get; set; }

        /// <summary> Gets or sets the name of the fund. </summary>
        /// <value> The name of the fund. </value>
        public string FundName { get; set; }

        /// <summary> Gets or sets the account code. </summary>
        /// <value> The account code. </value>
        public string AccountCode { get; set; }

        /// <summary> Gets or sets the program project code. </summary>
        /// <value> The program project code. </value>
        public string ProgramProjectCode { get; set; }

        /// <summary> Gets or sets the name of the program project. </summary>
        /// <value> The name of the program project. </value>
        public string ProgramProjectName { get; set; }

        /// <summary> Gets or sets the boc code. </summary>
        /// <value> The boc code. </value>
        public string BocCode { get; set; }

        /// <summary> Gets or sets the name of the boc. </summary>
        /// <value> The name of the boc. </value>
        public string BocName { get; set; }

        /// <summary> Gets or sets the org code. </summary>
        /// <value> The org code. </value>
        public string OrgCode { get; set; }

        /// <summary> Gets or sets the name of the org. </summary>
        /// <value> The name of the org. </value>
        public string OrgName { get; set; }

        /// <summary> Gets or sets the foc code. </summary>
        /// <value> The foc code. </value>
        public string FocCode { get; set; }

        /// <summary> Gets or sets the name of the foc. </summary>
        /// <value> The name of the foc. </value>
        public string FocName { get; set; }

        /// <summary> Gets or sets the epa site identifier. </summary>
        /// <value> The epa site identifier. </value>
        public string EpaSiteId { get; set; }

        /// <summary> Gets or sets the site project code. </summary>
        /// <value> The site project code. </value>
        public string SiteProjectCode { get; set; }

        /// <summary> Gets or sets the ssid. </summary>
        /// <value> The ssid. </value>
        public string Ssid { get; set; }

        /// <summary> Gets or sets the action code. </summary>
        /// <value> The action code. </value>
        public string ActionCode { get; set; }

        /// <summary> Gets or sets the operable unit. </summary>
        /// <value> The operable unit. </value>
        public string OperableUnit { get; set; }

        /// <summary> Gets or sets the name of the site project. </summary>
        /// <value> The name of the site project. </value>
        public string SiteProjectName { get; set; }

        /// <summary> Gets or sets the state. </summary>
        /// <value> The state. </value>
        public string State { get; set; }

        /// <summary> Gets or sets the city. </summary>
        /// <value> The city. </value>
        public string City { get; set; }

        /// <summary> Gets or sets the congressional district. </summary>
        /// <value> The congressional district. </value>
        public string CongressionalDistrict { get; set; }

        /// <summary> Gets or sets the type of the project. </summary>
        /// <value> The type of the project. </value>
        public string ProjectType { get; set; }

        /// <summary> Gets or sets the start date. </summary>
        /// <value> The start date. </value>
        public DateOnly StartDate { get; set; }

        /// <summary> Gets or sets the last activity. </summary>
        /// <value> The last activity. </value>
        public DateOnly LastActivity { get; set; }

        /// <summary> Gets or sets the end date. </summary>
        /// <value> The end date. </value>
        public DateOnly EndDate { get; set; }

        /// <summary> Gets or sets the requested. </summary>
        /// <value> The requested. </value>
        public double Requested { get; set; }

        /// <summary> Gets or sets the accepted. </summary>
        /// <value> The accepted. </value>
        public double Accepted { get; set; }

        /// <summary> Gets or sets the closed. </summary>
        /// <value> The closed. </value>
        public double Closed { get; set; }

        /// <summary> Gets or sets the outstanding. </summary>
        /// <value> The outstanding. </value>
        public double Outstanding { get; set; }

        /// <summary> Gets or sets the refunded. </summary>
        /// <value> The refunded. </value>
        public double Refunded { get; set; }

        /// <summary> Gets or sets the reversal. </summary>
        /// <value> The reversal. </value>
        public double Reversal { get; set; }

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
        /// <see cref="SiteActivity"/>
        /// class.
        /// </summary>
        public SiteActivity( )
        {
            Source = Source.SiteActivity;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteActivity"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public SiteActivity( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteActivity"/>
        /// class.
        /// </summary>
        /// <param name="builder"> The builder. </param>
        public SiteActivity( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SiteActivity"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public SiteActivity( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
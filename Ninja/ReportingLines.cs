// ***********************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:              20-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        20-10-2023
// ***********************************************************************************************
// <copyright file="ReportingLines.cs.cs" company="Terry D. Eppler">
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Eppler, Terry.cs
// </summary>
// ***********************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ReportingLines
    {
        /// <summary> Gets or sets the identifier. </summary>
        /// <value> The identifier. </value>
        public int ID { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public string Name { get; set; }

        /// <summary> Gets or sets the number. </summary>
        /// <value> The number. </value>
        public string Number { get; set; }

        /// <summary> Gets or sets the caption. </summary>
        /// <value> The caption. </value>
        public string Caption { get; set; }

        /// <summary> Gets or sets the category. </summary>
        /// <value> The category. </value>
        public string Category { get; set; }

        /// <summary> Gets or sets the range. </summary>
        /// <value> The range. </value>
        public string Range { get; set; }

        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public Provider Provider { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        public DataRow Record { get; set; }

        /// <summary> Gets or sets the data. </summary>
        /// <value> The data. </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ReportingLines"/>
        /// class.
        /// </summary>
        public ReportingLines( )
        {
            Source = Source.ReconciliationLines;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ReportingLines"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public ReportingLines( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReportingLinesId" ].ToString( ) ?? string.Empty );
            Number = Record[ "Number" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Caption = Record[ "Caption" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Range = Record[ "Range" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ReportingLines"/>
        /// class.
        /// </summary>
        /// <param name="dataBuilder"> The data builder. </param>
        public ReportingLines( IDataModel dataBuilder )
            : this( )
        {
            Record = dataBuilder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReportingLinesId" ].ToString( ) ?? string.Empty );
            Number = Record[ "Number" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Caption = Record[ "Caption" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Range = Record[ "Range" ].ToString( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ReportingLines"/>
        /// class.
        /// </summary>
        /// <param name="dataRow"> The data row. </param>
        public ReportingLines( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "ReportingLinesId" ].ToString( ) ?? string.Empty );
            Number = Record[ "Number" ].ToString( );
            Name = Record[ "Name" ].ToString( );
            Caption = Record[ "Caption" ].ToString( );
            Category = Record[ "Category" ].ToString( );
            Range = Record[ "Range" ].ToString( );
        }
    }
}
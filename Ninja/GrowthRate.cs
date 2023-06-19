// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="GrowthRate.cs" company="Terry D. Eppler">
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
//   GrowthRate.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class GrowthRate  
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the rate identifier.
        /// </summary>
        /// <value>
        /// The rate identifier.
        /// </value>
        public int RateId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the budget year rate.
        /// </summary>
        /// <value>
        /// The budget year rate.
        /// </value>
        public double BudgetYearRate { get; set; }

        /// <summary>
        /// Gets or sets the out year1.
        /// </summary>
        /// <value>
        /// The out year1.
        /// </value>
        public double OutYear1 { get; set; }

        /// <summary>
        /// Gets or sets the out year2.
        /// </summary>
        /// <value>
        /// The out year2.
        /// </value>
        public double OutYear2 { get; set; }

        /// <summary>
        /// Gets or sets the out year3.
        /// </summary>
        /// <value>
        /// The out year3.
        /// </value>
        public double OutYear3 { get; set; }

        /// <summary>
        /// Gets or sets the out year4.
        /// </summary>
        /// <value>
        /// The out year4.
        /// </value>
        public double OutYear4 { get; set; }

        /// <summary>
        /// Gets or sets the out year5.
        /// </summary>
        /// <value>
        /// The out year5.
        /// </value>
        public double OutYear5 { get; set; }

        /// <summary>
        /// Gets or sets the out year6.
        /// </summary>
        /// <value>
        /// The out year6.
        /// </value>
        public double OutYear6 { get; set; }

        /// <summary>
        /// Gets or sets the out year7.
        /// </summary>
        /// <value>
        /// The out year7.
        /// </value>
        public double OutYear7 { get; set; }

        /// <summary>
        /// Gets or sets the out year8.
        /// </summary>
        /// <value>
        /// The out year8.
        /// </value>
        public double OutYear8 { get; set; }

        /// <summary>
        /// Gets or sets the out year9.
        /// </summary>
        /// <value>
        /// The out year9.
        /// </value>
        public double OutYear9 { get; set; }

        /// <summary>
        /// Gets or sets the sort.
        /// </summary>
        /// <value>
        /// The sort.
        /// </value>
        public string Sort { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrowthRate"/> class.
        /// </summary>
        public GrowthRate( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrowthRate"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public GrowthRate( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "GrowthRatesId" ].ToString( ) ?? "0" );
            RateId = int.Parse( Record[ "RatesId" ].ToString( ) ?? "0" );
            Description = Record[ "Description" ].ToString( );
            BudgetYearRate = Double.Parse( Record[ "BudgetYearRate" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( Record[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( Record[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( Record[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( Record[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( Record[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( Record[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( Record[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( Record[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( Record[ "OutYear9" ].ToString( ) ?? "0" );
            Sort = Record[ "Sort" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrowthRate"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public GrowthRate( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
            ID = int.Parse( Record[ "GrowthRatesId" ].ToString( ) ?? "0" );
            RateId = int.Parse( Record[ "RatesId" ].ToString( ) ?? "0" );
            Description = Record[ "Description" ].ToString( );
            BudgetYearRate = Double.Parse( Record[ "BudgetYearRate" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( Record[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( Record[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( Record[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( Record[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( Record[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( Record[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( Record[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( Record[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( Record[ "OutYear9" ].ToString( ) ?? "0" );
            Sort = Record[ "Sort" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrowthRate"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public GrowthRate( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
            ID = int.Parse( Record[ "GrowthRatesId" ].ToString( ) ?? "0" );
            RateId = int.Parse( Record[ "RatesId" ].ToString( ) ?? "0" );
            Description = Record[ "Description" ].ToString( );
            BudgetYearRate = Double.Parse( Record[ "BudgetYearRate" ].ToString( ) ?? "0" );
            OutYear1 = double.Parse( Record[ "OutYear1" ].ToString( ) ?? "0" );
            OutYear2 = double.Parse( Record[ "OutYear2" ].ToString( ) ?? "0" );
            OutYear3 = double.Parse( Record[ "OutYear3" ].ToString( ) ?? "0" );
            OutYear4 = double.Parse( Record[ "OutYear4" ].ToString( ) ?? "0" );
            OutYear5 = double.Parse( Record[ "OutYear5" ].ToString( ) ?? "0" );
            OutYear6 = double.Parse( Record[ "OutYear6" ].ToString( ) ?? "0" );
            OutYear7 = double.Parse( Record[ "OutYear7" ].ToString( ) ?? "0" );
            OutYear8 = double.Parse( Record[ "OutYear8" ].ToString( ) ?? "0" );
            OutYear9 = double.Parse( Record[ "OutYear9" ].ToString( ) ?? "0" );
            Sort = Record[ "Sort" ].ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrowthRate"/> class.
        /// </summary>
        /// <param name="rate">The rate.</param>
        public GrowthRate( GrowthRate rate )
        {
            ID = rate.ID;
            RateId = rate.RateId;
            Description = rate.Description;
            BudgetYearRate = rate.BudgetYearRate;
            OutYear1 = rate.OutYear1;
            OutYear2 = rate.OutYear2;
            OutYear3 = rate.OutYear3;
            OutYear4 = rate.OutYear4;
            OutYear5 = rate.OutYear5;
            OutYear6 = rate.OutYear6;
            OutYear7 = rate.OutYear7;
            OutYear8 = rate.OutYear8;
            OutYear9 = rate.OutYear9;
        }
    }
}
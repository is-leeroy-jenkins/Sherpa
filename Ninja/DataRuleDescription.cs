// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataRuleDescription.cs" company="Terry D. Eppler">
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
//   DataRuleDescription.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class DataRuleDescription : DataUnit
    {
        /// <summary>
        /// Gets or sets the schedule.
        /// </summary>
        /// <value>
        /// The schedule.
        /// </value>
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or sets the line number.
        /// </summary>
        /// <value>
        /// The line number.
        /// </value>
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the rule number.
        /// </summary>
        /// <value>
        /// The rule number.
        /// </value>
        public string RuleNumber { get; set; }

        /// <summary>
        /// Gets or sets the rule description.
        /// </summary>
        /// <value>
        /// The rule description.
        /// </value>
        public string RuleDescription { get; set; }

        /// <summary>
        /// Gets or sets the schedule order.
        /// </summary>
        /// <value>
        /// The schedule order.
        /// </value>
        public string ScheduleOrder { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataRuleDescription" />
        /// class.
        /// </summary>
        public DataRuleDescription( )
        {
            Source = Source.DataRuleDescriptions;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataRuleDescription" />
        /// class.
        /// </summary>
        /// <param name="query">The query.</param>
        public DataRuleDescription( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query ).Record;
            Map = Record.ToDictionary( );
            Schedule = Record[ "Schedule" ]?.ToString( );
            LineNumber = Record[ "LineNumber" ]?.ToString( );
            RuleNumber = Record[ "RuleNumber" ]?.ToString( );
            ScheduleOrder = Record[ "ScheduleOrder" ]?.ToString( );
            RuleDescription = Record[ "RuleDescription" ]?.ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataRuleDescription" />
        /// class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public DataRuleDescription( IDataModel builder )
            : this( )
        {
            Record = builder.Record;
            Map = Record.ToDictionary( );
            Schedule = Record[ "Schedule" ]?.ToString( );
            LineNumber = Record[ "LineNumber" ]?.ToString( );
            RuleNumber = Record[ "RuleNumber" ]?.ToString( );
            ScheduleOrder = Record[ "ScheduleOrder" ]?.ToString( );
            RuleDescription = Record[ "RuleDescription" ]?.ToString( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataRuleDescription" />
        /// class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public DataRuleDescription( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            Map = dataRow.ToDictionary( );
            Schedule = dataRow[ "Schedule" ]?.ToString( );
            LineNumber = dataRow[ "LineNumber" ]?.ToString( );
            RuleNumber = dataRow[ "RuleNumber" ]?.ToString( );
            ScheduleOrder = dataRow[ "ScheduleOrder" ]?.ToString( );
            RuleDescription = dataRow[ "RuleDescription" ]?.ToString( );
        }
    }
}
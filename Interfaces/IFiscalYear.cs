// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IFiscalYear.cs" company="Terry D. Eppler">
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
//   IFiscalYear.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;

    /// <summary> </summary>
    public interface IFiscalYear
    {
        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the fiscal year identifier. </summary>
        /// <value> The fiscal year identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the first year. </summary>
        /// <value> The first year. </value>
        string FirstYear { get; set; }

        /// <summary> Gets or sets the last year. </summary>
        /// <value> The last year. </value>
        string LastYear { get; set; }

        /// <summary> Gets or sets the expiring year. </summary>
        /// <value> The expiring year. </value>
        string ExpiringYear { get; set; }

        /// <summary> Gets or sets the input year. </summary>
        /// <value> The input year. </value>
        string InputYear { get; set; }

        /// <summary> Gets or sets the start date. </summary>
        /// <value> The start date. </value>
        DateOnly StartDate { get; set; }

        /// <summary> Gets or sets the end date. </summary>
        /// <value> The end date. </value>
        DateOnly EndDate { get; set; }

        /// <summary> Gets or sets the cancellation date. </summary>
        /// <value> The cancellation date. </value>
        DateOnly CancellationDate { get; set; }

        /// <summary> Gets or sets the record. </summary>
        /// <value> The record. </value>
        DataRow Record { get; set; }

        /// <summary> Determines whether this instance is current. </summary>
        /// <returns>
        /// <c> true </c>
        /// if this instance is current; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsCurrent( );

        /// <summary> Determines whether this instance is carryover. </summary>
        /// <returns>
        /// <c> true </c>
        /// if this instance is carryover; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsCarryover( );
    }
}
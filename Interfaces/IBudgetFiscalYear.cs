// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IBudgetFiscalYear.cs" company="Terry D. Eppler">
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
//   IBudgetFiscalYear.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    public interface IBudgetFiscalYear
    {
        /// <summary> Gets or sets the fiscal year identifier. </summary>
        /// <value> The fiscal year identifier. </value>
        int ID { get; set; }

        /// <summary> Gets or sets the bfy. </summary>
        /// <value> The bfy. </value>
        string BFY { get; set; }

        /// <summary> Gets or sets the efy. </summary>
        /// <value> The efy. </value>
        string Efy { get; set; }

        /// <summary> Gets or sets the start date. </summary>
        /// <value> The start date. </value>
        DateOnly StartDate { get; set; }

        /// <summary> Gets or sets the end date. </summary>
        /// <value> The end date. </value>
        DateOnly EndDate { get; set; }

        /// <summary> Gets or sets the columbus. </summary>
        /// <value> The columbus. </value>
        DateOnly ColumbusDay { get; set; }

        /// <summary> Gets or sets the christmas. </summary>
        /// <value> The christmas. </value>
        DateOnly ChristmasDay { get; set; }

        /// <summary> Gets or sets the thanksgiving. </summary>
        /// <value> The thanksgiving. </value>
        DateOnly ThanksgivingDay { get; set; }

        /// <summary> Gets or sets the veterans. </summary>
        /// <value> The veterans. </value>
        DateOnly VeteransDay { get; set; }

        /// <summary> Gets or sets the labor. </summary>
        /// <value> The labor. </value>
        DateOnly LaborDay { get; set; }

        /// <summary> Gets or sets the independence. </summary>
        /// <value> The independence. </value>
        DateOnly IndependenceDay { get; set; }

        /// <summary> Gets or sets the juneteenth. </summary>
        /// <value> The juneteenth. </value>
        DateOnly JuneteenthDay { get; set; }

        /// <summary> Gets or sets the memorial. </summary>
        /// <value> The memorial. </value>
        DateOnly MemorialDay { get; set; }

        /// <summary> Gets or sets the washingtons. </summary>
        /// <value> The washingtons. </value>
        DateOnly PresidentsDay { get; set; }

        /// <summary> Gets or sets the martin luther king. </summary>
        /// <value> The martin luther king. </value>
        DateOnly MartinLutherKingDay { get; set; }

        /// <summary> Creates new years. </summary>
        /// <value> The new years. </value>
        DateOnly NewYearsDay { get; set; }

        /// <summary> Gets or sets the expiring year. </summary>
        /// <value> The expiring year. </value>
        string ExpiringYear { get; set; }

        /// <summary> Gets or sets the expiration date. </summary>
        /// <value> The expiration date. </value>
        DateOnly ExpirationDate { get; set; }

        /// <summary> Gets or sets the cancellation date. </summary>
        /// <value> The cancellation date. </value>
        DateOnly CancellationDate { get; set; }

        /// <summary> Gets or sets the work days. </summary>
        /// <value> The work days. </value>
        double WorkDays { get; set; }

        /// <summary> Gets or sets the week days. </summary>
        /// <value> The week days. </value>
        double WeekDays { get; set; }

        /// <summary> Gets or sets the week ends. </summary>
        /// <value> The week ends. </value>
        double WeekEnds { get; set; }

        /// <summary> Gets the current date. </summary>
        /// <value> The current date. </value>
        DateTime CurrentDate { get; set; }

        /// <summary> Gets the current month. </summary>
        /// <value> The current month. </value>
        int CurrentMonth { get; set; }

        /// <summary> Gets the current day. </summary>
        /// <value> The current day. </value>
        int CurrentDay { get; set; }

        /// <summary> Gets the current year. </summary>
        /// <value> The current year. </value>
        int CurrentYear { get; set; }

        /// <summary> Gets or sets the bbfy. </summary>
        /// <value> The bbfy. </value>
        string FirstYear { get; set; }

        /// <summary> Gets or sets the ebfy. </summary>
        /// <value> The ebfy. </value>
        string LastYear { get; set; }

        /// <summary> Gets or sets the input year. </summary>
        /// <value> The input year. </value>
        string InputYear { get; set; }

        /// <summary> Gets the federal holidays. </summary>
        /// <returns> </returns>
        IDictionary<NationalHoliday, DateOnly> GetFederalHolidays( );

        /// <summary> Determines whether this instance is current. </summary>
        /// <returns>
        /// <c> true </c>
        /// if this instance is current; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        bool IsCurrent( );
    }
}
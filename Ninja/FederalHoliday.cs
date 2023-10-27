// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="FederalHoliday.cs" company="Terry D. Eppler">
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
//   FederalHoliday.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class FederalHoliday
    {
        /// <summary> Columbus Day, the second Monday in October. </summary>
        /// <value> Columbus Day, the second Monday in October. </value>
        public virtual DateOnly ColumbusDay { get; set; }

        /// <summary> Veterans Day, November 11. </summary>
        /// <value> Veterans Day, November 11. </value>
        public virtual DateOnly VeteransDay { get; set; }

        /// <summary> Thanksgiving Day, the fourth Thursday in November. </summary>
        /// <value> Thanksgiving Day, the fourth Thursday in November. </value>
        public virtual DateOnly ThanksgivingDay { get; set; }

        /// <summary> Christmas Day, December 25. </summary>
        /// <value> Christmas Day, December 25. </value>
        public virtual DateOnly ChristmasDay { get; set; }

        /// <summary> New Year’s Day, January 1. </summary>
        /// <value> New Year’s Day, January 1. </value>
        public virtual DateOnly NewYearsDay { get; set; }

        /// <summary>
        /// Birthday of Martin Luther King, Jr., the third Monday in January.
        /// </summary>
        /// <value>
        /// Birthday of Martin Luther King, Jr., the third Monday in January.
        /// </value>
        public virtual DateOnly MartinLutherKingDay { get; set; }

        /// <summary> Washington’s Birthday, the third Monday in February. </summary>
        /// <value> Washington’s Birthday, the third Monday in February. </value>
        public virtual DateOnly PresidentsDay { get; set; }

        /// <summary> Memorial Day, the last Monday in May. </summary>
        /// <value> Memorial Day, the last Monday in May. </value>
        public virtual DateOnly MemorialDay { get; set; }

        /// <summary> Juneteenth National Independence Day, June 19. </summary>
        /// <value> Juneteenth National Independence Day, June 19. </value>
        public virtual DateOnly JuneteenthDay { get; set; }

        /// <summary> Independence Day, July 4. </summary>
        /// <value> Independence Day, July 4. </value>
        public virtual DateOnly IndependenceDay { get; set; }

        /// <summary> Labor Day, the first Monday in September. </summary>
        /// <value> Labor Day, the first Monday in September. </value>
        public virtual DateOnly LaborDay { get; set; }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
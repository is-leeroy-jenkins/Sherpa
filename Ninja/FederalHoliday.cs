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

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public abstract class FederalHoliday
    {
        /// <summary>
        /// Gets or sets the columbus day.
        /// </summary>
        /// <value>
        /// The columbus day.
        /// </value>
        public virtual DateOnly ColumbusDay { get; set; }

        /// <summary>
        /// Gets or sets the veterans day.
        /// </summary>
        /// <value>
        /// The veterans day.
        /// </value>
        public virtual DateOnly VeteransDay { get; set; }

        /// <summary>
        /// Gets or sets the thanksgiving day.
        /// </summary>
        /// <value>
        /// The thanksgiving day.
        /// </value>
        public virtual DateOnly ThanksgivingDay { get; set; }

        /// <summary>
        /// Gets or sets the christmas day.
        /// </summary>
        /// <value>
        /// The christmas day.
        /// </value>
        public virtual DateOnly ChristmasDay { get; set; }

        /// <summary>
        /// Creates new yearsday.
        /// </summary>
        /// <value>
        /// The new years day.
        /// </value>
        public virtual DateOnly NewYearsDay { get; set; }

        /// <summary>
        /// Gets or sets the martin luther king day.
        /// </summary>
        /// <value>
        /// The martin luther king day.
        /// </value>
        public virtual DateOnly MartinLutherKingDay { get; set; }

        /// <summary>
        /// Gets or sets the presidents day.
        /// </summary>
        /// <value>
        /// The presidents day.
        /// </value>
        public virtual DateOnly PresidentsDay { get; set; }

        /// <summary>
        /// Gets or sets the memorial day.
        /// </summary>
        /// <value>
        /// The memorial day.
        /// </value>
        public virtual DateOnly MemorialDay { get; set; }

        /// <summary>
        /// Gets or sets the juneteenth day.
        /// </summary>
        /// <value>
        /// The juneteenth day.
        /// </value>
        public virtual DateOnly JuneteenthDay { get; set; }

        /// <summary>
        /// Gets or sets the independence day.
        /// </summary>
        /// <value>
        /// The independence day.
        /// </value>
        public virtual DateOnly IndependenceDay { get; set; }

        /// <summary>
        /// Gets or sets the labor day.
        /// </summary>
        /// <value>
        /// The labor day.
        /// </value>
        public virtual DateOnly LaborDay { get; set; }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
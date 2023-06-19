// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Heading.cs" company="Terry D. Eppler">
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
//   Heading.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.Grid" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Heading : Grid
    {
        /// <summary>
        /// Gets or sets the span.
        /// </summary>
        /// <value>
        /// The span.
        /// </value>
        public int Span { get; set; }

        /// <summary>
        /// Gets or sets the anchor.
        /// </summary>
        /// <value>
        /// The anchor.
        /// </value>
        public (int Row, int Column) Anchor { get; set; }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>
        /// The caption.
        /// </value>
        public IDictionary<int, string> Caption { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        public Heading( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public Heading( IGrid grid )
        {
            Worksheet = grid.Worksheet;
            Range = grid.Range;
            Address = grid.Address;
            From = ( Range.Start.Row, Range.Start.Column );
            To = ( Range.Start.Row, Range.End.Column );
            Anchor = ( From.Row, From.Column );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="caption">The caption.</param>
        public Heading( IGrid grid, IDictionary<int, string> caption )
            : this( grid )
        {
            Caption = caption;
            Span = Range.Columns;
        }
    }
}
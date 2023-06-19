// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Section.cs" company="Terry D. Eppler">
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
//   Section.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.Grid" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Section : Grid
    {
        /// <summary>
        /// Gets or sets the anchor.
        /// </summary>
        /// <value>
        /// The anchor.
        /// </value>
        public (int Row, int Column) Anchor { get; set; }

        /// <summary>
        /// Gets or sets the span.
        /// </summary>
        /// <value>
        /// The span.
        /// </value>
        public int Span { get; set; }

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        /// <value>
        /// The depth.
        /// </value>
        public int Depth { get; set; }

        /// <summary>
        /// Gets or sets the area.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public (int Depth, int Span) Area { get; set; }

        /// <summary>
        /// Gets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        private IGrid Grid { get;  }

        /// <summary>
        /// Initializes a new instance of the <see cref="Section"/> class.
        /// </summary>
        public Section( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Section"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public Section( IGrid grid )

        {
            Grid = grid;
            Worksheet = Grid.Worksheet;
            Range = Grid.Range;
            Address = Grid.Address;
            From = ( Range.Start.Row, Range.Start.Column );
            To = ( Range.End.Row, Range.End.Column );
            Span = Range.Columns;
            Depth = Range.Rows;
            Area = ( Depth, Span );
        }

        /// <summary>
        /// Gets the anchor.
        /// </summary>
        /// <returns></returns>
        public (int Row, int Column) GetAnchor( )
        {
            try
            {
                return default( (int Row, int Column) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return ( 0, 0 );
            }
        }

        /// <summary>
        /// Gets the span.
        /// </summary>
        /// <returns></returns>
        public int GetSpan( )
        {
            try
            {
                return default( int );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the depth.
        /// </summary>
        /// <returns></returns>
        public int GetDepth( )
        {
            try
            {
                return default( int );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <returns></returns>
        public (int Depth, int Span) GetArea( )
        {
            try
            {
                return default( (int Depth, int Span) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return ( 0, 0 );
            }
        }
    }
}
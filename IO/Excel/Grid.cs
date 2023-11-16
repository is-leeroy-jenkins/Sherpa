// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Grid.cs" company="Terry D. Eppler">
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
//   Grid.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using OfficeOpenXml;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:OfficeOpenXml.ExcelCellBase"/>
    /// <seealso cref="T:BudgetExecution.IGrid"/>
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Grid : ExcelCellBase, IGrid
    {
        /// <inheritdoc/>
        /// <summary>
        /// The range
        /// </summary>
        public ExcelRange Range { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// The workSheet
        /// </summary>
        public ExcelWorksheet Worksheet { get; set; }

        /// <summary>
        /// The address
        /// </summary>
        public ExcelAddress Address { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets from. </summary>
        /// <value> From. </value>
        public ( int Row, int Column ) From { get; set; }

        /// <inheritdoc/>
        /// <summary> Gets or sets to. </summary>
        /// <value> To. </value>
        public ( int Row, int Column ) To { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        public Grid( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="range"> The range. </param>
        public Grid( ExcelWorksheet workSheet, ExcelRange range )
        {
            Worksheet = workSheet;
            Range = range;
            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row,
                Range.End.Row );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="address"> The address. </param>
        public Grid( ExcelWorksheet workSheet, ExcelAddress address )
        {
            Worksheet = workSheet;
            Address = address;
            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
            Range = Worksheet.Cells[ From.Row, From.Column, To.Row, To.Column ];
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="fromRow"> From row. </param>
        /// <param name="fromColumn"> From column. </param>
        /// <param name="toRow"> To row. </param>
        /// <param name="toColumn"> To column. </param>
        public Grid( ExcelWorksheet workSheet, int fromRow = 1, int fromColumn = 1, int toRow = 55,
            int toColumn = 12 )
        {
            Worksheet = workSheet;
            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
            Range = Worksheet.Cells[ fromRow, fromColumn, toRow, toColumn ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row,
                Range.End.Row );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="cell"> The cell. </param>
        public Grid( ExcelWorksheet workSheet, IList<int> cell )
        {
            Worksheet = workSheet;
            Range = Worksheet.Cells[ cell[ 0 ], cell[ 1 ], cell[ 2 ], cell[ 3 ] ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row,
                Range.End.Column );

            From = ( Address.Start.Row, Address.Start.Column );
            To = ( Address.End.Row, Address.End.Column );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="from"> From. </param>
        /// <param name="to"> To. </param>
        public Grid( ExcelWorksheet workSheet, (int Row, int Column) from,
            (int Row, int Column) to )
        {
            Worksheet = workSheet;
            Range = Worksheet.Cells[ from.Row, from.Column, to.Row, to.Column ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.End.Row,
                Range.End.Row );

            From = from;
            To = to;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/>
        /// class.
        /// </summary>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="from"> From. </param>
        public Grid( ExcelWorksheet workSheet, (int Row, int Column) from )
        {
            ThrowIf.Null( workSheet, nameof( workSheet ) );
            Worksheet = workSheet;
            Range = Worksheet.Cells[ from.Row, from.Column ];
            Address = new ExcelAddress( Range.Start.Row, Range.Start.Column, Range.Start.Row,
                Range.Start.Column );

            From = from;
            To = From;
        }

        /// <inheritdoc/>
        /// <summary> Counts the cells. </summary>
        /// <param name="range"> The range. </param>
        /// <returns> </returns>
        public int CountCells( ExcelRange range )
        {
            try
            {
                ThrowIf.Null( range, nameof( range ) );
                return range?.Rows * range?.Columns ?? default( int );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
            }
        }

        /// <inheritdoc/>
        /// <summary> Gets the row count. </summary>
        /// <returns> </returns>
        public int GetRowCount( )
        {
            try
            {
                return Range.Rows > 0
                    ? Range.Rows
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( int );
            }
        }

        /// <inheritdoc/>
        /// <summary> Gets the column count. </summary>
        /// <returns> </returns>
        public int GetColumnCount( )
        {
            try
            {
                return Range.Columns > 0
                    ? Range.Columns
                    : 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( int );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
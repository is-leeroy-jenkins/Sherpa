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
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using OfficeOpenXml;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.Grid" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    public class Section : Grid
    {
        /// <summary>
        /// The span
        /// </summary>
        private int _span;

        /// <summary>
        /// The depth
        /// </summary>
        private int _depth;

        /// <summary>
        /// The area
        /// </summary>
        private int _area;

        /// <summary>
        /// The anchor
        /// </summary>
        private (int Row, int Column) _anchor;

        /// <summary>
        /// The values
        /// </summary>
        private IList<object> _values;

        /// <summary>
        /// Gets the span.
        /// </summary>
        /// <value>
        /// The span.
        /// </value>
        public int Span
        {
            get
            {
                return _span;
            }
            private protected set
            {
                _span = value;
            }
        }

        /// <summary>
        /// Gets the depth.
        /// </summary>
        /// <value>
        /// The depth.
        /// </value>
        public int Depth
        {
            get
            {
                return _depth;
            }
            private protected set
            {
                _depth = value;
            }
        }

        /// <summary>
        /// Gets the anchor.
        /// </summary>
        /// <value>
        /// The anchor.
        /// </value>
        public (int Row, int Column) Anchor
        {
            get
            {
                return _anchor;
            }
            private protected set
            {
                _anchor = value;
            }
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <value>
        /// The area.
        /// </value>
        public int Area
        {
            get
            {
                return _area;
            }
            private protected set
            {
                _area = value;
            }
        }

        /// <summary>
        /// Gets the cells.
        /// </summary>
        /// <value>
        /// The cells.
        /// </value>
        public IList<ExcelRangeBase> Cells
        {
            get
            {
                return _cells;
            }
            private protected set
            {
                _cells = value;
            }
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        public IList<object> Values
        {
            get
            {
                return _values;
            }
            private protected set
            {
                _values = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Section" /> class.
        /// </summary>
        public Section( )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Section" /> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="range">The range.</param>
        public Section( ExcelPackage excel, ExcelRange range ) 
            : base( excel, range )
        {
            _anchor = ( range.Start.Row, range.Start.Column );
            _span = Range.Columns;
            _depth = Range.Rows;
            _area = Range.Rows * Range.Columns;
            _cells = GetCells( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Section" /> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="fromRow">From row.</param>
        /// <param name="fromColumn">From column.</param>
        /// <param name="toRow">To row.</param>
        /// <param name="toColumn">To column.</param>
        public Section( ExcelPackage excel, int fromRow = 1, int fromColumn = 1,
            int toRow = 55, int toColumn = 12 ) 
            : base( excel, fromRow, fromColumn, toRow, toColumn )
        {
            _anchor = ( fromRow, fromColumn );
            _span = Range.Columns;
            _depth = Range.Rows;
            _area = Range.Rows * Range.Columns;
            _cells = GetCells( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Section" /> class.
        /// </summary>
        /// <param name="excel">The worksheet.</param>
        /// <param name="cell">The cell.</param>
        public Section( ExcelPackage excel, IList<int> cell ) 
            : base( excel, cell )
        {
            _anchor = ( cell[ 0 ], cell[ 1 ] );
            _span = Range.Columns;
            _depth = Range.Rows;
            _area = Range.Rows * Range.Columns;
            _cells = GetCells( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Section" /> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public Section( ExcelPackage excel, (int Row, int Column) from,
            (int Row, int Column) to )
            : base( excel, from, to )
        {
            _anchor = ( from.Row, from.Column );
            _span = Range.Columns;
            _depth = Range.Rows;
            _area = Range.Rows * Range.Columns;
            _cells = GetCells( );
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="row">The row.</param>
        public void SetValues( DataRow row )
        {
            try
            {
                ThrowIf.Null( row, nameof( row ) );
                if( _cells.Count == row.ItemArray.Length )
                {
                    SetValues( row.ItemArray );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public void SetValues( IDictionary<string, object> dict )
        {
            try
            {
                ThrowIf.NoItems( dict, nameof( dict ) );
                var _items = dict.Values.ToArray( );
                if( _cells.Count == _items.Length )
                {
                    SetValues( _items );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetValues( IEnumerable<string> data )
        {
            try
            {
                ThrowIf.NoData( data, nameof( data ) );
                var _items = data.ToArray( );
                if( _cells.Count == _items?.Length )
                {
                    SetValues( _items );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}
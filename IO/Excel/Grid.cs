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
    using System.Linq;
    using OfficeOpenXml;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:OfficeOpenXml.ExcelCellBase" />
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ConvertSwitchStatementToSwitchExpression" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    public class Grid : ExcelCellBase
    {
        /// <summary>
        /// From
        /// </summary>
        private ( int Row, int Column ) _from;

        /// <summary>
        /// The range
        /// </summary>
        private ExcelRange _range;

        /// <summary>
        /// To
        /// </summary>
        private protected ( int Row, int Column ) _to;

        /// <summary>
        /// The worksheet
        /// </summary>
        private ExcelWorksheet _worksheet;

        /// <summary>
        /// The cells
        /// </summary>
        private protected IList<ExcelRangeBase> _cells;

        /// <summary>
        /// Gets the range.
        /// </summary>
        /// <value>
        /// The range.
        /// </value>
        public ExcelRange Range
        {
            get
            {
                return _range;
            }
            private protected set
            {
                _range = value;
            }
        }

        /// <summary>
        /// Gets the worksheet.
        /// </summary>
        /// <value>
        /// The worksheet.
        /// </value>
        public ExcelWorksheet Worksheet
        {
            get
            {
                return _worksheet;
            }
            private protected set
            {
                _worksheet = value;
            }
        }

        /// <summary>
        /// Gets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public (int Row, int Column) From
        {
            get
            {
                return _from;
            }
            private protected set
            {
                _from = value;
            }
        }

        /// <summary>
        /// Gets to.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public (int Row, int Column) To
        {
            get
            {
                return _to;
            }
            private protected set
            {
                _to = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/> class.
        /// </summary>
        public Grid( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="range">The range.</param>
        public Grid( ExcelPackage excel, ExcelRange range )
        {
            _worksheet = excel.Workbook?.Worksheets[ 0 ];
            _range = range;
            _from = ( range.Start.Row, range.Start.Column );
            _to = ( range.End.Row, range.End.Column );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Grid"/> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="address">The address.</param>
        public Grid( ExcelPackage excel, ExcelAddress address )
        {
            _worksheet = excel.Workbook?.Worksheets[ 0 ];
            _from = ( address.Start.Row, address.Start.Column );
            _to = ( address.End.Row, address.End.Column );
            _range = _worksheet?.Cells[ _from.Row, _from.Column, _to.Row, _to.Column ];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="startRow">From row.</param>
        /// <param name="startColumn">From column.</param>
        /// <param name="endRow">To row.</param>
        /// <param name="endColumn">To column.</param>
        public Grid( ExcelPackage excel, int startRow = 1, int startColumn = 1, int endRow = 55,
            int endColumn = 12 )
        {
            _worksheet = excel.Workbook?.Worksheets[ 0 ];
            _from = ( startRow, startColumn );
            _to = ( endRow, endColumn );
            _range = _worksheet?.Cells[ startRow, startColumn, endRow, endColumn ];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="cell">The cell.</param>
        public Grid( ExcelPackage excel, IList<int> cell )
        {
            _worksheet = excel.Workbook?.Worksheets[ 0 ];
            _from = ( cell[ 0 ], cell[ 1 ] );
            _to = ( cell[ 2 ], cell[ 3 ] );
            _range = _worksheet?.Cells[ cell[ 0 ], cell[ 1 ], cell[ 2 ], cell[ 3 ] ];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        public Grid( ExcelPackage excel, (int Row, int Column) from, ( int Row, int Column ) to )
        {
            _worksheet = excel.Workbook?.Worksheets[ 0 ];
            _range = _worksheet?.Cells[ from.Row, from.Column, to.Row, to.Column ];
            _from = from;
            _to = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class.
        /// </summary>
        /// <param name="excel">The excel.</param>
        /// <param name="from">From.</param>
        public Grid( ExcelPackage excel, ( int Row, int Column ) from )
        {
            _worksheet = excel.Workbook?.Worksheets[ 0 ];
            _range = _worksheet?.Cells[ from.Row, from.Column ];
            _from = from;
            _to = from;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public Grid( Grid grid )
        {
            _worksheet = grid.Worksheet;
            _range = grid.Range;
            _from = grid.From;
            _to = grid.To;
        }

        /// <summary>
        /// Gets the cells.
        /// </summary>
        /// <returns></returns>
        private protected IList<ExcelRangeBase> GetCells( )
        {
            try
            {
                var _list = new List<ExcelRangeBase>( );
                foreach( var _cell in Range )
                {
                    _list.Add( _cell.Current );
                }

                return _list?.Any( ) == true
                    ? _list
                    : default( IList<ExcelRangeBase> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<ExcelRangeBase> );
            }
        }

        /// <summary>
        /// Sets the values.
        /// </summary>
        /// <param name="values">The values.</param>
        private protected void SetValues( IList<object> values )
        {
            try
            {
                ThrowIf.Null( values, nameof( values ) );
                var _vals = values.ToArray( );
                var _data = _cells.ToArray( );
                if( _data.Length == _vals.Length )
                {
                    for( var _c = 0; _c < _data.Length; _c++ )
                    {
                        if( _vals[ _c ] != null )
                        {
                            switch( _vals[ _c ] )
                            {
                                case string _text:
                                {
                                    _data[ _c ].Value = _text;
                                    break;
                                }
                                case int _index:
                                {
                                    _data[ _c ].Value = _index;
                                    break;
                                }
                                case double _num:
                                {
                                    _data[ _c ].Value = _num;
                                    break;
                                }
                                case decimal _money:
                                {
                                    _data[ _c ].Value = _money;
                                    break;
                                }
                                case DateTime _dateTime:
                                {
                                    _data[ _c ].Value = _dateTime;
                                    break;
                                }
                                case DateOnly _dateOnly:
                                {
                                    _data[ _c ].Value = _dateOnly;
                                    break;
                                }
                                default:
                                {
                                    _data[ _c ].Value = _vals[ _c ];
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
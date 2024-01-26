// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-20-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-20-2024
// ******************************************************************************************
// <copyright file="BasicReport.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   BasicReport.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Spreadsheet;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantCheckBeforeAssignment" ) ]
    public abstract class BasicReport
    {
        /// <summary>
        /// The primary back color
        /// </summary>
        private protected Color _primaryBackColor;

        /// <summary>
        /// The secondary back color
        /// </summary>
        private protected Color _secondaryBackColor;

        /// <summary>
        /// The row height
        /// </summary>
        private protected double _rowHeight;

        /// <summary>
        /// The column width
        /// </summary>
        private protected double _columnWidth;

        /// <summary>
        /// The zoom level
        /// </summary>
        private protected int _zoomLevel;

        /// <summary>
        /// The font color
        /// </summary>
        private protected Color _fontColor;

        /// <summary>
        /// The font
        /// </summary>
        private protected Font _font;

        /// <summary>
        /// The title font
        /// </summary>
        private protected Font _titleFont;

        /// <summary>
        /// The left margin
        /// </summary>
        private protected decimal _leftMargin;

        /// <summary>
        /// The right margin
        /// </summary>
        private protected decimal _rightMargin;

        /// <summary>
        /// The header margin
        /// </summary>
        private protected decimal _headerMargin;

        /// <summary>
        /// The top margin
        /// </summary>
        private protected decimal _topMargin;

        /// <summary>
        /// The footer margin
        /// </summary>
        private protected decimal _footerMargin;

        /// <summary>
        /// The bottom margin
        /// </summary>
        private protected decimal _bottomMargin;

        /// <summary>
        /// The data connection
        /// </summary>
        private protected OleDbConnection _dataConnection;

        /// <summary>
        /// The data command
        /// </summary>
        private protected OleDbCommand _dataCommand;

        /// <summary>
        /// The data adapter
        /// </summary>
        private protected OleDbDataAdapter _dataAdapter;

        /// <summary>
        /// The file information
        /// </summary>
        private protected FileInfo _fileInfo;

        /// <summary>
        /// The header range
        /// </summary>
        private protected ExcelRange _headerRange;

        /// <summary>
        /// The footer range
        /// </summary>
        private protected ExcelRange _footerRange;

        /// <summary>
        /// The excel range
        /// </summary>
        private protected ExcelRange _excelRange;

        /// <summary>
        /// The application
        /// </summary>
        private protected ExcelPackage _excelPackage;

        /// <summary>
        /// The workbook
        /// </summary>
        private protected ExcelWorkbook _excelWorkbook;

        /// <summary>
        /// The worksheet
        /// </summary>
        private protected ExcelWorksheet _excelWorksheet;

        /// <summary>
        /// The comments
        /// </summary>
        private protected IList<ExcelComment> _comments;

        /// <summary>
        /// The theme path
        /// </summary>
        private protected string _themePath;

        /// <summary>
        /// The data
        /// </summary>
        private protected DataTable _dataTable;

        /// <summary>
        /// The internal path
        /// </summary>
        private protected string _internalPath;

        /// <summary>
        /// The save path
        /// </summary>
        private protected string _savePath;

        /// <summary>
        /// The image path
        /// </summary>
        private protected string _headerPath;

        /// <summary>
        /// The footer path
        /// </summary>
        private protected string _footerPath;

        /// <summary>
        /// The file path
        /// </summary>
        private protected string _filePath;

        /// <summary>
        /// The file name
        /// </summary>
        private protected string _fileName;

        /// <summary>
        /// The int
        /// </summary>
        private protected int _rowIndex;

        /// <summary>
        /// The row count
        /// </summary>
        private protected int _rowCount;

        /// <summary>
        /// The column count
        /// </summary>
        private protected int _columnCount;

        /// <summary>
        /// Sets the color of the background.
        /// </summary>
        /// <param name="excelRange"> </param>
        /// <param name="color">The color.</param>
        public void SetRangeBackgroundColor( ExcelRange excelRange, Color color )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                ThrowIf.NullOrEmpty( color, nameof( color ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                _excelRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _excelRange.Style.Fill.BackgroundColor.SetColor( color );
                _excelRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the range font.
        /// </summary>
        /// <param name="excelRange"> </param>
        /// <param name="font">The font.</param>
        public void SetRangeFont( ExcelRange excelRange, Font font )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                _excelRange.Style.Font.SetFromFont( font.Name, font.Size );
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the color of the font.
        /// </summary>
        /// <param name="excelRange"> </param>
        /// <param name="color">The color.</param>
        public void SetRangeFontColor( ExcelRange excelRange, Color color )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                ThrowIf.NullOrEmpty( color, nameof( color ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                _excelRange.Style.Font.Color.SetColor( color );
                _excelRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Lists to data table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        private protected DataTable ListToDataTable<T>( IEnumerable<T> data )
        {
            try
            {
                ThrowIf.Null( data, nameof( data ) );
                var _table = new DataTable( );
                for( var _i = 0; _i < ( typeof( T )?.GetProperties( ) ).Length; _i++ )
                {
                    var _info = ( typeof( T )?.GetProperties( ) )[ _i ];
                    var _col = new DataColumn( _info.Name, GetNullableType( _info.PropertyType ) );
                    _table?.Columns?.Add( _col );
                }

                foreach( var _t in data )
                {
                    var _row = _table.NewRow( );
                    foreach( var _info in typeof( T ).GetProperties( ) )
                    {
                        _row[ _info.Name ] = !IsNullableType( _info.PropertyType )
                            ? _info.GetValue( _t, null )
                            : _info.GetValue( _t, null ) ?? DBNull.Value;
                    }

                    _table.Rows.Add( _row );
                }

                return _table;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Gets the type of the nullable.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        private protected Type GetNullableType( Type type )
        {
            try
            {
                var _returnType = type;
                if( type.IsGenericType
                   && type.GetGenericTypeDefinition( ) == typeof( Nullable<> ) )
                {
                    _returnType = Nullable.GetUnderlyingType( type );
                }

                return _returnType;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Type );
            }
        }

        /// <summary>
        /// Appends the text cell.
        /// </summary>
        /// <param name="cellReference">The cell reference.</param>
        /// <param name="cellValue">The cell value.</param>
        /// <param name="excelRow">The excel row.</param>
        private protected void AppendTextCell( string cellReference, string cellValue,
            OpenXmlElement excelRow )
        {
            try
            {
                ThrowIf.NullOrEmpty( cellReference, nameof( cellReference ) );
                ThrowIf.NullOrEmpty( cellValue, nameof( cellValue ) );
                ThrowIf.Null( excelRow, nameof( excelRow ) );
                var _cell = new Cell
                {
                    CellReference = cellReference,
                    DataType = CellValues.String
                };

                var _cellValue = new CellValue
                {
                    Text = cellValue
                };

                _cell.Append( _cellValue );
                excelRow.Append( _cell );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Appends the numeric cell.
        /// </summary>
        /// <param name="cellReference">The cell reference.</param>
        /// <param name="cellValue">The cell value.</param>
        /// <param name="excelRow">The excel row.</param>
        private protected void AppendNumericCell( string cellReference, string cellValue,
            OpenXmlElement excelRow )
        {
            try
            {
                ThrowIf.NullOrEmpty( cellReference, nameof( cellReference ) );
                ThrowIf.NullOrEmpty( cellValue, nameof( cellValue ) );
                ThrowIf.Null( excelRow, nameof( excelRow ) );
                var _cell = new Cell
                {
                    CellReference = cellReference
                };

                var _cellValue = new CellValue
                {
                    Text = cellValue
                };

                _cell.Append( _cellValue );
                excelRow.Append( _cell );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the name of the excel column.
        /// </summary>
        /// <param name="columnIndex">Index of the column.</param>
        /// <returns></returns>
        private protected string GetExcelColumnName( int columnIndex )
        {
            try
            {
                ThrowIf.NegativeOrZero( columnIndex, nameof( columnIndex ) );
                if( columnIndex < 26 )
                {
                    return ( (char)( 'A' + columnIndex ) ).ToString( );
                }

                var _first = (char)( 'A' + ( columnIndex / 26 ) - 1 );
                var _second = (char)( 'A' + ( columnIndex % 26 ) );
                return $"{_first}{_second}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary>
        /// Determines whether [is nullable type] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if [is nullable type] [the specified type];
        ///   otherwise, <c>false</c>.
        /// </returns>
        private protected bool IsNullableType( Type type )
        {
            try
            {
                return type == typeof( string )
                    || type.IsArray
                    || ( type.IsGenericType
                        && type.GetGenericTypeDefinition( ) == typeof( Nullable<> ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary>
        /// Releases unmanaged and
        /// - optionally - managed resources.
        /// </summary>
        /// <param name="disposing">
        /// <c> true </c>
        /// to release both managed and unmanaged resources;
        /// <c> false </c>
        /// to release only unmanaged resources.
        /// </param>
        private void Dispose( bool disposing )
        {
            try
            {
                _font?.Dispose( );
                _titleFont?.Dispose( );
                _dataConnection?.Dispose( );
                _dataCommand?.Dispose( );
                _dataAdapter?.Dispose( );
                _excelWorksheet?.Dispose( );
                _excelWorkbook?.Dispose( );
                _excelPackage?.Dispose( );
                if( _fileInfo != null )
                {
                    _fileInfo = null;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Releases unmanaged and
        /// - optionally - managed resources.
        /// </summary>
        public void Dispose( )
        {
            try
            {
                Dispose( true );
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
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
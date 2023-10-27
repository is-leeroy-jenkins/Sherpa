// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ExcelReport.cs" company="Terry D. Eppler">
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
//   ExcelReport.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Spreadsheet;
    using static DocumentFormat.OpenXml.Packaging.SpreadsheetDocument;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class ExcelReport
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelReport"/>
        /// class.
        /// </summary>
        public ExcelReport( )
        {
        }

        /// <summary> Creates the excel document. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="data"> The data. </param>
        /// <param name="path"> The path. </param>
        /// <returns> </returns>
        public bool CreateExcelDocument<T>( IEnumerable<T> data, string path )
        {
            try
            {
                ThrowIf.NoElements( data, "data" );
                ThrowIf.NullOrEmpty( path, "path" );
                var _dataSet = new DataSet( );
                _dataSet?.Tables?.Add( ListToDataTable( data ) );
                return CreateExcelDocument( _dataSet, path );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary> Creates the excel document. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <param name="path"> The path. </param>
        /// <returns> </returns>
        public bool CreateExcelDocument( DataTable dataTable, string path )
        {
            try
            {
                ThrowIf.NoData( dataTable, "dataTable" );
                ThrowIf.NullOrEmpty( path, "path" );
                var _dataSet = new DataSet( );
                _dataSet.Tables.Add( dataTable );
                var _document = CreateExcelDocument( _dataSet, path );
                _dataSet.Tables.Remove( dataTable );
                return _document;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( bool );
            }
        }

        /// <summary> Creates the excel document. </summary>
        /// <param name="dataSet"> The data set. </param>
        /// <param name="fileName"> Name of the file. </param>
        /// <returns> </returns>
        public bool CreateExcelDocument( DataSet dataSet, string fileName )
        {
            try
            {
                ThrowIf.NoData( dataSet, "dataSet" );
                ThrowIf.NullOrEmpty( fileName, "fileName" );
                using( var _document = Create( fileName, SpreadsheetDocumentType.Workbook ) )
                {
                    WriteExcelFile( dataSet, _document );
                }

                Trace.WriteLine( "Successfully created: " + fileName );
                return true;
            }
            catch( Exception _ex )
            {
                Trace.WriteLine( "Failed, exception thrown: " + _ex.Message );
                return false;
            }
        }

        /// <summary> Lists to data table. </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="data"> The data. </param>
        /// <returns> </returns>
        public DataTable ListToDataTable<T>( IEnumerable<T> data )
        {
            try
            {
                ThrowIf.NoElements( data, "data" );
                var _table = new DataTable( );
                foreach( var _info in typeof( T ).GetProperties( ) )
                {
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

        /// <summary> Gets the type of the nullable. </summary>
        /// <param name="type"> The type. </param>
        /// <returns> </returns>
        public Type GetNullableType( Type type )
        {
            try
            {
                var _returnType = type;
                if( type.IsGenericType
                   && ( type.GetGenericTypeDefinition( ) == typeof( Nullable<> ) ) )
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

        /// <summary> Appends the text cell. </summary>
        /// <param name="cellReference"> The cell reference. </param>
        /// <param name="cellStringValue"> The cell string value. </param>
        /// <param name="excelRow"> The excel row. </param>
        public void AppendTextCell( string cellReference, string cellStringValue,
                                    OpenXmlElement excelRow )
        {
            try
            {
                ThrowIf.NullOrEmpty( cellReference, "cellReference" );
                ThrowIf.NullOrEmpty( cellStringValue, "cellStringValue" );
                ThrowIf.Null( excelRow, "excelRow" );
                var _cell = new Cell( );
                _cell.CellReference = cellReference;
                _cell.DataType = CellValues.String;
                var _cellValue = new CellValue( );
                _cellValue.Text = cellStringValue;
                _cell.Append( _cellValue );
                excelRow.Append( _cell );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Appends the numeric cell. </summary>
        /// <param name="cellReference"> The cell reference. </param>
        /// <param name="cellStringValue"> The cell string value. </param>
        /// <param name="excelRow"> The excel row. </param>
        public void AppendNumericCell( string cellReference, string cellStringValue,
                                       OpenXmlElement excelRow )
        {
            try
            {
                ThrowIf.NullOrEmpty( cellReference, "cellReference" );
                ThrowIf.NullOrEmpty( cellStringValue, "cellStringValue" );
                ThrowIf.Null( excelRow, "excelRow" );
                var _cell = new Cell( );
                _cell.CellReference = cellReference;
                var _cellValue = new CellValue( );
                _cellValue.Text = cellStringValue;
                _cell.Append( _cellValue );
                excelRow.Append( _cell );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Gets the name of the excel column. </summary>
        /// <param name="columnIndex"> Index of the column. </param>
        /// <returns> </returns>
        public string GetExcelColumnName( int columnIndex )
        {
            try
            {
                ThrowIf.Negative( columnIndex, "columnIndex" );
                if( columnIndex < 26 )
                {
                    return ( (char) ( 'A' + columnIndex ) ).ToString( );
                }

                var _first = (char) ( 'A' + columnIndex / 26 - 1 );
                var _second = (char) ( 'A' + columnIndex % 26 );
                return $"{_first}{_second}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> Writes the excel file. </summary>
        /// <param name="dataSet"> The data set. </param>
        /// <param name="spreadSheet"> The spread sheet. </param>
        public void WriteExcelFile( DataSet dataSet, SpreadsheetDocument spreadSheet )
        {
            try
            {
                ThrowIf.NoData( dataSet, "dataSet" );
                ThrowIf.Null( spreadSheet, "spreadSheet" );
                spreadSheet.AddWorkbookPart( );
                spreadSheet.WorkbookPart.Workbook =
                    new DocumentFormat.OpenXml.Spreadsheet.Workbook( );

                spreadSheet.WorkbookPart.Workbook?.Append( new BookViews( new WorkbookView( ) ) );
                var _styles = spreadSheet.WorkbookPart.AddNewPart<WorkbookStylesPart>( "Styles" );
                var _stylesheet = new Stylesheet( );
                _styles.Stylesheet = _stylesheet;
                uint _id = 1;
                foreach( DataTable _dataTable in dataSet.Tables )
                {
                    var _part = spreadSheet?.WorkbookPart?.AddNewPart<WorksheetPart>( );
                    if( _part != null )
                    {
                        _part.Worksheet = new Worksheet( );
                        _part.Worksheet.AppendChild( new SheetData( ) );
                        WriteDataTableToExcelWorksheet( _dataTable, _part );
                        _part.Worksheet.Save( );
                        if( _id == 1 )
                        {
                            spreadSheet?.WorkbookPart?.Workbook?.AppendChild( new Sheets( ) );
                        }

                        spreadSheet.WorkbookPart?.Workbook?.GetFirstChild<Sheets>( )
                            ?.AppendChild( new Sheet
                            {
                                Id = spreadSheet.WorkbookPart.GetIdOfPart( _part ),
                                SheetId = _id,
                                Name = _dataTable.TableName
                            } );
                    }

                    _id++;
                }

                spreadSheet.WorkbookPart?.Workbook?.Save( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Writes the data table to excel worksheet. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <param name="workSheetPart"> The work sheet part. </param>
        public void WriteDataTableToExcelWorksheet( DataTable dataTable,
                                                    WorksheetPart workSheetPart )
        {
            try
            {
                ThrowIf.NoData( dataTable, "dataTable" );
                ThrowIf.Null( workSheetPart, "workSheetPart" );
                var _worksheet = workSheetPart.Worksheet;
                var _data = _worksheet?.GetFirstChild<SheetData>( );
                var _columns = dataTable.Columns.Count;
                var _isNumeric = new bool[ _columns ];
                var _names = new string[ _columns ];
                for( var _n = 0; _n < _columns; _n++ )
                {
                    _names[ _n ] = GetExcelColumnName( _n );
                }

                uint _rowIndex = 1;
                var _row = new Row( );
                _row.RowIndex = _rowIndex;
                _data?.Append( _row );
                for( var _colinx = 0; _colinx < _columns; _colinx++ )
                {
                    var _column = dataTable.Columns[ _colinx ];
                    AppendTextCell( _names[ _colinx ] + "1", _column.ColumnName, _row );
                    _isNumeric[ _colinx ] = ( _column.DataType.FullName == "System.Decimal" )
                        || ( _column.DataType.FullName == "System.Int32" );
                }

                foreach( DataRow _dataRow in dataTable.Rows )
                {
                    ++_rowIndex;
                    var _excelRow = new Row( );
                    _excelRow.RowIndex = _rowIndex;
                    _data?.Append( _excelRow );
                    for( var _i = 0; _i < _columns; _i++ )
                    {
                        var _value = _dataRow?.ItemArray[ _i ]?.ToString( );
                        if( _isNumeric[ _i ] )
                        {
                            if( double.TryParse( _value, out var _cellNumericValue ) )
                            {
                                _value = _cellNumericValue.ToString( );
                                AppendNumericCell( _names[ _i ] + _rowIndex, _value, _excelRow );
                            }
                        }
                        else
                        {
                            AppendTextCell( _names[ _i ] + _rowIndex, _value, _excelRow );
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
        /// Determines whether [is nullable type] [the specified type].
        /// </summary>
        /// <param name="type"> The type. </param>
        /// <returns>
        /// <c> true </c>
        /// if [is nullable type] [the specified type]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        protected bool IsNullableType( Type type )
        {
            try
            {
                return ( type == typeof( string ) )
                    || type.IsArray
                    || ( type.IsGenericType
                        && ( type.GetGenericTypeDefinition( ) == typeof( Nullable<> ) ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
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
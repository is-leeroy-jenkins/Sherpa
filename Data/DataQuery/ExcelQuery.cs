// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ExcelQuery.cs" company="Terry D. Eppler">
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
//   ExcelQuery.cs
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
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;
    using OfficeOpenXml;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.Query"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    public class ExcelQuery : Query
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelQuery"/>
        /// class.
        /// </summary>
        public ExcelQuery( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        public ExcelQuery( Source source )
            : base( source, Provider.Excel, SQL.SELECT )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        public ExcelQuery( Source source, IDictionary<string, object> dict )
            : base( source, Provider.Excel, dict, SQL.SELECT )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        /// <param name="commandType"> Type of the command. </param>
        public ExcelQuery( Source source, IDictionary<string, object> dict, SQL commandType )
            : base( source, Provider.Excel, dict, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public ExcelQuery( Source source, IDictionary<string, object> updates,
                           IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, Provider.Excel, updates, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="criteria"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public ExcelQuery( Source source, IEnumerable<string> columns,
                           IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, Provider.Excel, columns, criteria, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="criteria"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public ExcelQuery( Source source, IEnumerable<string> fields, IEnumerable<string> numerics,
                           IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, Provider.Excel, fields, numerics, criteria,
                commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlStatement. </param>
        public ExcelQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public ExcelQuery( Source source, string sqlText )
            : base( source, Provider.Excel, sqlText )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> The commandType. </param>
        public ExcelQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="commandType"> The commandType. </param>
        /// <param name="dict"> </param>
        public ExcelQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary> Saves the file. </summary>
        /// <param name="workBook"> The work book. </param>
        public void SaveFile( ExcelPackage workBook )
        {
            try
            {
                ThrowIf.Null( workBook, "workBook" );
                var _dialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    FilterIndex = 1
                };

                if( _dialog?.ShowDialog( ) == DialogResult.OK )
                {
                    var _name = _dialog.FileName;
                    workBook.Save( _name );
                    const string SUCCESSFUL = "Save Successful!";
                    var _message = new Message( SUCCESSFUL );
                    _message?.ShowDialog( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Writes the excel file. </summary>
        /// <param name="dataTable"> The table. </param>
        /// <param name="filePath"> The file path. </param>
        public void WriteExcelFile( DataTable dataTable, string filePath )
        {
            try
            {
                ThrowIf.NoData( dataTable, "dataTable" );
                ThrowIf.NullOrEmpty( filePath, "filePath" );
                using var _excelPackage = ReadExcelFile( filePath );
                var _name = Path.GetFileNameWithoutExtension( filePath );
                var _excelWorksheet = _excelPackage?.Workbook?.Worksheets?.Add( _name );
                var _columns = dataTable?.Columns?.Count;
                var _rows = dataTable?.Rows?.Count;
                for( var _column = 1; _column <= _columns; _column++ )
                {
                    if( _excelWorksheet != null )
                    {
                        var _colName = dataTable.Columns[ _column - 1 ].ColumnName;
                        _excelWorksheet.Cells[ 1, _column ].Value = _colName;
                    }
                }

                for( var _row = 1; _row <= _rows; _row++ )
                {
                    for( var _col = 0; _col < _columns; _col++ )
                    {
                        if( _excelWorksheet != null )
                        {
                            var _column = dataTable.Rows[ _row - 1 ][ _col ];
                            _excelWorksheet.Cells[ _row + 1, _col + 1 ].Value = _column;
                        }
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Gets the excel file. </summary>
        /// <returns> </returns>
        public string GetExcelFile( )
        {
            try
            {
                var _fileName = "";
                var _dialog = new OpenFileDialog
                {
                    Title = "Excel File Dialog",
                    InitialDirectory = @"c:\",
                    Filter = "Excel files (*.xlsx)|*.xls|*.csv",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if( _dialog.ShowDialog( ) == DialogResult.OK )
                {
                    _fileName = _dialog.FileName;
                }

                return _fileName;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> Imports the data. </summary>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <returns> </returns>
        public DataTable ImportData( ref string sheetName )
        {
            try
            {
                ThrowIf.NullOrEmpty( sheetName, "sheetName" );
                var _dataSet = new DataSet( );
                var _connection = DataConnection as OleDbConnection;
                _connection?.Open( );
                var _sql = $"SELECT * FROM {sheetName}";
                var _schema = _connection?.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                if( ( _schema?.Columns?.Count > 0 )
                   && !SheetExists( sheetName, _schema ) )
                {
                    const string MSG = "Sheet Does Not Exist!";
                    var _message = new Message( MSG );
                    _message?.ShowDialog( );
                }
                else
                {
                    sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                }

                var _adapter = new OleDbDataAdapter( _sql, _connection );
                _adapter?.Fill( _dataSet );
                return _dataSet?.Tables[ 0 ];
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary> CSVs the import. </summary>
        /// <param name="fileName"> Name of the file. </param>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <returns> </returns>
        public DataTable CsvImport( string fileName, ref string sheetName )
        {
            try
            {
                ThrowIf.NullOrEmpty( fileName, "fileName" );
                ThrowIf.NullOrEmpty( sheetName, "sheetName" );
                var _data = new DataSet( );
                var _sql = $"SELECT * FROM {sheetName}";
                var _connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;"
                    + $"Data Source={Path.GetDirectoryName( fileName )} "
                    + "Extended Properties='Text;HDR=YES;FMT=Delimited'";

                var _connection = new OleDbConnection( _connectionString );
                var _schema = _connection.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                if( !string.IsNullOrEmpty( sheetName ) )
                {
                    if( !SheetExists( sheetName, _schema ) )
                    {
                        var _msg = $"{sheetName} in {fileName} Does Not Exist!";
                        var _message = new Message( _msg );
                        _message?.ShowDialog( );
                    }
                }
                else
                {
                    sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                }

                var _dataAdapter = new OleDbDataAdapter( _sql, _connection );
                _dataAdapter.Fill( _data );
                return _data.Tables[ 0 ];
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary> Releases the specified range. </summary>
        /// <param name="range"> The range. </param>
        /// <param name="workSheet"> The work sheet. </param>
        /// <param name="excel"> The excel. </param>
        protected virtual void Release( ExcelRange range, ExcelWorksheet workSheet,
                                        ExcelPackage excel )
        {
            try
            {
                GC.Collect( );
                GC.WaitForPendingFinalizers( );
                Marshal.ReleaseComObject( range );
                Marshal.ReleaseComObject( workSheet );
                Marshal.ReleaseComObject( excel );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc/>
        /// <summary> </summary>
        /// <param name="disposing"> </param>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                base.Dispose( disposing );
            }

            IsDisposed = true;
        }

        /// <summary> Reads the excel file. </summary>
        /// <param name="filePath"> The file path. </param>
        /// <returns> </returns>
        private static ExcelPackage ReadExcelFile( string filePath )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, "filePath" );
                var _fileInfo = new FileInfo( filePath );
                return new ExcelPackage( _fileInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( ExcelPackage );
            }
        }

        /// <summary> Exports to data grid. </summary>
        /// <param name="dataGrid"> The data grid. </param>
        private void ExportToDataGrid( DataGridView dataGrid )
        {
            try
            {
                ThrowIf.Null( dataGrid, "dataGrid" );
                var _filePath = ConnectionFactory.ClientPath;
                var _stream = new FileInfo( _filePath );
                var _application = new ExcelPackage( _stream );
                var _workbook = _application.Workbook;
                var _worksheet = _workbook.Worksheets[ 1 ];
                var _range = _worksheet.SelectedRange;
                var _rows = _range.Rows;
                var _columns = _range.Columns;
                dataGrid.ColumnCount = _columns;
                dataGrid.RowCount = _rows;
                for( var _i = 1; _i <= _rows; _i++ )
                {
                    for( var _j = 1; _j <= _columns; _j++ )
                    {
                        var _address = _range[ _i, _j ]?.Address;
                        if( ( !string.IsNullOrEmpty( _address ) )
                           && ( _range[ _i, _j ]?.Value != null ) )
                        {
                            dataGrid.Rows[ _i - 1 ].Cells[ _j - 1 ].Value = _address;
                        }
                    }
                }

                Release( _range, _worksheet, _application );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sheets the exists. </summary>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <param name="dataTable"> The data table. </param>
        /// <returns> </returns>
        private bool SheetExists( string sheetName, DataTable dataTable )
        {
            try
            {
                ThrowIf.NullOrEmpty( sheetName, "sheetName" );
                ThrowIf.NoData( dataTable, "dataTable" );
                for( var _i = 0; _i < dataTable.Rows.Count; _i++ )
                {
                    var _dataRow = dataTable.Rows[ _i ];
                    if( sheetName == _dataRow[ "TABLENAME" ].ToString( ) )
                    {
                        return true;
                    }
                }

                return false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }
    }
}
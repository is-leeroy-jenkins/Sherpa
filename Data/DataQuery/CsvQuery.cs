// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CsvQuery.cs" company="Terry D. Eppler">
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
//   CsvQuery.cs
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
    using System.Threading;
    using System.Windows.Forms;
    using OfficeOpenXml;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.Query"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class CsvQuery : Query
    {
        /// <inheritdoc/>
        /// <summary> Gets the Provider </summary>
        public new Provider Provider { get; set; } = Provider.CSV;

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        public CsvQuery( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        public CsvQuery( Source source )
            : base( source, Provider.Access, SQL.SELECT )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        public CsvQuery( Source source, IDictionary<string, object> dict )
            : base( source, Provider.Access, dict, SQL.SELECT )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source Data. </param>
        /// <param name="provider"> The provider used. </param>
        /// <param name="dict"> </param>
        /// <param name="commandType"> The type of sql command. </param>
        public CsvQuery( Source source, Provider provider, IDictionary<string, object> dict,
                         SQL commandType )
            : base( source, provider, dict, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public CsvQuery( Source source, Provider provider, IDictionary<string, object> updates,
                         IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="criteria"> </param>
        /// <param name="commandType"> Type of the command. </param>
        public CsvQuery( Source source, Provider provider, IEnumerable<string> columns,
                         IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, criteria, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlStatement. </param>
        public CsvQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public CsvQuery( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="dict"> </param>
        public CsvQuery( Source source, Provider provider, IDictionary<string, object> dict )
            : base( source, provider, dict )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> The commandType. </param>
        public CsvQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CsvQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="commandType"> The commandType. </param>
        /// <param name="dict"> </param>
        public CsvQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary> Saves the file. </summary>
        /// <param name="workBook"> The work book. </param>
        public void SaveFile( ExcelPackage workBook )
        {
            if( workBook != null )
            {
                try
                {
                    var _fileDialog = new SaveFileDialog
                    {
                        Filter = "CSV files (*.csv)|*.csv",
                        FilterIndex = 1
                    };

                    if( _fileDialog.ShowDialog( ) == DialogResult.OK )
                    {
                        workBook.SaveAs( new FileInfo( _fileDialog.FileName ) );
                        const string MSG = "Save Successful!";
                        using var _message = new Message( MSG );
                        _message?.ShowDialog( );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> CSVs the import. </summary>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <returns> </returns>
        public DataTable CsvImport( ref string sheetName )
        {
            if( !string.IsNullOrEmpty( sheetName )
               && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    using var _dataSet = new DataSet( );
                    var _sql = "SELECT * FROM [" + sheetName + "]";
                    var _connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={
                        Path.GetDirectoryName( sheetName )};"
                        + "Extended Properties='Text;HDR=YES;FMT=Delimited'";

                    using var _connection = new OleDbConnection( _connectionString );
                    var _schema = _connection.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                    if( !string.IsNullOrEmpty( sheetName ) )
                    {
                        if( !SheetExists( sheetName, _schema ) )
                        {
                            var _msg = $"{sheetName} in {sheetName} Does Not Exist!";
                            using var _message = new Message( _msg );
                            _message?.ShowDialog( );
                        }
                    }
                    else
                    {
                        sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                    }

                    using var _dataAdapter = new OleDbDataAdapter( _sql, _connection );
                    _dataAdapter.Fill( _dataSet );
                    return _dataSet.Tables[ 0 ];
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary> CSVs the import. </summary>
        /// <param name="fileName"> Name of the file. </param>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <returns> </returns>
        public DataTable CsvImport( string fileName, ref string sheetName )
        {
            if( !string.IsNullOrEmpty( fileName )
               && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    using var _dataSet = new DataSet( );
                    var _sql = "SELECT * FROM [" + sheetName + "]";
                    var _connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={
                        Path.GetDirectoryName( fileName )
                    };Extended Properties='Text;HDR=YES;FMT=Delimited'";

                    using var _connection = new OleDbConnection( _connectionString );
                    var _schema = _connection.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                    if( !string.IsNullOrEmpty( sheetName ) )
                    {
                        if( !SheetExists( sheetName, _schema ) )
                        {
                            var _msg = $"{sheetName} in {fileName} Does Not Exist!";
                            using var _message = new Message( _msg );
                            _message?.ShowDialog( );
                        }
                    }
                    else
                    {
                        sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                    }

                    using var _dataAdapter = new OleDbDataAdapter( _sql, _connection );
                    _dataAdapter.Fill( _dataSet );
                    return _dataSet.Tables[ 0 ];
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary> CSVs the export. </summary>
        /// <param name="table"> The table. </param>
        /// <param name="filePath"> The file path. </param>
        public void CsvExport( DataTable table, string filePath )
        {
            if( ( table?.Columns.Count > 0 )
               && ( table.Rows.Count > 0 )
               && !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    using var _excel = CreateCsvFile( filePath );
                    var _withoutExtension = Path.GetFileNameWithoutExtension( filePath );
                    var _sheet = _excel.Workbook.Worksheets.Add( _withoutExtension );
                    var _columns = table.Columns.Count;
                    var _rows = table.Rows.Count;
                    for( var _column = 1; _column <= _columns; _column++ )
                    {
                        _sheet.Cells[ 1, _column ].Value = table.Columns[ _column - 1 ].ColumnName;
                    }

                    for( var _row = 1; _row <= _rows; _row++ )
                    {
                        for( var _col = 0; _col < _columns; _col++ )
                        {
                            _sheet.Cells[ _row + 1, _col + 1 ].Value =
                                table.Rows[ _row - 1 ][ _col ];
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> CSVs the export. </summary>
        /// <param name="dataGrid"> The data grid. </param>
        public void CsvExport( DataGridView dataGrid )
        {
            if( ( dataGrid?.DataSource != null )
               && ( ConnectionFactory != null ) )
            {
                try
                {
                    var _filePath = ConnectionFactory.ClientPath;
                    using var _excel = new ExcelPackage( new FileInfo( _filePath ) );
                    var _workbook = _excel.Workbook;
                    var _worksheet = _workbook.Worksheets[ 1 ];
                    var _rows = _worksheet.SelectedRange.Rows;
                    var _columns = _worksheet.SelectedRange.Columns;
                    dataGrid.ColumnCount = _columns;
                    dataGrid.RowCount = _rows;
                    for( var _i = 1; _i <= _rows; _i++ )
                    {
                        for( var _j = 1; _j <= _columns; _j++ )
                        {
                            var _value = _worksheet.Cells[ _i, _j ].Value.ToString( );
                            if( !string.IsNullOrEmpty( _value ) )
                            {
                                dataGrid.Rows[ _i - 1 ].Cells[ _j - 1 ].Value = _value;
                            }
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Creates the CSV file. </summary>
        /// <param name="filePath"> The file path. </param>
        /// <returns> </returns>
        public ExcelPackage CreateCsvFile( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    var _fileInfo = new FileInfo( filePath );
                    return new ExcelPackage( _fileInfo );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( ExcelPackage );
                }
            }

            return default( ExcelPackage );
        }

        /// <summary> Gets the CSV file. </summary>
        /// <returns> </returns>
        public string GetCsvFile( )
        {
            try
            {
                var _fileName = "";
                var _fileDialog = new OpenFileDialog
                {
                    Title = "CSV File Dialog",
                    InitialDirectory = @"c:\",
                    Filter = "All files (*.*)|*.*|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if( _fileDialog.ShowDialog( ) == DialogResult.OK )
                {
                    _fileName = _fileDialog.FileName;
                }

                return _fileName;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary> Sheets the exists. </summary>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <param name="dataTable"> The data table. </param>
        /// <returns> </returns>
        private bool SheetExists( string sheetName, DataTable dataTable )
        {
            if( !string.IsNullOrEmpty( sheetName )
               && ( dataTable?.Columns.Count > 0 )
               && ( dataTable.Rows.Count > 0 ) )
            {
                try
                {
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
                }
            }

            return false;
        }
    }
}
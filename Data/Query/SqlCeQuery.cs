﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="SqlCeQuery.cs" company="Terry D. Eppler">
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
//   SqlCeQuery.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    /// <inheritdoc />
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.Query" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class SqlCeQuery : Query
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        public SqlCeQuery( )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        public SqlCeQuery( Source source )
            : base( source, Provider.SqlCe, SQL.SELECT )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        public SqlCeQuery( Source source, IDictionary<string, object> dict )
            : base( source, Provider.SqlCe, dict, SQL.SELECT )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="dict"> The dictionary. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlCeQuery( Source source, IDictionary<string, object> dict, SQL commandType )
            : base( source, Provider.SqlCe, dict, commandType )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlCeQuery( Source source, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, Provider.SqlCe, updates, where, commandType )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="criteria"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlCeQuery( Source source, IEnumerable<string> columns,
            IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, Provider.SqlCe, columns, criteria, commandType )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlStatement. </param>
        public SqlCeQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public SqlCeQuery( Source source, string sqlText )
            : base( source, Provider.SqlCe, sqlText )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> The commandType. </param>
        public SqlCeQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlCeQuery" />
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="commandType"> The commandType. </param>
        /// <param name="dict"> </param>
        public SqlCeQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary> Creates the table from excel file. </summary>
        /// <param name="filePath"> Name of the file. </param>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <returns> </returns>
        public DataTable CreateTableFromExcelFile( string filePath, ref string sheetName )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                ThrowIf.NullOrEmpty( sheetName, nameof( sheetName ) );
                var _dataSet = new DataSet( );
                var _dataTable = new DataTable( );
                _dataSet.DataSetName = sheetName;
                _dataTable.TableName = sheetName;
                _dataSet.Tables.Add( _dataTable );
                var _sql = $"SELECT * FROM {sheetName}$";
                if( !string.IsNullOrEmpty( filePath ) )
                {
                    var _excelQuery = new ExcelQuery( filePath, _sql );
                    var _connection = DataConnection as OleDbConnection;
                    _connection?.Open( );
                    var _dataAdapter = _excelQuery.GetAdapter( );
                    _dataAdapter.Fill( _dataSet );
                    return _dataTable.Columns.Count > 0
                        ? _dataTable
                        : default( DataTable );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }

            return default( DataTable );
        }

        /// <summary> Creates the table from CSV file. </summary>
        /// <param name="filePath"> The file path. </param>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <returns>
        /// DataTable 
        /// </returns>
        public DataTable CreateTableFromCsvFile( string filePath, ref string sheetName )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                ThrowIf.NullOrEmpty( sheetName, nameof( sheetName ) );
                var _dataSet = new DataSet( );
                var _dataTable = new DataTable( );
                var _fileName = ConnectionFactory?.FileName;
                if( _fileName != null )
                {
                    _dataSet.DataSetName = _fileName;
                }

                _dataTable.TableName = sheetName;
                _dataSet.Tables.Add( _dataTable );
                var _cstring = GetExcelFilePath( );
                if( !string.IsNullOrEmpty( _cstring ) )
                {
                    var _sql = $"SELECT * FROM {sheetName}$";
                    using var _csvQuery = new CsvQuery( _cstring, _sql );
                    var _dataAdapter = _csvQuery.GetAdapter( ) as OleDbDataAdapter;
                    _dataAdapter?.Fill( _dataSet, sheetName );
                    return _dataTable.Columns.Count > 0
                        ? _dataTable
                        : default( DataTable );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }

            return default( DataTable );
        }

        /// <summary>
        /// Gets the excel file path.
        /// </summary>
        /// <returns></returns>
        private string GetExcelFilePath( )
        {
            try
            {
                var _fileName = "";
                var _fileDialog = new OpenFileDialog
                {
                    Title = "Excel File Dialog",
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

        /// <summary>
        /// Checks if sheet name exists.
        /// </summary>
        /// <param name="sheetName"> Name of the sheet. </param>
        /// <param name="schemaTable"> The schema table. </param>
        /// <returns>
        /// boolean
        /// </returns>
        private bool CheckIfSheetNameExists( string sheetName, DataTable schemaTable )
        {
            try
            {
                ThrowIf.NullOrEmpty( sheetName, nameof( sheetName ) );
                ThrowIf.NoData( schemaTable, nameof( schemaTable ) );
                for( var _i = 0; _i < schemaTable.Rows.Count; _i++ )
                {
                    var _dataRow = schemaTable.Rows[ _i ];
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
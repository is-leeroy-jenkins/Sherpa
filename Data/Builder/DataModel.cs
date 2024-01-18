// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataModel.cs" company="Terry D. Eppler">
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
//   DataModel.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using OfficeOpenXml;
    using static System.IO.File;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.ModelBase" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    public class DataModel : ModelBase
    {
        /// <summary>
        /// Gets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement
        {
            get
            {
                return _sqlStatement;
            }
            private protected set
            {
                _sqlStatement = value;
            }
        }

        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        public IConnectionFactory ConnectionFactory
        {
            get
            {
                return _connectionFactory;
            }
            private protected set
            {
                _connectionFactory = value;
            }
        }

        /// <summary>
        /// Gets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        public IList<int> Keys
        {
            get
            {
                return _keys;
            }
            private protected set
            {
                _keys = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/> class.
        /// </summary>
        public DataModel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public DataModel( Source source, Provider provider = Provider.Access )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, SQL.SELECTALL );
            _dataTable = GetDataTable( );
            _elements = CreateSeries( _dataTable );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        public DataModel( Source source, Provider provider, IDictionary<string, object> where )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, where );
            _dataTable = GetDataTable( );
            _elements = CreateSeries( _dataTable );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataModel( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            _dataTable = GetDataTable( );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _elements = CreateSeries( _dataTable );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataModel( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            _dataTable = GetDataTable( );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _elements = CreateSeries( _dataTable );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataModel( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> where,
            SQL commandType )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, fields, numerics, where,
                commandType );

            _dataTable = GetDataTable( );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _elements = CreateSeries( _dataTable );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="where">The where.</param>
        public DataModel( Source source, IDictionary<string, object> where )
        {
            _source = source;
            _provider = Provider.Access;
            _connectionFactory = new ConnectionFactory( source, Provider.Access );
            _sqlStatement = new SqlStatement( source, Provider.Access, where );
            _dataTable = GetDataTable( );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _elements = CreateSeries( _dataTable );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public DataModel( Source source, Provider provider, string sqlText )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, sqlText );
            _dataTable = GetDataTable( );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _elements = CreateSeries( _dataTable );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataModel( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            ConnectionFactory = new ConnectionFactory( fullPath );
            _source = ConnectionFactory.Source;
            _provider = ConnectionFactory.Provider;
            _sqlStatement = new SqlStatement( Source, Provider, sqlText, commandType );
            _dataTable = GetDataTable( );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _elements = CreateSeries( _dataTable );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public DataModel( IQuery query )
        {
            _source = query.Source;
            _provider = query.Provider;
            _connectionFactory = query.ConnectionFactory;
            _sqlStatement = query.SqlStatement;
            _dataTable = GetDataTable( );
            _dataColumns = GetDataColumns( );
            _columnNames = GetColumnNames( );
            _keys = GetPrimaryKeys( );
            _fields = GetFields( );
            _numerics = GetNumerics( );
            _dates = GetDates( );
            _elements = CreateSeries( _dataTable );
            _record = GetData( )?.FirstOrDefault( );
            _map = _record?.ToDictionary( );
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string column )
        {
            try
            {
                ThrowIf.Null( dataRows, nameof( dataRows ) );
                ThrowIf.NullOrEmpty( column, nameof( column ) );
                var _query = dataRows
                    ?.Select( v => v.Field<string>( column ) )
                    ?.Distinct( );

                return _query?.Any( ) == true
                    ? _query
                    : default( IEnumerable<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string name,
            string value )
        {
            try
            {
                ThrowIf.Null( dataRows, nameof( dataRows ) );
                ThrowIf.NullOrEmpty( name, nameof( name ) );
                ThrowIf.NullOrEmpty( value, nameof( value ) );
                var _query = dataRows
                    ?.Where( v => v.Field<string>( $"{name}" ).Equals( value ) )
                    ?.Select( v => v.Field<string>( $"{name}" ) )
                    ?.Distinct( );

                return _query?.Any( ) == true
                    ? _query
                    : default( IEnumerable<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Creates the table from worksheet.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="header">if set to
        /// <c>true</c> [header].</param>
        /// <returns></returns>
        public static DataTable CreateTableFromWorksheet( string filePath, bool header = true )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                using var _package = new ExcelPackage( );
                using var _stream = OpenRead( filePath );
                _package.Load( _stream );
                var _sheet = _package?.Workbook?.Worksheets?.First( );
                var _table = new DataTable( _sheet?.Name );
                if( _sheet?.Cells != null )
                {
                    var _lastColumn = _sheet.Dimension.End.Column;
                    var _lastRow = _sheet.Dimension.End.Row;
                    foreach( var _cell in _sheet?.Cells[ 1, 1, 1, _lastColumn ] )
                    {
                        _table?.Columns?.Add( header
                            ? _cell.Text
                            : $"Column {_cell.Start.Column}" );
                    }

                    var _start = header
                        ? 2
                        : 1;

                    for( var _row = _start; _row <= _lastRow; _row++ )
                    {
                        var _range = _sheet.Cells[ _row, 1, _row, _lastColumn ];
                        var _data = _table.Rows?.Add( );
                        foreach( var _cell in _range )
                        {
                            _data[ _cell.Start.Column - 1 ] = _cell?.Text;
                        }
                    }

                    return _table?.Rows?.Count > 0
                        ? _table
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
        /// Creates the series.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.
        /// </param>
        /// <returns>
        /// Dictionary
        /// </returns>
        private static IDictionary<string, IEnumerable<string>> CreateSeries( DataTable dataTable )
        {
            try
            {
                ThrowIf.Null( dataTable, nameof( dataTable ) );
                var _dict = new Dictionary<string, IEnumerable<string>>( );
                var _columns = dataTable?.Columns;
                var _rows = dataTable?.AsEnumerable( );
                for( var _i = 0; _i < _columns?.Count; _i++ )
                {
                    if( !string.IsNullOrEmpty( _columns[ _i ]?.ColumnName )
                       && ( _columns[ _i ]?.DataType == typeof( string ) ) )
                    {
                        var _name = GetValues( _rows, _columns[ _i ]?.ColumnName );
                        _dict?.Add( _columns[ _i ]?.ColumnName, _name );
                    }
                }

                return _dict?.Any( ) == true
                    ? _dict
                    : default( Dictionary<string, IEnumerable<string>> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, IEnumerable<string>> );
            }
        }
    }
}
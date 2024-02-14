// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="AsyncModel.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the 
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  $CURRENT_YEAR$  Terry Eppler
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
//   AsyncModel.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.AsyncData" />
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    public class AsyncModel : AsyncData
    {
        /// <summary>
        /// The busy
        /// </summary>
        private protected bool _busy;

        /// <summary>
        /// 
        /// </summary>
        private Task<IDictionary<string, IEnumerable<string>>> _dataElements;

        /// <inheritdoc/>
        /// <summary>
        /// Gets the data elements.
        /// </summary>
        /// <value>
        /// The data elements.
        /// </value>
        public Task<IDictionary<string, IEnumerable<string>>> DataElements
        {
            get
            {
                return _dataElements;
            }
            private set
            {
                _dataElements = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is busy; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool IsBusy
        {
            get
            {
                return _busy;
            }
            set
            {
                _busy = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        public AsyncModel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public AsyncModel( Source source, Provider provider = Provider.Access )
        {
            BeginInit( );
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, SQL.SELECTALL );
            _query = new Query( SqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataElements = GetSeriesAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The where. </param>
        public AsyncModel( Source source, Provider provider, IDictionary<string, object> where )
        {
            BeginInit( );
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, where );
            _query = new Query( SqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataElements = GetSeriesAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _record = GetRecordAsync( );
            Map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AsyncModel( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            BeginInit( );
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            _query = new Query( SqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _dataElements = GetSeriesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AsyncModel( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            BeginInit( );
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            _query = new Query( _sqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _dataElements = GetSeriesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AsyncModel( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> where,
            SQL commandType )
        {
            BeginInit( );
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, fields, numerics, where,
                commandType );

            _query = new Query( _sqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _dataElements = GetSeriesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="where"> The where. </param>
        public AsyncModel( Source source, IDictionary<string, object> where )
        {
            BeginInit( );
            _source = source;
            _provider = Provider.Access;
            _connectionFactory = new ConnectionFactory( source, Provider.Access );
            _sqlStatement = new SqlStatement( source, Provider.Access, where );
            _query = new Query( _sqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _dataElements = GetSeriesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public AsyncModel( Source source, Provider provider, string sqlText )
        {
            BeginInit( );
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, sqlText );
            _query = new Query( _sqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _keys = GetPrimaryKeysAsync( );
            _dates = GetDatesAsync( );
            _dataElements = GetSeriesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AsyncModel( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            BeginInit( );
            _connectionFactory = new ConnectionFactory( fullPath );
            _source = ConnectionFactory.Source;
            _provider = ConnectionFactory.Provider;
            _sqlStatement = new SqlStatement( Source, Provider, sqlText, commandType );
            _query = new Query( _sqlStatement );
            _dataTable = GetDataTableAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _dataElements = GetSeriesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/>
        /// class.
        /// </summary>
        /// <param name="query"> The query. </param>
        public AsyncModel( IQuery query )
        {
            BeginInit( );
            _query = query;
            _source = query.Source;
            _provider = query.Provider;
            _connectionFactory = query.ConnectionFactory;
            _sqlStatement = query.SqlStatement;
            _dataTable = GetDataTableAsync( );
            _dataColumns = GetColumnsAsync( );
            _columnNames = GetNamesAsync( );
            _keys = GetPrimaryKeysAsync( );
            _fields = GetFieldsAsync( );
            _numerics = GetNumericsAsync( );
            _dates = GetDatesAsync( );
            _dataElements = GetSeriesAsync( );
            _record = GetRecordAsync( );
            _map = GetMapAsync( );
            EndInit( );
        }

        /// <summary>
        /// Begins the initialize.
        /// </summary>
        private protected void BeginInit( )
        {
            _busy = true;
        }

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private protected void EndInit( )
        {
            _busy = false;
        }

        /// <summary> Gets the values asynchronous. </summary>
        /// <param name="dataRows"> The data rows. </param>
        /// <param name="columnName"> The name. </param>
        /// <param name="columnValue"> The value. </param>
        /// <returns> </returns>
        public Task<IList<string>> GetValuesAsync( IEnumerable<DataRow> dataRows,
            string columnName, string columnValue )
        {
            if( ( dataRows?.Any( ) == true )
               && !string.IsNullOrEmpty( columnValue ) )
            {
                var _tcs = new TaskCompletionSource<IList<string>>( );
                try
                {
                    var _select = dataRows
                        ?.Where( v => v.Field<string>( $"{columnName}" ).Equals( columnValue ) )
                        ?.Select( v => v.Field<string>( $"{columnName}" ) )
                        ?.Distinct( )
                        ?.ToList( );

                    _tcs.SetResult( _select );
                    return _select?.Any( ) == true
                        ? _tcs.Task
                        : default( Task<IList<string>> );
                }
                catch( Exception _ex )
                {
                    _tcs.SetException( _ex );
                    Fail( _ex );
                    return default( Task<IList<string>> );
                }
            }

            return default( Task<IList<string>> );
        }

        /// <summary> Gets the values. </summary>
        /// <param name="dataRows"> The data rows. </param>
        /// <param name="columnName"> The column. </param>
        /// <returns> </returns>
        private IList<string> GetValues( IEnumerable<DataRow> dataRows, string columnName )
        {
            if( ( dataRows?.Any( ) == true )
               && !string.IsNullOrEmpty( columnName ) )
            {
                try
                {
                    var _values = dataRows
                        ?.Select( v => v.Field<string>( columnName ) )
                        ?.Distinct( )
                        ?.ToList( );

                    return _values?.Any( ) == true
                        ? _values
                        : default( IList<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary> Creates the series asynchronous. </summary>
        /// <returns> </returns>
        private Task<IDictionary<string, IEnumerable<string>>> GetSeriesAsync( )
        {
            var _tcs = new TaskCompletionSource<IDictionary<string, IEnumerable<string>>>( );
            try
            {
                var _table = GetDataTable( );
                var _columns = _table?.Columns;
                var _rows = _table?.AsEnumerable( );
                var _dict = new Dictionary<string, IEnumerable<string>>( );
                for( var _i = 0; _i < _columns?.Count; _i++ )
                {
                    var _colName = _columns[ _i ]?.ColumnName;
                    if( !string.IsNullOrEmpty( _colName )
                       && ( _columns[ _i ]?.DataType == typeof( string ) ) )
                    {
                        var _name = GetValues( _rows, _colName );
                        _dict?.Add( _columns[ _i ]?.ColumnName, _name );
                    }
                }

                _tcs.SetResult( _dict );
                return _dict?.Any( ) == true
                    ? _tcs.Task
                    : default( Task<IDictionary<string, IEnumerable<string>>> );
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<IDictionary<string, IEnumerable<string>>> );
            }
        }
    }
}
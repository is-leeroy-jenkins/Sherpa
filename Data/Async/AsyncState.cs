// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 07-14-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-14-2023
// ******************************************************************************************
// <copyright file="AsyncData.cs" company="Terry D. Eppler">
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
//
// </copyright>
// <summary>
//   AsyncData.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.ISource" />
    /// <seealso cref="T:BudgetExecution.IProvider" />
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class AsyncState : AsyncBase
    {
        /// <summary>
        /// 
        /// </summary>
        private protected IConnectionFactory _connectionFactory;
        
        private protected ISqlStatement _sqlStatement;

        private protected IQuery _query;

        private protected Task<DataRow> _record;

        private protected Task<IList<int>> _keys;

        private protected Task<IDictionary<string, object>> _map;

        /// <inheritdoc />
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
            private set
            {
                _connectionFactory = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the SQL statement.
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

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public IQuery Query
        {
            get
            {
                return _query;
            }
            private protected set
            {
                _query = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public Task<DataRow> Record
        {
            get
            {
                return _record;
            }
            private protected set
            {
                _record = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        public Task<IList<int>> Keys
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

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        /// <value>
        /// The map.
        /// </value>
        public Task<IDictionary<string, object>> Map
        {
            get
            {
                return _map;
            }
            private protected set
            {
                _map = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data table asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<DataTable> GetDataTableAsync( )
        {
            if( _query != null )
            {
                var _tcs = new TaskCompletionSource<DataTable>( );
                try
                {
                    var _set = new DataSet( $"{_source}" );
                    var _table = new DataTable( $"{_source}" );
                    _table.TableName = _source.ToString( );
                    _set.Tables.Add( _table );
                    var _adapter = _query.DataAdapter;
                    _adapter.Fill( _set, _table.TableName );
                    SetColumnCaptions( _table );
                    _tcs.SetResult( _table );
                    return _table.Rows.Count > 0
                        ? _tcs.Task
                        : default( Task<DataTable> );
                }
                catch( Exception _ex )
                {
                    _tcs.SetException( _ex );
                    Fail( _ex );
                    return default( Task<DataTable> );
                }
            }

            return default( Task<DataTable> );
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the record asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<DataRow> GetRecordAsync( )
        {
            var _tcs = new TaskCompletionSource<DataRow>( );
            try
            {
                var _table = GetDataTable( );
                var _data = _table?.AsEnumerable( );
                var _row = _data.FirstOrDefault( );
                _tcs.SetResult( _row );
                return _row?.ItemArray?.Length > 0
                    ? _tcs.Task
                    : default( Task<DataRow> );
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<DataRow> );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable( )
        {
            if( Query != null )
            {
                try
                {
                    var _set = new DataSet( $"{Source}" );
                    var _table = new DataTable( $"{Source}" );
                    _table.TableName = Source.ToString( );
                    _set.Tables.Add( _table );
                    var _adapter = Query.DataAdapter;
                    _adapter.Fill( _set, _table.TableName );
                    SetColumnCaptions( _table );
                    return _table?.Rows?.Count > 0
                        ? _table
                        : default( DataTable );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the data set asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<DataSet> GetDataSetAsync( )
        {
            if( _query != null )
            {
                var _tcs = new TaskCompletionSource<DataSet>( );
                try
                {
                    var _set = new DataSet( $"{_source}" );
                    var _table = new DataTable( $"{_source}" );
                    _table.TableName = _source.ToString( );
                    _set.Tables.Add( _table );
                    var _adapter = _query.DataAdapter;
                    _adapter.Fill( _set, _table.TableName );
                    SetColumnCaptions( _table );
                    _tcs.SetResult( _set );
                    return _set.Tables?.Count > 0
                        ? _tcs.Task
                        : default( Task<DataSet> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Task<DataSet> );
                }
            }

            return default( Task<DataSet> );
        }

        /// <inheritdoc />
        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public void SetColumnCaptions( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    foreach( DataColumn _column in dataTable.Columns )
                    {
                        if( _column != null )
                        {
                            var _caption = _column.ColumnName.SplitPascal( );
                            _column.Caption = _caption;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the fields asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<string>> GetFieldsAsync( )
        {
            var _tcs = new TaskCompletionSource<IList<string>>( );
            try
            {
                var _list = new List<string>( );
                var _table = GetDataTable( );
                foreach( DataColumn _col in _table.Columns )
                {
                    if( _col.DataType == typeof( string ) )
                    {
                        _list.Add( _col.ColumnName );
                    }
                }

                _tcs.SetResult( _list );
                return _list?.Any( ) == true
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the numerics asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<string>> GetNumericsAsync( )
        {
            var _tcs = new TaskCompletionSource<IList<string>>( );
            try
            {
                var _list = new List<string>( );
                var _table = GetDataTable( );
                foreach( DataColumn _col in _table.Columns )
                {
                    if( ( !_col.ColumnName.EndsWith( "Id" )
                           && ( _col.Ordinal > 0 )
                           && ( _col.DataType == typeof( double ) ) )
                       || ( _col.DataType == typeof( short ) )
                       || ( _col.DataType == typeof( long ) )
                       || ( _col.DataType == typeof( decimal ) )
                       || ( _col.DataType == typeof( float ) ) )
                    {
                        _list.Add( _col.ColumnName );
                    }
                }

                _tcs.SetResult( _list );
                return _list?.Any( ) == true
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the dates asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<string>> GetDatesAsync( )
        {
            var _tcs = new TaskCompletionSource<IList<string>>( );
            try
            {
                var _list = new List<string>( );
                var _table = GetDataTable( );
                foreach( DataColumn _col in _table.Columns )
                {
                    if( ( _col.Ordinal > 0 )
                       && ( ( _col.DataType == typeof( DateTime ) )
                           || ( _col.DataType == typeof( DateOnly ) )
                           || ( _col.DataType == typeof( DateTimeOffset ) )
                           || _col.ColumnName.EndsWith( nameof( Day ) )
                           || _col.ColumnName.EndsWith( "Date" ) ) )
                    {
                        _list.Add( _col.ColumnName );
                    }
                }

                _tcs.SetResult( _list );
                return _list?.Any( ) == true
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

        /// <inheritdoc />
        /// <summary>
        /// Gets the primary keys asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task<IList<int>> GetPrimaryKeysAsync( )
        {
            var _tcs = new TaskCompletionSource<IList<int>>( );
            try
            {
                var _table = GetDataTable( );
                var _values = _table?.AsEnumerable( )
                    ?.Select( c => c.Field<int>( 0 ) )
                    ?.Distinct( );

                var _list = _values?.ToList( );
                _tcs.SetResult( _list );
                return _values?.Any( ) == true
                    ? _tcs.Task
                    : default( Task<IList<int>> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Task<IList<int>> );
            }
        }
    }
}
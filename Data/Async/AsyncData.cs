// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 $CREATED_MONTH$-$CREATED_DAY$-$CREATED_YEAR$
//
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        $CURRENT_MONTH$-$CURRENT_DAY$-$CURRENT_YEAR$
// ******************************************************************************************
// <copyright file="AsyncBase.cs" company="Terry D. Eppler">
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
//   AsyncBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    public abstract class AsyncData : AsyncState
    {
        /// <summary> Gets the query asynchronous. </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        /// <returns> </returns>
        public Task<IQuery> GetQueryAsync( SqlStatement sqlStatement )
        {
            if( sqlStatement != null )
            {
                var _tcs = new TaskCompletionSource<IQuery>( );
                try
                {
                    var _query = new Query( sqlStatement );
                    _tcs.SetResult( _query );
                    return _query != null
                        ? _tcs.Task
                        : default( Task<IQuery> );
                }
                catch( Exception _ex )
                {
                    _tcs.SetException( _ex );
                    Fail( _ex );
                    return default( Task<IQuery> );
                }
            }

            return default( Task<IQuery> );
        }

        /// <summary> Gets the ordinals. </summary>
        /// <returns> </returns>
        public Task<IEnumerable<int>> GetOrdinalsAsync( )
        {
            var _tcs = new TaskCompletionSource<IEnumerable<int>>( );
            try
            {
                var _dataTable = GetDataTable( );
                var _columns = _dataTable.Columns;
                var _values = new List<int>( );
                if( _columns?.Count > 0 )
                {
                    foreach( DataColumn _column in _columns )
                    {
                        _values?.Add( _column.Ordinal );
                    }
                }

                _tcs.SetResult( _values );
                return _values?.Any( ) == true
                    ? _tcs.Task
                    : default( Task<IEnumerable<int>> );
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<IEnumerable<int>> );
            }
        }

        /// <summary> Gets the map asynchronous. </summary>
        /// <returns> </returns>
        public Task<IDictionary<string, object>> GetMapAsync( )
        {
            var _tcs = new TaskCompletionSource<IDictionary<string, object>>( );
            try
            {
                var _dataTable = GetDataTable( );
                var _rows = _dataTable.AsEnumerable( );
                var _record = _rows.FirstOrDefault( );
                var _map = _record.ToDictionary( );
                _tcs.SetResult( _map );
                return _map?.Any( ) == true
                    ? _tcs.Task
                    : default( Task<IDictionary<string, object>> );
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<IDictionary<string, object>> );
            }
        }

        /// <summary> Gets the column schema. </summary>
        /// <returns> </returns>
        public Task<IDictionary<string, Type>> GetSchemaAsync( )
        {
            var _tcs = new TaskCompletionSource<IDictionary<string, Type>>( );
            try
            {
                var _dataTable = GetDataTable( );
                var _columns = _dataTable.Columns;
                if( _columns != null )
                {
                    var _schema = new Dictionary<string, Type>( );
                    foreach( DataColumn _col in _columns )
                    {
                        _schema.Add( _col.ColumnName, _col.DataType );
                    }

                    _tcs.SetResult( _schema );
                    return _schema?.Any( ) == true
                        ? _tcs.Task
                        : default( Task<IDictionary<string, Type>> );
                }
                else
                {
                    return default( Task<IDictionary<string, Type>> );
                }
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<IDictionary<string, Type>> );
            }
        }

        /// <summary> Gets the data columns. </summary>
        /// <returns> </returns>
        public Task<IEnumerable<DataColumn>> GetColumnsAsync( )
        {
            var _tcs = new TaskCompletionSource<IEnumerable<DataColumn>>( );
            try
            {
                var _data = GetDataTable( );
                if( _data != null )
                {
                    var _dataColumns = new List<DataColumn>( );
                    foreach( DataColumn _column in _data?.Columns )
                    {
                        if( _column != null )
                        {
                            _dataColumns.Add( _column );
                        }
                    }

                    _tcs.SetResult( _dataColumns );
                    return _dataColumns?.Any( ) == true
                        ? _tcs.Task
                        : default( Task<IEnumerable<DataColumn>> );
                }
                else
                {
                    return default( Task<IEnumerable<DataColumn>> );
                }
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<IEnumerable<DataColumn>> );
            }
        }

        /// <summary> Gets the column names. </summary>
        /// <returns> </returns>
        public Task<IEnumerable<string>> GetNamesAsync( )
        {
            if( DataTable?.Result != null )
            {
                var _tcs = new TaskCompletionSource<IEnumerable<string>>( );
                try
                {
                    var _dataTable = GetDataTable( );
                    var _columns = _dataTable.Columns;
                    if( _columns?.Count > 0 )
                    {
                        var _names = new List<string>( );
                        foreach( DataColumn _column in _columns )
                        {
                            if( !string.IsNullOrEmpty( _column?.ColumnName ) )
                            {
                                _names.Add( _column.ColumnName );
                            }
                        }

                        return _names?.Any( ) == true
                            ? _tcs.Task
                            : default( Task<IEnumerable<string>> );
                    }
                    else
                    {
                        return default( Task<IEnumerable<string>> );
                    }
                }
                catch( Exception _ex )
                {
                    _tcs.SetException( _ex );
                    Fail( _ex );
                    return default( Task<IEnumerable<string>> );
                }
            }

            return default( Task<IEnumerable<string>> );
        }
    }
}
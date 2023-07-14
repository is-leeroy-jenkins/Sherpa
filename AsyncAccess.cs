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
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class AsyncAccess : ISource, IProvider
    {
        /// <summary>
        /// The busy
        /// </summary>
        private protected bool _busy;

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        public IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets or sets the map.
        /// </summary>
        /// <value>
        /// The map.
        /// </value>
        public IDictionary<string, object> Map { get; set; }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        /// <value>
        /// The query.
        /// </value>
        public IQuery Query { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public Task<DataTable> DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data columns.
        /// </summary>
        /// <value>
        /// The data columns.
        /// </value>
        public Task<IEnumerable<DataColumn>> DataColumns { get; set; }

        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public Task<IEnumerable<string>> ColumnNames { get; set; }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        public Task<IList<int>> Keys { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public Task<IList<string>> Fields { get; set; }

        /// <summary>
        /// Gets or sets the dates.
        /// </summary>
        /// <value>
        /// The dates.
        /// </value>
        public Task<IList<string>> Dates { get; set; }

        /// <summary>
        /// Gets or sets the numeric fields.
        /// </summary>
        /// <value>
        /// The numeric fields.
        /// </value>
        public Task<IList<string>> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        public DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the name of the data set.
        /// </summary>
        /// <value>
        /// The name of the data set.
        /// </value>
        public string DataSetName { get; set; }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        private protected DataTable GetDataTable( )
        {
            if( Query != null )
            {
                try
                {
                    _busy = true;
                    DataSet = new DataSet( $"{Provider}" );
                    var _dataTable = new DataTable( $"{Source}" );
                    _dataTable.TableName = Source.ToString( );
                    DataSet.Tables.Add(_dataTable );
                    var _adapter = Query.DataAdapter;
                    _adapter.Fill( DataSet, _dataTable.TableName );
                    SetColumnCaptions( _dataTable);
                    _busy = false;
                    return _dataTable?.Rows?.Count > 0
                        ? _dataTable
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

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<DataRow>> GetDataAsync( )
        {
            var _tcs = new TaskCompletionSource<IEnumerable<DataRow>>( );
            try
            {
                _busy = true;
                var _dataTable = GetDataTable( );
                var _data = _dataTable?.AsEnumerable( );
                _tcs.SetResult( _data );
                _busy = false;
                return _tcs.Task;
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<IEnumerable<DataRow>> );
            }
        }

        /// <summary>
        /// Gets the table asynchronous.
        /// </summary>
        /// <returns></returns>
        private protected Task<DataTable> GetTableAsync( )
        {
            if( Query != null )
            {
                var _tcs = new TaskCompletionSource<DataTable>( );
                try
                {
                    _busy = true;
                    var _dataTable = new DataTable( $"{Source}" );
                    _dataTable.TableName = Source.ToString( );
                    DataSet.Tables.Add( _dataTable );
                    var _adapter = Query.DataAdapter;
                    _adapter.Fill( DataSet, _dataTable.TableName );
                    SetColumnCaptions( _dataTable );
                    _tcs.SetResult( _dataTable );
                    _busy = false;
                    return _tcs.Task;
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

        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        private protected void SetColumnCaptions( DataTable dataTable )
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

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns></returns>
        private protected Task<IList<string>> GetFieldsAsync( )
        {
            if( DataTable != null )
            {
                var _tcs = new TaskCompletionSource<IList<string>>( );
                try
                {
                    var _fields = new List<string>( );
                    foreach( DataColumn _col in DataTable.Result.Columns )
                    {
                        if( _col.DataType == typeof( string ) )
                        {
                            _fields.Add( _col.ColumnName );
                        }
                    }

                    _tcs.SetResult( _fields );
                    return _fields?.Any( ) == true
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

        /// <summary>
        /// Gets the numerics.
        /// </summary>
        /// <returns></returns>
        private protected Task<IList<string>> GetNumericsAsync( )
        {
            if( DataTable != null )
            {
                var _tcs = new TaskCompletionSource<IList<string>>( );
                try
                {
                    var _numerics = new List<string>( );
                    foreach( DataColumn _col in DataTable.Result.Columns )
                    {
                        if( ( !_col.ColumnName.EndsWith( "Id" )
                               && ( _col.Ordinal > 0 )
                               && ( _col.DataType == typeof( double ) ) )
                           || ( _col.DataType == typeof( short ) )
                           || ( _col.DataType == typeof( long ) )
                           || ( _col.DataType == typeof( decimal ) )
                           || ( _col.DataType == typeof( float ) ) )
                        {
                            _numerics.Add( _col.ColumnName );
                        }
                    }

                    _tcs.SetResult( _numerics );
                    return _numerics?.Any( ) == true
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

        /// <summary>
        /// Gets the dates.
        /// </summary>
        /// <returns></returns>
        private protected Task<IList<string>> GetDatesAsync( )
        {
            if( DataTable != null )
            {
                var _tcs = new TaskCompletionSource<IList<string>>( );
                try
                {
                    var _dates = new List<string>( );
                    foreach( DataColumn _col in DataTable.Result.Columns )
                    {
                        if( ( _col.Ordinal > 0 )
                           && ( ( _col.DataType == typeof( DateTime ) )
                               || ( _col.DataType == typeof( DateOnly ) )
                               || ( _col.DataType == typeof( DateTimeOffset ) )
                               || _col.ColumnName.EndsWith( "Day" )
                               || _col.ColumnName.EndsWith( "Date" ) ) )
                        {
                            _dates.Add( _col.ColumnName );
                        }
                    }

                    _tcs.SetResult( _dates );
                    return _dates?.Any( ) == true
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

        /// <summary>
        /// Gets the primary keys.
        /// </summary>
        /// <returns></returns>
        private protected Task<IList<int>> GetPrimaryKeysAsync( )
        {
            if( DataTable != null )
            {
                var _tcs = new TaskCompletionSource<IList<int>>( );
                try
                {
                    var _values = DataTable.Result.GetIndexValues( );
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

            return default( Task<IList<int>> );
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
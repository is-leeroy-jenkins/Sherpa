﻿//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                DataAccess.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DataAccess.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    DataAccess.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Diagnostics;
    using DataTable = System.Data.DataTable;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class DataAccess : ISource, IProvider
    {
        /// <summary>
        /// The busy
        /// </summary>
        private protected bool _busy;

        /// <summary>
        /// The duration
        /// </summary>
        private protected TimeSpan _duration;

        /// <summary>
        /// The data set
        /// </summary>
        private protected DataSet _dataSet;

        /// <summary>
        /// The data table
        /// </summary>
        private protected DataTable _dataTable;

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
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public TimeSpan Duration { get; set; }

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
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data columns.
        /// </summary>
        /// <value>
        /// The data columns.
        /// </value>
        public IEnumerable<DataColumn> DataColumns { get; set; }

        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public IEnumerable<string> ColumnNames { get; set; }

        /// <summary>
        /// Gets or sets the keys.
        /// </summary>
        /// <value>
        /// The keys.
        /// </value>
        public IList<int> Keys { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

        /// <summary>
        /// Gets or sets the dates.
        /// </summary>
        /// <value>
        /// The dates.
        /// </value>
        public IList<string> Dates { get; set; }

        /// <summary>
        /// Gets or sets the numeric fields.
        /// </summary>
        /// <value>
        /// The numeric fields.
        /// </value>
        public IList<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        public DataSet DataSet { get; set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataRow> GetData( )
        {
            try
            {
                var _table = GetDataTable( );
                var _data = _table?.AsEnumerable( );
                return _data?.Any( ) == true
                    ? _data
                    : default( IEnumerable<DataRow> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<DataRow> );
            }
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns></returns>
        private protected DataTable GetDataTable( )
        {
            try
            {
                var _clock = Stopwatch.StartNew( );
                ThrowIf.NullOrEmpty( SqlStatement, "SqlStatement" );
                _dataSet = new DataSet( $"{Provider}" );
                _dataTable = new DataTable( $"{Source}" );
                _dataTable.TableName = Source.ToString( );
                _dataSet.Tables.Add( _dataTable );
                var _query = new Query( SqlStatement );
                var _adapter = _query.DataAdapter;
                _adapter.Fill( _dataSet, _dataTable.TableName );
                SetColumnCaptions( _dataTable );
                _duration = _clock.Elapsed;
                return _dataTable?.Rows?.Count > 0
                    ? _dataTable
                    : default( DataTable );
            }
            catch( ArgumentNullException _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Gets the table asynchronous.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected Task<DataTable> GetTableAsync( )
        {
            ThrowIf.NullOrEmpty( SqlStatement, "SqlStatement" );
            var _tcs = new TaskCompletionSource<DataTable>( );
            try
            {
                var _clock = Stopwatch.StartNew( );
                _dataSet = new DataSet( $"{Provider}" );
                _dataTable = new DataTable( $"{Source}" );
                _dataTable.TableName = Source.ToString( );
                _dataSet.Tables.Add( _dataTable );
                var _query = new Query( SqlStatement );
                var _adapter = _query.DataAdapter;
                _adapter.Fill( _dataSet, _dataTable.TableName );
                SetColumnCaptions( _dataTable );
                _tcs.SetResult( _dataTable );
                _duration = _clock.Elapsed;
                return _tcs?.Task;
            }
            catch( Exception _ex )
            {
                _tcs.SetException( _ex );
                Fail( _ex );
                return default( Task<DataTable> );
            }
        }

        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.
        /// </param>
        private protected void SetColumnCaptions( DataTable dataTable )
        {
            try
            {
                ThrowIf.NullOrEmpty( dataTable, dataTable.TableName );
                foreach( DataColumn _column in dataTable?.Columns )
                {
                    if( _column != null )
                    {
                        var _caption = _column.ColumnName.SplitPascal( );
                        _column.Caption = _caption;
                    }
                }
            }
            catch( ArgumentException _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetFields( )
        {
            try
            {
                ThrowIf.NullOrEmpty( _dataTable, _dataTable.TableName );
                var _fields = new List<string>( );
                foreach( DataColumn _col in _dataTable.Columns )
                {
                    if( _col.DataType == typeof( string ) )
                    {
                        _fields.Add( _col.ColumnName );
                    }
                }

                return _fields?.Any( ) == true
                    ? _fields
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the numerics.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetNumerics( )
        {
            try
            {
                ThrowIf.NullOrEmpty( _dataTable, _dataTable.TableName );
                var _numerics = new List<string>( );
                foreach( DataColumn _col in _dataTable.Columns )
                {
                    if( ( !_col.ColumnName.EndsWith( "Id" )
                           && _col.Ordinal > 0
                           && _col.DataType == typeof( double ) )
                       || _col.DataType == typeof( short )
                       || _col.DataType == typeof( long )
                       || _col.DataType == typeof( decimal )
                       || _col.DataType == typeof( float ) )
                    {
                        _numerics.Add( _col.ColumnName );
                    }
                }

                return _numerics?.Any( ) == true
                    ? _numerics
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the dates.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetDates( )
        {
            try
            {
                ThrowIf.NullOrEmpty( _dataTable, _dataTable.TableName );
                var _dates = new List<string>( );
                foreach( DataColumn _col in _dataTable.Columns )
                {
                    if( _col.Ordinal > 0
                       && ( _col.DataType == typeof( DateTime )
                           || _col.DataType == typeof( DateOnly )
                           || _col.DataType == typeof( DateTimeOffset )
                           || _col.ColumnName.EndsWith( "Day" )
                           || _col.ColumnName.EndsWith( "Date" ) ) )
                    {
                        _dates.Add( _col.ColumnName );
                    }
                }

                return _dates?.Any( ) == true
                    ? _dates
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the primary keys.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected IList<int> GetPrimaryKeys( )
        {
            try
            {
                ThrowIf.NullOrEmpty( _dataTable, _dataTable.TableName );
                var _values = _dataTable.GetIndexValues( );
                return _values?.Any( ) == true
                    ? _values.ToList( )
                    : default( IList<int> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<int> );
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
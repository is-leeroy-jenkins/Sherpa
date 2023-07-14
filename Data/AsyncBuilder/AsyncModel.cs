﻿// ******************************************************************************************
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
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AsyncModel : AsyncBase
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets the data elements.
        /// </summary>
        /// <value>
        /// The data elements.
        /// </value>
        public Task<IDictionary<string, IEnumerable<string>>> DataElements { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is busy; otherwise, <c>false</c>.
        /// </value>
        public bool IsBusy
        {
            get { return _busy; }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        public AsyncModel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public AsyncModel( Source source, Provider provider = Provider.Access )
        {
            BeginInit( );
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, SQL.SELECTALL );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataElements = CreateSeriesAsync( DataTable );
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        public AsyncModel( Source source, Provider provider, IDictionary<string, object> where )
        {
            BeginInit( );
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, where );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public AsyncModel( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            BeginInit( );
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public AsyncModel( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            BeginInit( );
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public AsyncModel( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> where, SQL commandType )
        {
            BeginInit( );
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, fields, numerics, where,
                commandType );

            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="where">The where.</param>
        public AsyncModel( Source source, IDictionary<string, object> where )
        {
            BeginInit( );
            Source = source;
            Provider = Provider.Access;
            ConnectionFactory = new ConnectionFactory( source, Provider.Access );
            SqlStatement = new SqlStatement( source, Provider.Access, where );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public AsyncModel( Source source, Provider provider, string sqlText )
        {
            BeginInit( );
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, sqlText );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Keys = GetPrimaryKeysAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public AsyncModel( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            BeginInit( );
            ConnectionFactory = new ConnectionFactory( fullPath );
            Source = ConnectionFactory.Source;
            Provider = ConnectionFactory.Provider;
            SqlStatement = new SqlStatement( Source, Provider, sqlText, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncModel"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public AsyncModel( IQuery query )
        {
            BeginInit( );
            Query = query;
            Source = query.Source;
            Provider = query.Provider;
            ConnectionFactory = query.ConnectionFactory;
            SqlStatement = query.SqlStatement;
            DataTable = GetTableAsync( );
            DataSetName = DataSet.DataSetName;
            TableName = SqlStatement.TableName;
            DataColumns = GetColumnsAsync( );
            ColumnNames = GetColumnNamesAsync( );
            Keys = GetPrimaryKeysAsync( );
            Fields = GetFieldsAsync( );
            Numerics = GetNumericsAsync( );
            Dates = GetDatesAsync( );
            DataElements = CreateSeriesAsync( DataTable );
            Record = GetDataAsync( )?.Result.FirstOrDefault( );
            Map = Record?.ToDictionary( );
            EndInit( );
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        private IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string column )
        {
            if( ( dataRows?.Any( ) == true )
               && !string.IsNullOrEmpty( column ) )
            {
                try
                {
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

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string name,
            string value )
        {
            if( ( dataRows?.Any( ) == true )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
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

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the values asynchronous.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public Task<IEnumerable<string>> GetValuesAsync( IEnumerable<DataRow> dataRows, string name,
            string value )
        {
            if( ( dataRows?.Any( ) == true )
               && !string.IsNullOrEmpty( value ) )
            {
                var _tcs = new TaskCompletionSource<IEnumerable<string>>( );
                try
                {
                    var _query = dataRows
                        ?.Where( v => v.Field<string>( $"{name}" ).Equals( value ) )
                        ?.Select( v => v.Field<string>( $"{name}" ) )
                        ?.Distinct( );

                    _tcs.SetResult( _query );
                    return _query?.Any( ) == true
                        ? _tcs.Task
                        : default( Task<IEnumerable<string>> );
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

        /// <summary>
        /// Creates the series asynchronous.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <returns></returns>
        private Task<IDictionary<string, IEnumerable<string>>> CreateSeriesAsync( Task<DataTable> dataTable )
        {
            if( dataTable != null )
            {
                var _tcs = new TaskCompletionSource<IDictionary<string, IEnumerable<string>>>( );
                try
                {
                    var _dict = new Dictionary<string, IEnumerable<string>>( );
                    var _columns = dataTable?.Result.Columns;
                    var _rows = dataTable?.Result.AsEnumerable( );
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

            return default( Task<IDictionary<string, IEnumerable<string>>> );
        }
    }
}
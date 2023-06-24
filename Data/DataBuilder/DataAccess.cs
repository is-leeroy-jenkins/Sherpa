// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataConfig.cs" company="Terry D. Eppler">
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
//   DataConfig.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public abstract class DataAccess : ISource, IProvider
    {
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
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataRow> GetData( )
        {
            try
            {
                var _dataTable = GetDataTable( );
                var _data = _dataTable?.AsEnumerable( );
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
            if( Query != null )
            {
                try
                {
                    DataSet = new DataSet( $"{Provider}" );
                    DataTable = new DataTable( $"{Source}" );
                    DataTable.TableName = Source.ToString( );
                    DataSet.Tables.Add( DataTable );
                    var _adapter = Query.DataAdapter;
                    _adapter.Fill( DataSet, DataTable.TableName );
                    SetColumnCaptions( DataTable );
                    return DataTable?.Rows?.Count > 0
                        ? DataTable
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
        private protected IList<string> GetFields( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _fields = new List<string>( );
                    foreach( DataColumn _col in DataTable.Columns )
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

            return default( IList<string> );
        }

        /// <summary>
        /// Gets the numerics.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetNumerics( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _numerics = new List<string>( );
                    foreach( DataColumn _col in DataTable.Columns )
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

            return default( IList<string> );
        }

        /// <summary>
        /// Gets the dates.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetDates( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _dates = new List<string>( );
                    foreach( DataColumn _col in DataTable.Columns )
                    {
                        if( ( _col.Ordinal > 0 )
                           && ( ( _col.DataType == typeof( DateTime ) ) 
                               || ( _col.DataType == typeof( DateOnly ) ) 
                               || ( _col.DataType == typeof( DateTimeOffset ) ) 
                               || ( _col.ColumnName.EndsWith( "Day" ) )   
                               || ( _col.ColumnName.EndsWith( "Date" ) ) ) )
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

            return default( IList<string> );
        }

        /// <summary>
        /// Gets the primary keys.
        /// </summary>
        /// <returns></returns>
        private protected IList<int> GetPrimaryKeys( )
        {
            if( DataTable != null )
            {
                try
                {
                    var _values = DataTable.GetIndexValues( );
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

            return default( IList<int> );
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
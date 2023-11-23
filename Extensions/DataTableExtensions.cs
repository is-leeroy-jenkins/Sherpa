// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataTableExtensions.cs" company="Terry D. Eppler">
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
//   DataTableExtensions.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Configuration;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using System.Xml.Linq;
    using OfficeOpenXml;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeRedundantParentheses" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "ReturnTypeCanBeEnumerable.Global" ) ]
    public static class DataTableExtensions
    {
        /// <summary> The connection string </summary>
        public static readonly ConnectionStringSettingsCollection Connection =
            ConfigurationManager.ConnectionStrings;

        /// <summary> Converts to xml. </summary>
        /// <param name="dataTable"> The dataTable. </param>
        /// <param name="rootName"> The rootName. </param>
        /// <returns> </returns>
        public static XDocument ToXml( this DataTable dataTable, string rootName )
        {
            try
            {
                var _xml = new XDocument { Declaration = new XDeclaration( "1.0", "utf-8", "" ) };
                _xml.Add( new XElement( rootName ) );
                foreach( DataRow _dataRow in dataTable.Rows )
                {
                    var _element = new XElement( dataTable.TableName );
                    for( var _i = 0; _i < dataTable.Columns.Count; _i++ )
                    {
                        var _col = dataTable.Columns[ _i ];
                        var _row = _dataRow?[ _col ]?.ToString( )?.Trim( ' ' );
                        var _node = new XElement( _col.ColumnName, _row );
                        _element.Add( new XElement( _node ) );
                    }

                    _xml.Root?.Add( _element );
                }

                return _xml;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( XDocument );
            }
        }

        /// <summary> Converts to excel. </summary>
        /// <param name="dataTable"> The dataTable. </param>
        /// <param name="filePath"> The filePath. </param>
        /// <exception cref="Exception">
        /// OSExportToExcelFile: Null or empty input datatable!\n or OSExportToExcelFile: Excel file could not
        /// be saved.\n" + ex.Message
        /// </exception>
        public static void ToExcel( this DataTable dataTable, string filePath = null )
        {
            try
            {
                if( dataTable == null )
                {
                    throw new Exception( "Null or empty input datatable!\n" );
                }

                var _excel = new ExcelPackage( );
                var _worksheet = _excel?.Workbook?.Worksheets[ 0 ];
                for( var _i = 0; _i < dataTable?.Columns?.Count; _i++ )
                {
                    if( ( _worksheet != null )
                       && !string.IsNullOrEmpty( dataTable.Columns[ _i ]?.ColumnName ) )
                    {
                        _worksheet.Cells[ 1, _i + 1 ].Value = dataTable.Columns[ _i ]?.ColumnName;
                    }
                }

                for( var _i = 0; _i < dataTable.Rows?.Count; _i++ )
                {
                    for( var _j = 0; _j < dataTable.Columns?.Count; _j++ )
                    {
                        if( _worksheet != null )
                        {
                            _worksheet.Cells[ _i + 2, _j + 1 ].Value = dataTable.Rows[ _i ][ _j ];
                        }
                    }
                }

                if( !string.IsNullOrEmpty( filePath ) )
                {
                    try
                    {
                        _excel.Save( filePath );
                        MessageBox.Show( "Excel file saved!" );
                    }
                    catch( Exception _ex )
                    {
                        throw new Exception( "Excel file could not be saved.\n" + _ex.Message );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> From excel. </summary>
        /// <param name="dataTable"> The dataTable. </param>
        /// <param name="filePath"> The filePath. </param>
        /// <param name="sheetName"> The sheetName. </param>
        /// <returns> </returns>
        public static DataTable FromExcel( this DataTable dataTable, string filePath,
                                           string sheetName )
        {
            if( !string.IsNullOrEmpty( filePath )
               && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    var _connectionString = Connection[ "Excel" ].ConnectionString;

                    var _sql = "SELECT * FROM [" + sheetName + "$]";
                    using var _adapter = new OleDbDataAdapter( _sql, _connectionString );
                    var _table = new DataTable( );
                    _table.TableName = sheetName;
                    _adapter?.FillSchema( _table, System.Data.SchemaType.Source );
                    _adapter.Fill( _table, _table.TableName );
                    return _table;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary> Determines whether [has numeric column]. </summary>
        /// <param name="dataTable"> The dataTable. </param>
        /// <returns>
        /// <c> true </c>
        /// if [has numeric column] [the specified dataTable]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        public static bool HasNumericColumn( this DataTable dataTable )
        {
            try
            {
                if( dataTable?.Rows?.Count > 0 )
                {
                    foreach( DataColumn _col in dataTable.Columns )
                    {
                        if( ( _col?.Ordinal > 0 )
                           && !_col.ColumnName.EndsWith( "Id" )
                           && ( _col.DataType == typeof( double )
                               | _col.DataType == typeof( decimal )
                               | _col.DataType == typeof( float )
                               | _col.DataType == typeof( int ) ) )
                        {
                            return true;
                        }
                    }

                    return false;
                }

                return false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return false;
            }
        }

        /// <summary> Gets the primary key values. </summary>
        /// <param name="dataTable"> The dataTable. </param>
        /// <returns> </returns>
        public static IEnumerable<int> GetIndexValues( this DataTable dataTable )
        {
            try
            {
                if( dataTable?.Rows?.Count > 0 )
                {
                    var _list = new List<int>( );
                    foreach( DataColumn _col in dataTable.Columns )
                    {
                        for( var _i = 0; _i < dataTable.Rows.Count; _i++ )
                        {
                            if( ( _col.DataType == typeof( int ) )
                               && ( _col.Ordinal == 0 ) )
                            {
                                var _row = dataTable.Rows[ _i ];
                                var _value = _row[ _col.ColumnName ]?.ToString( );
                                if( !string.IsNullOrEmpty( _value ) )
                                {
                                    var _index = int.Parse( _value );
                                    _list.Add( _index );
                                }
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( IEnumerable<int> );
                }

                return default( IEnumerable<int> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<int> );
            }
        }

        /// <summary> Gets the primary key values. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <param name="where"> The dictionary. </param>
        /// <returns> </returns>
        public static IEnumerable<int> GetIndexValues( this DataTable dataTable,
                                                       IDictionary<string, object> where )
        {
            try
            {
                if( ( dataTable?.Rows?.Count > 0 )
                   && ( where?.Any( ) == true ) )
                {
                    var _list = new List<int>( );
                    var _criteria = where.ToCriteria( );
                    if( !string.IsNullOrEmpty( _criteria ) )
                    {
                        var _filtered = dataTable.Select( _criteria );
                        if( _filtered?.Any( ) == true )
                        {
                            foreach( var _row in _filtered )
                            {
                                var _item = _row?.ItemArray[ 0 ];
                                var _value = _item?.ToString( );
                                var _index = int.Parse( _value );
                                _list.Add( _index );
                            }
                        }
                    }

                    return ( _list?.Any( ) == true )
                        ? _list
                        : default( IEnumerable<int> );
                }

                return default( IEnumerable<int> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<int> );
            }
        }

        /// <summary> Gets the unique values. </summary>
        /// <param name="dataTable"> The dataTable. </param>
        /// <param name="columnName"> The column. </param>
        /// <returns> </returns>
        public static string[ ] GetUniqueColumnValues( this DataTable dataTable, string columnName )
        {
            if( !string.IsNullOrEmpty( columnName )
               && ( dataTable?.Columns?.Contains( columnName ) == true ) )
            {
                try
                {
                    var _enumerable = dataTable?.AsEnumerable( )
                        ?.Select( p => p.Field<string>( columnName ) )
                        ?.Distinct( );

                    return ( _enumerable?.Any( ) == true )
                        ? _enumerable?.ToArray( )
                        : default( string[ ] );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( string[ ] );
                }
            }

            return default( string[ ] );
        }

        /// <summary> Gets the unique column values. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <param name="columnName"> Name of the column. </param>
        /// <param name="where"> The where. </param>
        /// <returns> </returns>
        public static string[ ] GetUniqueColumnValues( this DataTable dataTable, string columnName,
                                                       IDictionary<string, object> where )
        {
            if( !string.IsNullOrEmpty( columnName )
               && ( dataTable?.Columns?.Contains( columnName ) == true )
               && ( where?.Any( ) == true ) )
            {
                try
                {
                    var _criteria = where.ToCriteria( );
                    var _query = dataTable.Select( _criteria )
                        ?.Select( p => p.Field<string>( columnName ) )
                        ?.Distinct( );

                    return ( _query?.Any( ) == true )
                        ? _query?.ToArray( )
                        : default( string[ ] );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( string[ ] );
                }
            }

            return default( string[ ] );
        }

        /// <summary> Gets the chart points. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <returns> </returns>
        public static IList<DataPoint> GetChartPoints( this DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _points = new List<DataPoint>( );
                    var _names = new List<string>( );
                    var _values = new List<double>( );
                    foreach( DataColumn _col in dataTable.Columns )
                    {
                        if( ( _col.Ordinal > 1 )
                           && ( _col.DataType == typeof( decimal )
                               | _col.DataType == typeof( float )
                               | _col.DataType == typeof( double )
                               | _col.DataType == typeof( int ) ) )
                        {
                            _names.Add( _col.ColumnName );
                        }
                    }

                    for( var _index = 0; _index < dataTable.Rows.Count; _index++ )
                    {
                        var _row = dataTable.Rows[ _index ];
                        var _point = new DataPoint( );
                        _point.XValue = _index;
                        foreach( var _name in _names )
                        {
                            var _val = double.Parse( _row[ _name ]?.ToString( ) );
                            _values.Add( _val );
                        }

                        var _range = _values.ToArray( );
                        _point.YValues = _range;
                        _points.Add( _point );
                    }

                    return _points?.Any( ) == true
                        ? _points
                        : default( IList<DataPoint> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<DataPoint> );
                }
            }

            return default( IList<DataPoint> );
        }

        /// <summary> Filters the specified dictionary. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <param name="dict"> The dictionary. </param>
        /// <returns> </returns>
        public static IEnumerable<DataRow> Filter( this DataTable dataTable,
                                                   IDictionary<string, object> dict )
        {
            if( ( dataTable?.Columns?.Count > 0 )
               && ( dict?.Any( ) == true ) )
            {
                try
                {
                    var _query = dataTable?.Select( dict.ToCriteria( ) )?.ToList( );
                    return ( _query?.Any( ) == true )
                        ? _query
                        : default( IEnumerable<DataRow> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary> Gets the column names. </summary>
        /// <param name="dataTable"> The dataTable. </param>
        /// <returns> </returns>
        public static string[ ] GetColumnNames( this DataTable dataTable )
        {
            try
            {
                var _fields = new string[ dataTable.Columns.Count ];
                for( var _i = 0; _i < dataTable.Columns.Count; _i++ )
                {
                    _fields[ _i ] = dataTable.Columns[ _i ].ColumnName;
                }

                var _names = _fields?.OrderBy( f => f.IndexOf( f ) )?.Select( f => f )?.ToArray( );
                return ( _names?.Any( ) == true )
                    ? _names
                    : default( string[ ] );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string[ ] );
            }
        }

        /// <summary> Gets the chart points. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <returns> </returns>
        public static IList<DataColumn> GetNumericColumns( this DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _columns = new List<DataColumn>( );
                    foreach( DataColumn _col in dataTable.Columns )
                    {
                        if( !_col.ColumnName.EndsWith( "Id" )
                           && ( _col.DataType == typeof( decimal )
                               | _col.DataType == typeof( float )
                               | _col.DataType == typeof( double )
                               | _col.DataType == typeof( int ) ) )
                        {
                            _columns.Add( _col );
                        }
                    }

                    return _columns?.Any( ) == true
                        ? _columns
                        : default( IList<DataColumn> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<DataColumn> );
                }
            }

            return default( IList<DataColumn> );
        }

        /// <summary> Gets the date columns. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <returns> </returns>
        public static IList<DataColumn> GetDateColumns( this DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _columns = new List<DataColumn>( );
                    foreach( DataColumn _col in dataTable.Columns )
                    {
                        if( _col.ColumnName.EndsWith( "Date" )
                           || ( _col.DataType == typeof( DateTime )
                               | _col.DataType == typeof( DateOnly )
                               | _col.DataType == typeof( DateTimeOffset ) ) )
                        {
                            _columns.Add( _col );
                        }
                    }

                    return _columns?.Any( ) == true
                        ? _columns
                        : default( IList<DataColumn> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<DataColumn> );
                }
            }

            return default( IList<DataColumn> );
        }

        /// <summary> Removes a DataColumn from the table </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <param name="columnName"> The column name. </param>
        public static void RemoveColumn( this DataTable dataTable, string columnName )
        {
            if( ( dataTable != null )
               && !string.IsNullOrEmpty( columnName )
               && dataTable.Columns.Contains( columnName ) )
            {
                try
                {
                    var _index = dataTable.Columns.IndexOf( columnName );
                    dataTable.Columns.RemoveAt( _index );
                    dataTable.AcceptChanges( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Converts to bindinglist. </summary>
        /// <param name="dataTable"> The data table. </param>
        /// <returns> </returns>
        public static BindingList<DataRow> ToBindingList( this DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _bindingList = new BindingList<DataRow>( );
                    foreach( DataRow _row in dataTable.Rows )
                    {
                        _bindingList.Add( _row );
                    }

                    return ( _bindingList?.Any( ) == true )
                        ? _bindingList
                        : default( BindingList<DataRow> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( BindingList<DataRow> );
                }
            }

            return default( BindingList<DataRow> );
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
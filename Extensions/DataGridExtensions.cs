// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataGridExtensions.cs" company="Terry D. Eppler">
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
//   DataGridExtensions.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public static class DataGridExtensions
    {
        /// <summary>
        /// The GetDataTable
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <returns>
        /// The
        /// <see cref="DataTable" />
        /// </returns>
        public static DataTable GetDataTable( this DataGridView dataGridView )
        {
            try
            {
                var _dataTable = new DataTable( );
                for( var _i = 0; _i < dataGridView.Columns.Count; _i++ )
                {
                    var _gridColumn = dataGridView.Columns[ _i ];
                    var _dataColumn = new DataColumn( );
                    _dataColumn.ColumnName = _gridColumn.Name;
                    _dataColumn.DataType = _gridColumn.ValueType;
                    _dataTable.Columns.Add( _dataColumn );
                }

                for( var _j = 0; _j < dataGridView.Rows.Count; _j++ )
                {
                    var _gridRow = dataGridView.Rows[ _j ];
                    var _values = new object[ _gridRow.Cells.Count ];
                    for( var _k = 0; _k < _values.Length; _k++ )
                    {
                        _values[ _k ] = _gridRow.Cells[ _k ].Value;
                    }

                    _dataTable.Rows.Add( _values );
                }

                return ( _dataTable?.Columns?.Count > 0 ) && ( _dataTable?.Rows?.Count > 0 )
                    ? _dataTable
                    : default( DataTable );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// The SetColumns
        /// </summary>
        /// <param name="dataGridView">The dataGridView</param>
        /// <param name="columns">The fields
        /// <see><cref> string[] </cref></see></param>
        /// <returns>
        /// The
        /// <see cref="DataTable" />
        /// </returns>
        public static DataTable SetColumns( this DataGridView dataGridView, string[ ] columns )
        {
            if( ( dataGridView?.DataSource != null )
               && ( columns?.Length > 0 ) )
            {
                try
                {
                    var _grid = dataGridView.GetDataTable( );
                    if( _grid != null )
                    {
                        var _view = new System.Data.DataView( _grid );
                        if( _grid?.Columns.Count > 0 )
                        {
                            var _table = _view.ToTable( true, columns );
                            return _table?.Columns?.Count > 0
                                ? _table
                                : default( DataTable );
                        }
                    }
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
        /// The SetColumns
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <param name="index">The index
        /// <see /></param>
        /// <returns>
        /// The
        /// <see cref="DataTable" />
        /// </returns>
        public static DataTable SetColumns( this DataGridView dataGridView, int[ ] index )
        {
            try
            {
                using var _dataTable = dataGridView?.GetDataTable( );
                if( ( _dataTable?.Columns?.Count > 0 )
                   && ( index?.Length > 0 ) )
                {
                    var _columns = _dataTable.Columns;
                    var _names = new string[ index.Length ];
                    if( ( _columns?.Count > 0 )
                       && ( _names?.Length > 0 ) )
                    {
                        for( var _i = 0; _i < index.Length; _i++ )
                        {
                            _names[ _i ] = _columns[ index[ _i ] ].ColumnName;
                        }
                    }

                    using var _view = new System.Data.DataView( _dataTable );
                    var _table = _view?.ToTable( true, _names );
                    return _table.Columns.Count > 0
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
        /// The CommaDelimitedRows
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <returns>
        /// The
        /// <see />
        /// </returns>
        public static string[ ] CommaDelimitedRows( this DataGridView dataGridView )
        {
            if( dataGridView?.RowCount > 0 )
            {
                try
                {
                    var _list = new List<string>( );
                    foreach( var _row in dataGridView.Rows )
                    {
                        if( !( (DataGridViewRow) _row )?.IsNewRow == true )
                        {
                            var _cells = ( (DataGridViewRow) _row )?.Cells
                                ?.Cast<DataGridViewCell>( )
                                ?.ToArray( );

                            var _array = ( (DataGridViewRow) _row )?.Cells
                                ?.Cast<DataGridViewCell>( )
                                ?.ToArray( );

                            if( _cells?.Any( ) == true )
                            {
                                var _item = string.Join( ",",
                                    Array.ConvertAll( _array, c => c.Value?.ToString( ) ) );

                                if( !string.IsNullOrEmpty( _item ) )
                                {
                                    _list?.Add( _item );
                                }
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list.ToArray( )
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

        /// <summary>
        /// The ExportToCommaDelimitedFile
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <param name="fileName">The fileName
        /// <see cref="string" /></param>
        public static void ExportToCommaDelimitedFile( this DataGridView dataGridView,
                                                       string fileName )
        {
            if( !string.IsNullOrEmpty( fileName )
               && ( dataGridView != null ) )
            {
                try
                {
                    var _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    if( !string.IsNullOrEmpty( _baseDirectory ) )
                    {
                        var _path = Path.Combine( _baseDirectory, fileName );
                        if( !string.IsNullOrEmpty( _path ) )
                        {
                            File.WriteAllLines( _path, dataGridView.CommaDelimitedRows( ) );
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
        /// The ExpandColumns
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        public static void ExpandColumns( this DataGridView dataGridView )
        {
            try
            {
                foreach( DataGridViewColumn _column in dataGridView.Columns )
                {
                    _column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// The PascalizeHeaders
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <param name="dataTable">The dataTable
        /// <see cref="DataTable" /></param>
        public static void PascalizeHeaders( this DataGridView dataGridView, DataTable dataTable )
        {
            if( ( dataGridView != null )
               && ( dataTable?.Columns?.Count > 0 ) )
            {
                try
                {
                    for( var _i = 0; _i < dataGridView.Columns.Count; _i++ )
                    {
                        var _column = dataTable?.Columns[ _i ];
                        var _caption = _column?.ColumnName?.SplitPascal( );
                        if( !string.IsNullOrEmpty( _caption ) )
                        {
                            dataGridView.Columns[ _i ].HeaderText = _caption;
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
        /// The PascalizeHeaders
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        public static void PascalizeHeaders( this DataGridView dataGridView )
        {
            if( dataGridView?.DataSource != null )
            {
                try
                {
                    var _table = dataGridView.GetDataTable( );
                    if( _table?.Columns?.Count > 0 )
                    {
                        for( var _i = 0; _i < dataGridView.Columns.Count; _i++ )
                        {
                            var _column = _table.Columns[ _i ];
                            var _caption = _column.ColumnName?.SplitPascal( );
                            if( !string.IsNullOrEmpty( _caption ) )
                            {
                                dataGridView.Columns[ _i ].HeaderText = _caption;
                            }
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
        /// Sets the column format.
        /// </summary>
        /// <param name="dataGridView">The data grid view.</param>
        public static void FormatColumns( this DataGridView dataGridView )
        {
            if( dataGridView?.DataSource != null )
            {
                try
                {
                    var _table = dataGridView.GetDataTable( );
                    if( _table?.Columns?.Count > 0 )
                    {
                        for( var _i = 0; _i < dataGridView.Columns.Count; _i++ )
                        {
                            var _column = _table.Columns[ _i ];
                            if( ( _column.DataType == typeof( int ) )
                               || _column.ColumnName.EndsWith( "Id" ) )
                            {
                                dataGridView.Columns[ _i ].DefaultCellStyle.Format = "G0";
                            }
                            else if( ( _column.DataType == typeof( double ) )
                                    || ( _column.DataType == typeof( float ) ) )
                            {
                                dataGridView.Columns[ _i ].DefaultCellStyle.Format = "N2";
                            }
                            else if( _column.DataType == typeof( decimal ) )
                            {
                                dataGridView.Columns[ _i ].DefaultCellStyle.Format = "C0";
                            }
                            else if( _column.DataType == typeof( DateTime ) )
                            {
                                dataGridView.Columns[ _i ].DefaultCellStyle.Format = "yyyy-MM-dd";
                            }
                            else if( _column.DataType == typeof( DateOnly ) )
                            {
                                dataGridView.Columns[ _i ].DefaultCellStyle.Format = "yyyy-MM-dd";
                            }
                            else if( _column.DataType == typeof( DateTimeOffset ) )
                            {
                                dataGridView.Columns[ _i ].DefaultCellStyle.Format = "yyyy-MM-dd";
                            }
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
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
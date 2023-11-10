// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AccessConnect.cs" company="Terry D. Eppler">
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
//   AccessConnect.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:System.IDisposable" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    public class AccessConnect : IDisposable
    {
        /// <summary>
        /// The connection
        /// </summary>
        private OleDbConnection _connection;

        /// <summary>
        /// Gets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
        /// </value>
        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessConnect"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public AccessConnect( string path )
        {
            var _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" 
                + "Data Source="
                + path
                + ";Jet OLEDB:Database Password=;";

            _connection = new OleDbConnection( _connectionString );
            _connection?.Open( );
        }

        /// <summary>
        /// Gets the table names.
        /// </summary>
        /// <returns>
        /// IEnumerable<string>
        /// </returns>
        public IEnumerable<string> GetTableNames( )
        {
            try
            {
                var _names = new List<string>( );
                var _restrictions = new string[ 4 ];
                _restrictions[ 3 ] = "Table";
                var _schema = _connection?.GetSchema( "Tables", _restrictions );
                for( var _i = 0; _i < _schema?.Rows?.Count; _i++ )
                {
                    _names?.Add( _schema.Rows[ _i ][ 2 ].ToString( ) );
                }

                return _names?.Any( ) == true
                    ? _names
                    : default( IEnumerable<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the table.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public DataTable CreateTable( string name )
        {
            try
            {
                ThrowIf.NullOrEmpty( name, nameof( name ) );
                var _table = new DataTable( );
                var _sql = "SELECT * FROM " + name;
                var _adapter = new OleDbDataAdapter( _sql, _connection );
                _adapter.Fill( _table );

                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Gets the column names.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <returns></returns>
        public List<string> GetColumnNames( string tableName )
        {
            try
            {
                ThrowIf.NullOrEmpty( tableName, nameof( tableName ) );
                var _names = new List<string>( );
                using var _command = new OleDbCommand( "select * from " + tableName, _connection );
                using var _reader = _command.ExecuteReader( CommandBehavior.SchemaOnly );
                var _table = _reader.GetSchemaTable( );
                var _column = _table?.Columns[ "ColumnName" ];
                if( _table?.Rows != null )
                {
                    foreach( DataRow _row in _table?.Rows )
                    {
                        if( _column != null )
                        {
                            _names.Add( _row[ _column ].ToString( ) );
                        }
                    }
                }

                return _names?.Any( ) == true
                    ? _names
                    : default( List<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( List<string> );
            }
        }

        /// <inheritdoc />
        /// <summary>Performs application-defined tasks associated with
        /// freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose( )
        {
            Dispose( true );
            GC.SuppressFinalize( this );
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed
        /// and unmanaged resources; <c>false</c> to release only unmanaged resources.
        /// </param>
        private protected virtual void Dispose( bool disposing )
        {
            if( disposing )
            {
                _connection?.Dispose( );
                Dispose( );
                IsDisposed = true;
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
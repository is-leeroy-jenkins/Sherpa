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

    /// <summary> </summary>
    public class AccessConnect : IDisposable
    {
        /// <summary> The connection </summary>
        private OleDbConnection _connection;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessConnect"/>
        /// class.
        /// </summary>
        /// <param name="path"> The path. </param>
        public AccessConnect( string path )
        {
            var _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=" + path + ";Jet OLEDB:Database Password=;";
            _connection = new OleDbConnection( _connectionString );
            _connection?.Open( );
        }

        /// <summary> Gets the table names. </summary>
        /// <returns> </returns>
        public IEnumerable<string> GetTableNames( )
        {
            var _names = new List<string>( );
            var _restrictions = new string[ 4 ];
            _restrictions[ 3 ] = "Table";
            var _schema = _connection.GetSchema( "Tables", _restrictions );
            for( var _i = 0; _i < _schema.Rows.Count; _i++ )
            {
                _names.Add( _schema.Rows[ _i ][ 2 ].ToString( ) );
            }

            return _names;
        }

        /// <summary> Gets the table. </summary>
        /// <param name="name"> The name. </param>
        /// <returns> </returns>
        public DataTable GetTable( string name )
        {
            try
            {
                var _table = new DataTable( );
                var _adapter = new OleDbDataAdapter( "SELECT * FROM " + name, _connection );
                _adapter.Fill( _table );
                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception _ex )
            {
                Console.WriteLine( _ex );
                throw;
            }
        }

        /// <summary> Gets the column names. </summary>
        /// <param name="tableName"> The tableName. </param>
        /// <returns> </returns>
        public List<string> GetColumnNames( string tableName )
        {
            var _names = new List<string>( );
            using var _command = new OleDbCommand( "select * from " + tableName, _connection );
            using var _dataReader = _command.ExecuteReader( CommandBehavior.SchemaOnly );
            var _dataTable = _dataReader.GetSchemaTable( );
            var _dataColumn = _dataTable?.Columns[ "ColumnName" ];
            if( _dataTable?.Rows != null )
            {
                foreach( DataRow _row in _dataTable?.Rows )
                {
                    if( _dataColumn != null )
                    {
                        _names.Add( _row[ _dataColumn ].ToString( ) );
                    }
                }
            }

            return _names?.Any( ) == true
                ? _names
                : default( List<string> );
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged
        /// resources.
        /// </summary>
        public void Dispose( )
        {
            if( _connection.State == ConnectionState.Open )
            {
                _connection = null;
            }

            GC.SuppressFinalize( this );
        }
    }
}
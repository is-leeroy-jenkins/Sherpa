// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AccessConversion.cs" company="Terry D. Eppler">
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
//   AccessConversion.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    public class AccessConversion : IDisposable 
    {
        /// <summary>
        /// The connection
        /// </summary>
        private SQLiteConnection _connection;

        /// <summary>
        /// Gets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
        /// </value>
        public bool IsDisposed { get; private set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessConversion"/>
        /// class.
        /// </summary>
        public AccessConversion( )
        {
            _connection = new SQLiteConnection( "Data Source=MyDatabase.sqlite;Version=3;" );
            _connection.Open( );
        }

        /// <summary>
        /// Creates the table.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <returns>
        /// </returns>
        public int CreateTable( string name )
        {
            try
            {
                ThrowIf.NullOrEmpty( name, nameof( name ) );
                var _sql = "CREATE TABLE " + name + " (word varchar(200), image text)";
                using var _command = new SQLiteCommand( _sql, _connection );
                return _command.ExecuteNonQuery( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return -1;
            }
        }

        /// <summary>
        /// Inserts the row.
        /// </summary>
        /// <param name="word"> The word. </param>
        /// <param name="image"> The image. </param>
        /// <param name="table"> The table. </param>
        /// <returns> </returns>
        public int InsertRow( string word, string image, string table )
        {
            try
            {
                ThrowIf.NullOrEmpty( word, nameof( word ) );
                ThrowIf.NullOrEmpty( image, nameof( image ) );
                ThrowIf.NullOrEmpty( table, nameof( table ) );
                var _sql = "INSERT INTO " + table + " (word,image) VALUES ( @word, @image )";
                using var _command = new SQLiteCommand( _sql, _connection );
                _command.Parameters.AddWithValue( "@word", word );
                _command.Parameters.AddWithValue( "@image", image );
                return _command.ExecuteNonQuery( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return -1;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs application-defined tasks associated with
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

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
    using System.Data;
    using System.Data.SQLite;

    /// <summary> </summary>
    public class AccessConversion : IDisposable
    {
        /// <summary> The connection </summary>
        private SQLiteConnection _connection;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AccessConversion"/>
        /// class.
        /// </summary>
        public AccessConversion( )
        {
            SQLiteConnection.CreateFile( "MyDatabase.sqlite" );
            _connection = new SQLiteConnection( "Data Source=MyDatabase.sqlite;Version=3;" );
            _connection.Open( );
        }

        /// <summary> Creates the table. </summary>
        /// <param name="name"> The name. </param>
        /// <returns> </returns>
        public int CreateTable( string name )
        {
            var _sql = "CREATE TABLE " + name + " (word varchar(200), image text)";
            using var _cmd = new SQLiteCommand( _sql, _connection );
            return _cmd.ExecuteNonQuery( );
        }

        /// <summary> Inserts the row. </summary>
        /// <param name="word"> The word. </param>
        /// <param name="image"> The image. </param>
        /// <param name="table"> The table. </param>
        /// <returns> </returns>
        public int InsertRow( string word, string image, string table )
        {
            var _sql = "INSERT INTO " + table + " (word,image) VALUES ( @word, @image )";
            using var _cmd = new SQLiteCommand( _sql, _connection );
            _cmd.Parameters.AddWithValue( "@word", word );
            _cmd.Parameters.AddWithValue( "@image", image );
            return _cmd.ExecuteNonQuery( );
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
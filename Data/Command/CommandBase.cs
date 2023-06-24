// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="CommandBase.cs" company="Terry D. Eppler">
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
//   CommandBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.ISource" />
    /// <seealso cref="T:BudgetExecution.IProvider" />
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class CommandBase : ISource, IProvider
    {
        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public DbCommand Command { get; set; }

        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        public IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public Provider Provider { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        protected CommandBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        protected CommandBase( Source source, Provider provider, string sqlText, SQL commandType )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, sqlText, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        protected CommandBase( Source source, Provider provider, IDictionary<string, object> where, 
            SQL commandType = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="update">The update.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        protected CommandBase( Source source, Provider provider, IDictionary<string, object> update, 
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, update, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        protected CommandBase( Source source, Provider provider, IEnumerable<string> columns, 
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="having">The having.</param>
        /// <param name="commandType">Type of the command.</param>
        protected CommandBase( Source source, Provider provider, IEnumerable<string> fields, 
            IEnumerable<string> numerics, IDictionary<string, object> having, 
            SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionFactory = new ConnectionFactory( source, provider );
            SqlStatement = new SqlStatement( source, provider, fields, numerics, having,
                commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        protected CommandBase( ISqlStatement sqlStatement )
        {
            SqlStatement = sqlStatement;
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            CommandType = sqlStatement.CommandType;
            ConnectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
        }

        /// <summary>
        /// Gets the sq lite command.
        /// </summary>
        /// <returns></returns>
        private protected DbCommand GetSQLiteCommand( )
        {
            if( ( SqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), SqlStatement.CommandType )
               && ( ConnectionFactory != null ) )
            {
                try
                {
                    var _connection = ConnectionFactory?.Connection as SQLiteConnection;
                    switch( SqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection )
                                : default( SQLiteCommand );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        default:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL ce command.
        /// </summary>
        /// <returns></returns>
        private protected DbCommand GetSqlCeCommand( )
        {
            if( ( SqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), SqlStatement.CommandType )
               && ( ConnectionFactory != null ) )
            {
                try
                {
                    var _connection = ConnectionFactory?.Connection as SqlCeConnection;
                    switch( SqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        default:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <returns></returns>
        private protected DbCommand GetSqlCommand( )
        {
            if( ( SqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), SqlStatement.CommandType )
               && ( ConnectionFactory != null ) )
            {
                try
                {
                    var _connection = ConnectionFactory?.Connection as SqlConnection;
                    switch( SqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        default:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the OLE database command.
        /// </summary>
        /// <returns></returns>
        private protected DbCommand GetOleDbCommand( )
        {
            if( ( SqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), SqlStatement.CommandType )
               && ( ConnectionFactory != null ) )
            {
                try
                {
                    var _connection = ConnectionFactory?.Connection as OleDbConnection;
                    switch( SqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        default:
                        {
                            var _sql = SqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
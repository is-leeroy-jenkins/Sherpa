// ************************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:              19-10-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        13-02-2024
// ************************************************************************************************
// <copyright file="CommandBase.cs.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for analysts in the
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Eppler, Terry.cs
// </summary>
// ************************************************************************************************

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

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.ISource"/>
    /// <seealso cref="T:BudgetExecution.IProvider"/>
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class CommandBase : ISource, IProvider
    {
        /// <summary>
        /// The source
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected Provider _provider;

        /// <summary>
        ///  
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected DbCommand _command;

        /// <summary>
        ///  
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected IConnectionFactory _connectionFactory;
        
        /// <summary>
        /// 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected SQL _commandType;

        /// <summary>
        ///  
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected ISqlStatement _sqlStatement;
        
        /// <summary>
        /// Gets or sets the command.
        /// </summary>
        /// <value>
        /// command.
        /// </value>
        public DbCommand Command
        {
            get
            {
                return _command;
            }
            private protected set
            {
                _command = value;
            }
        }

        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        public IConnectionFactory ConnectionFactory
        {
            get
            {
                return _connectionFactory;
            }
            private protected set
            {
                _connectionFactory = value;
            }
        }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public SQL CommandType
        {
            get
            {
                return _commandType;
            }
            private protected set
            {
                _commandType = value;
            }
        }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement
        {
            get
            {
                return _sqlStatement;
            }
            private protected set
            {
                _sqlStatement = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// </summary>
        public Provider Provider
        {
            get
            {
                return _provider;
            }
            private protected set
            {
                _provider = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source
        {
            get
            {
                return _source;
            }
            private protected set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBase"/>
        /// class.
        /// </summary>
        protected CommandBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected CommandBase( Source source, Provider provider, string sqlText, SQL commandType )
        {
            _source = source;
            _provider = provider;
            _commandType = commandType;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, sqlText, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected CommandBase( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
        {
            _source = source;
            _provider = provider;
            _commandType = commandType;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="update"> The update. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected CommandBase( Source source, Provider provider, IDictionary<string, object> update,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            _source = source;
            _provider = provider;
            _commandType = commandType;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, update, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected CommandBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            _source = source;
            _provider = provider;
            _commandType = commandType;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, columns, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="having"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected CommandBase( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> having,
            SQL commandType = SQL.SELECT )
        {
            _source = source;
            _provider = provider;
            _commandType = commandType;
            _connectionFactory = new ConnectionFactory( source, provider );
            _sqlStatement = new SqlStatement( source, provider, fields, numerics, having,
                commandType );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBase"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        protected CommandBase( ISqlStatement sqlStatement )
        {
            _sqlStatement = sqlStatement;
            _source = sqlStatement.Source;
            _provider = sqlStatement.Provider;
            _commandType = sqlStatement.CommandType;
            _connectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
        }

        /// <summary>
        /// Gets the sq lite command.
        /// </summary>
        /// <returns> </returns>
        private protected DbCommand GetSQLiteCommand( )
        {
            if( ( _sqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), _sqlStatement.CommandType )
               && ( _connectionFactory != null ) )
            {
                try
                {
                    var _connection = _connectionFactory?.Connection as SQLiteConnection;
                    switch( _sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection )
                                : default( SQLiteCommand );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        default:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
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
        /// <returns>
        /// </returns>
        private protected DbCommand GetSqlCeCommand( )
        {
            if( ( _sqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), _sqlStatement.CommandType )
               && ( _connectionFactory != null ) )
            {
                try
                {
                    var _connection = _connectionFactory?.Connection as SqlCeConnection;
                    switch( _sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCeCommand( _sql, _connection )
                                : default( DbCommand );
                        }
                        default:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
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
        /// <returns>
        /// </returns>
        private protected DbCommand GetSqlCommand( )
        {
            if( ( _sqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), _sqlStatement.CommandType )
               && ( _connectionFactory != null ) )
            {
                try
                {
                    var _connection = _connectionFactory?.Connection as SqlConnection;
                    switch( _sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new SqlCommand( _sql, _connection );
                        }
                        default:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
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

        /// <summary> Gets the OLE database command. </summary>
        /// <returns> </returns>
        private protected DbCommand GetOleDbCommand( )
        {
            if( ( _sqlStatement != null )
               && Enum.IsDefined( typeof( SQL ), _sqlStatement.CommandType )
               && ( _connectionFactory != null ) )
            {
                try
                {
                    var _connection = _connectionFactory?.Connection as OleDbConnection;
                    switch( _sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
                            return new OleDbCommand( _sql, _connection );
                        }
                        default:
                        {
                            var _sql = _sqlStatement?.GetCommandText( );
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

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
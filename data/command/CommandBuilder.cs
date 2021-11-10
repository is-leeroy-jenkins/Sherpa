﻿// <copyright file = "CommandBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.CommandBase" />
    /// <seealso cref="BudgetExecution.ICommandBuilder" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CommandBuilder : ICommandBuilder
    {
        /// <summary>
        /// The command
        /// </summary>
        public DbCommand Command { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionBuilder ConnectionBuilder { get;  }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; }

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get;  }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public ISqlStatement SqlStatement { get;  }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        public CommandBuilder()
        {
        }

        public CommandBuilder( Source source, Provider provider, IDictionary<string, object> dict )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( Source, Provider );
            SqlStatement = new SqlStatement( ConnectionBuilder, dict );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        public CommandBuilder( ISqlStatement sqlStatement )
        {
            SqlStatement = sqlStatement;
            ConnectionBuilder = SqlStatement.ConnectionBuilder;
            Provider = ConnectionBuilder.GetProvider();
            Source = ConnectionBuilder.GetSource();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connection builder.</param>
        /// <param name="sqlStatement">The SQL statement.</param>
        public CommandBuilder( IConnectionBuilder connectionBuilder, ISqlStatement sqlStatement )
        {
            SqlStatement = sqlStatement;
            ConnectionBuilder = connectionBuilder;
            Provider = ConnectionBuilder.GetProvider();
            Source = ConnectionBuilder.GetSource();
        }

        /// <summary>
        /// Gets the SQL statement.
        /// </summary>
        /// <returns></returns>
        public ISqlStatement GetSqlStatement()
        {
            try
            {
                return Verify.Ref( SqlStatement )
                    ? SqlStatement
                    : default( ISqlStatement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISqlStatement );
            }
        }

        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetCommand( ISqlStatement sqlStatement )
        {
            if( Verify.Ref( sqlStatement )
                && Enum.IsDefined( typeof( Provider ), ConnectionBuilder.GetProvider() ) )
            {
                try
                {
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.SqlCe:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.SqlServer:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        default:
                        {
                            return default( DbCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }
        
        /// <summary>
        /// Gets the sq lite command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSQLiteCommand( ISqlStatement sqlStatement )
        {
            if( Verify.Ref( sqlStatement ) )
            {
                try
                {
                    var _connection = new ConnectionFactory( ConnectionBuilder )?.GetConnection();

                    switch( sqlStatement?.GetCommandType() )
                    {
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement();

                            return Verify.Input( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }

                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertStatement();

                            return Verify.Input( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }

                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement?.GetUpdateStatement();

                            return Verify.Input( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }

                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteStatement();

                            return Verify.Input( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }

                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement();

                            return Verify.Input( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL ce command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCeCommand( ISqlStatement sqlStatement )
        {
            if( Verify.Ref( sqlStatement ) )
            {
                try
                {
                    var _connection = new ConnectionFactory( ConnectionBuilder )?.GetConnection();

                    if( Verify.Input( _connection?.ConnectionString ) )
                    {
                        switch( sqlStatement?.GetCommandType() )
                        {
                            case SQL.SELECT:
                            {
                                var _sql = sqlStatement?.GetSelectStatement();

                                return Verify.Input( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            case SQL.INSERT:
                            {
                                var _sql = sqlStatement?.GetInsertStatement();

                                return Verify.Input( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            case SQL.UPDATE:
                            {
                                var _sql = sqlStatement?.GetUpdateStatement();

                                return Verify.Input( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            case SQL.DELETE:
                            {
                                var _sql = sqlStatement?.GetDeleteStatement();

                                return Verify.Input( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            default:
                            {
                                var _sql = sqlStatement?.GetSelectStatement();

                                return Verify.Input( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( DbCommand );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCommand( ISqlStatement sqlStatement )
        {
            if( Verify.Ref( sqlStatement ) )
            {
                try
                {
                    var _connection = new ConnectionFactory( ConnectionBuilder )?.GetConnection();

                    switch( sqlStatement?.GetCommandType() )
                    {
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement();

                            return Verify.Input( _sql )
                                ? new SqlCommand( _sql, _connection as SqlConnection )
                                : default( DbCommand );
                        }

                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertStatement();

                            return Verify.Input( _sql )
                                ? new SqlCommand( _sql, _connection as SqlConnection )
                                : default( DbCommand );
                        }

                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement?.GetUpdateStatement();

                            return Verify.Input( _sql )
                                ? new SqlCommand( _sql, _connection as SqlConnection )
                                : default( DbCommand );
                        }

                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteStatement();

                            return Verify.Input( _sql )
                                ? new SqlCommand( _sql, _connection as SqlConnection )
                                : default( DbCommand );
                        }

                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement();

                            return Verify.Input( _sql )
                                ? new SqlCommand( _sql, _connection as SqlConnection )
                                : default( DbCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the OLE database command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetOleDbCommand( ISqlStatement sqlStatement )
        {
            if( Verify.Ref( sqlStatement ) )
            {
                try
                {
                    var _connection = new ConnectionFactory( ConnectionBuilder )?.GetConnection();

                    switch( sqlStatement?.GetCommandType() )
                    {
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement();

                            return Verify.Input( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertStatement();

                            return Verify.Input( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement.GetUpdateStatement();

                            return Verify.Input( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteStatement();

                            return Verify.Input( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement();

                            return Verify.Input( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AdapterBase.cs" company="Terry D. Eppler">
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
//   AdapterBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:System.Data.Common.DbDataAdapter"/>
    /// <seealso cref="T:BudgetExecution.ISource"/>
    /// <seealso cref="T:BudgetExecution.IProvider"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MergeConditionalExpression" ) ]
    public class AdapterBase : DbDataAdapter, ISource, IProvider
    {
        /// <summary>
        /// Gets or sets the data connection.
        /// </summary>
        /// <value>
        /// The data connection.
        /// </value>
        public virtual DbConnection DataConnection { get; set; }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public virtual ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets or sets the connection factory.
        /// </summary>
        /// <value>
        /// The connection factory.
        /// </value>
        public virtual IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets or sets the commands.
        /// </summary>
        /// <value>
        /// The commands.
        /// </value>
        public virtual IDictionary<string, DbCommand> Commands { get; set; }

        /// <summary>
        /// Gets or sets the command factory.
        /// </summary>
        /// <value> The command factory.
        /// </value>
        public virtual ICommandFactory CommandFactory { get; set; }

        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        /// <value> The command text. </value>
        public virtual string CommandText { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// </summary>
        public virtual Provider Provider { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Gets the source.
        /// </summary>
        public virtual Source Source { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AdapterBase"/>
        /// class.
        /// </summary>
        protected AdapterBase( )
        {
            MissingSchemaAction = MissingSchemaAction.AddWithKey;
            MissingMappingAction = MissingMappingAction.Ignore;
            ContinueUpdateOnError = true;
            AcceptChangesDuringFill = true;
            AcceptChangesDuringUpdate = true;
            ReturnProviderSpecificTypes = true;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AdapterBase"/>
        /// class.
        /// </summary>
        /// <param name="commandFactory"> The command factory. </param>
        protected AdapterBase( ICommandFactory commandFactory )
            : this( )
        {
            Source = commandFactory.Source;
            Provider = commandFactory.Provider;
            CommandFactory = commandFactory;
            ConnectionFactory =
                new ConnectionFactory( commandFactory.Source, commandFactory.Provider );

            DataConnection = ConnectionFactory.GetConnection( );
            CommandText = CommandFactory.GetCommand( ).CommandText;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AdapterBase"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        protected AdapterBase( ISqlStatement sqlStatement )
            : this( )
        {
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            SqlStatement = sqlStatement;
            ConnectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
            DataConnection = ConnectionFactory.GetConnection( );
            CommandText = sqlStatement.CommandText;
        }

        /// <summary>
        /// Gets the sq lite adapter.
        /// </summary>
        /// <returns></returns>
        private protected SQLiteDataAdapter GetSQLiteAdapter( )
        {
            try
            {
                var _connection = DataConnection as SQLiteConnection;
                var _adapter = new SQLiteDataAdapter( CommandText, _connection );
                _adapter.ContinueUpdateOnError = true;
                _adapter.AcceptChangesDuringFill = true;
                _adapter.AcceptChangesDuringUpdate = true;
                _adapter.ReturnProviderSpecificTypes = true;
                if( CommandText.StartsWith( "SELECT *" )
                   || CommandText.StartsWith( "SELECT ALL" ) )
                {
                    var _builder = new SQLiteCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand( );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                    return _adapter;
                }
                else
                {
                    return _adapter;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( SQLiteDataAdapter );
            }
        }

        /// <summary>
        /// Gets the SQL adapter.
        /// </summary>
        /// <returns></returns>
        private protected SqlDataAdapter GetSqlAdapter( )
        {
            try
            {
                var _connection = DataConnection as SqlConnection;
                var _adapter = new SqlDataAdapter( CommandText, _connection );
                _adapter.ContinueUpdateOnError = true;
                _adapter.AcceptChangesDuringFill = true;
                _adapter.AcceptChangesDuringUpdate = true;
                _adapter.ReturnProviderSpecificTypes = true;
                if( CommandText.StartsWith( "SELECT *" )
                   || CommandText.StartsWith( "SELECT ALL" ) )
                {
                    var _builder = new SqlCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand( );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                    return _adapter;
                }
                else
                {
                    return _adapter;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( SqlDataAdapter );
            }
        }

        /// <summary>
        /// Gets the OLE database adapter.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected OleDbDataAdapter GetOleDbAdapter( )
        {
            try
            {
                var _connection = DataConnection as OleDbConnection;
                var _adapter = new OleDbDataAdapter( CommandText, _connection );
                _adapter.ContinueUpdateOnError = true;
                _adapter.AcceptChangesDuringFill = true;
                _adapter.AcceptChangesDuringUpdate = true;
                _adapter.ReturnProviderSpecificTypes = true;
                if( CommandText.StartsWith( "SELECT *" )
                   || CommandText.StartsWith( "SELECT ALL" ) )
                {
                    var _builder = new OleDbCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand( );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                    return ( _adapter != null )
                        ? _adapter
                        : default( OleDbDataAdapter );
                }

                return default( OleDbDataAdapter );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( OleDbDataAdapter );
            }
        }

        /// <summary>
        /// Gets the SQL ce adapter.
        /// </summary>
        /// <returns> </returns>
        private protected DbDataAdapter GetSqlCeAdapter( )
        {
            try
            {
                var _connection = DataConnection as SqlCeConnection;
                var _adapter = new SqlCeDataAdapter( CommandText, _connection );
                _adapter.ContinueUpdateOnError = true;
                _adapter.AcceptChangesDuringFill = true;
                _adapter.AcceptChangesDuringUpdate = true;
                _adapter.ReturnProviderSpecificTypes = true;
                if( CommandText.StartsWith( "SELECT *" )
                   || CommandText.StartsWith( "SELECT ALL" ) )
                {
                    var _builder = new SqlCeCommandBuilder( _adapter );
                    _adapter.InsertCommand = _builder.GetInsertCommand( );
                    _adapter.UpdateCommand = _builder.GetUpdateCommand( );
                    _adapter.DeleteCommand = _builder.GetDeleteCommand( );
                    return _adapter;
                }
                else
                {
                    return _adapter;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( SqlCeDataAdapter );
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
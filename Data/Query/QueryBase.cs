// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-14-2023
// ******************************************************************************************
// <copyright file="QueryBase.cs" company="Terry D. Eppler">
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
//   QueryBase.cs
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

    /// <inheritdoc/>
    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MergeConditionalExpression" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public abstract class QueryBase : IDisposable
    {
        /// <summary>
        /// The source
        /// </summary>
        private protected Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private protected Provider _provider;

        /// <summary>
        /// The command type
        /// </summary>
        private protected SQL _commandType;

        /// <summary>
        /// The data connection
        /// </summary>
        private protected DbConnection _dataConnection;

        /// <summary>
        /// The SQL statement
        /// </summary>
        private protected ISqlStatement _sqlStatement;

        /// <summary>
        /// The connection factory
        /// </summary>
        private protected IConnectionFactory _connectionFactory;

        /// <summary>
        /// The criteria
        /// </summary>
        private protected IDictionary<string, object> _criteria;

        /// <summary>
        /// The data adapter
        /// </summary>
        private protected DbDataAdapter _dataAdapter;

        /// <summary>
        /// The data reader
        /// </summary>
        private protected DbDataReader _dataReader;

        /// <summary>
        /// The is disposed
        /// </summary>
        private protected bool _isDisposed;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        protected QueryBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider = Provider.Access,
            SQL commandType = SQL.SELECTALL )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( source, provider, commandType );
            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
        {
            _source = source;
            _provider = provider;
            _criteria = where;
            _connectionFactory = new ConnectionFactory( source, provider );
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( source, provider, where, commandType );
            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> The updates. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            _source = source;
            _provider = provider;
            _criteria = where;
            _connectionFactory = new ConnectionFactory( source, provider );
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            _source = source;
            _provider = provider;
            _criteria = where;
            _commandType = commandType;
            _connectionFactory = new ConnectionFactory( source, provider );
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="having"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> having,
            SQL commandType = SQL.SELECT )
        {
            _source = source;
            _provider = provider;
            _criteria = having;
            _connectionFactory = new ConnectionFactory( source, provider );
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( source, provider, fields, having, commandType );
            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        protected QueryBase( Source source, Provider provider, string sqlText )
        {
            _source = source;
            _provider = provider;
            _connectionFactory = new ConnectionFactory( source, provider );
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( source, provider, sqlText );
            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
            _criteria = null;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        protected QueryBase( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            _criteria = null;
            _connectionFactory = new ConnectionFactory( fullPath );
            _provider = _connectionFactory.Provider;
            _source = _connectionFactory.Source;
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( _connectionFactory.Source, _connectionFactory.Provider,
                sqlText );

            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="commandType"> Type of the command. </param>
        /// <param name="where"> The where. </param>
        protected QueryBase( string fullPath, SQL commandType, IDictionary<string, object> where )
        {
            _connectionFactory = new ConnectionFactory( fullPath );
            _criteria = where;
            _commandType = commandType;
            _source = _connectionFactory.Source;
            _provider = _connectionFactory.Provider;
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = new SqlStatement( _source, _provider, where, commandType );
            _dataAdapter = new AdapterFactory( _sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        protected QueryBase( ISqlStatement sqlStatement )
        {
            _source = sqlStatement.Source;
            _provider = sqlStatement.Provider;
            _criteria = sqlStatement.Criteria;
            _connectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
            _dataConnection = _connectionFactory.GetConnection( );
            _sqlStatement = sqlStatement;
            _dataAdapter = new AdapterFactory( sqlStatement ).GetAdapter( );
            _isDisposed = false;
        }

        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns></returns>
        public virtual DbDataAdapter GetAdapter( )
        {
            if( Enum.IsDefined( typeof( Provider ), _provider )
               && _sqlStatement != null )
            {
                try
                {
                    var _sqlText = _sqlStatement.CommandText;
                    var _connString = _dataConnection.ConnectionString;
                    switch( _provider )
                    {
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.OleDb:
                        case Provider.Access:
                        {
                            var _adapter = new OleDbDataAdapter( _sqlText, _connString );
                            return ( _adapter != null )
                                ? _adapter 
                                : default( OleDbDataAdapter );
                        }
                        case Provider.SQLite:
                        {
                            var _adapter = new SQLiteDataAdapter( _sqlText, _connString );
                            return ( _adapter != null )
                                ? _adapter
                                : default( SQLiteDataAdapter );
                        }
                        case Provider.SqlCe:
                        {
                            var _adapter = new SqlCeDataAdapter( _sqlText, _connString );
                            return ( _adapter != null )
                                ? _adapter
                                : default( SqlCeDataAdapter );
                        }
                        case Provider.SqlServer:
                        {
                            var _adapter = new SqlDataAdapter( _sqlText, _connString );
                            return ( _adapter != null )
                                ? _adapter
                                : default( SqlDataAdapter );
                        }
                        default:
                        {
                            var _adapter = new OleDbDataAdapter( _sqlText, _connString );
                            return ( _adapter != null )
                                ? _adapter
                                : default( OleDbDataAdapter );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DbDataAdapter );
                }
            }

            return default( DbDataAdapter );
        }

        /// <inheritdoc />
        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose( )
        {
            Dispose( true );
            GC.SuppressFinalize( this );
        }

        /// <summary> Releases unmanaged and - optionally - managed resources. </summary>
        /// <param name="disposing">
        /// <c> true </c>
        /// to release both managed and unmanaged resources;
        /// <c> false </c>
        /// to release only unmanaged resources.
        /// </param>
        private protected virtual void Dispose( bool disposing )
        {
            if( disposing )
            {
                _dataConnection?.Dispose( );
                _dataAdapter?.Dispose( );
                _dataReader?.Dispose( );
                _isDisposed = true;
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
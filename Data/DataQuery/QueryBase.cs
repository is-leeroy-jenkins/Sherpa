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
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class QueryBase
    {
        /// <summary> Gets or sets the source. </summary>
        /// <value> The source. </value>
        public virtual Source Source { get; set; }

        /// <summary> Gets or sets the provider. </summary>
        /// <value> The provider. </value>
        public virtual Provider Provider { get; set; }

        /// <summary> Gets or sets the type of the command. </summary>
        /// <value> The type of the command. </value>
        public virtual SQL CommandType { get; set; }

        /// <summary> Gets or sets the criteria. </summary>
        /// <value> The criteria. </value>
        public virtual IDictionary<string, object> Criteria { get; set; }

        /// <summary> Gets or sets the SQL statement. </summary>
        /// <value> The SQL statement. </value>
        public virtual ISqlStatement SqlStatement { get; set; }

        /// <summary> Gets or sets the connection factory. </summary>
        /// <value> The connection factory. </value>
        public virtual IConnectionFactory ConnectionFactory { get; set; }

        /// <summary> Gets or sets the data connection. </summary>
        /// <value> The data connection. </value>
        public virtual DbConnection DataConnection { get; set; }

        /// <summary> Gets or sets the data adapter. </summary>
        /// <value> The data adapter. </value>
        public virtual DbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is disposed; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public virtual bool IsDisposed { get; set; }

        /// <summary> Gets or sets the data reader. </summary>
        /// <value> The data reader. </value>
        public virtual DbDataReader DataReader { get; set; }

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
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
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
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
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
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
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
            Source = source;
            Provider = provider;
            Criteria = where;
            CommandType = commandType;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
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
            Source = source;
            Provider = provider;
            Criteria = having;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, fields, having, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
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
            Source = source;
            Provider = provider;
            ConnectionFactory = new ConnectionFactory( source, provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( source, provider, sqlText );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
            Criteria = null;
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
            Criteria = null;
            ConnectionFactory = new ConnectionFactory( fullPath );
            Provider = ConnectionFactory.Provider;
            Source = ConnectionFactory.Source;
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( ConnectionFactory.Source, ConnectionFactory.Provider,
                sqlText );

            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
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
            ConnectionFactory = new ConnectionFactory( fullPath );
            Criteria = where;
            CommandType = commandType;
            Source = ConnectionFactory.Source;
            Provider = ConnectionFactory.Provider;
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = new SqlStatement( Source, Provider, where, commandType );
            DataAdapter = new AdapterFactory( SqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="QueryBase"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        protected QueryBase( ISqlStatement sqlStatement )
        {
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            Criteria = sqlStatement.Criteria;
            ConnectionFactory = new ConnectionFactory( sqlStatement.Source, sqlStatement.Provider );
            DataConnection = ConnectionFactory.GetConnection( );
            SqlStatement = sqlStatement;
            DataAdapter = new AdapterFactory( sqlStatement ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary> Gets the adapter. </summary>
        /// <returns> </returns>
        public virtual DbDataAdapter GetAdapter( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider )
               && ( SqlStatement != null ) )
            {
                try
                {
                    switch( Provider )
                    {
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.OleDb:
                        case Provider.Access:

                        {
                            var _adapter = new AdapterFactory( SqlStatement );
                            return _adapter?.GetAdapter( ) as OleDbDataAdapter;
                        }

                        case Provider.SQLite:

                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as SQLiteDataAdapter;
                        }

                        case Provider.SqlCe:

                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as SqlCeDataAdapter;
                        }

                        case Provider.SqlServer:

                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as SqlDataAdapter;
                        }

                        default:

                        {
                            var _builder = new AdapterFactory( SqlStatement );
                            return _builder?.GetAdapter( ) as OleDbDataAdapter;
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
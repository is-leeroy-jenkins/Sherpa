﻿// ****************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ****************************************************************************************
// <copyright file="Query.cs" company="Terry D. Eppler">
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
//   Query.cs
// </summary>
// ****************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:System.IDisposable"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ValueParameterNotUsed" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MergeConditionalExpression" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AsyncQuery : AsyncBase 
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.Query"/>
        /// class.
        /// </summary>
        public AsyncQuery( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> The commandType. </param>
        public AsyncQuery( Source source, Provider provider = Provider.Access,
            Command commandType = Command.SELECTALL )
        {
            _source = source;
            _provider = provider;
            _connection = new BudgetConnection( source, provider ).Create( );
            _sqlStatement = new SqlStatement( source, provider, commandType );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source Data. </param>
        /// <param name="provider"> The provider used. </param>
        /// <param name="where"> The dictionary of parameters. </param>
        /// <param name="commandType"> The type of sql command. </param>
        public AsyncQuery( Source source, Provider provider, IDictionary<string, object> where,
            Command commandType = Command.SELECTALL )
        {
            _source = source;
            _provider = provider;
            _criteria = where;
            _connection = new BudgetConnection( source, provider ).Create( );
            _sqlStatement = new SqlStatement( source, provider, where, commandType );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AsyncQuery( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, Command commandType = Command.UPDATE )
        {
            _source = source;
            _provider = provider;
            _criteria = where;
            _connection = new BudgetConnection( source, provider ).Create( );
            _sqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The criteria. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AsyncQuery( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, Command commandType = Command.SELECT )
        {
            _source = source;
            _provider = provider;
            _criteria = where;
            _commandType = commandType;
            _connection = new BudgetConnection( source, provider ).Create( );
            _sqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="numerics"> The numeric field. </param>
        /// <param name="having"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        public AsyncQuery( Source source, Provider provider, IEnumerable<string> columns,
            IEnumerable<string> numerics, IDictionary<string, object> having,
            Command commandType = Command.SELECT )
        {
            _source = source;
            _provider = provider;
            _criteria = having;
            _connection = new BudgetConnection( source, provider ).Create( );
            _sqlStatement = new SqlStatement( source, provider, columns, having, commandType );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public AsyncQuery( Source source, Provider provider, string sqlText )
        {
            _source = source;
            _provider = provider;
            _connection = new BudgetConnection( source, provider ).Create( );
            _sqlStatement = new SqlStatement( source, provider, sqlText );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
            _criteria = null;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The dictionary. </param>
        public AsyncQuery( Source source, Provider provider, IDictionary<string, object> where )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="sqlText"> </param>
        /// <param name="commandType"> The commandType. </param>
        public AsyncQuery( string fullPath, string sqlText, Command commandType = Command.SELECT )
        {
            _criteria = null;
            _connection = new BudgetConnection( fullPath ).Create( );
            _provider = Provider.Access;
            _source = Source.External;
            _sqlStatement = new SqlStatement( _source, _provider, sqlText );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullpath. </param>
        /// <param name="commandType"> The commandType. </param>
        /// <param name="where"> The dictionary. </param>
        public AsyncQuery( string fullPath, Command commandType, IDictionary<string, object> where )
        {
            _connection = new BudgetConnection( fullPath ).Create( );
            _criteria = where;
            _commandType = commandType;
            _source = Source.External;
            _provider = Provider.Access;
            _connection = new BudgetConnection( _source, _provider ).Create( );
            _sqlStatement = new SqlStatement( _source, _provider, where, commandType );
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetQuery"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The sqlStatement. </param>
        public AsyncQuery( ISqlStatement sqlStatement )
        {
            _source = sqlStatement.Source;
            _provider = sqlStatement.Provider;
            _criteria = sqlStatement.Criteria;
            _connection = new BudgetConnection( _source, _provider ).Create( );
            _sqlStatement = sqlStatement;
            _dataAdapter = GetAdapterAsync( );
            _disposed = false;
        }
        
        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns></returns>
        public Task<DbDataAdapter> GetAdapterAsync( )
        {
            var _async = new TaskCompletionSource<DbDataAdapter>( );
            try
            {
                var _commandText = _sqlStatement.CommandText;
                var _connString = _connection.ConnectionString;
                switch( _provider )
                {
                    case Provider.Excel:
                    case Provider.CSV:
                    case Provider.OleDb:
                    case Provider.Access:
                    {
                        var _adapter = new OleDbDataAdapter( _commandText, _connString );
                        _async.SetResult( _adapter );
                        return ( _adapter != null )
                            ? _async.Task
                            : default( Task<DbDataAdapter> );
                    }
                    case Provider.SQLite:
                    {
                        var _adapter = new SQLiteDataAdapter( _commandText, _connString );
                        _async.SetResult( _adapter );
                        return ( _adapter != null )
                            ? _async.Task
                            : default( Task<DbDataAdapter> );
                    }
                    case Provider.SqlCe:
                    {
                        var _adapter = new SqlCeDataAdapter( _commandText, _connString );
                        _async.SetResult( _adapter );
                        return ( _adapter != null )
                            ? _async.Task
                            : default( Task<DbDataAdapter> );
                    }
                    case Provider.SqlServer:
                    {
                        var _adapter = new SqlDataAdapter( _commandText, _connString );
                        _async.SetResult( _adapter );
                        return ( _adapter != null )
                            ? _async.Task
                            : default( Task<DbDataAdapter> );
                    }
                    default:
                    {
                        var _adapter = new OleDbDataAdapter( _commandText, _connString );
                        _async.SetResult( _adapter );
                        return ( _adapter != null )
                            ? _async.Task
                            : default( Task<DbDataAdapter> );
                    }
                }
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
                Fail( _ex );
                return default( Task<DbDataAdapter> );
            }
        }
    }
}
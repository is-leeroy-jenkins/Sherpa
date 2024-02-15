// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="AdapterFactory.cs" company="Terry D. Eppler">
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
//   AdapterFactory.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.AdapterBase"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class AdapterFactory : AdapterBase, ISource, IProvider
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
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

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
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

        /// <inheritdoc />
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
        /// Gets or sets the data connection.
        /// </summary>
        /// <value>
        /// The data connection.
        /// </value>
        public DbConnection DataConnection
        {
            get
            {
                return _dataConnection;
            }
            private protected set
            {
                _dataConnection = value;
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
        /// Gets or sets the commands.
        /// </summary>
        /// <value>
        /// The commands.
        /// </value>
        public IDictionary<string, DbCommand> Commands
        {
            get
            {
                return _commands;
            }
            private protected set
            {
                _commands = value;
            }
        }

        /// <summary>
        /// Gets or sets the command factory.
        /// </summary>
        /// <value> The command factory.
        /// </value>
        public ICommandFactory CommandFactory
        {
            get
            {
                return _commandFactory;
            }
            private protected set
            {
                _commandFactory = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        /// <value>
        /// The command text.
        /// </value>
        public string CommandText
        {
            get
            {
                return _commandText;
            }
            private protected set
            {
                _commandText = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AdapterFactory"/>
        /// class.
        /// </summary>
        public AdapterFactory( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AdapterFactory"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        public AdapterFactory( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns> DbDataAdapter </returns>
        public DbDataAdapter GetAdapter( )
        {
            if( Enum.IsDefined( typeof( Provider ), _provider )
               && ( _dataConnection != null )
               && !string.IsNullOrEmpty( _commandText ) )
            {
                try
                {
                    switch( _provider )
                    {
                        case Provider.SQLite:
                        {
                            return GetSQLiteAdapter( );
                        }
                        case Provider.SqlCe:
                        {
                            return GetSqlCompactAdapter( );
                        }
                        case Provider.SqlServer:
                        {
                            return GetSqlServerAdapter( );
                        }
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return GetOleDbAdapter( );
                        }
                        default:
                        {
                            return GetOleDbAdapter( );
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
    }
}
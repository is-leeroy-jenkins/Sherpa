// ******************************************************************************************
//     Assembly:                Baby
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:         11-16-2023
// ******************************************************************************************
// <copyright file="SafeDictionary.cs" company="Terry D. Eppler">
//    Baby is a small web browser used in a Federal Budget, Finance, and Accounting application for the
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
//   SafeDictionary.cs
// </summary>
// ******************************************************************************************

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using static BudgetExecution.CommandFactory;

namespace BudgetExecution
{
    using System;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.ICommand"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CommandFactory : CommandBase, ICommandFactory
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.CommandFactory"/>
        /// class.
        /// </summary>
        public CommandFactory( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        public CommandFactory( Source source, Provider provider, string sqlText, SQL commandType )
            : base( source, provider, sqlText, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> The dictionary. </param>
        /// <param name="commandType"> </param>
        public CommandFactory( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
            : base( source, provider, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="update"> The updates. </param>
        /// <param name="where"> The criteria. </param>
        /// <param name="commandType"> </param>
        public CommandFactory( Source source, Provider provider, IDictionary<string, object> update,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, update, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary> </summary>
        /// <param name="source"> </param>
        /// <param name="provider"> </param>
        /// <param name="columns"> </param>
        /// <param name="where"> </param>
        /// <param name="commandType"> </param>
        public CommandFactory( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The fields. </param>
        /// <param name="numerics"> The numerics. </param>
        /// <param name="having"> The having. </param>
        /// <param name="commandType"> Type of the command. </param>
        public CommandFactory( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> having,
            SQL commandType = SQL.SELECT )
            : base( source, provider, fields, numerics, having,
                commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandFactory"/>
        /// class.
        /// </summary>
        /// <param name="sqlStatement"> The SQL statement. </param>
        public CommandFactory( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <inheritdoc/>
        /// <summary> Sets the command. </summary>
        /// <returns> </returns>
        public DbCommand GetCommand( )
        {
            try
            {
                switch( SqlStatement.Provider )
                {
                    case Provider.SQLite:
                    {
                        return GetSQLiteCommand( );
                    }
                    case Provider.SqlCe:
                    {
                        return GetSqlCeCommand( );
                    }
                    case Provider.SqlServer:
                    {
                        return GetSqlCommand( );
                    }
                    case Provider.Excel:
                    case Provider.CSV:
                    case Provider.Access:
                    case Provider.Text:
                    case Provider.OleDb:
                    {
                        return GetOleDbCommand( );
                    }
                    default:
                    {
                        return default( DbCommand );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DbCommand );
            }
        }
    }
}
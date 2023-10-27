// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="SqlStatement.cs" company="Terry D. Eppler">
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
//   SqlStatement.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.SqlBase"/>
    /// <seealso cref="T:BudgetExecution.ISqlStatement"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class SqlStatement : SqlBase, ISqlStatement
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        public SqlStatement( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, SQL commandType = SQL.SELECTALL )
            : base( source, provider, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        public SqlStatement( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText, SQL.SELECT )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="sqlText"> The SQL text. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, string sqlText, SQL commandType )
            : base( source, provider, sqlText, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="where"> </param>
        /// <param name="commandType"> </param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> where,
                             SQL commandType = SQL.SELECTALL )
            : base( source, provider, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="updates"> </param>
        /// <param name="where"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> updates,
                             IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="commandType"> Type of the command. </param>
        /// <param name="where"> The arguments. </param>
        public SqlStatement( Source source, Provider provider, SQL commandType,
                             IDictionary<string, object> where )
            : base( source, provider, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="columns"> The columns. </param>
        /// <param name="where"> The dictionary. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> columns,
                             IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SqlStatement"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        /// <param name="fields"> The columns. </param>
        /// <param name="numerics"> The aggregates. </param>
        /// <param name="having"> The where. </param>
        /// <param name="commandType"> Type of the command. </param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> fields,
                             IEnumerable<string> numerics, IDictionary<string, object> having,
                             SQL commandType = SQL.SELECT )
            : base( source, provider, fields, numerics, having,
                commandType )
        {
        }

        /// <summary> Converts to string. </summary>
        /// <returns>
        /// A
        /// <see cref="System.String"/>
        /// that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( CommandText )
                    ? CommandText
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }
    }
}
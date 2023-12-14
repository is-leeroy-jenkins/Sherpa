// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 06-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        11-30-2023
// ******************************************************************************************
// <copyright file="Terry Eppler.cs" company="Terry D. Eppler">
//    BudgetExecution is a Federal Budget, Finance, and Accounting application for the
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
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   ConnectionFactory.cs.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using static System.Configuration.ConfigurationManager;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.ConnectionBase"/>
    /// <seealso cref="T:BudgetExecution.ISource"/>
    /// <seealso cref="T:BudgetExecution.IProvider"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class ConnectionFactory : ConnectionBase, ISource, IProvider, IConnectionFactory
    {
        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ConnectionFactory"/>
        /// class.
        /// </summary>
        public ConnectionFactory( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionFactory"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        public ConnectionFactory( Source source, Provider provider = Provider.Access )
            : base( source, provider )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionFactory"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullPath. </param>
        public ConnectionFactory( string fullPath )
            : base( fullPath )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionFactory"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The fullPath. </param>
        /// <param name="provider"> The provider. </param>
        public ConnectionFactory( string fullPath, Provider provider = Provider.Access )
            : base( fullPath, provider )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public DbConnection GetConnection( )
        {
            try
            {
                var _connectionString = ConnectionStrings[ $"{Provider}" ]?.ConnectionString;
                if( !string.IsNullOrEmpty( _connectionString ) )
                {
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            return new SQLiteConnection( _connectionString );
                        }
                        case Provider.SqlCe:
                        {
                            return new SqlCeConnection( _connectionString );
                        }
                        case Provider.SqlServer:
                        {
                            return new SqlConnection( _connectionString );
                        }
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Text:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return new OleDbConnection( _connectionString );
                        }
                        default:
                        {
                            return new OleDbConnection( _connectionString );
                        }
                    }
                }

                return default( DbConnection );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DbConnection );
            }
        }
    }
}
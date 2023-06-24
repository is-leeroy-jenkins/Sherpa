// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="SqlBase.cs" company="Terry D. Eppler">
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
//   SqlBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class SqlBase
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public EXT Extension { get; set; }

        /// <summary>
        /// Gets or sets the criteria.
        /// </summary>
        /// <value>
        /// The criteria.
        /// </value>
        public IDictionary<string, object> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the updates.
        /// </summary>
        /// <value>
        /// The updates.
        /// </value>
        public IDictionary<string, object> Updates { get; set; }

        /// <summary>
        /// Gets or sets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields { get; set; }

        /// <summary>
        /// Gets or sets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics { get; set; }

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        /// <value>
        /// The groups.
        /// </value>
        public IList<string> Groups { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the database path.
        /// </summary>
        /// <value>
        /// The database path.
        /// </value>
        public string DbPath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        /// <value>
        /// The command text.
        /// </value>
        public string CommandText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        protected SqlBase( )
        {
            Criteria = new Dictionary<string, object>( );
            Fields = new List<string>( );
            Numerics = new List<string>( );
            Groups = new List<string>( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.SqlBase" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, SQL commandType = SQL.SELECTALL )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).ClientPath;
            CommandType = commandType;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            CommandText = $"SELECT * FROM {source}";
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.SqlBase" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, string sqlText, SQL commandType )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).ClientPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            CommandText = sqlText;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.SqlBase" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).ClientPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = where;
            CommandText = $"SELECT * FROM {source} WHERE {where.ToCriteria( )}";
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.SqlBase" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, IDictionary<string, object> updates, 
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).ClientPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Updates = updates;
            Criteria = where;
            Fields = updates.Keys.ToList( );
            CommandText = GetCommandText( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.SqlBase" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> columns, 
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).ClientPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = where;
            Fields = columns.ToList( );
            CommandText = GetCommandText( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:BudgetExecution.SqlBase" /> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="fields">The fields.</param>
        /// <param name="numerics">The numerics.</param>
        /// <param name="having">The having.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> fields,
            IEnumerable<string> numerics, IDictionary<string, object> having, 
            SQL commandType = SQL.SELECT )
            : this( )
        {
            DbPath = new ConnectionFactory( source, provider ).ClientPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            Criteria = having;
            Fields = fields.ToList( );
            Numerics = numerics.ToList( );
            CommandText = GetCommandText( );
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <returns></returns>
        public string GetCommandText( )
        {
            if( Enum.IsDefined( typeof( SQL ), CommandType ) )
            {
                try
                {
                    switch( CommandType )
                    {
                        case SQL.SELECT:
                        case SQL.SELECTALL:
                        {
                            return GetSelectStatement( );
                        }
                        case SQL.INSERT:
                        {
                            return GetInsertStatement( );
                        }
                        case SQL.UPDATE:
                        {
                            return GetUpdateStatement( );
                        }
                        case SQL.DELETE:
                        {
                            return GetDeleteStatement( );
                        }
                        default:
                        {
                            return GetSelectStatement( );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <returns></returns>
        private protected string GetSelectStatement( )
        {
            if( ( Fields?.Any( ) == true )
               && ( Criteria?.Any( ) == true )
               && ( Numerics?.Any( ) == true ) )
            {
                var _cols = string.Empty;
                var _aggr = string.Empty;
                foreach( var _name in Fields )
                {
                    _cols += $"{_name}, ";
                }

                foreach( var _metric in Numerics )
                {
                    _aggr += $"SUM({_metric}) AS {_metric}, ";
                }

                var _criteria = Criteria.ToCriteria( );
                var _columns = _cols + _aggr.TrimEnd( ", ".ToCharArray( ) );
                var _groups = _cols.TrimEnd( ", ".ToCharArray( ) );
                return $"SELECT {_columns} FROM {Source} " 
                    + $"WHERE {_criteria} " 
                    + $"GROUP BY {_groups};";
            }

            if( ( Fields?.Any( ) == true )
               && ( Criteria?.Any( ) == true )
               && ( Numerics?.Any( ) == false ) )
            {
                var _cols = string.Empty;
                foreach( var _name in Fields )
                {
                    _cols += $"{_name}, ";
                }

                var _criteria = Criteria.ToCriteria( );
                var _columns = _cols.TrimEnd( ", ".ToCharArray( ) );
                return $"SELECT {_columns} FROM {Source} " 
                    + $"WHERE {_criteria} " 
                    + $"GROUP BY {_columns};";
            }
            else if( ( Fields?.Any( ) == false )
                    && ( Criteria?.Any( ) == true )
                    && ( Numerics?.Any( ) == false ) )
            {
                var _criteria = Criteria.ToCriteria( );
                return $"SELECT * FROM {Source} WHERE {_criteria};";
            }
            else if( ( Fields?.Any( ) == false )
                    && ( Criteria?.Any( ) == false )
                    && ( Numerics?.Any( ) == false ) )
            {
                return $"SELECT * FROM {Source};";
            }

            return default( string );
        }

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <returns></returns>
        private protected string GetUpdateStatement( )
        {
            if( ( Updates?.Any( ) == true )
               && ( Criteria?.Any( ) == true )
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _update = string.Empty;
                    if( Updates.Count == 1 )
                    {
                        foreach( var _kvp in Updates )
                        {
                            _update += $"{_kvp.Key} = '{_kvp.Value}'";
                        }
                    }
                    else if( Updates.Count > 1 )
                    {
                        foreach( var _kvp in Updates )
                        {
                            _update += $"{_kvp.Key} = '{_kvp.Value}', ";
                        }
                    }

                    var _criteria = Criteria.ToCriteria( );
                    var _values = _update.TrimEnd( ", ".ToCharArray( ) );
                    return $"UPDATE {Source} SET {_values} WHERE {_criteria};";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the insert statement.
        /// </summary>
        /// <returns></returns>
        private protected string GetInsertStatement( )
        {
            if( ( Updates?.Any( ) == true )
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _columns = string.Empty;
                    var _values = string.Empty;
                    if( Updates.Count == 1 )
                    {
                        foreach( var _kvp in Updates )
                        {
                            _columns += $"{_kvp.Key}";
                            _values += $"{_kvp.Value}";
                        }
                    }
                    else if( Updates.Count > 1 )
                    {
                        foreach( var _kvp in Updates )
                        {
                            _columns += $"{_kvp.Key}, ";
                            _values += $"{_kvp.Value}, ";
                        }
                    }

                    var _columnValues = $"({_columns.TrimEnd( ", ".ToCharArray( ) )})" 
                        + $" VALUES ({_values.TrimEnd( ", ".ToCharArray( ) )})";
                    
                    return $"INSERT INTO {Source} {_columnValues};";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the delete statement.
        /// </summary>
        /// <returns></returns>
        private protected string GetDeleteStatement( )
        {
            if( Criteria?.Any( ) == true )
            {
                try
                {
                    var _criteria = Criteria.ToCriteria( );
                    return !string.IsNullOrEmpty( _criteria )
                        ? $"DELETE FROM {Source} WHERE {_criteria};"
                        : $"DELETE FROM {Source};";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
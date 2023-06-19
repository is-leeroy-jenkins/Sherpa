// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="SqlServerConverter.cs" company="Terry D. Eppler">
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
//   SqlServerConverter.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using log4net;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "BadParensLineBreaks" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class SqlServerConverter
    {
        /// <summary>
        /// The cancelled
        /// </summary>
        private bool _cancelled;

        /// <summary>
        /// The keys
        /// </summary>
        private readonly Regex _keys = new Regex( @"(([a-zA-ZäöüÄÖÜß0-9\.]|(\s+))+)(\(\-\))?" );

        /// <summary>
        /// The log
        /// </summary>
        private readonly ILog _log = LogManager.GetLogger( typeof( SqlServerConverter ) );

        /// <summary>
        /// The value
        /// </summary>
        private readonly Regex _value = new Regex( @"\(N(\'.*\')\)" );

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        private bool IsActive { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerConverter"/> class.
        /// </summary>
        public SqlServerConverter( )
        {
        }

        /// <summary>
        /// Cancels the conversion.
        /// </summary>
        public void CancelConversion( )
        {
            _cancelled = true;
        }

        /// <summary>
        /// Converts the SQL server to sq lite database.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="path">The path.</param>
        /// <param name="passWord">The pass word.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="selectionHandler">The selection handler.</param>
        /// <param name="failureHandler">The failure handler.</param>
        /// <param name="createTriggers">if set to <c>true</c> [create triggers].</param>
        /// <param name="createViews">if set to <c>true</c> [create views].</param>
        public void ConvertSqlServerToSQLiteDatabase( string connectionString, string path, 
            string passWord, SqlConversionHandler handler, 
            SqlTableSelectionHandler selectionHandler, FailedViewDefinitionHandler failureHandler, 
            bool createTriggers, bool createViews )
        {
            _cancelled = false;
            ThreadPool.QueueUserWorkItem( delegate
            {
                try
                {
                    IsActive = true;
                    ConvertToSQLite( connectionString, path, passWord, handler, selectionHandler,
                        failureHandler, createTriggers, createViews );

                    IsActive = false;
                    handler( true, true, 100, "Finished converting database" );
                }
                catch( Exception _ex )
                {
                    _log.Error( "Failed to convert SQL Server database to SQLite database", _ex );
                    IsActive = false;
                    handler( true, false, 100, _ex.Message );
                }
            } );
        }

        /// <summary>
        /// Writes the trigger schema.
        /// </summary>
        /// <param name="schema">The schema.</param>
        /// <returns></returns>
        private string WriteTriggerSchema( TriggerSchema schema )
        {
            return @"CREATE TRIGGER [" + schema.Name + "] " 
                + schema.Type 
                + " " 
                + schema.Event 
                + " ON [" + schema.Table + "] " 
                + "BEGIN " 
                + schema.Body 
                + " END;";
        }

        /// <summary>
        /// Converts to sq lite.
        /// </summary>
        /// <param name="sqlconnstring">The sqlconnstring.</param>
        /// <param name="path">The path.</param>
        /// <param name="password">The password.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="selectionhandler">The selectionhandler.</param>
        /// <param name="viewfailurehandler">The viewfailurehandler.</param>
        /// <param name="createtriggers">if set to <c>true</c> [createtriggers].</param>
        /// <param name="createviews">if set to <c>true</c> [createviews].</param>
        private void ConvertToSQLite( string sqlconnstring, string path, string password, 
            SqlConversionHandler handler, SqlTableSelectionHandler selectionhandler, 
            FailedViewDefinitionHandler viewfailurehandler, bool createtriggers, bool createviews )
        {
            if( File.Exists( path ) )
            {
                File.Delete( path );
            }

            var _ds = ReadSqlServerSchema( sqlconnstring, handler, selectionhandler );
            CreateSQLiteDatabase( path, _ds, password, handler, viewfailurehandler,
                createviews );

            CopyDataRows( sqlconnstring, path, _ds.Tables, password, handler );
            if( createtriggers )
            {
                AddTriggersForForeignKeys( path, _ds.Tables, password );
            }
        }

        /// <summary>
        /// Copies the data rows.
        /// </summary>
        /// <param name="sqlconnstring">The sqlconnstring.</param>
        /// <param name="path">The path.</param>
        /// <param name="schema">The schema.</param>
        /// <param name="password">The password.</param>
        /// <param name="handler">The handler.</param>
        private void CopyDataRows( string sqlconnstring, string path, IList<TableSchema> schema, 
            string password, SqlConversionHandler handler )
        {
            CheckCancelled( );
            handler( false, true, 0, "Preparing to insert tables..." );
            _log.Debug( "preparing to insert tables ..." );
            var _sqlConnection = new SqlConnection( sqlconnstring );
            _sqlConnection.Open( );
            var _connectionString = CreateSQLiteConnectionString( path, password );
            using var _sqlConn = new SQLiteConnection( _connectionString );
            _sqlConn.Open( );
            for( var _i = 0; _i < schema.Count; _i++ )
            {
                var _tx = _sqlConn.BeginTransaction( );
                try
                {
                    var _tableQuery = BuildSqlServerTableQuery( schema[ _i ] );
                    using( var _query = new SqlCommand( _tableQuery, _sqlConnection ) )
                    {
                        using var _reader = _query.ExecuteReader( );
                        var _insert = BuildSQLiteInsert( schema[ _i ] );
                        var _counter = 0;
                        while( _reader.Read( ) )
                        {
                            _insert.Connection = _sqlConn;
                            _insert.Transaction = _tx;
                            var _names = new List<string>( );
                            for( var _j = 0; _j < schema[ _i ].Columns.Count; _j++ )
                            {
                                var _name = "@" 
                                    + GetNormalizedName( schema[ _i ].Columns[ _j ].ColumnName, 
                                        _names );
                                
                                _insert.Parameters[ _name ].Value = 
                                    CastValueForColumn( _reader[ _j ], schema[ _i ].Columns[ _j ] );
                                
                                _names.Add( _name );
                            }

                            _insert.ExecuteNonQuery( );
                            _counter++;
                            if( _counter % 1000 == 0 )
                            {
                                CheckCancelled( );
                                _tx.Commit( );
                                handler( false, true, (int)( 100.0 * _i / schema.Count ), "Added " 
                                    + _counter 
                                    + " rows to table " 
                                    + schema[ _i ].TableName 
                                    + " so far" );
                                
                                _tx = _sqlConn.BeginTransaction( );
                            }
                        }
                    }

                    CheckCancelled( );
                    _tx.Commit( );
                    handler( false, true, (int)( 100.0 * _i / schema.Count ), 
                        "Finished inserting rows for table " 
                        + schema[ _i ].TableName );
                    
                    _log.Debug( "finished inserting all rows for table [" + schema[ _i ].TableName 
                        + "]" );
                }
                catch( Exception _ex )
                {
                    _log.Error( "unexpected exception", _ex );
                    _tx.Rollback( );
                    throw;
                }
            }
        }

        /// <summary>
        /// Casts the value for column.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <param name="columnschema">The columnschema.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Illegal database type [" + Enum.GetName( typeof( DbType ), dt ) + "]</exception>
        private object CastValueForColumn( object val, ColumnSchema columnschema )
        {
            if( val is DBNull )
            {
                return null;
            }

            var _dt = GetDbTypeOfColumn( columnschema );
            switch( _dt )
            {
                case DbType.Int32:
                {
                    switch( val )
                    {
                        case short _s:
                        {
                            return (int)_s;
                        }
                        case byte _b:
                        {
                            return (int)_b;
                        }
                        case long _l:
                        {
                            return (int)_l;
                        }
                        case decimal _val1:
                        {
                            return (int)_val1;
                        }
                    }

                    break;
                }
                case DbType.Int16:
                {
                    switch( val )
                    {
                        case int _i:
                        {
                            return (short)_i;
                        }
                        case byte _b:
                        {
                            return (short)_b;
                        }
                        case long _l:
                        {
                            return (short)_l;
                        }
                        case decimal _val1:
                        {
                            return (short)_val1;
                        }
                    }

                    break;
                }
                case DbType.Int64:
                {
                    switch( val )
                    {
                        case int _i:
                            return (long)_i;
                        case short _s:
                            return (long)_s;
                        case byte _b:
                            return (long)_b;
                        case decimal _val1:
                            return (long)_val1;
                    }

                    break;
                }
                case DbType.Single:
                {
                    switch( val )
                    {
                        case double _d:
                            return (float)_d;
                        case decimal _val1:
                            return (float)_val1;
                    }

                    break;
                }
                case DbType.Double:
                {
                    switch( val )
                    {
                        case float _f:
                            return (double)_f;
                        case double _d:
                            return _d;
                        case decimal _val1:
                            return (double)_val1;
                    }

                    break;
                }
                case DbType.String:
                {
                    if( val is Guid _guid )
                    {
                        return _guid.ToString( );
                    }

                    break;
                }
                case DbType.Guid:
                {
                    switch( val )
                    {
                        case string _s:
                            return ParseStringAsGuid( _s );
                        case byte[ ] _bytes:
                            return ParseBlobAsGuid( _bytes );
                    }

                    break;
                }
                case DbType.Binary:
                case DbType.Boolean:
                case DbType.DateTime:
                    break;
                default:
                {
                    _log.Error( "argument exception - illegal database type" );
                    throw new ArgumentException( "Illegal database type [" + Enum.GetName( typeof( DbType ), _dt ) + "]" );
                }
            }

            return val;
        }

        /// <summary>
        /// Parses the BLOB as unique identifier.
        /// </summary>
        /// <param name="blob">The BLOB.</param>
        /// <returns></returns>
        private Guid ParseBlobAsGuid( IEnumerable<byte> blob )
        {
            var _data = blob.ToArray( );
            switch( blob.Count( ) )
            {
                case 16:
                {
                    _data = new byte[ 16 ];
                    for( var _i = 0; _i < 16; _i++ )
                    {
                        _data[ _i ] = blob.ToArray( )[ _i ];
                    }

                    break;
                }
                case 17:
                {
                    _data = new byte[ 16 ];
                    for( var _i = 0; _i < blob.Count( ); _i++ )
                    {
                        _data[ _i ] = blob.ToArray( )[ _i ];
                    }

                    break;
                }
            }

            return new Guid( _data );
        }

        /// <summary>
        /// Parses the string as unique identifier.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        private Guid ParseStringAsGuid( string str )
        {
            try
            {
                return new Guid( str );
            }
            catch( Exception )
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// Builds the sq lite insert.
        /// </summary>
        /// <param name="ts">The ts.</param>
        /// <returns></returns>
        private SQLiteCommand BuildSQLiteInsert( TableSchema ts )
        {
            var _command = new SQLiteCommand( );
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( $"INSERT INTO {ts.TableName}" );
            for( var _i = 0; _i < ts.Columns.Count; _i++ )
            {
                _stringBuilder.Append( "[" + ts.Columns[ _i ].ColumnName + "]" );
                if( _i < ts.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }
            }

            _stringBuilder.Append( ") VALUES (" );
            var _names = new List<string>( );
            for( var _i = 0; _i < ts.Columns.Count; _i++ )
            {
                var _name = "@" + GetNormalizedName( ts.Columns[ _i ].ColumnName, _names );
                _stringBuilder.Append( _name );
                if( _i < ts.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }

                var _dbType = GetDbTypeOfColumn( ts.Columns[ _i ] );
                var _parameter = new SQLiteParameter( _name, _dbType, ts.Columns[ _i ].ColumnName );
                _command.Parameters.Add( _parameter );
                _names.Add( _name );
            }

            _stringBuilder.Append( ')' );
            _command.CommandText = _stringBuilder.ToString( );
            _command.CommandType = CommandType.Text;
            return _command;
        }

        /// <summary>
        /// Gets the name of the normalized.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="names">The names.</param>
        /// <returns></returns>
        private string GetNormalizedName( string str, ICollection<string> names )
        {
            var _stringBuilder = new StringBuilder( );
            for( var _i = 0; _i < str.Length; _i++ )
            {
                if( char.IsLetterOrDigit( str[ _i ] ) )
                {
                    _stringBuilder.Append( str[ _i ] );
                }
                else
                {
                    _stringBuilder.Append( "" );
                }
            }

            return names.Contains( _stringBuilder.ToString( ) )
                ? GetNormalizedName( _stringBuilder + "", names )
                : _stringBuilder.ToString( );
        }

        /// <summary>
        /// Gets the database type of column.
        /// </summary>
        /// <param name="columnSchema">The column schema.</param>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException"></exception>
        private DbType GetDbTypeOfColumn( ColumnSchema columnSchema )
        {
            switch( columnSchema.ColumnType )
            {
                case "tinyint":
                    return DbType.Byte;
                case "int":
                    return DbType.Int32;
                case "smallint":
                    return DbType.Int16;
                case "bigint":
                    return DbType.Int64;
                case "bit":
                    return DbType.Boolean;
                case "nvarchar":
                case "varchar":
                case "text":
                case "ntext":
                    return DbType.String;
                case "float":
                    return DbType.Double;
                case "real":
                    return DbType.Single;
                case "blob":
                    return DbType.Binary;
                case "numeric":
                    return DbType.Double;
                case "timestamp":
                case "datetime":
                case "datetime2":
                case "date":
                case "time":
                    return DbType.DateTime;
                case "nchar":
                case "char":
                    return DbType.String;
                case "uniqueidentifier":
                case "guid":
                    return DbType.Guid;
                case "xml":
                    return DbType.String;
                case "sqlvariant":
                    return DbType.Object;
                case "integer":
                    return DbType.Int64;
                default:
                    _log.Error( "illegal db type found" );
                    var _message = "Illegal type (" + columnSchema.ColumnType + ")";
                    throw new ApplicationException( _message );
            }
        }

        /// <summary>
        /// Builds the SQL server table query.
        /// </summary>
        /// <param name="ts">The ts.</param>
        /// <returns></returns>
        private string BuildSqlServerTableQuery( TableSchema ts )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( "SELECT " );
            for( var _i = 0; _i < ts.Columns.Count; _i++ )
            {
                _stringBuilder.Append( "[" + ts.Columns[ _i ].ColumnName + "]" );
                if( _i < ts.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }
            }

            _stringBuilder.Append( " FROM " + ts.TableSchemaName + "." + "[" + ts.TableName + "]" );
            return _stringBuilder.ToString( );
        }

        /// <summary>
        /// Creates the sq lite database.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="schema">The schema.</param>
        /// <param name="passWord">The pass word.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="viewFailureHandler">The view failure handler.</param>
        /// <param name="createViews">if set to <c>true</c> [create views].</param>
        private void CreateSQLiteDatabase( string path, DatabaseSchema schema, string passWord, SqlConversionHandler handler,
            FailedViewDefinitionHandler viewFailureHandler, bool createViews )
        {
            _log.Debug( "Creating SQLite database..." );
            SQLiteConnection.CreateFile( path );
            _log.Debug( "SQLite file was created successfully at [" + path + "]" );
            var _sqliteconnstring = CreateSQLiteConnectionString( path, passWord );
            using( var _conn = new SQLiteConnection( _sqliteconnstring ) )
            {
                _conn.Open( );
                var _count = 0;
                foreach( var _dt in schema.Tables )
                {
                    try
                    {
                        AddSQLiteTable( _conn, _dt );
                    }
                    catch( Exception _ex )
                    {
                        _log.Error( "AddSQLiteTable failed", _ex );
                        throw;
                    }

                    _count++;
                    CheckCancelled( );
                    handler( false, true, (int)( _count * 50.0 / schema.Tables.Count ), "Added table " + _dt.TableName + " to the SQLite database" );
                    _log.Debug( "added schema for SQLite table [" + _dt.TableName + "]" );
                }

                _count = 0;
                if( createViews )
                {
                    foreach( var _vs in schema.Views )
                    {
                        try
                        {
                            AddSQLiteView( _conn, _vs, viewFailureHandler );
                        }
                        catch( Exception _ex )
                        {
                            _log.Error( "AddSQLiteView failed", _ex );
                            throw;
                        }

                        _count++;
                        CheckCancelled( );
                        handler( false, true, 50 + (int)( _count * 50.0 / schema.Views.Count ), "Added view " + _vs.ViewName + " to the SQLite database" );
                        _log.Debug( "added schema for SQLite view [" + _vs.ViewName + "]" );
                    }
                }
            }

            _log.Debug( "finished adding all table/view schemas for SQLite database" );
        }

        /// <summary>
        /// Adds the sq lite view.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="vs">The vs.</param>
        /// <param name="handler">The handler.</param>
        private void AddSQLiteView( SQLiteConnection conn, ViewSchema vs, FailedViewDefinitionHandler handler )
        {
            var _stmt = vs.ViewSql;
            _log.Info( "\n\n" + _stmt + "\n\n" );
            var _tx = conn.BeginTransaction( );
            try
            {
                using( var _cmd = new SQLiteCommand( _stmt, conn, _tx ) )
                {
                    _cmd.ExecuteNonQuery( );
                }

                _tx.Commit( );
            }
            catch( SQLiteException )
            {
                _tx.Rollback( );
                if( handler != null )
                {
                    var _updated = new ViewSchema
                    {
                        ViewName = vs.ViewName,
                        ViewSql = vs.ViewSql
                    };

                    var _sql = handler( _updated );
                    if( _sql == null )
                    {
                    }
                    else
                    {
                        _updated.ViewSql = _sql;
                        AddSQLiteView( conn, _updated, handler );
                    }
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Adds the sq lite table.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="dt">The dt.</param>
        private void AddSQLiteTable( SQLiteConnection conn, TableSchema dt )
        {
            var _commandText = BuildCreateTableQuery( dt );
            _log.Info( "\n\n" + _commandText + "\n\n" );
            var _command = new SQLiteCommand( _commandText, conn );
            _command.ExecuteNonQuery( );
        }

        /// <summary>
        /// Builds the create table query.
        /// </summary>
        /// <param name="schema">The schema.</param>
        /// <returns></returns>
        private string BuildCreateTableQuery( TableSchema schema )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( $"CREATE TABLE {schema.TableName}" );
            var _key = false;
            for( var _i = 0; _i < schema.Columns.Count; _i++ )
            {
                var _column = schema.Columns[ _i ];
                var _statement = BuildColumnStatement( _column, schema, ref _key );
                _stringBuilder.Append( _statement );
                if( _i < schema.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ",\n" );
                }
            }

            if( ( schema.PrimaryKey != null )
               && ( schema.PrimaryKey.Count > 0 & !_key ) )
            {
                _stringBuilder.Append( ",\n" );
                _stringBuilder.Append( "    PRIMARY KEY (" );
                for( var _i = 0; _i < schema.PrimaryKey.Count; _i++ )
                {
                    _stringBuilder.Append( "[" + schema.PrimaryKey[ _i ] + "]" );
                    if( _i < schema.PrimaryKey.Count - 1 )
                    {
                        _stringBuilder.Append( ", " );
                    }
                }

                _stringBuilder.Append( ")\n" );
            }
            else
            {
                _stringBuilder.Append( '\n' );
            }

            if( schema.ForeignKeys.Count > 0 )
            {
                _stringBuilder.Append( ",\n" );
                for( var _i = 0; _i < schema.ForeignKeys.Count; _i++ )
                {
                    var _foreignkey = schema.ForeignKeys[ _i ];
                    var _stmt = $"    FOREIGN KEY ([{_foreignkey.ColumnName}])\n " + "REFERENCES [{foreignkey.ForeignTableName}]" + "([{foreignkey.ForeignColumnName}])";
                    _stringBuilder.Append( _stmt );
                    if( _i < schema.ForeignKeys.Count - 1 )
                    {
                        _stringBuilder.Append( ",\n" );
                    }
                }
            }

            _stringBuilder.Append( '\n' );
            _stringBuilder.Append( ");\n" );
            if( schema.Indexes != null )
            {
                for( var _i = 0; _i < schema.Indexes.Count; _i++ )
                {
                    var _stmt = BuildCreateIndex( schema.TableName, schema.Indexes[ _i ] );
                    _stringBuilder.Append( _stmt + ";\n" );
                }
            }

            var _query = _stringBuilder.ToString( );
            return _query;
        }

        /// <summary>
        /// Builds the index of the create.
        /// </summary>
        /// <param name="tablename">The tablename.</param>
        /// <param name="schema">The schema.</param>
        /// <returns></returns>
        private string BuildCreateIndex( string tablename, IndexSchema schema )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( "CREATE " );
            if( schema.IsUnique )
            {
                _stringBuilder.Append( "UNIQUE " );
            }

            _stringBuilder.Append( "INDEX [" + tablename + "" + schema.IndexName + "]\n" );
            _stringBuilder.Append( "ON [" + tablename + "]\n" );
            _stringBuilder.Append( '(' );
            for( var _i = 0; _i < schema.Columns.Count; _i++ )
            {
                _stringBuilder.Append( "[" + schema.Columns[ _i ] + "]" );
                if( schema.Columns[ _i ] != null )
                {
                    _stringBuilder.Append( " DESC" );
                }

                if( _i < schema.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }
            }

            _stringBuilder.Append( ')' );
            return _stringBuilder.ToString( );
        }

        /// <summary>
        /// Builds the column statement.
        /// </summary>
        /// <param name="column">The column.</param>
        /// <param name="schema">The schema.</param>
        /// <param name="primaryKey">if set to <c>true</c> [primary key].</param>
        /// <returns></returns>
        private string BuildColumnStatement( ColumnSchema column, TableSchema schema, ref bool primaryKey )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( "\t[" + column.ColumnName + "]\t" );
            if( column.IsIdentity )
            {
                if( ( schema.PrimaryKey.Count == 1 )
                   && ( ( column.ColumnType == "tinyint" ) || ( column.ColumnType == "int" ) || ( column.ColumnType == "smallint" ) || ( column.ColumnType == "bigint" ) || ( column.ColumnType == "integer" ) ) )
                {
                    _stringBuilder.Append( "integer PRIMARY KEY AUTOINCREMENT" );
                    primaryKey = true;
                }
                else
                {
                    _stringBuilder.Append( "integer" );
                }
            }
            else
            {
                switch( column.ColumnType )
                {
                    case "int":
                        _stringBuilder.Append( "integer" );
                        break;
                    default:
                        _stringBuilder.Append( column.ColumnType );
                        break;
                }

                if( column.Length > 0 )
                {
                    _stringBuilder.Append( "(" + column.Length + ")" );
                }
            }

            if( !column.IsNullable )
            {
                _stringBuilder.Append( " NOT NULL" );
            }

            if( column.IsCaseSensitive == false )
            {
                _stringBuilder.Append( " COLLATE NOCASE" );
            }

            var _default = StripParens( column.DefaultValue );
            _default = DiscardNational( _default );
            _log.Debug( "DEFAULT VALUE BEFORE [" + column.DefaultValue + "] AFTER [" + _default + "]" );
            switch( string.IsNullOrEmpty( _default ) )
            {
                case false when _default.ToUpper( ).Contains( "GETDATE" ):
                    _log.Debug( "converted SQL Server GETDATE() to CURRENTTIMESTAMP for column [" + column.ColumnName + "]" );
                    _stringBuilder.Append( " DEFAULT (CURRENTTIMESTAMP)" );
                    break;
                case false when IsValidDefaultValue( _default ):
                    _stringBuilder.Append( " DEFAULT " + _default );
                    break;
            }

            return _stringBuilder.ToString( );
        }

        /// <summary>
        /// Discards the national.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private string DiscardNational( string value )
        {
            var _rx = new Regex( @"N\'([^\']*)\'" );
            var _m = _rx.Match( value );
            return _m.Success
                ? _m.Groups[ 1 ].Value
                : value;
        }

        /// <summary>
        /// Determines whether [is valid default value] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is valid default value] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidDefaultValue( string value )
        {
            return IsSingleQuoted( value ) || double.TryParse( value, out _ );
        }

        /// <summary>
        /// Determines whether [is single quoted] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is single quoted] [the specified value]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsSingleQuoted( string value )
        {
            value = value.Trim( );
            return value.StartsWith( "'" ) && value.EndsWith( "'" );
        }

        /// <summary>
        /// Strips the parens.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private string StripParens( string value )
        {
            var _rx = new Regex( @"\(([^\)]*)\)" );
            var _m = _rx.Match( value );
            return !_m.Success
                ? value
                : StripParens( _m.Groups[ 1 ].Value );
        }

        /// <summary>
        /// Reads the SQL server schema.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="selectionHandler">The selection handler.</param>
        /// <returns></returns>
        private DatabaseSchema ReadSqlServerSchema( string connectionString, SqlConversionHandler handler, SqlTableSelectionHandler selectionHandler )
        {
            var _tables = new List<TableSchema>( );
            using var _connection = new SqlConnection( connectionString );
            {
                _connection.Open( );
                var _tableNames = new List<string>( );
                var _tableSchema = new List<string>( );
                const string SQL = @"select * from INFORMATIONSCHEMA.TABLES  where TABLETYPE = 'BASE TABLE'";
                using( var _cmd = new SqlCommand( SQL, _connection ) )
                {
                    var _reader = _cmd.ExecuteReader( );
                    while( _reader.Read( ) )
                    {
                        if( _reader[ "TABLENAME" ] == DBNull.Value )
                        {
                            continue;
                        }

                        if( _reader[ "TABLESCHEMA" ] == DBNull.Value )
                        {
                            continue;
                        }

                        _tableNames.Add( (string)_reader[ "TABLENAME" ] );
                        _tableSchema.Add( (string)_reader[ "TABLESCHEMA" ] );
                    }
                }

                var _count = 0;
                for( var _i = 0; _i < _tableNames.Count; _i++ )
                {
                    var _name = _tableNames[ _i ];
                    var _schema = _tableSchema[ _i ];
                    var _ts = CreateTableSchema( _connection, _name, _schema );
                    CreateForeignKeySchema( _connection, _ts );
                    _tables.Add( _ts );
                    _count++;
                    CheckCancelled( );
                    handler( false, true, (int)( _count * 50.0 / _tableNames.Count ), "Parsed table " + _name );
                    _log.Debug( "parsed table schema for [" + _name + "]" );
                }
            }

            _log.Debug( "finished parsing all tables in SQL Server schema" );
            var _updated = selectionHandler?.Invoke( _tables );
            if( _updated != null )
            {
                _tables = _updated;
            }

            var _regex = new Regex( @"dbo\.", RegexOptions.Compiled | RegexOptions.IgnoreCase );
            var _views = new List<ViewSchema>( );
            using( var _conn = new SqlConnection( connectionString ) )
            {
                _conn.Open( );
                const string SQL = @"SELECT TABLENAME, VIEWDEFINITION  from INFORMATIONSCHEMA.VIEWS";
                var _command = new SqlCommand( SQL, _conn );
                var _reader = _command.ExecuteReader( );
                var _count = 0;
                while( _reader.Read( ) )
                {
                    var _schema = new ViewSchema( );
                    if( _reader[ "TABLENAME" ] == DBNull.Value )
                    {
                        continue;
                    }

                    if( _reader[ "VIEWDEFINITION" ] == DBNull.Value )
                    {
                        continue;
                    }

                    _schema.ViewName = (string)_reader[ "TABLENAME" ];
                    _schema.ViewSql = (string)_reader[ "VIEWDEFINITION" ];
                    _schema.ViewSql = _regex.Replace( _schema.ViewSql, string.Empty );
                    _views.Add( _schema );
                    _count++;
                    CheckCancelled( );
                    handler( false, true, 50 + (int)( _count * 50.0 / _views.Count ), "Parsed view " + _schema.ViewName );
                    _log.Debug( "parsed view schema for [" + _schema.ViewName + "]" );
                }
            }

            var _databaseSchema = new DatabaseSchema
            {
                Tables = _tables,
                Views = _views
            };

            return _databaseSchema;
        }

        /// <summary>
        /// Checks the cancelled.
        /// </summary>
        /// <exception cref="System.ApplicationException">User cancelled the conversion</exception>
        private void CheckCancelled( )
        {
            if( _cancelled )
            {
                throw new ApplicationException( "User cancelled the conversion" );
            }
        }

        /// <summary>
        /// Creates the table schema.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="tablename">The tablename.</param>
        /// <param name="schems">The schems.</param>
        /// <returns></returns>
        private TableSchema CreateTableSchema( SqlConnection conn, string tablename, string schems )
        {
            var _res = new TableSchema
            {
                TableName = tablename,
                TableSchemaName = schems,
                Columns = new List<ColumnSchema>( )
            };

            using( var _command = 
                  new SqlCommand( @"SELECT COLUMNNAME, COLUMNDEFAULT, ISNULLABLE,DATATYPE,  (columnproperty(objectid(TABLENAME), COLUMNNAME, 'IsIdentity')) A[IDENT], " + @"CHARACTERMAXIMUMLENGTH AS CSIZE FROM INFORMATIONSCHEMA.COLUMNS WHERE TABLENAME = '{tablename}' ORDER BY ORDINALPOSITION ASC", conn ) )
            {
                var _reader = _command.ExecuteReader( );
                while( _reader.Read( ) )
                {
                    var _tmp = _reader[ "COLUMNNAME" ];
                    if( _tmp is DBNull )
                    {
                        continue;
                    }

                    var _columnName = (string)_reader[ "COLUMNNAME" ];
                    _tmp = _reader[ "COLUMNDEFAULT" ];
                    var _columnDefault = true & _tmp is DBNull
                        ? string.Empty
                        : (string)_tmp;

                    _tmp = _reader[ "ISNULLABLE" ];
                    var _isNullable = (string)_tmp == "YES";
                    var _dataType = (string)_reader[ "DATATYPE" ];
                    var _isIdentity = false;
                    if( _reader[ "IDENT" ] != DBNull.Value )
                    {
                        if( (int)_reader[ "IDENT" ] == 1 )
                        {
                            _isIdentity = true;
                        }
                    }

                    var _length = _reader[ "CSIZE" ] != DBNull.Value
                        ? Convert.ToInt32( _reader[ "CSIZE" ] )
                        : 0;

                    ValidateDataType( _dataType );
                    switch( _dataType )
                    {
                        case "timestamp":
                        {
                            _dataType = "blob";
                            break;
                        }
                        case "datetime":
                        case "smalldatetime":
                        case "date":
                        case "datetime2":
                        case "time":
                        {
                            _dataType = "datetime";
                            break;
                        }
                        case "decimal":
                        case "money":
                        case "smallmoney":
                        {
                            _dataType = "numeric";
                            break;
                        }
                        case "binary":
                        case "varbinary":
                        case "image":
                        {
                            _dataType = "blob";
                            break;
                        }
                        case "tinyint":
                        {
                            _dataType = "smallint";
                            break;
                        }
                        case "bigint":
                        {
                            _dataType = "integer";
                            break;
                        }
                        case "sqlvariant":
                        {
                            _dataType = "blob";
                            break;
                        }
                        case "xml":
                        {
                            _dataType = "varchar";
                            break;
                        }
                        case "uniqueidentifier":
                        {
                            _dataType = "guid";
                            break;
                        }
                        case "ntext":
                        {
                            _dataType = "text";
                            break;
                        }
                        case "nchar":
                        {
                            _dataType = "char";
                            break;
                        }
                    }

                    if( ( _dataType == "bit" )
                       || ( _dataType == "int" ) )
                    {
                    }

                    _columnDefault = FixDefaultValueString( _columnDefault );
                    var _schema = new ColumnSchema
                    {
                        ColumnName = _columnName,
                        ColumnType = _dataType,
                        Length = _length,
                        IsNullable = _isNullable,
                        IsIdentity = _isIdentity,
                        DefaultValue = AdjustDefaultValue( _columnDefault )
                    };

                    _res.Columns.Add( _schema );
                }
            }

            using( var _cmd2 = new SqlCommand( $"EXEC sppkeys '{tablename}'", conn ) )
            {
                var _reader = _cmd2.ExecuteReader( );
                _res.PrimaryKey = new List<string>( );
                while( _reader.Read( ) )
                {
                    var _item = (string)_reader[ "COLUMNNAME" ];
                    _res.PrimaryKey.Add( _item );
                }
            }

            using( var _cmd4 = new SqlCommand( @"EXEC sptablecollations '" + schems + "." + tablename + "'", conn ) )
            {
                var _reader = _cmd4.ExecuteReader( );
                while( _reader.Read( ) )
                {
                    bool? _isCaseSensitive = null;
                    var _columnName = (string)_reader[ "name" ];
                    if( _reader[ "tdscollation" ] != DBNull.Value )
                    {
                        var _mask = (byte[ ])_reader[ "tdscollation" ];
                        _isCaseSensitive = ( _mask[ 2 ] & 0x10 ) == 0;
                    }

                    if( _isCaseSensitive.HasValue )
                    {
                        foreach( var _csc in _res.Columns )
                        {
                            if( _csc.ColumnName == _columnName )
                            {
                                _csc.IsCaseSensitive = _isCaseSensitive;
                                break;
                            }
                        }
                    }
                }
            }

            try
            {
                var _command = new SqlCommand( @"exec sphelpindex '" + schems + "." + tablename + "'", conn );
                var _reader = _command.ExecuteReader( );
                _res.Indexes = new List<IndexSchema>( );
                while( _reader.Read( ) )
                {
                    var _indexName = (string)_reader[ "indexname" ];
                    var _desc = (string)_reader[ "indexdescription" ];
                    var _indexes = (string)_reader[ "indexkeys" ];
                    if( _desc.Contains( "primary key" ) )
                    {
                        continue;
                    }

                    var _index = BuildIndexSchema( _indexName, _desc, _indexes );
                    _res.Indexes.Add( _index );
                }
            }
            catch( Exception )
            {
                _log.Warn( "failed to read index information for table [" + tablename + "]" );
            }

            return _res;
        }

        /// <summary>
        /// Validates the type of the data.
        /// </summary>
        /// <param name="dataType">Type of the data.</param>
        /// <exception cref="System.ApplicationException">Validation failed for Data type [" + dataType + "]</exception>
        private void ValidateDataType( string dataType )
        {
            if( ( dataType == "int" )
               || ( dataType == "smallint" )
               || ( dataType == "bit" )
               || ( dataType == "float" )
               || ( dataType == "real" )
               || ( dataType == "nvarchar" )
               || ( dataType == "varchar" )
               || ( dataType == "timestamp" )
               || ( dataType == "varbinary" )
               || ( dataType == "image" )
               || ( dataType == "text" )
               || ( dataType == "ntext" )
               || ( dataType == "bigint" )
               || ( dataType == "char" )
               || ( dataType == "numeric" )
               || ( dataType == "binary" )
               || ( dataType == "smalldatetime" )
               || ( dataType == "smallmoney" )
               || ( dataType == "money" )
               || ( dataType == "tinyint" )
               || ( dataType == "uniqueidentifier" )
               || ( dataType == "xml" )
               || ( dataType == "sqlvariant" )
               || ( dataType == "datetime2" )
               || ( dataType == "date" )
               || ( dataType == "time" )
               || ( dataType == "decimal" )
               || ( dataType == "nchar" )
               || ( dataType == "datetime" ) )
            {
                return;
            }

            throw new ApplicationException( "Validation failed for Data type [" + dataType + "]" );
        }

        /// <summary>
        /// Fixes the default value string.
        /// </summary>
        /// <param name="columnDefault">The column default.</param>
        /// <returns></returns>
        private string FixDefaultValueString( string columnDefault )
        {
            var _replaced = false;
            var _res = columnDefault.Trim( );
            var _first = -1;
            var _last = -1;
            for( var _i = 0; _i < _res.Length; _i++ )
            {
                if( ( _res[ _i ] == '\'' )
                   && ( _first == -1 ) )
                {
                    _first = _i;
                }

                if( ( _res[ _i ] == '\'' )
                   && ( _first != -1 )
                   && ( _i > _last ) )
                {
                    _last = _i;
                }
            }

            if( ( _first != -1 )
               && ( _last > _first ) )
            {
                return _res.Substring( _first, _last - _first + 1 );
            }

            var _sb = new StringBuilder( );
            for( var _i = 0; _i < _res.Length; _i++ )
            {
                if( ( _res[ _i ] != '(' )
                   && ( _res[ _i ] != ')' ) )
                {
                    _sb.Append( _res[ _i ] );
                    _replaced = true;
                }
            }

            return _replaced
                ? "(" + _sb + ")"
                : _sb.ToString( );
        }

        /// <summary>
        /// Creates the foreign key schema.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="ts">The ts.</param>
        private void CreateForeignKeySchema( SqlConnection conn, TableSchema ts )
        {
            ts.ForeignKeys = new List<ForeignKeySchema>( );
            var _cmd = new SqlCommand(
                $@"SELECT   ColumnName = CU.COLUMNNAME,   ForeignTableName  = PK.TABLENAME,   ForeignColumnName = PT.COLUMNNAME,   DeleteRule = C.DELETERULE,   IsNullable = COL.ISNULLABLE FROM INFORMATIONSCHEMA.REFERENTIALCONSTRAINTS C INNER JOIN INFORMATIONSCHEMA.TABLECONSTRAINTS FK ON C.CONSTRAINTNAME = FK.CONSTRAINTNAME INNER JOIN INFORMATIONSCHEMA.TABLECONSTRAINTS PK ON C.UNIQUECONSTRAINTNAME = PK.CONSTRAINTNAME INNER JOIN INFORMATIONSCHEMA.KEYCOLUMNUSAGE CU ON C.CONSTRAINTNAME = CU.CONSTRAINTNAME INNER JOIN   (     SELECT i1.TABLENAME, i2.COLUMNNAME     FROM  INFORMATIONSCHEMA.TABLECONSTRAINTS i1     INNER JOIN INFORMATIONSCHEMA.KEYCOLUMNUSAGE i2 ON i1.CONSTRAINTNAME = i2.CONSTRAINTNAME     WHERE i1.CONSTRAINTTYPE = 'PRIMARY KEY'   ) PT ON PT.TABLENAME = PK.TABLENAME INNER JOIN INFORMATIONSCHEMA.COLUMNS AS COL ON CU.COLUMNNAME = COL.COLUMNNAME AND FK.TABLENAME = COL.TABLENAME WHERE FK.TableNAME='{
                    ts.TableName
                }'", conn );

            var _reader = _cmd.ExecuteReader( );
            while( _reader.Read( ) )
            {
                var _fkc = new ForeignKeySchema
                {
                    ColumnName = (string)_reader[ "ColumnName" ],
                    ForeignTableName = (string)_reader[ "ForeignTableName" ],
                    ForeignColumnName = (string)_reader[ "ForeignColumnName" ],
                    CascadeOnDelete = (string)_reader[ "DeleteRule" ] == "CASCADE",
                    IsNullable = (string)_reader[ "IsNullable" ] == "YES",
                    TableName = ts.TableName
                };

                ts.ForeignKeys.Add( _fkc );
            }
        }

        /// <summary>
        /// Builds the index schema.
        /// </summary>
        /// <param name="indexname">The indexname.</param>
        /// <param name="desc">The desc.</param>
        /// <param name="keys">The keys.</param>
        /// <returns></returns>
        /// <exception cref="System.ApplicationException">Illegal key name [" + p + "] in index [" + indexname + "]</exception>
        private IndexSchema BuildIndexSchema( string indexname, string desc, string keys )
        {
            var _res = new IndexSchema { IndexName = indexname };
            var _descparts = desc.Split( ',' );
            for( var _i = 0; _i < _descparts.Length; _i++ )
            {
                var _p = _descparts[ _i ];
                if( _p.Trim( ).Contains( "unique" ) )
                {
                    _res.IsUnique = true;
                    break;
                }
            }

            _res.Columns = new List<IndexColumn>( );
            var _keysparts = keys.Split( ',' );
            foreach( var _p in _keysparts )
            {
                var _m = _keys.Match( _p.Trim( ) );
                if( !_m.Success )
                {
                    throw new ApplicationException( "Illegal key name [" + _p + "] in index [" + indexname + "]" );
                }

                var _ic = new IndexColumn( );
                _res.Columns.Add( _ic );
            }

            return _res;
        }

        /// <summary>
        /// Adjusts the default value.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        private string AdjustDefaultValue( string val )
        {
            if( string.IsNullOrEmpty( val ) )
            {
                return val;
            }

            var _m = _value.Match( val );
            return _m.Success
                ? _m.Groups[ 1 ].Value
                : val;
        }

        /// <summary>
        /// Creates the sq lite connection string.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        private string CreateSQLiteConnectionString( string path, string password )
        {
            var _builder = new SQLiteConnectionStringBuilder { DataSource = path };
            if( password != null )
            {
                _builder.Password = password;
            }

            _builder.PageSize = 4096;
            _builder.UseUTF16Encoding = true;
            var _connectionString = _builder.ConnectionString;
            return _connectionString;
        }

        /// <summary>
        /// Adds the triggers for foreign keys.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="schema">The schema.</param>
        /// <param name="passWord">The pass word.</param>
        private void AddTriggersForForeignKeys( string path, IEnumerable<TableSchema> schema, string passWord )
        {
            var _connectionString = CreateSQLiteConnectionString( path, passWord );
            using( var _connection = new SQLiteConnection( _connectionString ) )
            {
                _connection.Open( );
                foreach( var _item in schema )
                {
                    try
                    {
                        AddTableTriggers( _connection, _item );
                    }
                    catch( Exception _ex )
                    {
                        _log.Error( "AddTableTriggers failed", _ex );
                        throw;
                    }
                }
            }

            _log.Debug( "finished adding triggers to schema" );
        }

        /// <summary>
        /// Adds the table triggers.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="dt">The dt.</param>
        private void AddTableTriggers( SQLiteConnection conn, TableSchema dt )
        {
            var _triggers = TriggerBuilder.GetForeignKeyTriggers( dt );
            for( var _i = 0; _i < _triggers.Count; _i++ )
            {
                var _trigger = _triggers[ _i ];
                var _command = new SQLiteCommand( WriteTriggerSchema( _trigger ), conn );
                _command.ExecuteNonQuery( );
            }
        }
    }
}
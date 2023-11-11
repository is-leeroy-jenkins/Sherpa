//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                SqlServerConverter.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SqlServerConverter.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    SqlServerConverter.cs
//  </summary>
//  ******************************************************************************************

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

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "BadParensLineBreaks" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    public class SqlServerConverter : ConverisonBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerConverter"/> class.
        /// </summary>
        public SqlServerConverter( )
        {
        }

        /// <summary>
        /// Converts the SQL server to sq lite database.
        /// </summary>
        /// <param name="connstring">The connection string.</param>
        /// <param name="filePath">The path.</param>
        /// <param name="passWord">The pass word.</param>
        /// <param name="converter">The handler.</param>
        /// <param name="selector">The selection handler.</param>
        /// <param name="viewer">The failure handler.</param>
        /// <param name="triggers">if set to <c>true</c> [create triggers].</param>
        /// <param name="views">if set to <c>true</c> [create views].</param>
        public void ConvertSqlServerToSQLiteDatabase( string connstring, string filePath,
            string passWord, ConversionCallback converter, SelectionCallback selector, 
            ViewCallback viewer, bool triggers, bool views )
        {
            _cancelled = false;
            ThreadPool.QueueUserWorkItem( delegate
            {
                try
                {
                    _isActive = true;
                    ConvertToSqlite( connstring, filePath, passWord, converter, selector,
                        viewer, triggers, views );

                    _isActive = false;
                    converter( true, true, 100, "Finished converting database" );
                }
                catch( Exception _ex )
                {
                    _log.Error( "Failed to convert SQL Server database to SQLite database", _ex );
                    _isActive = false;
                    converter( true, false, 100, _ex.Message );
                }
            } );
        }

        /// <summary>
        /// Writes the trigger schema.
        /// </summary>
        /// <param name="trigger">The schema.</param>
        /// <returns></returns>
        private string CreateTriggerSchema( TriggerSchema trigger )
        {
            return @"CREATE TRIGGER [" + trigger.Name + "] " + trigger.Type + " " + trigger.Event
                + " ON [" + trigger.Table + "] " + "BEGIN " + trigger.Body + " END;";
        }

        /// <summary>
        /// Converts to sq lite.
        /// </summary>
        /// <param name="connstring">The sql connstring.</param>
        /// <param name="filePath">The path.</param>
        /// <param name="pass">The password.</param>
        /// <param name="converter">The handler.</param>
        /// <param name="selector">The selection handler.</param>
        /// <param name="viewer">The viewfailurehandler.</param>
        /// <param name="triggers">if set to <c>true</c> [createtriggers].</param>
        /// <param name="views">if set to <c>true</c> [createviews].</param>
        private void ConvertToSqlite( string connstring, string filePath, string pass,
            ConversionCallback converter, SelectionCallback selector,
            ViewCallback viewer, bool triggers, bool views = true )
        {
            if( File.Exists( filePath ) )
            {
                File.Delete( filePath );
            }

            var _schema = ReadSqlServerSchema( connstring, converter, selector );
            CreateSqliteDatabase( filePath, _schema, pass, converter, viewer, views );

            CopyDataRows( connstring, filePath, _schema.Tables, pass, converter );
            if( triggers )
            {
                AddForeignKeyTriggers( filePath, _schema.Tables, pass );
            }
        }

        /// <summary>
        /// Copies the data rows.
        /// </summary>
        /// <param name="connstring">The sql connstring.</param>
        /// <param name="filePath">The path.</param>
        /// <param name="schemas">The schema.</param>
        /// <param name="pass">The password.</param>
        /// <param name="converter">The handler.</param>
        private void CopyDataRows( string connstring, string filePath, IList<TableSchema> schemas,
            string pass, ConversionCallback converter )
        {
            CheckCancelled( );
            converter( false, true, 0, "Preparing to insert tables..." );
            _log.Debug( "preparing to insert tables ..." );
            using var _sqlConnection = new SqlConnection( connstring );
            _sqlConnection.Open( );
            var _sqlite = CreateSqliteConnectionString( filePath, pass );
            using var _sqliteConnection = new SQLiteConnection( _sqlite );
            _sqliteConnection.Open( );
            for( var _i = 0; _i < schemas.Count; _i++ )
            {
                var _sqliteTransaction = _sqliteConnection.BeginTransaction( );
                try
                {
                    var _commandText = CreateSqlServerTableQuery( schemas[ _i ] );
                    using var _command = new SqlCommand( _commandText, _sqlConnection );
                    using var _reader = _command.ExecuteReader( );
                    var _insert = CreateSqliteInsert( schemas[ _i ] );
                    var _counter = 0;
                    while( _reader.Read( ) )
                    {
                        _insert.Connection = _sqliteConnection;
                        _insert.Transaction = _sqliteTransaction;
                        var _names = new List<string>( );
                        for( var _j = 0; _j < schemas[ _i ].Columns.Count; _j++ )
                        {
                            var _name = "@" + NormalizeNames(
                                schemas[ _i ].Columns[ _j ].ColumnName, _names );

                            _insert.Parameters[ _name ].Value =
                                CastValueForColumn( _reader[ _j ],
                                    schemas[ _i ].Columns[ _j ] );

                            _names.Add( _name );
                        }

                        _insert.ExecuteNonQuery( );
                        _counter++;
                        if( _counter % 1000 == 0 )
                        {
                            CheckCancelled( );
                            _sqliteTransaction.Commit( );
                            converter( false, true, (int)( 100.0 * _i / schemas.Count ),
                                "Added " + _counter + " rows to table "
                                + schemas[ _i ].TableName + " so far" );

                            _sqliteTransaction = _sqliteConnection.BeginTransaction( );
                        }
                    }

                    CheckCancelled( );
                    _sqliteTransaction.Commit( );
                    converter( false, true, (int)( 100.0 * _i / schemas.Count ),
                        "Finished inserting rows for table " + schemas[ _i ].TableName );

                    _log.Debug( "finished inserting all rows for table ["
                        + schemas[ _i ].TableName + "]" );
                }
                catch( Exception _ex )
                {
                    _log.Error( "unexpected exception", _ex );
                    _sqliteTransaction.Rollback( );
                    throw;
                }
            }
        }

        /// <summary>
        /// Casts the value for column.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="columnSchema">The column schema.</param>
        /// <returns>
        /// </returns>
        private object CastValueForColumn( object value, ColumnSchema columnSchema )
        {
            if( value is DBNull )
            {
                return null;
            }

            var _dbType = GetColumnType( columnSchema );
            switch( _dbType )
            {
                case DbType.Int32:
                {
                    switch( value )
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
                    switch( value )
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
                    switch( value )
                    {
                        case int _i:
                        {
                            return (long)_i;
                        }
                        case short _s:
                        {
                            return (long)_s;
                        }
                        case byte _b:
                        {
                            return (long)_b;
                        }
                        case decimal _val1:
                        {
                            return (long)_val1;
                        }
                    }

                    break;
                }
                case DbType.Single:
                {
                    switch( value )
                    {
                        case double _d:
                        {
                            return (float)_d;
                        }
                        case decimal _val1:
                        {
                            return (float)_val1;
                        }
                    }

                    break;
                }
                case DbType.Double:
                {
                    switch( value )
                    {
                        case float _f:
                        {
                            return (double)_f;
                        }
                        case double _d:
                        {
                            return _d;
                        }
                        case decimal _val1:
                        {
                            return (double)_val1;
                        }
                    }

                    break;
                }
                case DbType.String:
                {
                    if( value is Guid _guid )
                    {
                        return _guid.ToString( );
                    }

                    break;
                }
                case DbType.Guid:
                {
                    switch( value )
                    {
                        case string _s:
                        {
                            return ParseStringAsGuid( _s );
                        }
                        case byte[ ] _bytes:
                        {
                            return ParseBlobAsGuid( _bytes );
                        }
                    }

                    break;
                }

                case DbType.Binary:
                case DbType.Boolean:
                case DbType.DateTime:
                {
                    break;
                }
                default:
                {
                    _log.Error( "argument exception - illegal database type" );
                    throw new ArgumentException( "Illegal database type ["
                        + Enum.GetName( typeof( DbType ), _dbType ) + "]" );
                }
            }

            return value;
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
        /// <param name="text">The string.</param>
        /// <returns></returns>
        private Guid ParseStringAsGuid( string text )
        {
            try
            {
                return new Guid( text );
            }
            catch( Exception )
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// Builds the sq lite insert.
        /// </summary>
        /// <param name="tableSchema">The ts.</param>
        /// <returns></returns>
        private SQLiteCommand CreateSqliteInsert( TableSchema tableSchema )
        {
            var _command = new SQLiteCommand( );
            var _builder = new StringBuilder( );
            _builder.Append( $"INSERT INTO {tableSchema.TableName}" );
            for( var _i = 0; _i < tableSchema.Columns.Count; _i++ )
            {
                _builder.Append( "[" + tableSchema.Columns[ _i ].ColumnName + "]" );
                if( _i < tableSchema.Columns.Count - 1 )
                {
                    _builder.Append( ", " );
                }
            }

            _builder.Append( ") VALUES (" );
            var _names = new List<string>( );
            for( var _i = 0; _i < tableSchema.Columns.Count; _i++ )
            {
                var _name = "@" + NormalizeNames( tableSchema.Columns[ _i ].ColumnName, _names );
                _builder.Append( _name );
                if( _i < tableSchema.Columns.Count - 1 )
                {
                    _builder.Append( ", " );
                }

                var _dbType = GetColumnType( tableSchema.Columns[ _i ] );
                var _parameter = new SQLiteParameter( _name, _dbType,
                    tableSchema.Columns[ _i ].ColumnName );

                _command.Parameters.Add( _parameter );
                _names.Add( _name );
            }

            _builder.Append( ')' );
            _command.CommandText = _builder.ToString( );
            _command.CommandType = CommandType.Text;
            return _command;
        }

        /// <summary>
        /// Gets the name of the normalized.
        /// </summary>
        /// <param name="text">The string.</param>
        /// <param name="names">The names.</param>
        /// <returns></returns>
        private string NormalizeNames( string text, ICollection<string> names )
        {
            var _builder = new StringBuilder( );
            for( var _i = 0; _i < text.Length; _i++ )
            {
                if( char.IsLetterOrDigit( text[ _i ] ) )
                {
                    _builder.Append( text[ _i ] );
                }
                else
                {
                    _builder.Append( "" );
                }
            }

            return names.Contains( _builder.ToString( ) )
                ? NormalizeNames( _builder + "", names )
                : _builder.ToString( );
        }

        /// <summary>
        /// Gets the database type of column.
        /// </summary>
        /// <param name="column">
        /// The column schema.
        /// </param>
        /// <returns></returns>
        private DbType GetColumnType( ColumnSchema column )
        {
            switch( column.ColumnType )
            {
                case "tinyint":
                {
                    return DbType.Byte;
                }
                case "int":
                {
                    return DbType.Int32;
                }
                case "smallint":
                {
                    return DbType.Int16;
                }
                case "bigint":
                {
                    return DbType.Int64;
                }
                case "bit":
                {
                    return DbType.Boolean;
                }
                case "nvarchar":
                case "varchar":
                case "text":
                case "ntext":
                {
                    return DbType.String;
                }
                case "float":
                {
                    return DbType.Double;
                }
                case "real":
                {
                    return DbType.Single;
                }
                case "blob":
                {
                    return DbType.Binary;
                }
                case "numeric":
                {
                    return DbType.Double;
                }
                case "timestamp":
                case "datetime":
                case "datetime2":
                case "date":
                case "time":
                {
                    return DbType.DateTime;
                }
                case "nchar":
                case "char":
                {
                    return DbType.String;
                }
                case "uniqueidentifier":
                case "guid":
                {
                    return DbType.Guid;
                }
                case "xml":
                {
                    return DbType.String;
                }
                case "sqlvariant":
                {
                    return DbType.Object;
                }
                case "integer":
                {
                    return DbType.Int64;
                }
                default:
                {
                    _log.Error( "illegal db type found" );
                    var _message = "Illegal type (" + column.ColumnType + ")";
                    throw new ApplicationException( _message );
                }
            }
        }

        /// <summary>
        /// Builds the SQL server table query.
        /// </summary>
        /// <param name="table">The ts.</param>
        /// <returns></returns>
        private string CreateSqlServerTableQuery( TableSchema table )
        {
            var _builder = new StringBuilder( );
            _builder.Append( "SELECT " );
            for( var _i = 0; _i < table.Columns.Count; _i++ )
            {
                _builder.Append( "[" + table.Columns[ _i ].ColumnName + "]" );
                if( _i < table.Columns.Count - 1 )
                {
                    _builder.Append( ", " );
                }
            }

            var _sql = " FROM " 
                + table.TableSchemaName 
                + "." 
                + "["
                + table.TableName 
                + "]";

            _builder.Append( _sql );

            return _builder?.ToString( );
        }

        /// <summary>
        /// Creates the sq lite database.
        /// </summary>
        /// <param name="filePath">The path.</param>
        /// <param name="dataSchema">The schema.</param>
        /// <param name="passWord">The pass word.</param>
        /// <param name="converter">The handler.</param>
        /// <param name="viewer">The view failure handler.</param>
        /// <param name="views">if set to <c>true</c> [create views].</param>
        private void CreateSqliteDatabase( string filePath, DataSchema dataSchema, string passWord,
            ConversionCallback converter, ViewCallback viewer, bool views )
        {
            _log.Debug( "Creating SQLite database..." );
            _log.Debug( "SQLite file was created successfully at [" + filePath + "]" );
            var _connstring = CreateSqliteConnectionString( filePath, passWord );
            using var _connection = new SQLiteConnection( _connstring );
            _connection.Open( );
            var _count = 0;
            foreach( var _dt in dataSchema.Tables )
            {
                try
                {
                    AddSqliteTable( _connection, _dt );
                }
                catch( Exception _ex )
                {
                    _log.Error( "AddSQLiteTable failed", _ex );
                    throw;
                }

                _count++;
                CheckCancelled( );
                converter( false, true, (int)( _count * 50.0 / dataSchema.Tables.Count ),
                    "Added table " + _dt.TableName + " to the SQLite database" );

                _log.Debug( "added schema for SQLite table [" + _dt.TableName + "]" );
            }

            _count = 0;
            if( views )
            {
                foreach( var _viewSchema in dataSchema.Views )
                {
                    try
                    {
                        AddSqliteView( _connection, _viewSchema, viewer );
                    }
                    catch( Exception _ex )
                    {
                        _log.Error( "AddSQLiteView failed", _ex );
                        throw;
                    }

                    _count++;
                    CheckCancelled( );
                    converter( false, true, 50 + (int)( _count * 50.0 / dataSchema.Views.Count ),
                        "Added view " + _viewSchema.ViewName + " to the SQLite database" );

                    _log.Debug( "added schema for SQLite view [" + _viewSchema.ViewName + "]" );
                }
            }

            _log.Debug( "finished adding all table/view schemas for SQLite database" );
        }

        /// <summary>
        /// Adds the sq lite view.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="viewSchema">The vs.</param>
        /// <param name="viewer">The handler.</param>
        private void AddSqliteView( SQLiteConnection connection, ViewSchema viewSchema, 
            ViewCallback viewer )
        {
            var _sql = viewSchema.ViewSql;
            _log.Info( "\n\n" + _sql + "\n\n" );
            var _transaction = connection.BeginTransaction( );
            try
            {
                using var _command = new SQLiteCommand( _sql, connection, _transaction );
                _command.ExecuteNonQuery( );

                _transaction.Commit( );
            }
            catch( SQLiteException _ex )
            {
                _transaction.Rollback( );
                if( viewer != null )
                {
                    var _updated = new ViewSchema
                    {
                        ViewName = viewSchema.ViewName,
                        ViewSql = viewSchema.ViewSql
                    };

                    var _text = viewer( _updated );
                    if( _text == null )
                    {
                    }
                    else
                    {
                        _updated.ViewSql = _text;
                        AddSqliteView( connection, _updated, viewer );
                    }
                }
                else
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Adds the sql lite table.
        /// </summary>
        /// <param name="connection">
        /// The connection.
        /// </param>
        /// <param name="tableSchema">
        /// The dt.
        /// </param>
        private void AddSqliteTable( SQLiteConnection connection, TableSchema tableSchema )
        {
            var _commandText = CreateTableQuery( tableSchema );
            _log.Info( "\n\n" + _commandText + "\n\n" );
            var _command = new SQLiteCommand( _commandText, connection );
            _command.ExecuteNonQuery( );
        }

        /// <summary>
        /// Builds the create table query.
        /// </summary>
        /// <param name="table">The schema.</param>
        /// <returns>
        /// </returns>
        private string CreateTableQuery( TableSchema table )
        {
            var _builder = new StringBuilder( );
            _builder.Append( $"CREATE TABLE {table.TableName}" );
            var _key = false;
            for( var _i = 0; _i < table.Columns.Count; _i++ )
            {
                var _column = table.Columns[ _i ];
                var _statement = BuildColumnStatement( _column, table, ref _key );
                _builder.Append( _statement );
                if( _i < table.Columns.Count - 1 )
                {
                    _builder.Append( ",\n" );
                }
            }

            if( table.PrimaryKey != null
               && ( table.PrimaryKey.Count > 0 ) & !_key )
            {
                _builder.Append( ",\n" );
                _builder.Append( " PRIMARY KEY (");
                for( var _i = 0; _i < table.PrimaryKey.Count; _i++ )
                {
                    var _text = @$"{table.PrimaryKey[ _i ]};";
                    _builder.Append( _text );
                    if( _i < table.PrimaryKey.Count - 1 )
                    {
                        _builder.Append( ", " );
                    }
                }

                _builder.Append( ")\n" );
            }
            else
            {
                _builder.Append( '\n' );
            }

            if( table.ForeignKeys.Count > 0 )
            {
                _builder.Append( ",\n" );
                for( var _i = 0; _i < table.ForeignKeys.Count; _i++ )
                {
                    var _foreignKey = table.ForeignKeys[ _i ];
                    var _statement = $"FOREIGN KEY ([{_foreignKey.ColumnName}])\n "
                        + @$"REFERENCES [{_foreignKey.ForeignTableName}]"
                        + @$"([{_foreignKey.ForeignColumnName}])";

                    _builder.Append( _statement );
                    if( _i < table.ForeignKeys.Count - 1 )
                    {
                        _builder.Append( ",\n" );
                    }
                }
            }

            _builder.Append( '\n' );
            _builder.Append( ");\n" );
            if( table.Indexes != null )
            {
                for( var _i = 0; _i < table.Indexes.Count; _i++ )
                {
                    var _stmt = CreateIndex( table.TableName, table.Indexes[ _i ] );
                    _builder.Append( _stmt + ";\n" );
                }
            }

            var _query = _builder.ToString( );
            return _query;
        }

        /// <summary>
        /// Builds the index of the create.
        /// </summary>
        /// <param name="tableName">The tablename.</param>
        /// <param name="index">The schema.</param>
        /// <returns>
        /// </returns>
        private string CreateIndex( string tableName, IndexSchema index )
        {
            var _builder = new StringBuilder( );
            _builder.Append( "CREATE " );
            if( index.IsUnique )
            {
                _builder.Append( "UNIQUE " );
            }

            _builder.Append( "INDEX [" + tableName + "" + index.IndexName + "]\n" );
            _builder.Append( "ON [" + tableName + "]\n" );
            _builder.Append( '(' );
            for( var _i = 0; _i < index.Columns.Count; _i++ )
            {
                _builder.Append( "[" + index.Columns[ _i ] + "]" );
                if( index.Columns[ _i ] != null )
                {
                    _builder.Append( " DESC" );
                }

                if( _i < index.Columns.Count - 1 )
                {
                    _builder.Append( ", " );
                }
            }

            _builder.Append( ')' );
            return _builder.ToString( );
        }

        /// <summary>
        /// Builds the column statement.
        /// </summary>
        /// <param name="columnSchema">The column.</param>
        /// <param name="tableSchema">The schema.</param>
        /// <param name="primaryKey">if set to <c>true</c> [primary key].</param>
        /// <returns></returns>
        private string BuildColumnStatement( ColumnSchema columnSchema, TableSchema tableSchema,
            ref bool primaryKey )
        {
            var _builder = new StringBuilder( );
            _builder.Append( "\t[" + columnSchema.ColumnName + "]\t" );
            if( columnSchema.IsIdentity )
            {
                if( tableSchema.PrimaryKey.Count == 1
                   && ( columnSchema.ColumnType == "tinyint" || columnSchema.ColumnType == "int"
                       || columnSchema.ColumnType == "smallint"
                       || columnSchema.ColumnType == "bigint"
                       || columnSchema.ColumnType == "integer" ) )
                {
                    _builder.Append( "integer PRIMARY KEY AUTOINCREMENT" );
                    primaryKey = true;
                }
                else
                {
                    _builder.Append( "integer" );
                }
            }
            else
            {
                switch( columnSchema.ColumnType )
                {
                    case "int":
                    {
                        _builder.Append( "integer" );
                        break;
                    }
                    default:
                    {
                        _builder.Append( columnSchema.ColumnType );
                        break;
                    }
                }

                if( columnSchema.Length > 0 )
                {
                    _builder.Append( "(" + columnSchema.Length + ")" );
                }
            }

            if( !columnSchema.IsNullable )
            {
                _builder.Append( " NOT NULL" );
            }

            if( columnSchema.IsCaseSensitive == false )
            {
                _builder.Append( " COLLATE NOCASE" );
            }

            var _default = StripParens( columnSchema.DefaultValue );
            _default = DiscardNational( _default );
            _log.Debug( "DEFAULT VALUE BEFORE [" + columnSchema.DefaultValue + "] AFTER ["
                + _default + "]" );

            switch( string.IsNullOrEmpty( _default ) )
            {
                case false when _default.ToUpper( ).Contains( "GETDATE" ):
                {
                    _log.Debug( @$"Converted SQL Server {tableSchema.TableName} to {columnSchema.ColumnType} for Column ["
                        + columnSchema.ColumnName + "]" );

                    _builder.Append( " DEFAULT (CURRENTTIMESTAMP)" );
                    break;
                }
                case false when IsValidDefaultValue( _default ):
                {
                    _builder.Append( " DEFAULT " + _default );
                    break;
                }
            }

            return _builder.ToString( );
        }

        /// <summary>
        /// Discards the national.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private string DiscardNational( string value )
        {
            var _regex = new Regex( @"N\'([^\']*)\'" );
            var _match = _regex.Match( value );
            return _match.Success
                ? _match.Groups[ 1 ].Value
                : value;
        }

        /// <summary>
        /// Determines whether [is valid default value] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if [is valid default value] [the specified value];
        /// otherwise, <c>false</c>.
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
        /// <param name="connstring">The connection string.</param>
        /// <param name="converter">The handler.</param>
        /// <param name="selector">The selection handler.</param>
        /// <returns></returns>
        private DataSchema ReadSqlServerSchema( string connstring,
            ConversionCallback converter, SelectionCallback selector )
        {
            var _tables = new List<TableSchema>( );
            using var _sqlConnection = new SqlConnection( connstring );
            _sqlConnection.Open( );
            var _tableNames = new List<string>( );
            var _tableSchema = new List<string>( );
            const string SQL =
                @"SELECT * FROM INFORMATIONSCHEMA.TABLES  WHERE TABLETYPE = 'BASE TABLE'";

            using var _sqlCommand = new SqlCommand( SQL, _sqlConnection );
            var _sqlReader = _sqlCommand.ExecuteReader( );
            while( _sqlReader.Read( ) )
            {
                if( _sqlReader[ "TABLENAME" ] == DBNull.Value )
                {
                    continue;
                }

                if( _sqlReader[ "TABLESCHEMA" ] == DBNull.Value )
                {
                    continue;
                }

                _tableNames.Add( (string)_sqlReader[ "TABLENAME" ] );
                _tableSchema.Add( (string)_sqlReader[ "TABLESCHEMA" ] );
            }

            var _count = 0;
            for( var _i = 0; _i < _tableNames.Count; _i++ )
            {
                var _name = _tableNames[ _i ];
                var _table = _tableSchema[ _i ];
                var _schema = CreateTableSchema( _sqlConnection, _name, _table );
                CreateForeignKeySchema( _sqlConnection, _schema );
                _tables.Add( _schema );
                _count++;
                CheckCancelled( );
                converter( false, true, (int)( _count * 50.0 / _tableNames.Count ),
                    "Parsed table " + _name );

                _log.Debug( "Parsed table for [" + _name + "]" );
            }

            _log.Debug( "Finished parsing all tables in the Database" );
            var _updated = selector?.Invoke( _tables );
            if( _updated != null )
            {
                _tables = _updated;
            }

            var _regex = new Regex( @"dbo\.", RegexOptions.Compiled | RegexOptions.IgnoreCase );
            var _views = new List<ViewSchema>( );
            using var _connection = new SqlConnection( connstring );
            _connection.Open( );
            string _sql = @"SELECT TABLENAME, VIEWDEFINITION  FROM INFORMATIONSCHEMA.VIEWS";
            using var _command = new SqlCommand( _sql, _connection );
            using var _reader = _command.ExecuteReader( );
            _count = 0;
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
                converter( false, true, 50 + (int)( _count * 50.0 / _views.Count ),
                    "Parsed view " + _schema.ViewName );

                _log.Debug( "parsed view schema for [" + _schema.ViewName + "]" );
            }

            var _dataSchema = new DataSchema
            {
                Tables = _tables,
                Views = _views
            };

            return _dataSchema;
        }

        /// <summary>
        /// Creates the table schema.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="tableName">The tablename.</param>
        /// <param name="schemaName">The schemas.</param>
        /// <returns></returns>
        private TableSchema CreateTableSchema( SqlConnection connection, string tableName, string schemaName )
        {
            var _table = new TableSchema
            {
                TableName = tableName,
                TableSchemaName = schemaName,
                Columns = new List<ColumnSchema>( )
            };

            var _query =
                @"SELECT COLUMNNAME, COLUMNDEFAULT, ISNULLABLE, DATATYPE, (ColumnProperty(ObjectID(TABLENAME), "
                + @"COLUMNNAME, 'IsIdentity')) A[IDENT], "
                + @"CHARACTER MAXIMUMLENGTH AS CSIZE FROM INFORMATIONSCHEMA.COLUMNS WHERE "
                + @"TABLENAME = '{tablename}' ORDER BY ORDINALPOSITION ASC";

            using var _sqlDataCommand = new SqlCommand( _query, connection );
            using var _sqlDataReader = _sqlDataCommand.ExecuteReader( );
            while( _sqlDataReader.Read( ) )
            {
                var _temp = _sqlDataReader[ "COLUMN NAME" ];
                if( _temp is DBNull )
                {
                    continue;
                }

                var _columnName = (string)_sqlDataReader[ "COLUMN NAME" ];
                _temp = _sqlDataReader[ "COLUMN DEFAULT" ];
                var _columnDefault = true & _temp is DBNull
                    ? string.Empty
                    : (string)_temp;

                _temp = _sqlDataReader[ "IS NULLABLE" ];
                var _nullable = (string)_temp == "YES";
                var _dataType = (string)_sqlDataReader[ "DATA TYPE" ];
                var _isIdentity = false;
                if( _sqlDataReader[ "IDENT" ] != DBNull.Value )
                {
                    if( (int)_sqlDataReader[ "IDENT" ] == 1 )
                    {
                        _isIdentity = true;
                    }
                }

                var _length = _sqlDataReader[ "CSIZE" ] != DBNull.Value
                    ? Convert.ToInt32( _sqlDataReader[ "CSIZE" ] )
                    : 0;

                VerifySqlServerType( _dataType );
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

                if( _dataType == "bit"
                   || _dataType == "int" )
                {
                }

                _columnDefault = CorrectDefaultColumnValue( _columnDefault );
                var _column = new ColumnSchema
                {
                    ColumnName = _columnName,
                    ColumnType = _dataType,
                    Length = _length,
                    IsNullable = _nullable,
                    IsIdentity = _isIdentity,
                    DefaultValue = AdjustDefaultColumnValue( _columnDefault )
                };

                _table.Columns.Add( _column );
            }

            using var _sqlCommand = new SqlCommand( $"EXEC sppkeys '{tableName}'", connection );
            using var _dataReader = _sqlCommand.ExecuteReader( );
            _table.PrimaryKey = new List<string>( );
            while( _dataReader.Read( ) )
            {
                var _item = (string)_dataReader[ "COLUMNNAME" ];
                _table.PrimaryKey.Add( _item );
            }

            var _sql = $@"EXEC SP TABLE COLLATIONS ' {schemaName}.{tableName} '";
            using var _columnCommand = new SqlCommand( _sql, connection );
            var _columnReader = _columnCommand.ExecuteReader( );
            while( _columnReader.Read( ) )
            {
                bool? _caseSensitive = null;
                var _columnName = _columnReader[ "name" ].ToString( );
                if( _columnReader[ "tdscollation" ] != DBNull.Value )
                {
                    var _mask = (byte[ ])_columnReader[ "tdscollation" ];
                    _caseSensitive = ( _mask[ 2 ] & 0x10 ) == 0;
                }

                if( _caseSensitive.HasValue )
                {
                    foreach( var _csc in _table.Columns )
                    {
                        if( _csc.ColumnName == _columnName )
                        {
                            _csc.IsCaseSensitive = _caseSensitive;
                            break;
                        }
                    }
                }
            }

            try
            {
                var _text = @$"EXEC SP HELP INDEX ' {schemaName}.{tableName} ' ";
                using var _command = new SqlCommand( _text, connection );
                using var _reader = _command.ExecuteReader( );
                _table.Indexes = new List<IndexSchema>( );
                while( _reader.Read( ) )
                {
                    var _indexName = (string)_reader[ "indexname" ];
                    var _desc = (string)_reader[ "indexdescription" ];
                    var _indexes = (string)_reader[ "indexkeys" ];
                    if( _desc.Contains( "primary key" ) )
                    {
                        continue;
                    }

                    var _index = CreateIndexSchema( _indexName, _desc, _indexes );
                    _table.Indexes.Add( _index );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }

            return _table;
        }

        /// <summary>
        /// Creates the foreign key schema.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="table">The ts.</param>
        private void CreateForeignKeySchema( SqlConnection connection, TableSchema table )
        {
            table.ForeignKeys = new List<ForeignKeySchema>( );
            var _sql = @"SELECT ColumnName = CU.COLUMNNAME, ForeignTableName  = PK.TABLENAME, "
                + @"ForeignColumnName = PT.COLUMNNAME,   DeleteRule = C.DELETERULE, "
                + @"IsNullable = COL.ISNULLABLE FROM INFORMATIONSCHEMA.REFERENTIALCONSTRAINTS C "
                + @"INNER JOIN INFORMATIONSCHEMA.TABLECONSTRAINTS FK ON C.CONSTRAINTNAME = FK.CONSTRAINTNAME "
                + @"INNER JOIN INFORMATIONSCHEMA.TABLECONSTRAINTS PK ON C.UNIQUECONSTRAINTNAME = PK.CONSTRAINTNAME "
                + @"INNER JOIN INFORMATIONSCHEMA.KEYCOLUMNUSAGE CU ON C.CONSTRAINTNAME = CU.CONSTRAINTNAME "
                + @"INNER JOIN (SELECT i1.TABLENAME, i2.COLUMNNAME FROM INFORMATIONSCHEMA.TABLECONSTRAINTS i1 "
                + @"INNER JOIN INFORMATIONSCHEMA.KEYCOLUMNUSAGE i2 ON i1.CONSTRAINTNAME = i2.CONSTRAINTNAME "
                + @"WHERE i1.CONSTRAINTTYPE = 'PRIMARY KEY'   ) PT ON PT.TABLENAME = PK.TABLENAME "
                + @"INNER JOIN INFORMATIONSCHEMA.COLUMNS AS COL ON CU.COLUMNNAME = COL.COLUMNNAME AND "
                + @$"FK.TABLENAME = COL.TABLENAME WHERE FK.TableNAME='{table.TableName}'";

            using var _command = new SqlCommand( _sql, connection );
            using var _reader = _command.ExecuteReader( );
            while( _reader.Read( ) )
            {
                var _keySchema = new ForeignKeySchema
                {
                    ColumnName = (string)_reader[ "ColumnName" ],
                    ForeignTableName = (string)_reader[ "ForeignTableName" ],
                    ForeignColumnName = (string)_reader[ "ForeignColumnName" ],
                    CascadeOnDelete = (string)_reader[ "DeleteRule" ] == "CASCADE",
                    IsNullable = (string)_reader[ "IsNullable" ] == "YES",
                    TableName = table.TableName
                };

                table.ForeignKeys.Add( _keySchema );
            }
        }

        /// <summary>
        /// Builds the index schema.
        /// </summary>
        /// <param name="name">The index name.</param>
        /// <param name="info">The desc.</param>
        /// <param name="keys">The keys.</param>
        /// <returns>
        /// </returns>
        private IndexSchema CreateIndexSchema( string name, string info, string keys )
        {
            var _index = new IndexSchema
            {
                IndexName = name
            };

            var _parts = info.Split( ',' );
            for( var _i = 0; _i < _parts.Length; _i++ )
            {
                var _part = _parts[ _i ];
                if( _part.Trim( ).Contains( "unique" ) )
                {
                    _index.IsUnique = true;
                    break;
                }
            }

            _index.Columns = new List<IndexColumn>( );
            var _items = keys.Split( ',' );
            foreach( var _item in _items )
            {
                var _match = _keys.Match( _item.Trim( ) );
                if( !_match.Success )
                {
                    var _message = @$"Illegal key name [' {_item} '] in index [ '{name} ']";
                    throw new ApplicationException( _message );
                }

                var _column = new IndexColumn( );
                _index.Columns.Add( _column );
            }

            return _index;
        }

        /// <summary>
        /// Creates the sq lite connection string.
        /// </summary>
        /// <param name="filePath">The path.</param>
        /// <param name="passWord">The password.
        /// </param>
        /// <returns></returns>
        private string CreateSqliteConnectionString( string filePath, string passWord )
        {
            var _builder = new SQLiteConnectionStringBuilder
            {
                DataSource = filePath
            };

            if( passWord != null )
            {
                _builder.Password = passWord;
            }

            _builder.PageSize = 4096;
            _builder.UseUTF16Encoding = true;
            var _connectionString = _builder.ConnectionString;
            return !string.IsNullOrEmpty( _connectionString )
                ? _connectionString
                : string.Empty;
        }

        /// <summary>
        /// Adds the triggers for foreign keys.
        /// </summary>
        /// <param name="filePath">The path.</param>
        /// <param name="schemas">The schema.</param>
        /// <param name="password">The pass word.</param>
        private void AddForeignKeyTriggers( string filePath, IEnumerable<TableSchema> schemas,
            string password )
        {
            var _connstring = CreateSqliteConnectionString( filePath, password );
            using var _connection = new SQLiteConnection( _connstring );
            _connection?.Open( );
            foreach( var _item in schemas )
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

            _log.Debug( "finished adding triggers to schema" );
        }

        /// <summary>
        /// Adds the table triggers.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="table">The dt.</param>
        private void AddTableTriggers( SQLiteConnection connection, TableSchema table )
        {
            var _triggers = TriggerFactory.GetForeignKeyTriggers( table );
            for( var _i = 0; _i < _triggers.Count; _i++ )
            {
                var _trig = _triggers[ _i ];
                using var _command = new SQLiteCommand( CreateTriggerSchema( _trig ), connection );
                _command.ExecuteNonQuery( );
            }
        }
    }
}
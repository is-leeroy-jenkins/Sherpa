﻿namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Configuration.ConfigurationManager;
    using static System.IO.Path;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public class AsyncConnection
    {
        /// <summary>
        /// The source
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected Provider _provider;

        /// <summary>
        ///  
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected DbConnection _connection;

        /// <summary>
        ///  
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected string _clientPath;

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        ///  
        /// </value>
        private protected EXT _extension;

        /// <summary>
        ///  
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected ISqlStatement _sqlStatement;

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected string _pathExtension;
        
        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected string _filePath;

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected string _fileName;

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected string _tableName;

        /// <summary>
        /// 
        /// </summary>
        /// <value>
        /// 
        /// </value>
        private protected string _connectionString;

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public DbConnection Connection
        {
            get
            {
                return _connection;
            }
            private protected set
            {
                _connection = value;
            }
        }

        /// <summary>
        /// Gets or sets the client path.
        /// </summary>
        /// <value>
        /// The client path.
        /// </value>
        public string ClientPath
        {
            get
            {
                return _clientPath;
            }
            private protected set
            {
                _clientPath = value;
            }
        }

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

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public EXT Extension
        {
            get
            {
                return _extension;
            }
            private protected set
            {
                _extension = value;
            }
        }

        /// <summary>
        /// Gets or sets the path extension.
        /// </summary>
        /// <value>
        /// The path extension.
        /// </value>
        public string PathExtension
        {
            get
            {
                return _pathExtension;
            }
            private protected set
            {
                _pathExtension = value;
            }
        }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath
        {
            get
            {
                return _filePath;
            }
            private protected set
            {
                _filePath = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName
        {
            get
            {
                return _fileName;
            }
            private protected set
            {
                _fileName = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName
        {
            get
            {
                return _tableName;
            }
            private protected set
            {
                _tableName = value;
            }
        }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            private protected set
            {
                _connectionString = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="AsyncConnection"/> class.
        /// </summary>
        public AsyncConnection( )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.AsyncConnection" /> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        public AsyncConnection( string fullPath )
            : this( )
        {
            _source = Source.External;
            _filePath = fullPath;
            _fileName = GetFileNameWithoutExtension( fullPath );
            _tableName = _fileName;
            _pathExtension = GetExtension( fullPath )?.Replace( ".", "" );
            if( !string.IsNullOrEmpty( _pathExtension ) )
            {
                _extension = (EXT)Enum.Parse( typeof( EXT ), _pathExtension.ToUpper( ) );
                _provider = (Provider)Enum.Parse( typeof( Provider ), _pathExtension.ToUpper( ) );
                _clientPath = AppSettings[ _extension.ToString( ) ];
                _connectionString = CreateConnectionString( _provider );
            }
        }
        
        /// <summary>
        /// Gets the database client path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private protected string GetDbClientPath( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    return provider switch
                    {
                        Provider.Access => AppSettings[ "ACCDB" ],
                        Provider.SQLite => AppSettings[ "DB" ],
                        Provider.SqlCe => AppSettings[ "SDF" ],
                        Provider.Excel => AppSettings[ "XLSX" ],
                        Provider.SqlServer => AppSettings[ "MDF" ],
                        Provider.CSV => AppSettings[ "CSV" ],
                        Provider.Text => AppSettings[ "TXT" ],
                        _ => AppSettings[ "ACCDB" ]
                    };
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the database client path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private protected string GetDbClientPath( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && HasExtension( filePath ) )
            {
                try
                {
                    var _file = GetExtension( filePath )
                        ?.Replace( ".", "" )
                        ?.ToUpper( );

                    if( !string.IsNullOrEmpty( _file ) )
                    {
                        _extension = (EXT)Enum.Parse( typeof( EXT ), _file );
                        var _names = Enum.GetNames( typeof( EXT ) );
                        if( _names?.Contains( _extension.ToString( ) ) == true )
                        {
                            _clientPath = AppSettings[ $"{_extension}" ];
                            return !string.IsNullOrEmpty( _clientPath )
                                ? _clientPath
                                : string.Empty;
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
        /// Creates the connection string.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        private protected virtual string CreateConnectionString( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider )
               && !string.IsNullOrEmpty( _filePath ) )
            {
                try
                {
                    _connectionString = ConnectionStrings[ provider.ToString( ) ]?.ConnectionString;
                    return !string.IsNullOrEmpty( _connectionString )
                        ? _connectionString?.Replace( $"{_filePath}", _filePath )
                        : string.Empty;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Creates the connection string.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private protected string CreateConnectionString( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && System.IO.File.Exists( filePath )
               && HasExtension( filePath ) )
            {
                try
                {
                    var _file = GetExtension( filePath );
                    if( !string.IsNullOrEmpty( _file ) )
                    {
                        var _ext = (EXT)Enum.Parse( typeof( EXT ), _file.ToUpper( ) );
                        var _names = Enum.GetNames( typeof( EXT ) );
                        if( _names?.Contains( _ext.ToString( ) ) == true )
                        {
                            _connectionString = ConnectionStrings[ $"{_ext}" ]?.ConnectionString;
                            return !string.IsNullOrEmpty( _connectionString )
                                ? _connectionString
                                : string.Empty;
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
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ConnectionBase.cs" company="Terry D. Eppler">
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
//   ConnectionBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using static System.Configuration.ConfigurationManager;
    using static System.IO.Path;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class ConnectionBase
    {
        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public DbConnection Connection { get; set; }

        /// <summary>
        /// Gets or sets the client path.
        /// </summary>
        /// <value>
        /// The client path.
        /// </value>
        public string ClientPath { get; set; }

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
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public EXT Extension { get; set; }

        /// <summary>
        /// Gets or sets the path extension.
        /// </summary>
        /// <value>
        /// The path extension.
        /// </value>
        public string PathExtension { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBase"/>
        /// class.
        /// </summary>
        protected ConnectionBase( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ConnectionBase"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        protected ConnectionBase( string fullPath )
            : this( )
        {
            Source = Source.External;
            FilePath = fullPath;
            FileName = GetFileNameWithoutExtension( fullPath );
            TableName = FileName;
            PathExtension = GetExtension( fullPath )?.Replace( ".", "" );
            if( !string.IsNullOrEmpty( PathExtension ) )
            {
                Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension.ToUpper( ) );
                Provider = (Provider)Enum.Parse( typeof( Provider ), PathExtension.ToUpper( ) );
                ClientPath = AppSettings[ Extension.ToString( ) ];
                ConnectionString = CreateConnectionString( Provider );
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ConnectionBase"/>
        /// class.
        /// </summary>
        /// <param name="fullPath"> The full path. </param>
        /// <param name="provider"> The provider. </param>
        protected ConnectionBase( string fullPath, Provider provider = Provider.Access )
            : this( )
        {
            Source = Source.External;
            Provider = provider;
            FilePath = fullPath;
            FileName = GetFileNameWithoutExtension( fullPath );
            TableName = FileName;
            PathExtension = GetExtension( fullPath )?.Replace( ".", "" );
            if( !string.IsNullOrEmpty( PathExtension ) )
            {
                Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension.ToUpper( ) );
                ClientPath = AppSettings[ Extension.ToString( ) ];
                ConnectionString = CreateConnectionString( Provider );
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ConnectionBase"/>
        /// class.
        /// </summary>
        /// <param name="source"> The source. </param>
        /// <param name="provider"> The provider. </param>
        protected ConnectionBase( Source source, Provider provider = Provider.Access )
            : this( )
        {
            Source = source;
            Provider = provider;
            TableName = source.ToString( );
            FilePath = GetDbClientPath( provider );
            ConnectionString = CreateConnectionString( provider );
            PathExtension = GetExtension( FilePath )?.Replace( ".", "" );
            FileName = GetFileNameWithoutExtension( FilePath );
            if( !string.IsNullOrEmpty( PathExtension ) )
            {
                Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension.ToUpper( ) );
                ClientPath = AppSettings[ Extension.ToString( ) ];
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
                        var _extension = (EXT)Enum.Parse( typeof( EXT ), _file );
                        var _names = Enum.GetNames( typeof( EXT ) );
                        if( _names?.Contains( _extension.ToString( ) ) == true )
                        {
                            var _clientPath = AppSettings[ $"{_extension}" ];
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
               && !string.IsNullOrEmpty( FilePath ) )
            {
                try
                {
                    var _connection = ConnectionStrings[ provider.ToString( ) ]?.ConnectionString;
                    return !string.IsNullOrEmpty( _connection )
                        ? _connection?.Replace( $"{FilePath}", FilePath )
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
        private protected virtual string CreateConnectionString( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath )
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
                            var _connectionString = ConnectionStrings[ $"{_ext}" ]
                                ?.ConnectionString;

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
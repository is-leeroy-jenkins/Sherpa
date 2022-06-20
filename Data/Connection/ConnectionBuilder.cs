// <copyright file = "ConnectionBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ConnectionBase" />
    /// <seealso cref="ISource" />
    /// <seealso cref="IProvider" />
    /// <seealso cref="IConnectionBuilder" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" )]
    [SuppressMessage( "ReSharper", "InconsistentNaming" )]
    [SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" )]
    public class ConnectionBuilder : ConnectionBase, ISource, IProvider, IConnectionBuilder
    {
        /// <summary>
        /// The provider path
        /// </summary>
        public NameValueCollection ProviderPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        public ConnectionBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ConnectionBuilder( Source source, Provider provider = Provider.SQLite )
        {
            Source = source;
            Provider = provider;
            FilePath = GetFilePath( provider );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
            ProviderPath = ConfigurationManager.AppSettings;
            FileExtension = (EXT)Enum.Parse( typeof( EXT ), Path.GetExtension( FilePath ) );
            TableName = Source.ToString( );
            ConnectionString = GetConnectionString( Provider );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="fullPath">The fullPath.</param>
        public ConnectionBuilder( string fullPath )
        {
            Source = Source.External;
            FilePath = fullPath;
            FileName = Path.GetFileNameWithoutExtension( FilePath );
            FileExtension = (EXT)Enum.Parse( typeof( EXT ), Path.GetExtension( FilePath ) );
            Provider = (Provider)Enum.Parse( typeof( Provider ), GetProviderPath( FilePath ) );
            ProviderPath = ConfigurationManager.AppSettings;
            TableName = FileName;
            ConnectionString = GetConnectionString( Provider );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="fullPath">The fullPath.</param>
        /// <param name="provider">The provider.</param>
        public ConnectionBuilder( string fullPath, Provider provider = Provider.SQLite )
        {
            Source = Source.External;
            Provider = provider;
            FilePath = fullPath;
            FileName = Path.GetFileNameWithoutExtension( fullPath );
            ProviderPath = ConfigurationManager.AppSettings;
            FileExtension = (EXT)Enum.Parse( typeof( EXT ), Path.GetExtension( fullPath ) );
            TableName = Source.ToString( );
            ConnectionString = GetConnectionString( Provider );
        }
    }
}
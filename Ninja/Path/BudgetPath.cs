// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IPath" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    public class BudgetPath : IPath
    {
        /// <summary>
        /// Gets or sets the full nae.
        /// </summary>
        /// <value>
        /// The full nae.
        /// </value>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the path root.
        /// </summary>
        /// <value>
        /// The path root.
        /// </value>
        public string PathRoot { get; set; }

        /// <summary>
        /// Gets or sets the input.
        /// </summary>
        /// <value>
        /// The input.
        /// </value>
        public string Input { get; set; }

        /// <summary>
        /// Gets or sets the current directory.
        /// </summary>
        /// <value>
        /// The current directory.
        /// </value>
        public static string CurrentDirectory { get; set; } = Directory.GetCurrentDirectory();

        /// <summary>
        /// Gets or sets the base directory.
        /// </summary>
        /// <value>
        /// The base directory.
        /// </value>
        public static string BaseDirectory { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public static ConnectionStringSettingsCollection ConnectionString { get; set; } =
            ConfigurationManager.ConnectionStrings;

        /// <summary>
        /// Gets or sets the setting.
        /// </summary>
        /// <value>
        /// The setting.
        /// </value>
        public static NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetPath"/> class.
        /// </summary>
        public BudgetPath()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetPath"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public BudgetPath( string input )
        {
            Input = input;
            FullName = Path.GetFileNameWithoutExtension( Input );
            FileName = Path.GetFileName( Input );
            FullPath = Path.GetFullPath( Input );
            FileExtension = Path.GetExtension( Input );
            PathRoot = Path.GetPathRoot( Input );
        }
        
        /// <summary>
        /// Changes the extension.
        /// </summary>
        /// <param name="ext">The ext.</param>
        /// <returns></returns>
        public string ChangeExtension( string ext )
        {
            try
            {
                return Verify.IsInput( ext ) 
                    && Enum.GetNames( typeof( EXT ) ).Contains( ext )
                        ? Path.ChangeExtension( FullPath, ext )
                        : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Combines the specified first.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns></returns>
        public static string Combine( string first, string second )
        {
            try
            {
                return Verify.IsInput( first ) 
                    && Verify.IsInput( second )
                        ? Path.Combine( first, second )
                        : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            try
            {
                return Verify.IsInput( FullPath )
                    ? FullPath
                    : string.Empty;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
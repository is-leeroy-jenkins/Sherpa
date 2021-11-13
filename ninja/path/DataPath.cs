// // <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// // Copyright (c) Terry Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.IPath" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    public class DataPath : IPath
    {
        /// <summary>
        /// The full name
        /// </summary>
        public string FullNae { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The full path
        /// </summary>
        public string FullPath { get; set; }

        /// <summary>
        /// The file extension
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// The path root
        /// </summary>
        public string PathRoot { get; set; }

        /// <summary>
        /// The input
        /// </summary>
        public string Input { get; set; }

        /// <summary>
        /// The current directory
        /// </summary>
        public static readonly string CurrentDirectory = Directory.GetCurrentDirectory();

        /// <summary>
        /// The base directory
        /// </summary>
        public static readonly string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// The connection string
        /// </summary>
        public static readonly ConnectionStringSettingsCollection ConnectionString =
            ConfigurationManager.ConnectionStrings;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPath"/> class.
        /// </summary>
        public DataPath()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPath"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public DataPath( string input )
        {
            Input = input;
            FullNae = Path.GetFileNameWithoutExtension( Input );
            FileName = Path.GetFileName( Input );
            FullPath = Path.GetFullPath( Input );
            FileExtension = Path.GetExtension( Input );
            PathRoot = Path.GetPathRoot( Input );
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            try
            {
                return Verify.Input( FullNae )
                    ? FullNae
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <returns></returns>
        public string GetFileName()
        {
            try
            {
                return Verify.Input( FileName )
                    ? FileName
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns></returns>
        public string GetFileExtension()
        {
            try
            {
                return Verify.Input( FileExtension )
                    ? FileExtension
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the root.
        /// </summary>
        /// <returns></returns>
        public string GetPathRoot()
        {
            try
            {
                return Verify.Input( PathRoot )
                    ? PathRoot
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the full path.
        /// </summary>
        /// <returns></returns>
        public string GetFullPath()
        {
            try
            {
                return Verify.Input( FullPath )
                    ? FullPath
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
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
                return Verify.Input( ext ) 
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
                return Verify.Input( first ) 
                    && Verify.Input( second )
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
                return Verify.Input( FullPath )
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
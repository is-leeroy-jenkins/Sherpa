// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Folder.cs" company="Terry D. Eppler">
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
//   Folder.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.IO.Compression;
    using System.Security.AccessControl;
    using static System.IO.Directory;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.FolderBase" />
    /// <seealso cref="BudgetExecution.IFolder" />
    /// <seealso cref="FolderBase" />
    /// <seealso cref="IFolder" />
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    public class Folder : FolderBase, IFolder
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Folder" />
        /// class.
        /// </summary>
        public Folder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Folder" />
        /// class.
        /// </summary>
        /// <param name="dirPath">The file.</param>
        public Folder( string dirPath )
            : base( dirPath )
        {
        }

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDirectory( )
        {
            try
            {
                return !string.IsNullOrEmpty( Environment.CurrentDirectory )
                    ? Environment.CurrentDirectory
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary>
        /// Creates the specified filepath.
        /// </summary>
        /// <param name="fullPath">The filepath.</param>
        /// <returns></returns>
        public static DirectoryInfo Create( string fullPath )
        {
            try
            {
                return !string.IsNullOrEmpty( fullPath ) 
                    && !Exists( fullPath )
                        ? CreateDirectory( fullPath )
                        : default( DirectoryInfo );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DirectoryInfo );
            }
        }

        /// <summary>
        /// Deletes the specified folderName.
        /// </summary>
        /// <param name="folderName">The folderName.</param>
        public static void Delete( string folderName )
        {
            try
            {
                if( !string.IsNullOrEmpty( folderName )
                   && Exists( folderName ) )
                {
                    Directory.Delete( folderName, true );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the zip file.
        /// </summary>
        /// <param name="source">The sourcePath.</param>
        /// <param name="destination">The destination.</param>
        public static void CreateZipFile( string source, string destination )
        {
            try
            {
                if( !string.IsNullOrEmpty( source ) )
                {
                    ZipFile.CreateFromDirectory( source, destination );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the sub folder.
        /// </summary>
        /// <param name="dirName">The folderName.</param>
        /// <returns></returns>
        public DirectoryInfo CreateSubDirectory( string dirName )
        {
            if( !string.IsNullOrEmpty( dirName )
               && !Exists( dirName ) )
            {
                try
                {
                    return new DirectoryInfo( FullPath )?.CreateSubdirectory( dirName );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( DirectoryInfo );
                }
            }

            return default( DirectoryInfo );
        }

        /// <summary>
        /// Moves the specified folder path.
        /// </summary>
        /// <param name="destination">
        /// The folder path.
        /// </param>
        public void Move( string destination )
        {
            if( !string.IsNullOrEmpty( destination ) )
            {
                try
                {
                    var _directory = new DirectoryInfo( FullPath );
                    _directory.MoveTo( destination );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Zips the specified filepath.
        /// </summary>
        /// <param name="destination">The filepath.</param>
        public void Zip( string destination )
        {
            try
            {
                if( !string.IsNullOrEmpty( destination )
                   && !string.IsNullOrEmpty( FullPath ) )
                {
                    ZipFile.CreateFromDirectory( FullPath, destination );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Uns the zip.
        /// </summary>
        /// <param name="zipPath">The zipPath.</param>
        public void UnZip( string zipPath )
        {
            try
            {
                if( !string.IsNullOrEmpty( zipPath )
                   && File.Exists( zipPath ) )
                {
                    ZipFile.ExtractToDirectory( zipPath, FullPath );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the access control.
        /// </summary>
        /// <param name="security">
        /// The security.
        /// </param>
        public void SetAccessControl( DirectorySecurity security )
        {
            if( security != null )
            {
                try
                {
                    var _directory = new DirectoryInfo( FullPath );
                    _directory?.SetAccessControl( security );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}
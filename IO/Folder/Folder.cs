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

using System.Collections.Generic;

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.IO.Compression;
    using System.Security.AccessControl;
    using static System.IO.Directory;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.FolderBase" />
    /// <seealso cref="T:BudgetExecution.IFolder" />
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    public class Folder : FolderBase, IFolder
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Folder" /> class.
        /// </summary>
        public Folder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Folder"/> class.
        /// </summary>
        /// <param name="dirPath"></param>
        public Folder( string dirPath )
        {
            Buffer = dirPath;
            FullPath = dirPath;
            Name = Path.GetDirectoryName( dirPath );
            FullName = Path.GetFileName( dirPath );
            Created = File.GetCreationTime( dirPath );
            Modified = File.GetLastWriteTime( dirPath );
            Parent = Directory.GetParent( dirPath );
            SubFiles = Directory.GetFiles( dirPath );
            SubFolders = Directory.GetDirectories( dirPath );
            Security = new DirectorySecurity( dirPath, AccessControlSections.Access );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder"/> class.
        /// </summary>
        /// <param name="folder">The folder.</param>
        public Folder( Folder folder )
        {
            Buffer = folder.Buffer;
            FullPath = folder.FullPath;
            Name = folder.Name;
            FullName = folder.FullName;
            Created = folder.Created;
            Modified = folder.Modified;
            Parent = folder.Parent;
            SubFiles = folder.SubFiles;
            SubFolders = folder.SubFolders;
            Security = folder.Security;
        }

        /// <summary>
        /// Deconstructs the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="fullPath">The full path.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="fullName">The full name.</param>
        /// <param name="created">The created.</param>
        /// <param name="modified">The modified.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="files">The files.</param>
        /// <param name="folders">The folders.</param>
        /// <param name="security">The security.</param>
        public void Deconstruct( out string buffer, out string fullPath, out string fileName,
            out string fullName, out DateTime created, out DateTime modified, 
            out DirectoryInfo parent, out IEnumerable<string> files, 
            out IEnumerable<string> folders, out DirectorySecurity security )
        {
            buffer = Buffer;
            fullPath = FullPath;
            fileName = Name;
            fullName = FullName;
            created = Created;
            modified = Modified;
            parent = Parent;
            files = SubFiles;
            folders = SubFolders;
            security = Security;
        }

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDirectory( )
        {
            try
            {
                return Environment.CurrentDirectory;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( string );
            }
        }

        /// <summary>
        /// Creates the specified full path.
        /// </summary>
        /// <param name="fullPath">
        /// The full path.
        /// </param>
        /// <returns>
        /// DirectoryInfo
        /// </returns>
        public static DirectoryInfo Create( string fullPath )
        {
            try
            {
                ThrowIf.NullOrEmpty( fullPath, nameof( fullPath) );
                return CreateDirectory( fullPath );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DirectoryInfo );
            }
        }

        /// <summary>
        /// Deletes the specified folder name.
        /// </summary>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        public static void Delete( string folderName )
        {
            try
            {
                ThrowIf.NullOrEmpty( folderName, nameof( folderName ) );
                Directory.Delete( folderName, true );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the zip file.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="destination">The destination.</param>
        public static void CreateZipFile( string source, string destination )
        {
            try
            {
                ThrowIf.NullOrEmpty( source, nameof( source ) );
                ThrowIf.NullOrEmpty( destination, nameof( destination ) );
                ZipFile.CreateFromDirectory( source, destination );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the sub directory.
        /// </summary>
        /// <param name="dirName">The folderName.</param>
        /// <returns></returns>
        public DirectoryInfo CreateSubDirectory( string dirName )
        {
            try
            {
                ThrowIf.NullOrEmpty( dirName, nameof( dirName ) );
                return new DirectoryInfo( FullPath )?.CreateSubdirectory( dirName );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DirectoryInfo );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Moves the specified fullName.
        /// </summary>
        /// <param name="destination">
        /// The fullName.
        /// </param>
        public void Move( string destination )
        {
            try
            {
                ThrowIf.NullOrEmpty( destination, nameof( destination ) );
                var _directory = new DirectoryInfo( FullPath );
                _directory.MoveTo( destination );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Zips the specified destination.
        /// </summary>
        /// <param name="destination">
        /// The destination.
        /// </param>
        public void Zip( string destination )
        {
            try
            {
                ThrowIf.NullOrEmpty( destination, nameof( destination ) );
                ZipFile.CreateFromDirectory( FullPath, destination );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Uns the zip.
        /// </summary>
        /// <param name="zipPath">
        /// The zipPath.
        /// </param>
        public void UnZip( string zipPath )
        {
            try
            {
                ThrowIf.NullOrEmpty( zipPath, nameof( zipPath ) );
                ZipFile.ExtractToDirectory( zipPath, FullPath );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Sets the access control.
        /// </summary>
        /// <param name="security">
        /// The security.</param>
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
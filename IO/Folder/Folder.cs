// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Folder.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application 
//    for analyst with the US Environmental Protection Agency (US EPA).
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
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
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
    using System.Collections.Generic;
    using System.Linq;
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
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class Folder : FolderBase
    {
        /// <summary>
        /// Gets the name of the folder.
        /// </summary>
        /// <value>
        /// The name of the folder.
        /// </value>
        public string FolderName
        {
            get
            {
                return _folderExists
                    ? Path.GetDirectoryName( _fullPath )
                    : string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the parent folder.
        /// </summary>
        /// <value>
        /// The parent folder.
        /// </value>
        public DirectoryInfo ParentFolder
        {
            get
            {
                return _hasParent
                    ? new DirectoryInfo( _fullPath ).Parent
                    : default( DirectoryInfo );
            }
        }

        /// <summary>
        /// Gets or sets the sub files.
        /// </summary>
        /// <value>
        /// The sub files.
        /// </value>
        public IEnumerable<string> SubFileNames
        {
            get
            {
                return _hasSubFiles
                    ? Directory.GetFiles( _fullPath )
                    : default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets or sets the sub folders.
        /// </summary>
        /// <value>
        /// The sub folders.
        /// </value>
        public IEnumerable<string> SubFolderNames
        {
            get
            {
                return _hasSubFolders
                    ? Directory.GetDirectories( _fullPath )
                    : default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the folder security.
        /// </summary>
        /// <value>
        /// The folder security.
        /// </value>
        public DirectorySecurity FolderSecurity
        {
            get
            {
                return _folderSecurity;
            }
            private protected set
            {
                _folderSecurity = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Folder" /> class.
        /// </summary>
        public Folder( ) 
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Folder" /> class.
        /// </summary>
        /// <param name="dirPath"></param>
        public Folder( string dirPath ) 
        {
            _buffer = dirPath;
            _fullPath = dirPath;
            _folderExists = Directory.Exists( dirPath );
            _folderName = Path.GetDirectoryName( dirPath );
            _hasSubFiles = ( Directory.GetFiles( dirPath )?.Length > 0 );
            _hasSubFolders = ( GetDirectories( dirPath )?.Length > 0 );
            _created = Directory.GetCreationTime( dirPath );
            _modified = Directory.GetLastWriteTime( dirPath );
            _folderSecurity = new DirectorySecurity( dirPath, AccessControlSections.Access );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Folder" /> class.
        /// </summary>
        /// <param name="folder">The folder.</param>
        public Folder( Folder folder ) 
        {
            _buffer = folder.Input;
            _fullPath = folder.FullPath;
            _folderName = folder.FolderName;
            _hasSubFiles = ( Directory.GetFiles( folder.FullPath )?.Length > 0 );
            _hasSubFolders = ( GetDirectories( folder.FullPath )?.Length > 0 );
            _created = folder.Created;
            _modified = folder.Modified;
            _folderSecurity = folder.FolderSecurity;
        }

        /// <summary>
        /// Deconstructs the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="fullPath">The full path.</param>
        /// <param name="folderName">Name of the file.</param>
        /// <param name="created">The created.</param>
        /// <param name="modified">The modified.</param>
        /// <param name="security">The security.</param>
        public void Deconstruct( out string buffer, out string fullPath, out string folderName,
            out DateTime created, out DateTime modified, out DirectorySecurity security )
        {
            buffer = _buffer;
            fullPath = _fullPath;
            folderName = _folderName;
            created = _created;
            modified = _modified;
            security = _folderSecurity;
        }

        /// <inheritdoc />
        /// <summary>
        /// Transfers the specified folder.
        /// </summary>
        /// <param name="folder">
        /// The folder.
        /// </param>
        public void CopyTree( DirectoryInfo folder )
        {
            try
            {
                ThrowIf.Null( folder, nameof( folder ) );
                var _files = folder?.GetFiles( );
                if( _files?.Any( ) == true )
                {
                    Directory.Move( _fileName, folder.Name );
                }
            }
            catch( IOException _ex )
            {
                Fail( _ex );
            }
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

        /// <inheritdoc />
        /// <summary>
        /// Creates the specified full path.
        /// </summary>
        /// <param name="fullPath">
        /// The full path.
        /// </param>
        /// <returns>
        /// DirectoryInfo
        /// </returns>
        public static new DirectoryInfo Create( string fullPath )
        {
            try
            {
                ThrowIf.NullOrEmpty( fullPath, nameof( fullPath ) );
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
        /// Creates the subdirectory.
        /// </summary>
        /// <param name="dirName">The folderName.</param>
        /// <returns></returns>
        public DirectoryInfo CreateSubDirectory( string dirName )
        {
            try
            {
                ThrowIf.NullOrEmpty( dirName, nameof( dirName ) );
                return new DirectoryInfo( _fullPath )?.CreateSubdirectory( dirName );
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
        public void Transfer( string destination )
        {
            try
            {
                ThrowIf.NullOrEmpty( destination, nameof( destination ) );
                var _directory = new DirectoryInfo( _fullPath );
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
                ZipFile.CreateFromDirectory( _fileName, destination );
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
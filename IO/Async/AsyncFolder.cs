﻿// ****************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 21-03-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        21-03-2024
// ****************************************************************************************
// <copyright file="AsyncFolder.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for analysts in the
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
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
//     EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//     OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE
//     AND NON-INFRINGEMENT.  IN NO EVENT SHALL THE AUTHORS
//     OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
//     TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//  AsyncFolder.cs
// </summary>
// ****************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// 
    /// </summary>
    public class AsyncFolder : AsyncFolderBase
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
        public IEnumerable<string> SubFiles
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
        public IList<string> SubFolders
        {
            get
            {
                return _hasSubFolders
                    ? Directory.GetDirectories( _fullPath )
                    : default( IList<string> );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Folder" /> class.
        /// </summary>
        public AsyncFolder( )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Folder" /> class.
        /// </summary>
        /// <param name="dirPath"></param>
        public AsyncFolder( string dirPath )
        {
            _buffer = dirPath;
            _fullPath = dirPath;
            _folderExists = Directory.Exists( dirPath );
            _folderName = Path.GetDirectoryName( dirPath );
            _hasSubFiles = Directory.GetFiles( dirPath )?.Length > 0;
            _hasSubFolders = Directory.GetDirectories( dirPath )?.Length > 0;
            _created = Directory.GetCreationTime( dirPath );
            _modified = Directory.GetLastWriteTime( dirPath );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Folder" /> class.
        /// </summary>
        /// <param name="folder">The folder.</param>
        public AsyncFolder( Folder folder )
        {
            _buffer = folder.Input;
            _fullPath = folder.FullPath;
            _folderName = folder.FolderName;
            _hasSubFiles = Directory.GetFiles( folder.FullPath )?.Length > 0;
            _hasSubFolders = Directory.GetDirectories( folder.FullPath )?.Length > 0;
            _created = folder.Created;
            _modified = folder.Modified;
        }

        /// <summary>
        /// Deconstructs the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="fullPath">The full path.</param>
        /// <param name="folderName">Name of the file.</param>
        /// <param name="hasSubFiles"> </param>
        /// <param name="hasSubFolders"> </param>
        /// <param name="created">The created.</param>
        /// <param name="modified">The modified.</param>
        public void Deconstruct( out string buffer, out string fullPath, out string folderName,
            out bool hasSubFiles, out bool hasSubFolders, out DateTime created,
            out DateTime modified )
        {
            buffer = _buffer;
            fullPath = _fullPath;
            folderName = _folderName;
            hasSubFiles = _hasSubFiles;
            hasSubFolders = _hasSubFolders;
            created = _created;
            modified = _modified;
        }

        /// <inheritdoc />
        /// <summary>
        /// Transfers the specified folder.
        /// </summary>
        /// <param name="destination">
        /// The folder.
        /// </param>
        public Task CopyContentsAsync( string destination )
        {
            var _async = new TaskCompletionSource( );
            try
            {
                ThrowIf.Null( destination, nameof( destination ) );
                Directory.Move( _buffer, destination );
                _async.SetResult( );
                return _async.Task;
            }
            catch( IOException _ex )
            {
                _async.SetException( _ex );
                Fail( _ex );
                return _async.Task;
            }
        }

        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <returns></returns>
        public static Task<string> GetCurrentDirectoryAsync( )
        {
            var _async = new TaskCompletionSource<string>( );
            try
            {
                _async.SetResult( Environment.CurrentDirectory );
                return _async.Task;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Task<string> );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the specified full path.
        /// </summary>
        /// <param name="filePath">
        /// The full path.
        /// </param>
        /// <returns>
        /// DirectoryInfo
        /// </returns>
        public static new DirectoryInfo Create( string filePath )
        {
            try
            {
                ThrowIf.Null( filePath, nameof( filePath ) );
                return Directory.CreateDirectory( filePath );
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
        public static void DeleteAsync( string folderName )
        {
            try
            {
                ThrowIf.Null( folderName, nameof( folderName ) );
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
        public static void CreateZipFileAsync( string source, string destination )
        {
            try
            {
                ThrowIf.Null( source, nameof( source ) );
                ThrowIf.Null( destination, nameof( destination ) );
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
        public DirectoryInfo CreateSubDirectoryAsync( string dirName )
        {
            try
            {
                ThrowIf.Null( dirName, nameof( dirName ) );
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
        public void TransferAsync( string destination )
        {
            try
            {
                ThrowIf.Null( destination, nameof( destination ) );
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
        public void ZipAsync( string destination )
        {
            try
            {
                ThrowIf.Null( destination, nameof( destination ) );
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
        public void UnZipAsync( string zipPath )
        {
            try
            {
                ThrowIf.Null( zipPath, nameof( zipPath ) );
                ZipFile.ExtractToDirectory( zipPath, FullPath );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" />
        /// that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                var _folder = new Folder( _buffer );
                var _name = _folder.FolderName ?? string.Empty;
                var _path = _folder.FullPath ?? string.Empty;
                var _dirPath = _folder.ParentPath ?? string.Empty;
                var _create = _folder.Created;
                var _modify = _folder.Modified;
                var _subfiles = _folder.SubFiles?.Count( );
                var _subfolders = _folder.SubFolders?.Count( );
                var _size = ( _folder.Size.ToString( "N0" ) ?? "0" ) + " bytes";
                var _nl = Environment.NewLine;
                var _tb = char.ToString( '\t' );
                var _text = _nl + _tb + "Folder Name: " + _tb + _name + _nl + _nl +
                    _tb + "Folder Path: " + _tb + _path + _nl + _nl +
                    _tb + "Parent Path: " + _tb + _dirPath + _nl + _nl +
                    _tb + "Sub-Files: " + _tb + _subfiles + _nl + _nl +
                    _tb + "Sub-Folders: " + _tb + _subfolders + _nl + _nl +
                    _tb + "File Size: " + _tb + _size + _nl + _nl +
                    _tb + "Created On: " + _tb + _create.ToShortDateString( ) + _nl + _nl +
                    _tb + "Modified On: " + _tb + _modify.ToShortDateString( ) + _nl + _nl;

                return !string.IsNullOrEmpty( _text )
                    ? _text
                    : string.Empty;
            }
            catch( IOException _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }
    }
}
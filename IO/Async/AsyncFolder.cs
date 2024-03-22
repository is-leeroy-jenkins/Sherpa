// ****************************************************************************************
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// </returns>
        public Task<IList<string>> GetSubFilesAsync( )
        {
            if( _hasSubFiles )
            {
                var _async = new TaskCompletionSource<IList<string>>( );
                try
                {
                    var _files = Directory.GetFiles( _fullPath );
                    _async.SetResult( _files );
                    return _async.Task;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Task<IList<string>> );
                }
            }
            else
            {
                return default( Task<IList<string>> );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// </returns>
        public Task<IList<string>> GetSubFoldersAsync( )
        {
            if( _hasSubFolders )
            {
                var _async = new TaskCompletionSource<IList<string>>( );
                try
                {
                    var _folders = Directory.GetDirectories( _fullPath );
                    _async.SetResult( _folders );
                    return _async.Task;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Task<IList<string>> );
                }
            }
            else
            {
                return default( Task<IList<string>> );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// </returns>
        public Task<DirectoryInfo> GetParentFolderAsync( )
        {
            if( _hasParent )
            {
                var _async = new TaskCompletionSource<DirectoryInfo>( );
                try
                {
                    var _folder = Directory.GetParent( _buffer );
                    _async.SetResult( _folder );
                    return _async.Task;
                }
                catch( Exception _ex )
                {
                    _async.SetException( _ex );
                    Fail( _ex );
                    return default( Task<DirectoryInfo> );
                }
            }
            else
            {
                return default( Task<DirectoryInfo> );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// </returns>
        public Task<string> GetFolderNameAsync( )
        {
            if( _folderExists )
            {
                var _async = new TaskCompletionSource<string>( );
                try
                {
                    var _name = Path.GetDirectoryName( _buffer );
                    _async.SetResult( _name );
                    return _async.Task;
                }
                catch( Exception _ex )
                {
                    _async.SetException( _ex );
                    Fail( _ex );
                    return default( Task<string> );
                }
            }
            else
            {
                return default( Task<string> );
            }
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
                _async.SetException( _ex );
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
        public static Task<DirectoryInfo> GetFolderAsync( string filePath )
        {
            var _async = new TaskCompletionSource<DirectoryInfo>( );
            try
            {
                ThrowIf.Null( filePath, nameof( filePath ) );
                var _stream = Directory.CreateDirectory( filePath );
                _async.SetResult( _stream );
                return _async.Task;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Task<DirectoryInfo> );
            }
        }

        /// <summary>
        /// Deletes the specified folder name.
        /// </summary>
        /// <param name="folderName">
        /// Name of the folder.
        /// </param>
        public static void DeleteFolderAsync( string folderName )
        {
            var _async = new TaskCompletionSource( );
            try
            {
                ThrowIf.Null( folderName, nameof( folderName ) );
                Directory.Delete( folderName, true );
                _async.SetResult( );
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the zip file.
        /// </summary>
        /// <param name="source">
        /// The source.
        /// </param>
        /// <param name="destination">
        /// The destination.
        /// </param>
        public static void GetZipFileAsync( string source, string destination )
        {
            var _async = new TaskCompletionSource( );
            try
            {
                ThrowIf.Null( source, nameof( source ) );
                ThrowIf.Null( destination, nameof( destination ) );
                ZipFile.CreateFromDirectory( source, destination );
                _async.SetResult( );
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
                Fail( _ex );
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Creates the subdirectory.
        /// </summary>
        /// <param name="dirName">The folderName.</param>
        /// <returns></returns>
        public Task<DirectoryInfo> GetSubDirectoryAsync( string dirName )
        {
            var _async = new TaskCompletionSource<DirectoryInfo>( );
            try
            {
                ThrowIf.Null( dirName, nameof( dirName ) );
                var _folder = new DirectoryInfo( _fullPath )
                    ?.CreateSubdirectory( dirName );

                _async.SetResult( _folder );
                return _async.Task;
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
                Fail( _ex );
                return default( Task<DirectoryInfo> );
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
            var _async = new TaskCompletionSource( );
            try
            {
                ThrowIf.Null( destination, nameof( destination ) );
                var _directory = new DirectoryInfo( _fullPath );
                _directory.MoveTo( destination );
                _async.SetResult( );
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
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
            var _async = new TaskCompletionSource( );
            try
            {
                ThrowIf.Null( destination, nameof( destination ) );
                ZipFile.CreateFromDirectory( _fileName, destination );
                _async.SetResult( );
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
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
            var _async = new TaskCompletionSource( );
            try
            {
                ThrowIf.Null( zipPath, nameof( zipPath ) );
                ZipFile.ExtractToDirectory( zipPath, FullPath );
                _async.SetResult( );
            }
            catch( Exception _ex )
            {
                _async.SetException( _ex );
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
        public Task<string> ToStringAsync( )
        {
            var _async = new TaskCompletionSource<string>( );
            try
            {
                var _file = new DataFile( _buffer );
                var _extenstion = _file.Extension ?? string.Empty;
                var _name = _file.FileName ?? string.Empty;
                var _path = _file.FullPath ?? string.Empty;
                var _dirPath = _file.ParentPath ?? string.Empty;
                var _create = _file.Created;
                var _modify = _file.Modified;
                var _size = ( _file.Size.ToString( "N0" ) ?? "0" ) + " bytes";
                var _nl = Environment.NewLine;
                var _tb = char.ToString( '\t' );
                var _text = _nl + _tb + "File Name: " + _tb + _name + _nl + _nl +
                    _tb + "File Path: " + _tb + _path + _nl + _nl +
                    _tb + "Parent Path: " + _tb + _dirPath + _nl + _nl +
                    _tb + "File Extension: " + _tb + _extenstion + _nl + _nl +
                    _tb + "File Size: " + _tb + _size + _nl + _nl +
                    _tb + "Created On: " + _tb + _create.ToShortDateString( ) + _nl + _nl +
                    _tb + "Modified On: " + _tb + _modify.ToShortDateString( ) + _nl + _nl;

                _async.SetResult( _text );
                return !string.IsNullOrEmpty( _text )
                    ? _async.Task
                    : default( Task<string> );
            }
            catch( IOException _ex )
            {
                _async.SetException( _ex );
                Fail( _ex );
                return default( Task<string> );
            }
        }
    }
}
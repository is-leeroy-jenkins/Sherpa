// ****************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 20-03-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        20-03-2024
// ****************************************************************************************
// <copyright file="AsyncPath.cs" company="Terry D. Eppler">
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
//  AsyncPath.cs
// </summary>
// ****************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    public class AsyncPath : AsyncPathBase
    {
        /// <summary>
        /// Gets or sets the buffer.
        /// </summary>
        /// <value>
        /// The buffer.
        /// </value>
        public string Input
        {
            get
            {
                return _buffer;
            }
            private protected set
            {
                _buffer = value;
            }
        }

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public string FullPath
        {
            get
            {
                return !string.IsNullOrEmpty( _fullPath )
                    ? _fullPath
                    : string.Empty;
            }
            private protected set
            {
                _fullPath = value;
            }
        }

        /// <summary>
        /// Gets or sets the absolute path.
        /// </summary>
        /// <value>
        /// The absolute path.
        /// </value>
        public string AbsolutePath
        {
            get
            {
                return !string.IsNullOrEmpty( _absolutePath )
                    ? _absolutePath
                    : string.Empty;
            }
            private protected set
            {
                _absolutePath = value;
            }
        }

        /// <summary>
        /// Gets the relative path.
        /// </summary>
        /// <value>
        /// The relative path.
        /// </value>
        public string RelativePath
        {
            get
            {
                return !string.IsNullOrEmpty( _relativePath )
                    ? _relativePath
                    : string.Empty;
            }
            private protected set
            {
                _relativePath = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string FileName
        {
            get
            {
                return !string.IsNullOrEmpty( _fileName )
                    ? _fileName
                    : string.Empty;
            }
            private protected set
            {
                _fileName = value;
            }
        }

        /// <summary>
        /// Gets or sets the modified.
        /// </summary>
        /// <value>
        /// The modified.
        /// </value>
        public DateTime Modified
        {
            get
            {
                return _modified;
            }
            private protected set
            {
                _modified = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating
        /// whether this instance has parent.
        /// </summary>
        /// <value>
        /// <c>true</c>
        /// if this instance has parent;
        /// otherwise,
        /// <c>false</c>.
        /// </value>
        public DirectoryInfo Parent
        {
            get
            {
                return _hasParent
                    ? Directory.GetParent( _buffer )
                    : default( DirectoryInfo );
            }
        }

        /// <summary>
        /// Gets the drive.
        /// </summary>
        /// <value>
        /// The drive.
        /// </value>
        public string Drive
        {
            get
            {
                return _isRooted
                    ? Path.GetPathRoot( _buffer )
                    : string.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the created.
        /// </summary>
        /// <value>
        /// The created.
        /// </value>
        public DateTime Created
        {
            get
            {
                return _created;
            }
            private protected set
            {
                _created = value;
            }
        }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public long Length
        {
            get
            {
                return _length;
            }
            private protected set
            {
                _length = value;
            }
        }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public string Extension
        {
            get
            {
                return _hasExtension
                    ? Path.GetExtension( _fullPath )
                    : string.Empty;
            }
            private protected set
            {
                _fileExtension = value;
            }
        }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public FileAttributes FileAttributes
        {
            get
            {
                return _fileAttributes;
            }
            private protected set
            {
                _fileAttributes = value;
            }
        }

        /// <summary>
        /// Gets or sets the file security.
        /// </summary>
        /// <value>
        /// The file security.
        /// </value>
        public FileSecurity FileSecurity
        {
            get
            {
                return _fileSecurity;
            }
            private protected set
            {
                _fileSecurity = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the invalid path chars.
        /// </summary>
        /// <value>
        /// The invalid path chars.
        /// </value>
        public char[ ] InvalidPathChars
        {
            get
            {
                return _invalidPathChars;
            }
            private protected set
            {
                _invalidPathChars = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the invalid name chars.
        /// </summary>
        /// <value>
        /// The invalid name chars.
        /// </value>
        public char[ ] InvalidNameChars
        {
            get
            {
                return _invalidNameChars;
            }
            private protected set
            {
                _invalidNameChars = value;
            }
        }

        /// <summary>
        /// Gets the path separator.
        /// </summary>
        /// <value>
        /// The path separator.
        /// </value>
        public char PathSeparator
        {
            get
            {
                return _pathSeparator;
            }
            private protected set
            {
                _pathSeparator = value;
            }
        }

        /// <summary>
        /// Gets the folder separator.
        /// </summary>
        /// <value>
        /// The folder separator.
        /// </value>
        public char FolderSeparator
        {
            get
            {
                return _folderSeparator;
            }
            private protected set
            {
                _folderSeparator = value;
            }
        }

        /// <summary>
        /// Gets the drive separator.
        /// </summary>
        /// <value>
        /// The drive separator.
        /// </value>
        public char DriveSeparator
        {
            get
            {
                return _driveSeparator;
            }
            private protected set
            {
                _driveSeparator = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataPath"/>
        /// class.
        /// </summary>
        public AsyncPath( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataPath"/>
        /// class.
        /// </summary>
        /// <param name="input">
        /// The input.
        /// </param>
        public AsyncPath( string input )
        {
            _buffer = input;
            _hasExtension = Path.HasExtension( input );
            _hasParent = !string.IsNullOrEmpty( Directory.GetParent( input )?.Name );
            _isRooted = Path.IsPathRooted( _buffer );
            _absolutePath = Path.GetFullPath( input );
            _relativePath = Path.GetRelativePath( Environment.CurrentDirectory, input );
            _fileName = Path.GetFileNameWithoutExtension( input );
            _fullPath = Path.GetFullPath( input );
            _length = input.Length;
            _created = File.GetCreationTime( input );
            _modified = File.GetLastWriteTime( input );
            _invalidPathChars = Path.GetInvalidPathChars( );
            _invalidNameChars = Path.GetInvalidFileNameChars( );
            _pathSeparator = Path.PathSeparator;
            _folderSeparator = Path.AltDirectorySeparatorChar;
            _driveSeparator = Path.DirectorySeparatorChar;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataPath"/> class.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        public AsyncPath( DataPath path )
        {
            _buffer = path.Input;
            _hasExtension = Path.HasExtension( path.FullPath );
            _fileName = Path.GetFileNameWithoutExtension( path.FullPath );
            _absolutePath = Path.GetFullPath( path.FullPath );
            _relativePath = Path.GetRelativePath( Environment.CurrentDirectory, path.FullPath );
            _fullPath = path.FullPath;
            _fileExtension = path.Extension;
            _length = path.Length;
            _created = path.Created;
            _modified = path.Modified;
            _invalidPathChars = path.InvalidPathChars;
            _invalidNameChars = path.InvalidNameChars;
            _pathSeparator = path.PathSeparator;
            _folderSeparator = path.FolderSeparator;
            _driveSeparator = path.DriveSeparator;
        }

        /// <summary>
        /// Deconstructs the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="absolutePath">The abs path.</param>
        /// <param name="name">The name.</param>
        /// <param name="fullPath">The full path.</param>
        /// <param name="length">The length.</param>
        /// <param name="extension"> </param>
        /// <param name="createDate">The created.</param>
        /// <param name="modifyDate">The modified.</param>
        public void Deconstruct( out string buffer, out string absolutePath, out string name,
            out string fullPath, out long length, out string extension, out DateTime createDate,
            out DateTime modifyDate )
        {
            buffer = _buffer;
            absolutePath = _absolutePath;
            name = _fileName;
            fullPath = _fullPath;
            extension = _fileExtension;
            length = _length;
            createDate = _created;
            modifyDate = _modified;
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
                var _path = new DataPath( _buffer );
                var _extenstion = _path.Extension ?? string.Empty;
                var _name = _path.FileName ?? string.Empty;
                var _filePath = _path.FullPath ?? string.Empty;
                var _create = _path.Created;
                var _modify = _path.Modified;
                var _len = _path.Length.ToString( "N0" ) ?? string.Empty;
                var _pathsep = _path.PathSeparator;
                var _drivesep = _path.DriveSeparator;
                var _foldersep = _path.FolderSeparator;
                var _root = _path.Drive;
                var _nl = Environment.NewLine;
                var _tb = char.ToString( '\t' );
                var _text = _nl + _tb + "File Name: " + _tb + _name + _nl + _nl +
                    _tb + "File Path: " + _tb + _filePath + _nl + _nl +
                    _tb + "Extension: " + _tb + _extenstion + _nl + _nl +
                    _tb + "Path Root: " + _tb + _root + _nl + _nl +
                    _tb + "Path Separator: " + _tb + _pathsep + _nl + _nl +
                    _tb + "Drive Separator: " + _tb + _drivesep + _nl + _nl +
                    _tb + "Folder Separator: " + _tb + _foldersep + _nl + _nl +
                    _tb + "Length: " + _tb + _len + _nl + _nl +
                    _tb + "Created: " + _tb + _create.ToShortDateString( ) + _nl + _nl +
                    _tb + "Modified: " + _tb + _modify.ToShortDateString( ) + _nl + _nl;

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
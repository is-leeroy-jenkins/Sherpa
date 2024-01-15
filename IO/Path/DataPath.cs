// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 12-23-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-23-2023
// ******************************************************************************************
// <copyright file="DataPath.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for analysts in the US Environmental Protection Agency (US EPA).
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   DataPath.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security.AccessControl;

    /// <inheritdoc/>
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.PathBase"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class DataPath : PathBase 
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
        public bool HasParent
        {
            get
            {
                return _hasParent;
            }
            private protected set
            {
                _hasParent = value;
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
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataPath"/>
        /// class.
        /// </summary>
        public DataPath( )
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
        public DataPath( string input )
        {
            _buffer = input;
            _hasExtension = Path.HasExtension( input );
            _hasParent = !string.IsNullOrEmpty( Directory.GetParent( input )?.Name );
            _absolutePath = Path.GetFullPath( input );
            _relativePath = Path.GetRelativePath( Environment.CurrentDirectory, input );
            _fileName = Path.GetFileNameWithoutExtension( input );
            _fullPath = Path.GetFullPath( input );
            _length = input.Length;
            _fileAttributes = File.GetAttributes( input );
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
        public DataPath( DataPath path )
        {
            _buffer = path.Input;
            _hasExtension = Path.HasExtension( path.FullPath );
            _fileName = Path.GetFileNameWithoutExtension( path.FullPath );
            _absolutePath = Path.GetFullPath( path.FullPath );
            _relativePath = Path.GetRelativePath( Environment.CurrentDirectory, path.FullPath );
            _fullPath = path.FullPath;
            _length = path.Length;
            _fileAttributes = path.FileAttributes;
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
        /// <param name="attributes">The attributes.</param>
        /// <param name="createDate">The created.</param>
        /// <param name="modifyDate">The modified.</param>
        public void Deconstruct( out string buffer, out string absolutePath, out string name,
            out string fullPath, out long length, out FileAttributes attributes, 
            out DateTime createDate, out DateTime modifyDate )
        {
            buffer = _buffer;
            absolutePath = _absolutePath;
            name = _fileName;
            fullPath = _fullPath;
            length = _length;
            attributes = _fileAttributes;
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
                return !string.IsNullOrEmpty( _fullPath )
                    ? _fullPath
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
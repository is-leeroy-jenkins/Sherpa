// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataFile.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application 
//    for analysts with the US Environmental Protection Agency (US EPA).
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
//   DataFile.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using static System.IO.Directory;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.FileBase" />
    /// <seealso cref="T:BudgetExecution.IFile" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public class DataFile : FileBase
    {
        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public long Size
        {
            get
            {
                return _fileExists
                    ? File.Open( _fullPath, FileMode.Open ).Length
                    : 0L;
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
        }

        /// <summary>
        /// Gets the name of the parent.
        /// </summary>
        /// <value>
        /// The name of the parent.
        /// </value>
        public string ParentName
        {
            get
            {
                return _hasParent
                    ? Path.GetDirectoryName( _fullPath )
                    : string.Empty;
            }
        }

        /// <summary>
        /// Gets the parent path.
        /// </summary>
        /// <value>
        /// The parent path.
        /// </value>
        public string ParentPath
        {
            get
            {
                return _hasParent
                    ? Directory.GetParent( _fullPath )?.FullName
                    : string.Empty;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataFile" /> class.
        /// </summary>
        public DataFile( ) 
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataFile" /> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public DataFile( string input ) 
        {
            _buffer = input;
            _fileName = Path.GetFileNameWithoutExtension( input );
            _fileExists = File.Exists( input );
            _hasExtension = Path.HasExtension( input );
            _fullPath = Path.GetFullPath( input );
            _absolutePath = Path.GetFullPath( input );
            _fileAttributes = File.GetAttributes( input );
            _created = File.GetCreationTime( input );
            _modified = File.GetLastWriteTime( input );
            _hasParent = !string.IsNullOrEmpty( Directory.GetParent( input )?.Name );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DataFile" /> class.
        /// </summary>
        /// <param name="file">The file.</param>
        public DataFile( DataFile file )
        {
            _buffer = file.Input;
            _fileName = file.FileName;
            _fileExists = File.Exists( file.FullPath );
            _hasExtension = Path.HasExtension( file.FullPath );
            _fullPath = file.FullPath;
            _absolutePath = file.AbsolutePath;
            _fileAttributes = file.FileAttributes;
            _created = file.Created;
            _modified = file.Modified;
            _hasParent = ( !string.IsNullOrEmpty( Directory.GetParent( file.FullPath )?.Name ) );
        }

        /// <inheritdoc />
        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="search">The search.</param>
        /// <returns>
        /// <c>true</c> if [contains] [the specified search];
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool Contains( string search )
        {
            if( _fileExists )
            {
                try
                {
                    ThrowIf.NullOrEmpty( search, nameof( search ) );
                    using var _stream = File.Open( _buffer, FileMode.Open );
                    using var _reader = new StreamReader( _stream );
                    if( _reader != null )
                    {
                        var _text = _reader?.ReadLine( );
                        var _result = false;
                        while( !string.IsNullOrEmpty( _text ) )
                        {
                            if( Regex.IsMatch( _text, search ) )
                            {
                                _result = true;
                                break;
                            }

                            _text = _reader.ReadLine( );
                        }

                        return _result;
                    }

                    return false;
                }
                catch( IOException _ex )
                {
                    Fail( _ex );
                    return false;
                }
            }

            return false;
        }

        /// <inheritdoc />
        /// <summary>
        /// Searches the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> Search( string pattern )
        {
            if( _fileExists )
            {
                try
                {
                    IEnumerable<string> _enumerable = GetDirectories( _buffer, pattern );
                    var _list = new List<FileInfo>( );
                    foreach( var _file in _enumerable )
                    {
                        _list.Add( new FileInfo( _file ) );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( List<FileInfo> );
                }
                catch( IOException _ex )
                {
                    Fail( _ex );
                    return default( IEnumerable<FileInfo> );
                }
            }

            return default( IEnumerable<FileInfo> );
        }

        /// <summary>
        /// Creates the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static FileInfo Create( string filePath )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                return new FileInfo( filePath );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( FileInfo );
            }
        }

        /// <summary>
        /// Opens the dialog.
        /// </summary>
        /// <returns>
        /// </returns>
        public static string OpenDialog( )
        {
            try
            {
                var _dialog = new OpenFileDialog( );
                _dialog.CheckFileExists = true;
                _dialog.CheckPathExists = true;
                _dialog.ShowDialog( );
                return !string.IsNullOrEmpty( _dialog.FileName )
                    ? _dialog.FileName
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        /// <returns>
        /// </returns>
        public void Save( )
        {
            FileStream _baseStream = null;
            try
            {
                var _dialog = new SaveFileDialog( );
                _dialog.CreatePrompt = true;
                _dialog.OverwritePrompt = true;
                _dialog.CheckFileExists = true;
                _dialog.CheckPathExists = true;
                _dialog.ShowDialog( );
                _baseStream = File.Create( _dialog.FileName );
                _baseStream.Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                _baseStream?.Close( );
            }
            finally
            {
                _baseStream?.Close( );
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
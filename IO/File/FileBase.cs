// ******************************************************************************************
//     Assembly:              Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 12-9-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        12-9-2023
// ******************************************************************************************
// <copyright file="FileBase.cs" company="Terry D. Eppler">
//    This is a tiny web browser used in Federal Budget, Finance, and Accounting application
//    for the US Environmental Protection Agency (US EPA).
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
//    Contact at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   FileBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.PathBase" />
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class FileBase : DataPath
    {
        /// <summary>
        /// The exists
        /// </summary>
        private protected bool _fileExists;

        /// <summary>
        /// Moves the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public void Move( string filePath )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                var _source = new FileInfo( FullPath );
                _source.MoveTo( filePath );
            }
            catch( IOException _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Copies the specified file path.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        public void Copy( string filePath )
        {
            try
            {
                ThrowIf.NullOrEmpty( filePath, nameof( filePath ) );
                var _source = new FileInfo( FullPath );
                _source.CopyTo( filePath );
            }
            catch( IOException _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public void Delete( )
        {
            try
            {
                if( File.Exists( _fullPath ) )
                {
                    File.Delete( _fullPath );
                }
            }
            catch( IOException _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the base stream.
        /// </summary>
        /// <returns></returns>
        private protected FileStream GetBaseStream( )
        {
            try
            {
                return File.Exists( _fullPath )
                    ? new FileInfo( _fullPath )?.Create( )
                    : default( FileStream );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( FileStream );
            }
        }

        /// <summary>
        /// Reads the lines.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> ReadLines( )
        {
            if( _fileExists )
            {
                try
                {
                    var _list = new List<string>( );
                    foreach( var _line in File.ReadAllLines( _buffer ) )
                    {
                        if( !string.IsNullOrEmpty( _line ) )
                        {
                            _list.Add( _line );
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( List<string> );
                }
                catch( IOException _ex )
                {
                    Fail( _ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary>
        /// Reads the bytes.
        /// </summary>
        /// <returns>
        /// </returns>
        private protected byte[ ] ReadBytes( )
        {
            if( _fileExists )
            {
                try
                {
                    var _data = File.ReadAllBytes( _buffer );
                    return _data.Length > 0
                        ? _data
                        : default( byte[ ] );
                }
                catch( IOException _ex )
                {
                    Fail( _ex );
                    return default( byte[ ] );
                }
            }

            return default( byte[ ] );
        }

        /// <summary>
        /// Writes the lines.
        /// </summary>
        /// <returns></returns>
        private protected string WriteLines( )
        {
            if( _fileExists )
            {
                try
                {
                    string _text = string.Empty;
                    var _list = ReadLines( );
                    for( var _i = 0; _i < _list.Count; _i++ )
                    {
                        _text += _list[ _i ];
                    }

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

            return string.Empty;
        }
    }
}
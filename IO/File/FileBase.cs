// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="FileBase.cs" company="Terry D. Eppler">
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
//   FileBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.PathBase" />
    [SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    public abstract class FileBase : PathBase
    {
        /// <summary>
        /// Moves the specified file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public virtual void Move( string filePath )
        {
            try
            {
                ThrowIf.NotExists( filePath, "filePath" );
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
        /// <param name="filePath">The file path.</param>
        public virtual void Copy( string filePath )
        {
            try
            {
                ThrowIf.NotExists( filePath, "filePath" );
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
        public virtual void Delete( )
        {
            try
            {
                var _file = Path.GetFullPath( Buffer );
                if( !string.IsNullOrEmpty( _file )
                   && File.Exists( _file ) )
                {
                    File.Delete( _file );
                }
            }
            catch( IOException _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the file security.
        /// </summary>
        /// <returns></returns>
        public FileSecurity GetFileSecurity( )
        {
            try
            {
                return FileSecurity ?? default( FileSecurity );
            }
            catch( IOException _ex )
            {
                Fail( _ex );
                return default( FileSecurity );
            }
        }

        /// <summary>
        /// Gets the base stream.
        /// </summary>
        /// <returns></returns>
        public FileStream GetBaseStream( )
        {
            try
            {
                var _path = Path.GetFullPath( Buffer );
                return !string.IsNullOrEmpty( _path ) && File.Exists( _path )
                    ? new FileInfo( _path )?.Create( )
                    : default( FileStream );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( FileStream );
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( Buffer )
                    ? Path.GetFullPath( Buffer )
                    : string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return string.Empty;
            }
        }
    }
}
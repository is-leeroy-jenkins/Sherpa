// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="PathBase.cs" company="Terry D. Eppler">
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
//   PathBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security.AccessControl;
    using System.Threading;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "ReplaceAutoPropertyWithComputedProperty" ) ]
    public abstract class PathBase
    {
        /// <summary> Gets or sets the buffer. </summary>
        /// <value> The buffer. </value>
        public virtual string Buffer { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        public virtual string Name { get; set; }

        /// <summary> Gets or sets the full path. </summary>
        /// <value> The full path. </value>
        public virtual string FullPath { get; set; }

        /// <summary> Gets or sets the absolute path. </summary>
        /// <value> The absolute path. </value>
        public virtual string AbsolutePath { get; set; }

        /// <summary> Gets or sets the modified. </summary>
        /// <value> The modified. </value>
        public virtual DateTime Modified { get; set; }

        /// <summary> Gets or sets the extension. </summary>
        /// <value> The extension. </value>
        public virtual string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance has parent; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public virtual bool HasParent { get; set; }

        /// <summary> Gets or sets the parent folder. </summary>
        /// <value> The parent folder. </value>
        public virtual string ParentFolder { get; set; }

        /// <summary> Gets or sets the created. </summary>
        /// <value> The created. </value>
        public virtual DateTime Created { get; set; }

        /// <summary> Gets or sets the length. </summary>
        /// <value> The length. </value>
        public virtual long Length { get; set; }

        /// <summary> Gets or sets the attributes. </summary>
        /// <value> The attributes. </value>
        public virtual FileAttributes Attributes { get; set; }

        /// <summary> Gets or sets the file security. </summary>
        /// <value> The file security. </value>
        public virtual FileSecurity FileSecurity { get; set; }

        /// <summary> Gets the dir sep. </summary>
        /// <value> The dir sep. </value>
        public char DirSep { get; } = Path.DirectorySeparatorChar;

        /// <summary> Gets the path sep. </summary>
        /// <value> The path sep. </value>
        public char PathSep { get; } = Path.PathSeparator;

        /// <summary> Gets the invalid path chars. </summary>
        /// <value> The invalid path chars. </value>
        public char[ ] InvalidPathChars { get; } = Path.GetInvalidPathChars( );

        /// <summary> Gets the invalid name chars. </summary>
        /// <value> The invalid name chars. </value>
        public char[ ] InvalidNameChars { get; } = Path.GetInvalidFileNameChars( );

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PathBase"/>
        /// class.
        /// </summary>
        protected PathBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="PathBase"/>
        /// class.
        /// </summary>
        /// <param name="input"> The input. </param>
        protected PathBase( string input )
        {
            Buffer = input;
            AbsolutePath = Path.GetFullPath( input );
            Name = new FileInfo( AbsolutePath ).Name;
            FullPath = new FileInfo( AbsolutePath ).FullName;
            Extension = new FileInfo( AbsolutePath ).Extension;
            Length = new FileInfo( AbsolutePath ).Length;
            Attributes = new FileInfo( AbsolutePath ).Attributes;
            FileSecurity = new FileInfo( AbsolutePath ).GetAccessControl( );
            Created = new FileInfo( AbsolutePath ).CreationTime;
            Modified = new FileInfo( AbsolutePath ).LastWriteTime;
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
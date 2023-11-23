// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="DataPath.cs" company="Terry D. Eppler">
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
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.PathBase"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameterInConstructor" ) ]
    public class DataPath : PathBase, IPath
    {
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
        /// <param name="input"> The input. </param>
        public DataPath( string input )
        {
            Buffer = input;
            AbsolutePath = Path.GetFullPath( input );
            Name = Path.GetFileNameWithoutExtension( input );
            FullPath = Path.GetFullPath( input );
            Extension = Path.GetExtension( input );
            Length = input.Length;
            Attributes = File.GetAttributes( input );
            FileSecurity = new FileSecurity( input, AccessControlSections.All );
            Created = File.GetCreationTime( input );
            Modified = File.GetLastWriteTime( input );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataPath"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public DataPath( DataPath path )
        {
            Buffer = path.Buffer;
            AbsolutePath = path.AbsolutePath;
            Name = path.Name;
            FullPath = path.FullPath;
            Extension = path.Extension;
            Length = path.Length;
            Attributes = path.Attributes;
            FileSecurity = path.FileSecurity;
            Created = path.Created;
            Modified = path.Modified;
        }

        /// <summary>
        /// Deconstructs the specified buffer.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="absPath">The abs path.</param>
        /// <param name="name">The name.</param>
        /// <param name="fullPath">The full path.</param>
        /// <param name="ext">The ext.</param>
        /// <param name="length">The length.</param>
        /// <param name="attrs">The attrs.</param>
        /// <param name="fileSecurity">The file security.</param>
        /// <param name="created">The created.</param>
        /// <param name="modified">The modified.</param>
        public void Deconstruct( out string buffer, out string absPath, out string name,
            out string fullPath, out string ext, out long length,
            out FileAttributes attrs, out FileSecurity fileSecurity,
            out DateTime created, out DateTime modified )
        {
            buffer = Buffer;
            absPath = AbsolutePath;
            name = Name;
            fullPath = FullPath;
            ext = Extension;
            length = Length;
            attrs = Attributes;
            fileSecurity = FileSecurity;
            created = Created;
            modified = Modified;
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
                return !string.IsNullOrEmpty( FullPath )
                    ? FullPath
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
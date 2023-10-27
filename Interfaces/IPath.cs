// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="IPath.cs" company="Terry D. Eppler">
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
//   IPath.cs
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
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public interface IPath
    {
        /// <summary> The path </summary>
        string Buffer { get; set; }

        /// <summary> Gets or sets the name of the file. </summary>
        /// <value> The name of the file. </value>
        string Name { get; set; }

        /// <summary> Gets or sets the full name. </summary>
        /// <value> The full name. </value>
        string FullPath { get; set; }

        /// <summary> Gets or sets the full path. </summary>
        /// <value> The full path. </value>
        string AbsolutePath { get; set; }

        /// <summary> Gets or sets the changed date. </summary>
        /// <value> The changed date. </value>
        DateTime Modified { get; set; }

        /// <summary> Gets or sets the extension. </summary>
        /// <value> The extension. </value>
        string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance has parent { get; set; } otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        bool HasParent { get; set; }

        /// <summary> Gets or sets the creation date. </summary>
        /// <value> The creation date.p/// </value>
        DateTime Created { get; set; }

        /// <summary> Gets or sets the lengeth. </summary>
        /// <value> The lengeth. </value>
        long Length { get; set; }

        /// <summary> Gets or sets the attributes. </summary>
        /// <value> The attributes. </value>
        FileAttributes Attributes { get; set; }

        /// <summary> Gets or sets the security. </summary>
        /// <value> The security. </value>
        FileSecurity FileSecurity { get; set; }

        /// <summary> Gets the dir sep. </summary>
        /// <value> The dir sep. </value>
        char DirSep { get; }

        /// <summary> Gets the path sep. </summary>
        /// <value> The path sep. </value>
        char PathSep { get; }

        /// <summary> Gets the invalid path character. </summary>
        /// <value> The invalid path character. </value>
        char[ ] InvalidPathChars { get; }

        /// <summary> Gets the invalid chars. </summary>
        /// <value> The invalid chars. </value>
        char[ ] InvalidNameChars { get; }
    }
}
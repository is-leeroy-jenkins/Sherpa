// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ISqlStatement.cs" company="Terry D. Eppler">
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
//   ISqlStatement.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    /// <summary> </summary>
    public interface ISqlStatement
    {
        /// <summary> The extension </summary>
        EXT Extension { get; set; }

        /// <summary> The source </summary>
        Source Source { get; set; }

        /// <summary> The provider </summary>
        Provider Provider { get; set; }

        /// <summary> The command type </summary>
        SQL CommandType { get; set; }

        /// <summary> Gets or sets the command text. </summary>
        /// <value> The command text. </value>
        string CommandText { get; set; }

        /// <summary> The arguments </summary>
        IDictionary<string, object> Criteria { get; set; }

        /// <summary> Gets or sets the updates. </summary>
        /// <value> The updates. </value>
        IDictionary<string, object> Updates { get; set; }

        /// <summary> Gets or sets the columns. </summary>
        /// <value> The columns. </value>
        IList<string> Fields { get; set; }

        /// <summary> Gets or sets the numerics. </summary>
        /// <value> The numerics. </value>
        IList<string> Numerics { get; set; }

        /// <summary> Gets or sets the name of the table. </summary>
        /// <value> The name of the table. </value>
        string TableName { get; set; }

        /// <summary> The provider path </summary>
        string DbPath { get; set; }

        /// <summary> The file name </summary>
        string FileName { get; set; }

        /// <summary> Gets the command text. </summary>
        /// <returns> </returns>
        string GetCommandText( );
    }
}
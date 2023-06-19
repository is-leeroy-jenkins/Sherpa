// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 03-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ColumnSchema.cs" company="Terry D. Eppler">
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
//   ColumnSchema.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;

    /// <summary> Contains the schema of a single DB column. </summary>
    public class ColumnSchema
    {
        /// <summary> Gets or sets the name of the column. </summary>
        /// <value> The name of the column. </value>
        public string ColumnName { get; set; }

        /// <summary> Gets or sets the type of the column. </summary>
        /// <value> The type of the column. </value>
        public string ColumnType { get; set; }

        /// <summary> Gets or sets the default value. </summary>
        /// <value> The default value. </value>
        public string DefaultValue { get; set; }

        /// <summary> Gets or sets the is case sensitive. </summary>
        /// <value> The is case sensitive. </value>
        public bool? IsCaseSensitive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is identity.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is identity; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool IsIdentity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is nullable.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is nullable; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool IsNullable { get; set; }

        /// <summary> Gets or sets the length. </summary>
        /// <value> The length. </value>
        public int Length { get; set; }
    }
}
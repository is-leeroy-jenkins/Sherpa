//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                IExcelConfig.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="IExcelConfig.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    IExcelConfig.cs
//  </summary>
//  ******************************************************************************************

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using OfficeOpenXml.Style;

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public interface IExcelConfig
    {
        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        int Index { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the color of the primary back.
        /// </summary>
        /// <value>
        /// The color of the primary back.
        /// </value>
        Color PrimaryBackColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the secondary back.
        /// </summary>
        /// <value>
        /// The color of the secondary back.
        /// </value>
        Color SecondaryBackColor { get; set; }

        /// <summary>
        /// Gets or sets the left.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        ExcelHorizontalAlignment Left { get; set; }

        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        ExcelHorizontalAlignment Center { get; set; }

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        ExcelHorizontalAlignment Right { get; set; }

        /// <summary>
        /// Gets or sets the height of the row.
        /// </summary>
        /// <value>
        /// The height of the row.
        /// </value>
        double RowHeight { get; set; }

        /// <summary>
        /// Gets or sets the width of the column.
        /// </summary>
        /// <value>
        /// The width of the column.
        /// </value>
        double ColumnWidth { get; set; }

        /// <summary>
        /// Gets or sets the top margin.
        /// </summary>
        /// <value>
        /// The top margin.
        /// </value>
        int TopMargin { get; set; }

        /// <summary>
        /// Gets or sets the bottom margin.
        /// </summary>
        /// <value>
        /// The bottom margin.
        /// </value>
        int BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets the left margin.
        /// </summary>
        /// <value>
        /// The left margin.
        /// </value>
        decimal LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets the right margin.
        /// </summary>
        /// <value>
        /// The right margin.
        /// </value>
        decimal RightMargin { get; set; }

        /// <summary>
        /// Gets or sets the header margin.
        /// </summary>
        /// <value>
        /// The header margin.
        /// </value>
        decimal HeaderMargin { get; set; }

        /// <summary>
        /// Gets or sets the footer margin.
        /// </summary>
        /// <value>
        /// The footer margin.
        /// </value>
        decimal FooterMargin { get; set; }

        /// <summary>
        /// Gets or sets the column count.
        /// </summary>
        /// <value>
        /// The column count.
        /// </value>
        int ColumnCount { get; set; }

        /// <summary>
        /// Gets or sets the row count.
        /// </summary>
        /// <value>
        /// The row count.
        /// </value>
        int RowCount { get; set; }

        /// <summary>
        /// Gets or sets the zoom level.
        /// </summary>
        /// <value>
        /// The zoom level.
        /// </value>
        int ZoomLevel { get; set; }

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        void SetFilePath( string filePath );

        /// <summary>
        /// Sets the name of the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        void SetFileName( string filePath );

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        EXT GetFileExtension( string filePath );

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        string GetConnectionString( string extension, string filePath );

        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        void AddComment( Grid grid, string text );

        /// <summary>
        /// Sets the caption text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        void SetCaptionText( Grid grid );

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        void SetText( Grid grid, IEnumerable<string> text );
    }
}
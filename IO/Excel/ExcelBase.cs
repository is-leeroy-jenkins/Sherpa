// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ExcelBase.cs" company="Terry D. Eppler">
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
//   ExcelBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.ExcelConfig" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class ExcelBase : ExcelConfig
    {
        /// <summary>
        /// Gets or sets the data connection.
        /// </summary>
        /// <value>
        /// The data connection.
        /// </value>
        public OleDbConnection DataConnection { get; set; }

        /// <summary>
        /// Gets or sets the data command.
        /// </summary>
        /// <value>
        /// The data command.
        /// </value>
        public OleDbCommand DataCommand { get; set; }

        /// <summary>
        /// Gets or sets the data adapter.
        /// </summary>
        /// <value>
        /// The data adapter.
        /// </value>
        public OleDbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets or sets the ext.
        /// </summary>
        /// <value>
        /// The ext.
        /// </value>
        public EXT Ext { get; set; }

        /// <summary>
        /// Gets or sets the file information.
        /// </summary>
        /// <value>
        /// The file information.
        /// </value>
        public FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the application.
        /// </summary>
        /// <value>
        /// The application.
        /// </value>
        public ExcelPackage Application { get; set; }

        /// <summary>
        /// Gets or sets the workbook.
        /// </summary>
        /// <value>
        /// The workbook.
        /// </value>
        public ExcelWorkbook Workbook { get; set; }

        /// <summary>
        /// Gets or sets the worksheet.
        /// </summary>
        /// <value>
        /// The worksheet.
        /// </value>
        public ExcelWorksheet Worksheet { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public IEnumerable<ExcelComment> Comment { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Sets the width of the column.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="width">The width.</param>
        public void SetColumnWidth( Grid grid, double width )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                ThrowIf.NegativeOrZero( width, "width" );
                using var _range = grid.Range;
                _range.AutoFitColumns( width );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the color of the background.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="color">The color.</param>
        public void SetBackgroundColor( Grid grid, Color color )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                ThrowIf.NullOrEmpty( color, "color" );
                using var _range = grid.Range;
                _range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _range.Style.Fill.BackgroundColor.SetColor( color );
                _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the range font.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="font">The font.</param>
        public void SetRangeFont( Grid grid, Font font )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                ThrowIf.Null( font, "font" );
                using var _range = grid.Range;
                _range.Style.Font.SetFromFont( font.Name, font.Size );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the color of the font.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="color">The color.</param>
        public void SetFontColor( Grid grid, Color color )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                ThrowIf.NullOrEmpty( color, "color" );
                using var _range = grid.Range;
                _range.Style.Font.Color.SetColor( color );
                _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="side">The side.</param>
        /// <param name="style">The style.</param>
        public void SetBorderStyle( Grid grid, BorderSide side, ExcelBorderStyle style )
        {
            if( ( grid?.Worksheet != null )
               && ( grid?.Range != null )
               && Enum.IsDefined( typeof( ExcelBorderStyle ), style )
               && Enum.IsDefined( typeof( BorderSide ), side ) )
            {
                try
                {
                    using var _range = grid.Range;
                    switch( side )
                    {
                        case BorderSide.Top:
                        {
                            _range.Style.Border.Top.Style = style;
                            break;
                        }
                        case BorderSide.Bottom:
                        {
                            _range.Style.Border.Bottom.Style = style;
                            break;
                        }
                        case BorderSide.Right:
                        {
                            _range.Style.Border.Right.Style = style;
                            break;
                        }
                        case BorderSide.Left:
                        {
                            _range.Style.Border.Left.Style = style;
                            break;
                        }
                        default:
                        {
                            _range.Style.Border.BorderAround( ExcelBorderStyle.None );
                            break;
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the horizontal alignment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="align">The align.</param>
        public void SetHorizontalAlignment( Grid grid, ExcelHorizontalAlignment align )
        {
            if( ( grid?.Worksheet != null )
               && ( grid?.Range != null )
               && Enum.IsDefined( typeof( ExcelHorizontalAlignment ), align ) )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Style.HorizontalAlignment = align;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the vertical alignment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="align">The align.</param>
        public void SetVerticalAlignment( Grid grid, ExcelVerticalAlignment align )
        {
            if( ( grid?.Worksheet != null )
               && Enum.IsDefined( typeof( ExcelVerticalAlignment ), align ) )
            {
                try
                {
                    using var _range = grid.Range;
                    _range.Style.VerticalAlignment = align;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Merges the cells.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void MergeCells( Grid grid )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                using var _range = grid.Range;
                _range.Merge = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}
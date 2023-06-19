// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ExcelConfig.cs" company="Terry D. Eppler">
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
//   ExcelConfig.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using OfficeOpenXml.Style;
    using static System.IO.Path;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "ConvertSwitchStatementToSwitchExpression" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class ExcelConfig
    {
        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int Index { get; set; } = 10;

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the color of the primary back.
        /// </summary>
        /// <value>
        /// The color of the primary back.
        /// </value>
        public Color PrimaryBackColor { get; set; } = Color.FromArgb( 255, 242, 242, 242 );

        /// <summary>
        /// Gets or sets the color of the secondary back.
        /// </summary>
        /// <value>
        /// The color of the secondary back.
        /// </value>
        public Color SecondaryBackColor { get; set; } = Color.FromArgb( 255, 221, 235, 247 );

        /// <summary>
        /// Gets or sets the left.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        public ExcelHorizontalAlignment Left { get; set; } = ExcelHorizontalAlignment.Left;

        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        public ExcelHorizontalAlignment Center { get; set; } = ExcelHorizontalAlignment.Center;

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        public ExcelHorizontalAlignment Right { get; set; } = ExcelHorizontalAlignment.Right;

        /// <summary>
        /// Gets or sets the height of the row.
        /// </summary>
        /// <value>
        /// The height of the row.
        /// </value>
        public double RowHeight { get; set; } = 0.22;

        /// <summary>
        /// Gets or sets the width of the column.
        /// </summary>
        /// <value>
        /// The width of the column.
        /// </value>
        public double ColumnWidth { get; set; } = 0.75;

        /// <summary>
        /// Gets or sets the top margin.
        /// </summary>
        /// <value>
        /// The top margin.
        /// </value>
        public int TopMargin { get; set; } = 1;

        /// <summary>
        /// Gets or sets the bottom margin.
        /// </summary>
        /// <value>
        /// The bottom margin.
        /// </value>
        public int BottomMargin { get; set; } = 1;

        /// <summary>
        /// Gets or sets the left margin.
        /// </summary>
        /// <value>
        /// The left margin.
        /// </value>
        public decimal LeftMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the right margin.
        /// </summary>
        /// <value>
        /// The right margin.
        /// </value>
        public decimal RightMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the header margin.
        /// </summary>
        /// <value>
        /// The header margin.
        /// </value>
        public decimal HeaderMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the footer margin.
        /// </summary>
        /// <value>
        /// The footer margin.
        /// </value>
        public decimal FooterMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the column count.
        /// </summary>
        /// <value>
        /// The column count.
        /// </value>
        public int ColumnCount { get; set; } = 12;

        /// <summary>
        /// Gets or sets the row count.
        /// </summary>
        /// <value>
        /// The row count.
        /// </value>
        public int RowCount { get; set; } = 55;

        /// <summary>
        /// Gets or sets the zoom level.
        /// </summary>
        /// <value>
        /// The zoom level.
        /// </value>
        public int ZoomLevel { get; set; } = 100;

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public void SetFilePath( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath ) )
            {
                try
                {
                    FilePath = GetFileName( filePath );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the name of the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public void SetFileName( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath ) )
            {
                try
                {
                    FilePath = GetFileNameWithoutExtension( filePath );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public EXT GetFileExtension( string filePath )
        {
            try
            {
                var _path = GetExtension( filePath );
                if( _path != null )
                {
                    var _extension = (EXT)Enum.Parse( typeof( EXT ), _path );
                    return Enum.IsDefined( typeof( EXT ), _extension )
                        ? _extension
                        : default( EXT );
                }

                return default( EXT );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( EXT );
            }
        }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public string GetConnectionString( string extension, string filePath )
        {
            if( !string.IsNullOrEmpty( extension )
               && !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    switch( extension?.ToUpper( ) )
                    {
                        case ".XLS":
                        {
                            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" 
                                + filePath 
                                + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
                        }
                        case ".XLSX":
                        {
                            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
                                + filePath 
                                + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                        }
                        default:
                        {
                            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" 
                                + filePath 
                                + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public void AddComment( Grid grid, string text )
        {
            if( ( grid != null )
               && !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    using var _range = grid?.Range;
                    var _excelComment = _range?.AddComment( text, "Budget" );
                    if( _excelComment != null )
                    {
                        _excelComment.From.Row = _range.Start.Row;
                        _excelComment.From.Column = _range.Start.Column;
                        _excelComment.To.Row = _range.End.Row;
                        _excelComment.To.Column = _range.End.Column;
                        _excelComment.BackgroundColor = Color.FromArgb( 15, 15, 15 );
                        _excelComment.Font.FontName = "Roboto";
                        _excelComment.Font.Size = 8;
                        _excelComment.Font.Color = Color.Black;
                        _excelComment.Text = text;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the caption text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetCaptionText( Grid grid )
        {
            if( grid != null )
            {
                try
                {
                    using var _sheet = grid.Worksheet;
                    var _row = grid.Range.Start.Row;
                    var _column = grid.Range.Start.Column;
                    _sheet.Cells[ _row, _column ].Value = "Account";
                    _sheet.Cells[ _row, _column + 1 ].Value = "SuperfundSite";
                    _sheet.Cells[ _row, _column + 2 ].Value = "Travel";
                    _sheet.Cells[ _row, _column + 3 ].Value = "Expenses";
                    _sheet.Cells[ _row, _column + 4 ].Value = "Contracts";
                    _sheet.Cells[ _row, _column + 5 ].Value = "Grants";
                    _sheet.Cells[ _row, _column + 6 ].Value = "Total";
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public void SetText( Grid grid, IEnumerable<string> text )
        {
            if( ( grid != null )
               && ( text?.Any( ) == true )
               && grid.Range.Any( ) )
            {
                try
                {
                    foreach( var _cell in grid.Range )
                    {
                        foreach( var _caption in text )
                        {
                            if( ( _cell != null )
                               && !string.IsNullOrEmpty( _caption ) )
                            {
                                _cell.Value = _caption;
                            }
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
        /// 
        /// </summary>
        public enum BorderSide
        {
            /// <summary>
            /// The top
            /// </summary>
            Top,

            /// <summary>
            /// The bottom
            /// </summary>
            Bottom,

            /// <summary>
            /// The left
            /// </summary>
            Left,

            /// <summary>
            /// The right
            /// </summary>
            Right
        };

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
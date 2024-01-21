﻿// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Workbook.cs" company="Terry D. Eppler">
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
//   Workbook.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class Workbook : ExcelConfig
    {
        /// <summary>
        /// Gets or sets the color of the font.
        /// </summary>
        /// <value>
        /// The color of the font.
        /// </value>
        public Color FontColor
        {
            get
            {
                return _fontColor;
            }
            private protected set
            {
                _fontColor = value;
            }
        }

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        /// <value>
        /// The font.
        /// </value>
        public Font Font
        {
            get
            {
                return _font;
            }
            private protected set
            {
                _font = value;
            }
        }

        /// <summary>
        /// Gets or sets the title font.
        /// </summary>
        /// <value>
        /// The title font.
        /// </value>
        public Font TitleFont
        {
            get
            {
                return _titleFont;
            }
            private protected set
            {
                _titleFont = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the header image.
        /// </summary>
        /// <value>
        /// The width of the header image.
        /// </value>
        public double HeaderImageWidth
        {
            get
            {
                return _headerImageWidth;
            }
            private protected set
            {
                _headerImageWidth = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the header image.
        /// </summary>
        /// <value>
        /// The height of the header image.
        /// </value>
        public double HeaderImageHeight
        {
            get
            {
                return _headerImageHeigth;
            }
            private protected set
            {
                _headerImageHeigth = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the footer image.
        /// </summary>
        /// <value>
        /// The width of the footer image.
        /// </value>
        public double FooterImageWidth
        {
            get
            {
                return _footerImageWidth;
            }
            private protected set
            {
                _footerImageWidth = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the footer image.
        /// </summary>
        /// <value>
        /// The height of the footer image.
        /// </value>
        public double FooterImageHeight
        {
            get
            {
                return _footerImageHeigth;
            }
            private protected set
            {
                _footerImageHeigth = value;
            }
        }

        /// <summary>
        /// Gets or sets the header image.
        /// </summary>
        /// <value>
        /// The header image.
        /// </value>
        public Image HeaderImage
        {
            get
            {
                return _headerImage;
            }
            private protected set
            {
                _headerImage = value;
            }
        }

        /// <summary>
        /// Gets or sets the footer image.
        /// </summary>
        /// <value>
        /// The footer image.
        /// </value>
        public Image FooterImage
        {
            get
            {
                return _footerImage;
            }
            private protected set
            {
                _footerImage = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Workbook"/> class.
        /// </summary>
        public Workbook( )
        {
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Workbook" /> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public Workbook( string filePath ) 
            : this( )
        {
            _fileInfo = new FileInfo( filePath );
            _excelPackage = new ExcelPackage( FileInfo );
            _excelWorkbook = _excelPackage.Workbook;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Workbook" /> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public Workbook( DataTable dataTable )
            : this( )
        {
            _data = dataTable.AsEnumerable( );
            _excelWorksheet = Workbook.Worksheets.Add( dataTable.TableName );
            _excelWorksheet.View.ShowGridLines = false;
            _excelWorksheet.View.ZoomScale = _zoomLevel;
            _excelWorksheet.View.PageLayoutView = true;
            _excelWorksheet.View.ShowHeaders = true;
            _excelWorksheet.DefaultRowHeight = _rowHeight;
            _excelWorksheet.DefaultColWidth = _columnWidth;
            _excelWorksheet.PrinterSettings.ShowHeaders = false;
            _excelWorksheet.PrinterSettings.ShowGridLines = false;
            _excelWorksheet.PrinterSettings.LeftMargin = _leftMargin;
            _excelWorksheet.PrinterSettings.RightMargin = _rightMargin;
            _excelWorksheet.PrinterSettings.TopMargin = _headerMargin;
            _excelWorksheet.PrinterSettings.BottomMargin = _footerMargin;
            _excelWorksheet.PrinterSettings.HorizontalCentered = true;
            _excelWorksheet.PrinterSettings.VerticalCentered = true;
            _excelWorksheet.PrinterSettings.FitToPage = true;
            _excelWorksheet.HeaderFooter.AlignWithMargins = true;
            _excelWorksheet.HeaderFooter.ScaleWithDocument = true;
        }

        /// <summary>
        /// Sets the header format.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetHeaderFormat( Grid grid )
        {
            if( grid?.Worksheet != null )
            {
                try
                {
                    SetFontColor( grid, _fontColor );
                    SetBackgroundColor( grid, _primaryBackColor );
                    SetHorizontalAlignment( grid, ExcelHorizontalAlignment.Left );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetHeaderText( Grid grid )
        {
            if( grid?.Worksheet != null )
            {
                try
                {
                    using var _range = grid.Range;
                    var _row = _range.Start.Row;
                    var _column = _range.Start.Column;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the dark color row.
        /// </summary>
        /// <param name="excelRange">The excel range.</param>
        public void SetDarkColorRow( ExcelRange excelRange )
        {
            if( excelRange != null )
            {
                try
                {
                    excelRange.Style.Font.Color.SetColor( _fontColor );
                    excelRange.Style.Font.SetFromFont( _font.Name, _font.Size );
                    excelRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    excelRange.Style.Fill.BackgroundColor.SetColor( _secondaryBackColor );
                    excelRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                    excelRange.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the light color row.
        /// </summary>
        /// <param name="range">The range.</param>
        public void SetLightColorRow( ExcelRange range )
        {
            if( range != null )
            {
                try
                {
                    range.Style.Font.Color.SetColor( _fontColor );
                    range.Style.Font.SetFromFont( _font.Name, _font.Size );
                    range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor( _primaryBackColor );
                    range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                    range.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the alternating row.
        /// </summary>
        /// <param name="range">The range.</param>
        public void SetAlternatingRowColor( ExcelRange range )
        {
            if( ( _excelWorksheet != null )
               && ( range?.Start?.Row > -1 )
               && ( range.Start.Column > -1 )
               && ( range.End?.Row > -1 )
               && ( range.End.Column > -1 ) )
            {
                try
                {
                    var _startRow = range.Start.Row;
                    var _startColumn = range.Start.Column;
                    var _endRow = range.End.Row;
                    var _endColumn = range.End.Column;
                    var _prc = _excelWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                    for( var _i = _startRow; _i < _endRow; _i++ )
                    {
                        if( _i % 2 == 0 )
                        {
                            SetLightColorRow( _prc );
                        }

                        if( _i % 2 != 0 )
                        {
                            SetDarkColorRow( _prc );
                        }
                    }

                    SetNumericRowFormat( range );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the numeric row format.
        /// </summary>
        /// <param name="range">The range.</param>
        public void SetNumericRowFormat( ExcelRange range )
        {
            if( ( _excelWorksheet != null )
               && ( range.Start.Row > -1 )
               && ( range.Start.Column > -1 )
               && ( range.End.Row > -1 )
               && ( range.End.Column > -1 ) )
            {
                try
                {
                    using( range )
                    {
                        range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                        range.Style.Numberformat.Format = "#,###";
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the table format.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetTableFormat( Grid grid )
        {
            if( grid?.Worksheet != null )
            {
                try
                {
                    SetHeaderText( grid );
                    using var _range = grid.Range;
                    _range.Style.Font.SetFromFont( _titleFont.Name, _titleFont.Size );
                    _range.Style.Border.BorderAround( ExcelBorderStyle.Thin );
                    _range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    _range.Style.Fill.BackgroundColor.SetColor( Color.White );
                    _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the total row format.
        /// </summary>
        /// <param name="range">The range.</param>
        public void SetTotalRowFormat( ExcelRange range )
        {
            if( ( _excelWorksheet != null )
               && ( range.Start.Row > -1 )
               && ( range.Start.Column > -1 )
               && ( range.End.Row > -1 )
               && ( range.End.Column > -1 ) )
            {
                try
                {
                    var _total = _excelWorksheet.Cells[ range.Start.Row, range.Start.Column, 
                        range.Start.Row, range.Start.Column + 6 ];
                    
                    var _range = _excelWorksheet.Cells[ range.Start.Row, range.Start.Column + 1, 
                        range.Start.Row, range.Start.Column + 6 ];
                    
                    _total.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    _total.Style.Fill.BackgroundColor.SetColor( _secondaryBackColor );
                    _range.Style.Border.Bottom.Style = ExcelBorderStyle.Double;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}
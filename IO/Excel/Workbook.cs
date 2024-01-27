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
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
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
    [ SuppressMessage( "ReSharper", "RedundantCheckBeforeAssignment" ) ]
    public abstract class Workbook : ExcelConfig
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Workbook" /> class.
        /// </summary>
        public void InitializeWorksheetFormat( )
        {
            try
            {
                if( _dataTable != null )
                {
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
                else
                {
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
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="excelRange">
        /// The grid.
        /// </param>
        /// <param name="labels">
        /// </param>
        public void SetHeaderRowValues( ExcelRange excelRange, IList<string> labels )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                ThrowIf.Null( labels, nameof( labels ) );
                var _header = excelRange.Start.Row - 1;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row - 1;
                var _endColumn = excelRange.End.Column;
                _headerRange = _excelWorksheet.Cells[ _header, _startColumn, _endRow, _endColumn ];
                foreach( var _item in labels )
                {
                    if( _startColumn <= _endColumn )
                    {
                        _headerRange.SetCellValue( _header, _startColumn, _item );
                    }

                    _startColumn++;
                }
            }
            catch( Exception _ex )
            {
                if( _headerRange != null )
                {
                    _headerRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the footer text.
        /// </summary>
        /// <param name="excelRange">The excel range.</param>
        /// <param name="labels">The labels.</param>
        public void SetFooterRowValues( ExcelRange excelRange, IEnumerable<string> labels )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                ThrowIf.Null( labels, nameof( labels ) );
                var _footer = excelRange.Start.Row + 1;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row + 1;
                var _endColumn = excelRange.End.Column;
                _footerRange = _excelWorksheet.Cells[ _footer, _startColumn, 
                    _endRow, _endColumn ];

                foreach( var _item in labels )
                {
                    if( _startColumn <= _endColumn )
                    {
                        _footerRange.SetCellValue( _footer, _startColumn, _item );
                    }

                    _startColumn++;
                }
            }
            catch( Exception _ex )
            {
                if( _footerRange != null )
                {
                    _footerRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the dark color row.
        /// </summary>
        /// <param name="excelRange"> </param>
        private protected void SetDarkRowColor( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                _excelRange.EntireRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _excelRange.EntireRow.Style.Fill.BackgroundColor.SetColor( _secondaryBackColor );
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the light color row.
        /// </summary>
        /// <param name="excelRange">The range.</param>
        private protected void SetLightRowColor( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn, _endRow, _endColumn ];
                _excelRange.EntireRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _excelRange.EntireRow.Style.Fill.BackgroundColor.SetColor( _primaryBackColor );
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the color of the alternating row.
        /// </summary>
        /// <param name="excelRange">The range.</param>
        public void SetAlternatingRowColor( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn, 
                    _endRow, _endColumn ];

                for( var _i = _startRow; _i < _endRow; _i++ )
                {
                    if( _i % 2 == 0 )
                    {
                        var _row = _excelWorksheet.Cells[ _i, _startColumn, _i, _endColumn ];
                        _row.EntireRow.Style.Border.Bottom.Style = ExcelBorderStyle.Dotted;
                        _row.EntireRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        _row.EntireRow.Style.Fill.BackgroundColor.SetColor( _primaryBackColor );
                    }
                    else
                    {
                        var _row = _excelWorksheet.Cells[ _i, _startColumn, _i, _endColumn ];
                        _row.EntireRow.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
                        _row.EntireRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
                        _row.EntireRow.Style.Fill.BackgroundColor.SetColor( _secondaryBackColor );
                    }
                }
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the numeric row format.
        /// </summary>
        /// <param name="excelRange">The range.</param>
        public void SetNumericRowFormat( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn,
                    _endRow, _endColumn ];

                _excelRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                _excelRange.Style.Numberformat.Format = "#,###";
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the total row format.
        /// </summary>
        /// <param name="excelRange">The range.</param>
        public void SetTableFormat( ExcelRange excelRange )
        {
            try
            {
                ThrowIf.Null( excelRange, nameof( excelRange ) );
                var _startRow = excelRange.Start.Row;
                var _startColumn = excelRange.Start.Column;
                var _endRow = excelRange.End.Row;
                var _endColumn = excelRange.End.Column;
                _excelRange = _excelWorksheet.Cells[ _startRow, _startColumn, 
                    _endRow, _endColumn ];

                _excelRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _excelRange.Style.Fill.BackgroundColor.SetColor( _secondaryBackColor );
                _excelRange.Style.Border.Bottom.Style = ExcelBorderStyle.Double;
            }
            catch( Exception _ex )
            {
                if( _excelRange != null )
                {
                    _excelRange = null;
                }

                Fail( _ex );
            }
        }
    }
}
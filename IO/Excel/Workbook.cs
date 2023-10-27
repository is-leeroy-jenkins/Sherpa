// ******************************************************************************************
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
    using System.Threading;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.ExcelBase"/>
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class Workbook : ExcelBase
    {
        /// <summary> Gets or sets the color of the font. </summary>
        /// <value> The color of the font. </value>
        public Color FontColor { get; set; } = Color.Black;

        /// <summary> Gets or sets the font. </summary>
        /// <value> The font. </value>
        public Font Font { get; set; } = new Font ( "Roboto", 8, FontStyle.Regular );

        /// <summary> Gets or sets the title font. </summary>
        /// <value> The title font. </value>
        public Font TitleFont { get; set; } = new Font ( "Roboto", 10, FontStyle.Bold );

        /// <summary> Gets or sets the width of the header image. </summary>
        /// <value> The width of the header image. </value>
        public double HeaderImageWidth { get; set; } = 1.75;

        /// <summary> Gets or sets the height of the header image. </summary>
        /// <value> The height of the header image. </value>
        public double HeaderImageHeight { get; set; } = 0.75;

        /// <summary> Gets or sets the width of the footer image. </summary>
        /// <value> The width of the footer image. </value>
        public double FooterImageWidth { get; set; } = 2.04;

        /// <summary> Gets or sets the height of the footer image. </summary>
        /// <value> The height of the footer image. </value>
        public double FooterImageHeight { get; set; } = 0.70;

        /// <summary> Gets or sets the header image. </summary>
        /// <value> The header image. </value>
        public Image HeaderImage { get; set; }

        /// <summary> Gets or sets the footer image. </summary>
        /// <value> The footer image. </value>
        public Image FooterImage { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Workbook"/>
        /// class.
        /// </summary>
        public Workbook( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Workbook"/>
        /// class.
        /// </summary>
        /// <param name="filePath"> The file path. </param>
        public Workbook( string filePath )
            : this( )
        {
            FileInfo = new FileInfo( filePath );
            Application = new ExcelPackage( FileInfo );
            Workbook = Application.Workbook;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Workbook"/>
        /// class.
        /// </summary>
        /// <param name="dataTable"> The data table. </param>
        public Workbook( DataTable dataTable )
            : this( )
        {
            Data = dataTable.AsEnumerable( );
            Worksheet = Workbook.Worksheets.Add( dataTable.TableName );
            Worksheet.View.ShowGridLines = false;
            Worksheet.View.ZoomScale = ZoomLevel;
            Worksheet.View.PageLayoutView = true;
            Worksheet.View.ShowHeaders = true;
            Worksheet.DefaultRowHeight = RowHeight;
            Worksheet.DefaultColWidth = ColumnWidth;
            Worksheet.PrinterSettings.ShowHeaders = false;
            Worksheet.PrinterSettings.ShowGridLines = false;
            Worksheet.PrinterSettings.LeftMargin = LeftMargin;
            Worksheet.PrinterSettings.RightMargin = RightMargin;
            Worksheet.PrinterSettings.TopMargin = TopMargin;
            Worksheet.PrinterSettings.BottomMargin = BottomMargin;
            Worksheet.PrinterSettings.HorizontalCentered = true;
            Worksheet.PrinterSettings.VerticalCentered = true;
            Worksheet.PrinterSettings.FitToPage = true;
            Worksheet.HeaderFooter.AlignWithMargins = true;
            Worksheet.HeaderFooter.ScaleWithDocument = true;
        }

        /// <summary> Sets the header format. </summary>
        /// <param name="grid"> The grid. </param>
        public void SetHeaderFormat( Grid grid )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                using( Font )
                {
                    SetFontColor( grid, FontColor );
                    SetBackgroundColor( grid, PrimaryBackColor );
                    SetHorizontalAlignment( grid, ExcelHorizontalAlignment.Left );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the header text. </summary>
        /// <param name="grid"> The grid. </param>
        public void SetHeaderText( Grid grid )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                using var _worksheet = grid.Worksheet;
                using var _range = grid.Range;
                var _row = _range.Start.Row;
                var _column = _range.Start.Column;
                SetFontColor( grid, FontColor );
                SetBackgroundColor( grid, PrimaryBackColor );
                SetHorizontalAlignment( grid, ExcelHorizontalAlignment.Left );
                _worksheet.Cells[ _row, _column ].Value = "Account";
                _worksheet.Cells[ _row, _column + 1 ].Value = "SuperfundSite";
                _worksheet.Cells[ _row, _column + 2 ].Value = "Travel";
                _worksheet.Cells[ _row, _column + 3 ].Value = "Expenses";
                _worksheet.Cells[ _row, _column + 4 ].Value = "Contracts";
                _worksheet.Cells[ _row, _column + 5 ].Value = "Grants";
                _worksheet.Cells[ _row, _column + 6 ].Value = "Total";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the dark color row. </summary>
        /// <param name="range"> The excel range. </param>
        public void SetDarkColorRow( ExcelRange range )
        {
            try
            {
                ThrowIf.Null( range, "range" );
                range.Style.Font.Color.SetColor( Color.Black );
                using var _font = Font;
                range.Style.Font.SetFromFont( Font.Name, Font.Size );
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor( PrimaryBackColor );
                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the light color row. </summary>
        /// <param name="range"> The range. </param>
        public void SetLightColorRow( ExcelRange range )
        {
            try
            {
                ThrowIf.Null( range, "range" );
                range.Style.Font.Color.SetColor( FontColor );
                using var _font = Font;
                range.Style.Font.SetFromFont( Font.Name, Font.Size );
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor( Color.White );
                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the color of the alternating row. </summary>
        /// <param name="range"> The range. </param>
        public void SetAlternatingRowColor( ExcelRange range )
        {
            try
            {
                ThrowIf.Null( range, "range" );
                var _prc = Worksheet.Cells[ range.Start.Row, range.Start.Column, range.End.Row,
                    range.End.Column ];

                for( var _i = range.Start.Row; _i < range.End.Row; _i++ )
                {
                    if( ( _i % 2 ) == 0 )
                    {
                        SetLightColorRow( _prc );
                    }

                    if( ( _i % 2 ) != 0 )
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

        /// <summary> Sets the numeric row format. </summary>
        /// <param name="range"> The range. </param>
        public void SetNumericRowFormat( ExcelRange range )
        {
            try
            {
                ThrowIf.Null( range, "range" );
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

        /// <summary> Sets the table format. </summary>
        /// <param name="grid"> The grid. </param>
        public void SetTableFormat( Grid grid )
        {
            try
            {
                ThrowIf.Null( grid, "grid" );
                SetHeaderText( grid );
                using var _range = grid.Range;
                _range.Style.Font.SetFromFont( TitleFont.Name, TitleFont.Size );
                _range.Style.Border.BorderAround( ExcelBorderStyle.Thin );
                _range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _range.Style.Fill.BackgroundColor.SetColor( PrimaryBackColor );
                _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.CenterContinuous;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the total row format. </summary>
        /// <param name="range"> The range. </param>
        public void SetTotalRowFormat( ExcelRange range )
        {
            try
            {
                ThrowIf.Null( range, "range" );
                var _total = Worksheet.Cells[ range.Start.Row, range.Start.Column, range.Start.Row,
                    range.Start.Column + 6 ];

                var _range = Worksheet.Cells[ range.Start.Row, range.Start.Column + 1,
                    range.Start.Row, range.Start.Column + 6 ];

                _total.Style.Fill.PatternType = ExcelFillStyle.Solid;
                _total.Style.Fill.BackgroundColor.SetColor( PrimaryBackColor );
                _range.Style.Border.Bottom.Style = ExcelBorderStyle.Double;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Releases unmanaged and - optionally - managed resources. </summary>
        /// <param name="disposing">
        /// <c> true </c>
        /// to release both managed and unmanaged resources;
        /// <c> false </c>
        /// to release only unmanaged resources.
        /// </param>
        public void Dispose( bool disposing )
        {
            try
            {
                TitleFont?.Dispose( );
                Font?.Dispose( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Releases unmanaged and - optionally - managed resources. </summary>
        public virtual void Dispose( )
        {
            try
            {
                Dispose( true );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}
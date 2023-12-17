// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="BudgetWorkbook.cs" company="Terry D. Eppler">
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
//
// </copyright>
// <summary>
//   BudgetWorkbook.cs
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
    using static System.Configuration.ConfigurationManager;

    /// <inheritdoc/>
    /// <summary> </summary>
    /// <seealso cref="T:BudgetExecution.ExcelConfig"/>
    [ SuppressMessage( "ReSharper", "MergeIntoPattern" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class ExcelReport : ExcelConfig
    {
        /// <summary>
        /// The configuration
        /// </summary>
        public string InternalPath { get; }
        
        /// <summary>
        /// Gets or sets the header image.
        /// </summary>
        /// <value>
        /// The header image.
        /// </value>
        public Image HeaderImage { get; set; }

        /// <summary>
        /// Gets or sets the footer image.
        /// </summary>
        /// <value>
        /// The footer image.
        /// </value>
        public Image FooterImage { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ExcelReport"/> class.
        /// </summary>
        public ExcelReport( )
        {
            InternalPath = AppSettings[ "Reports" ];
            FileInfo = new FileInfo( InternalPath );
            Application = new ExcelPackage( FileInfo );
            Workbook = Application.Workbook;
            Workbook.View.ShowHorizontalScrollBar = true;
            Workbook.View.ShowVerticalScrollBar = true;
            Workbook.Properties.Author = "Terry D. Eppler, PhD.";
            Workbook.Properties.Application = "Budget Execution";
            Workbook.Properties.Company = "US EPA";
            Workbook.Properties.Modified = DateTime.Now;
            InitializeSheetViews( );
            InitializePrinterSettings( );
            InitializeCells( );
            InitializeSelectedRange( );
            InitializeTables( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetWorkbook" /> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public ExcelReport( string filePath )
        {
            InternalPath = AppSettings[ "Reports" ];
            FileInfo = new FileInfo( filePath );
            Application = new ExcelPackage( FileInfo );
            Workbook = Application.Workbook;
            Workbook.View.ShowHorizontalScrollBar = true;
            Workbook.View.ShowVerticalScrollBar = true;
            Workbook.Properties.Author = "Terry D. Eppler, PhD.";
            Workbook.Properties.Application = "Budget Execution";
            Workbook.Properties.Company = "US EPA";
            Workbook.Properties.Modified = DateTime.Now;
            InitializeSheetViews( );
            InitializePrinterSettings( );
            InitializeCells( );
            InitializeSelectedRange( );
            InitializeTables( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetWorkbook"/>
        /// class.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.
        /// </param>
        public ExcelReport( DataTable dataTable )
        {
            InternalPath = AppSettings[ "Reports" ];
            FileInfo = new FileInfo( InternalPath );
            Application = new ExcelPackage( FileInfo );
            Workbook = Application.Workbook;
            Workbook.View.ShowHorizontalScrollBar = true;
            Workbook.View.ShowVerticalScrollBar = true;
            Workbook.Properties.Author = "Terry D. Eppler, PhD.";
            Workbook.Properties.Application = "Budget Execution";
            Workbook.Properties.Company = "US EPA";
            Workbook.Properties.Modified = DateTime.Now;
            Workbook.Worksheets[ 0 ].Cells[ "A1" ].LoadFromDataTable( dataTable );
            InitializeSheetViews( );
            InitializePrinterSettings( );
            InitializeCells( );
            InitializeSelectedRange( );
            InitializeTables( );
        }

        /// <summary>
        /// Initializes the worksheets.
        /// </summary>
        private void InitializeSheetViews( )
        {
            try
            {
                var _count = Workbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    Workbook.Worksheets[ _i ].Name = FileInfo.Name;
                    Workbook.Worksheets[ _i ].View.ShowGridLines = false;
                    Workbook.Worksheets[ _i ].View.ZoomScale = 100;
                    Workbook.Worksheets[ _i ].View.PageLayoutView = true;
                    Workbook.Worksheets[ _i ].View.ShowHeaders = true;
                    Workbook.Worksheets[ _i ].DefaultRowHeight = 0.22;
                    Workbook.Worksheets[ _i ].DefaultColWidth = 0.75;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the printer settings.
        /// </summary>
        private void InitializePrinterSettings( )
        {
            try
            {
                var _count = Workbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    Workbook.Worksheets[ _i ].PrinterSettings.ShowHeaders = true;
                    Workbook.Worksheets[ _i ].PrinterSettings.ShowGridLines = false;
                    Workbook.Worksheets[ _i ].PrinterSettings.LeftMargin = 0.25m;
                    Workbook.Worksheets[ _i ].PrinterSettings.RightMargin = 0.25m;
                    Workbook.Worksheets[ _i ].PrinterSettings.TopMargin = 1m;
                    Workbook.Worksheets[ _i ].PrinterSettings.BottomMargin = 1m;
                    Workbook.Worksheets[ _i ].PrinterSettings.HorizontalCentered = true;
                    Workbook.Worksheets[ _i ].PrinterSettings.VerticalCentered = true;
                    Workbook.Worksheets[ _i ].PrinterSettings.FitToPage = true;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the header footer.
        /// </summary>
        private void InitializeHeaderFooter( )
        {
            try
            {
                var _count = Workbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    Workbook.Worksheets[ _i ].HeaderFooter.AlignWithMargins = true;
                    Workbook.Worksheets[ _i ].HeaderFooter.ScaleWithDocument = true;
                    Workbook.Worksheets[ _i ].HeaderFooter.Pictures[ 0 ].Width = 1.75;
                    Workbook.Worksheets[ _i ].HeaderFooter.Pictures[ 0 ].Height = 0.75;
                    Workbook.Worksheets[ _i ].HeaderFooter.Pictures[ 1 ].Width = 2.04;
                    Workbook.Worksheets[ _i ].HeaderFooter.Pictures[ 1 ].Height = 0.70;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the range cells.
        /// </summary>
        private void InitializeCells( )
        {
            try
            {
                var _back = Color.FromArgb( 242, 242, 242 );
                var _text = Color.Black;
                var _count = Workbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    Workbook.Worksheets[ _i ].Cells.Style.Font.Name = "Roboto";
                    Workbook.Worksheets[ _i ].Cells.Style.Font.Size = 9;
                    Workbook.Worksheets[ _i ].Cells.Style.Font.Bold = false;
                    Workbook.Worksheets[ _i ].Cells.Style.Font.Italic = false;
                    Workbook.Worksheets[ _i ].Cells.Style.Fill.SetBackground( _back );
                    Workbook.Worksheets[ _i ].Cells.Style.Font.Color.SetColor( _text );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the range cells.
        /// </summary>
        private void InitializeSelectedRange( )
        {
            try
            {
                var _count = Workbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    Workbook.Worksheets[ _i ].SelectedRange.Style.Font.Name = "Roboto";
                    Workbook.Worksheets[ _i ].SelectedRange.Style.Font.Size = 9;
                    Workbook.Worksheets[ _i ].SelectedRange.Style.Font.Bold = false;
                    Workbook.Worksheets[ _i ].SelectedRange.Style.Font.Italic = false;
                    Workbook.Worksheets[ _i ].SelectedRange.EntireRow.CustomHeight = true;
                    Workbook.Worksheets[ _i ].SelectedRange.Style.VerticalAlignment =
                        ExcelVerticalAlignment.Center;

                    Workbook.Worksheets[ _i ].SelectedRange.Style.HorizontalAlignment =
                        ExcelHorizontalAlignment.Center;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// 
        /// Initializes the tables.
        /// </summary>
        private void InitializeTables( )
        {
            try
            {
                var _count = Workbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    Workbook.Worksheets[ _i ].Tables[ _i ].StyleName = nameof( DataTable );
                    Workbook.Worksheets[ _i ].Tables[ _i ].ShowTotal = true;
                    Workbook.Worksheets[ _i ].Tables[ _i ].ShowHeader = true;
                    Workbook.Worksheets[ _i ].Tables[ _i ].HeaderRowBorderStyle.Bottom.Style =
                        ExcelBorderStyle.Thin;
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
        /// <param name="text">
        /// The grid.
        /// </param>
        public void SetHeaderText( string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the footer text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetFooterText( string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Releases unmanaged and
        /// - optionally - managed resources.
        /// </summary>
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
                Application?.Dispose( );
                Workbook?.Dispose( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Releases unmanaged and
        /// - optionally - managed resources.
        /// </summary>
        public void Dispose( )
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
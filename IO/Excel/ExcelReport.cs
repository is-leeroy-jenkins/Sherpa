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
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    public class ExcelReport : Workbook
    {
        /// <summary>
        /// Gets or sets the height of the row.
        /// </summary>
        /// <value>
        /// The height of the row.
        /// </value>
        public double RowHeight
        {
            get
            {
                return _rowHeight;
            }
            private protected set
            {
                _rowHeight = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the column.
        /// </summary>
        /// <value>
        /// The width of the column.
        /// </value>
        public double ColumnWidth
        {
            get
            {
                return _columnWidth;
            }
            private protected set
            {
                _columnWidth = value;
            }
        }

        /// <summary>
        /// The configuration
        /// </summary>
        public string InternalPath
        {
            get
            {
                return _internalPath; 
            }
            private protected set
            {
                _internalPath = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.ExcelReport" /> class.
        /// </summary>
        public ExcelReport( )
        {
            _index = 10;
            _fontColor = Color.Black;
            _font = new Font( "Roboto", 8, FontStyle.Regular );
            _titleFont = new Font( "Roboto", 10, FontStyle.Bold );
            _rowCount = 55;
            _columnCount = 12;
            _rowHeight = 0.22;
            _columnWidth = 0.75;
            _headerImageWidth = 1.75;
            _headerImageHeigth = 0.75;
            _footerImageWidth = 2.04;
            _footerImageHeigth = 0.70;
            _leftMargin = 0.25m;
            _rightMargin = 0.25m;
            _headerMargin = 0.25m;
            _footerMargin = 0.25m;
            _zoomLevel = 100;
            _primaryBackColor = Color.FromArgb( 255, 242, 242, 242 );
            _secondaryBackColor = Color.FromArgb( 255, 221, 235, 247 );
            _internalPath = AppSettings[ "Reports" ];
            _fileInfo = new FileInfo( _internalPath );
            _excelPackage = new ExcelPackage( _fileInfo );
            _excelWorkbook = _excelPackage.Workbook;
            _excelWorkbook.View.ShowHorizontalScrollBar = true;
            _excelWorkbook.View.ShowVerticalScrollBar = true;
            _excelWorkbook.Properties.Author = "Terry D. Eppler, PhD.";
            _excelWorkbook.Properties.Application = "Budget Execution";
            _excelWorkbook.Properties.Company = "US EPA";
            _excelWorkbook.Properties.Modified = DateTime.Now;
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
            : this( )
        {
            _index = 1;
            _fontColor = Color.Black;
            _font = new Font( "Roboto", 8, FontStyle.Regular );
            _titleFont = new Font( "Roboto", 10, FontStyle.Bold );
            _rowHeight = 0.22;
            _columnWidth = 0.75;
            _headerImageWidth = 1.75;
            _headerImageHeigth = 0.75;
            _footerImageWidth = 2.04;
            _footerImageHeigth = 0.70;
            _leftMargin = 0.25m;
            _rightMargin = 0.25m;
            _headerMargin = 0.25m;
            _footerMargin = 0.25m;
            _zoomLevel = 100;
            _primaryBackColor = Color.FromArgb( 255, 242, 242, 242 );
            _secondaryBackColor = Color.FromArgb( 255, 221, 235, 247 );
            _internalPath = AppSettings[ "Reports" ];
            _fileInfo = new FileInfo( filePath );
            _excelPackage = new ExcelPackage( _fileInfo );
            _excelWorkbook = _excelPackage.Workbook;
            _excelWorkbook.View.ShowHorizontalScrollBar = true;
            _excelWorkbook.View.ShowVerticalScrollBar = true;
            _excelWorkbook.Properties.Author = "Terry D. Eppler, PhD.";
            _excelWorkbook.Properties.Application = "Budget Execution";
            _excelWorkbook.Properties.Company = "US EPA";
            _excelWorkbook.Properties.Modified = DateTime.Now;
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
            : this( )
        {
            _index = 10;
            _fontColor = Color.Black;
            _font = new Font( "Roboto", 8, FontStyle.Regular );
            _titleFont = new Font( "Roboto", 10, FontStyle.Bold );
            _rowHeight = 0.22;
            _columnWidth = 0.75;
            _headerImageWidth = 1.75;
            _headerImageHeigth = 0.75;
            _footerImageWidth = 2.04;
            _footerImageHeigth = 0.70;
            _leftMargin = 0.25m;
            _rightMargin = 0.25m;
            _headerMargin = 0.25m;
            _footerMargin = 0.25m;
            _zoomLevel = 100;
            _primaryBackColor = Color.FromArgb( 255, 242, 242, 242 );
            _secondaryBackColor = Color.FromArgb( 255, 221, 235, 247 );
            _internalPath = AppSettings[ "Reports" ];
            _fileInfo = new FileInfo( _internalPath );
            _excelPackage = new ExcelPackage( _fileInfo );
            _excelWorkbook = _excelPackage.Workbook;
            _excelWorkbook.View.ShowHorizontalScrollBar = true;
            _excelWorkbook.View.ShowVerticalScrollBar = true;
            _excelWorkbook.Properties.Author = "Terry D. Eppler, PhD.";
            _excelWorkbook.Properties.Application = "Budget Execution";
            _excelWorkbook.Properties.Company = "US EPA";
            _excelWorkbook.Properties.Modified = DateTime.Now;
            _excelWorkbook.Worksheets[ 0 ].Cells[ "A1" ].LoadFromDataTable( dataTable );
        }

        /// <summary>
        /// Initializes the worksheets.
        /// </summary>
        private void InitializeSheetViews( )
        {
            try
            {
                var _count = _excelWorkbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    _excelWorkbook.Worksheets[ _i ].Name = _fileInfo.Name;
                    _excelWorkbook.Worksheets[ _i ].View.ShowGridLines = false;
                    _excelWorkbook.Worksheets[ _i ].View.ZoomScale = 100;
                    _excelWorkbook.Worksheets[ _i ].View.PageLayoutView = true;
                    _excelWorkbook.Worksheets[ _i ].View.ShowHeaders = true;
                    _excelWorkbook.Worksheets[ _i ].DefaultRowHeight = _rowHeight;
                    _excelWorkbook.Worksheets[ _i ].DefaultColWidth = _columnWidth;
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
                var _count = _excelWorkbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.ShowHeaders = true;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.ShowGridLines = false;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.LeftMargin = _leftMargin;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.RightMargin = _rightMargin;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.TopMargin = _headerMargin;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.BottomMargin = _footerMargin;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.HorizontalCentered = true;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.VerticalCentered = true;
                    _excelWorkbook.Worksheets[ _i ].PrinterSettings.FitToPage = true;
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
                var _count = _excelWorkbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    var _header = _excelWorkbook.Worksheets[ _i ].HeaderFooter;
                    _header.AlignWithMargins = true;
                    _header.ScaleWithDocument = true;
                    _header.Pictures[ 0 ].Width = _headerImageWidth;
                    _header.Pictures[ 0 ].Height = _headerImageHeigth;
                    _header.Pictures[ 1 ].Width = _footerImageWidth;
                    _header.Pictures[ 1 ].Height = _footerImageHeigth;
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
                var _count = _rowCount * _columnCount;
                for( var _i = 0; _i < _count; _i++ )
                {
                    var _range = _excelWorkbook.Worksheets[ _i ].Cells;
                    _range.Style.Font.Name = "Roboto";
                    _range.Style.Font.Size = 9;
                    _range.Style.Font.Bold = false;
                    _range.Style.Font.Italic = false;
                    _range.Style.Fill.SetBackground( _primaryBackColor );
                    _range.Style.Font.Color.SetColor( _fontColor );
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
                var _count = _excelWorkbook.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    var _range = _excelWorkbook.Worksheets[ _i ].SelectedRange;
                    _range.Style.Font.Name = "Roboto";
                    _range.Style.Font.Size = 9;
                    _range.Style.Font.Bold = false;
                    _range.Style.Font.Italic = false;
                    _range.EntireRow.CustomHeight = true;
                    _range.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                    _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
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
                var _count = _excelWorkbook?.Worksheets?.Count;
                for( var _i = 0; _i < _count; _i++ )
                {
                    var _table = _excelWorkbook.Worksheets[ _i ].Tables[ _i ];
                    _table.StyleName = nameof( DataTable );
                    _table.ShowTotal = true;
                    _table.ShowHeader = true;
                    _table.HeaderRowBorderStyle.Bottom.Style = ExcelBorderStyle.Thin;
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
    }
}
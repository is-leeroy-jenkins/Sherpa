﻿// <copyright file=" <File _name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using OfficeOpenXml;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ExcelConfig" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    public abstract class BudgetConfig : ExcelConfig
    {
        /// <summary>
        /// The name
        /// </summary>
        private protected string _name;

        /// <summary>
        /// The title
        /// </summary>
        private protected Grid _title;

        /// <summary>
        /// The control number
        /// </summary>
        private protected Grid _controlNumber;

        /// <summary>
        /// The PRC
        /// </summary>
        private protected Grid _prc;

        /// <summary>
        /// The fte
        /// </summary>
        private protected Grid _fte;

        /// <summary>
        /// The awards
        /// </summary>
        private protected Grid _awards;

        /// <summary>
        /// The overtime
        /// </summary>
        private protected Grid _overtime;

        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public void AddComment( Grid grid, string text )
        {
            if( Validate.Grid( grid )
                && Verify.Input( text ) )
            {
                try
                {
                    using var _excelRange = grid?.GetRange();
                    var _excelComment = _excelRange?.AddComment( text, "Budget" );

                    if( _excelComment != null )
                    {
                        _excelComment.From.Row = _excelRange.Start.Row;
                        _excelComment.From.Column = _excelRange.Start.Column;
                        _excelComment.To.Row = _excelRange.End.Row;
                        _excelComment.To.Column = _excelRange.End.Column;
                        _excelComment.BackgroundColor = _primaryBackColor;
                        _excelComment.Font.FontName = "Consolas";
                        _excelComment.Font.Size = 8;
                        _excelComment.Font.Color = Color.Black;
                        _excelComment.Text = text;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the caption text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetCaptionText( Grid grid )
        {
            if( Validate.Grid( grid ) )
            {
                try
                {
                    using var _sheet = grid.GetWorksheet();
                    var _row = grid.GetRange().Start.Row;
                    var _column = grid.GetRange().Start.Column;
                    _sheet.Cells[ _row, _column ].Value = "Account";
                    _sheet.Cells[ _row, _column + 1 ].Value = "Site";
                    _sheet.Cells[ _row, _column + 2 ].Value = "Travel";
                    _sheet.Cells[ _row, _column  + 3 ].Value = "Expenses";
                    _sheet.Cells[ _row, _column  + 4 ].Value = "Contracts";
                    _sheet.Cells[ _row, _column  + 5 ].Value = "Grants";
                    _sheet.Cells[ _row, _column  + 6 ].Value = "_total";
                }
                catch( Exception ex )
                {
                    Fail( ex );
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
            if( Validate.Grid( grid )
                && text?.Any() == true 
                && grid.GetRange().Any() )
            {
                try
                {
                    foreach( var cell in grid.GetRange() )
                    {
                        foreach( var caption in text )
                        {
                            if( cell != null
                                && Verify.Input( caption ) )
                            {
                                cell.Value = caption;
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the workSheet properties.
        /// </summary>
        /// <param name="workSheet">The workSheet.</param>
        public void SetWorksheetProperties( ExcelWorksheet workSheet )
        {
            if( workSheet != null )
            {
                workSheet = _workbook.Worksheets[ 1 ];
                workSheet.View.ShowGridLines = false;
                workSheet.View.ZoomScale = _zoomLevel;
                workSheet.View.PageLayoutView = true;
                workSheet.View.ShowHeaders = true;
                workSheet.DefaultRowHeight = _rowHeight;
                workSheet.DefaultColWidth = _columnWidth;
                workSheet.PrinterSettings.ShowHeaders = false;
                workSheet.PrinterSettings.ShowGridLines = false;
                workSheet.PrinterSettings.LeftMargin = _leftMargin;
                workSheet.PrinterSettings.RightMargin = _rightMargin;
                workSheet.PrinterSettings.TopMargin = _topMargin;
                workSheet.PrinterSettings.BottomMargin = _bottomMarging;
                workSheet.PrinterSettings.HorizontalCentered = true;
                workSheet.PrinterSettings.VerticalCentered = true;
                workSheet.PrinterSettings.FitToPage = true;
                workSheet.HeaderFooter.AlignWithMargins = true;
                workSheet.HeaderFooter.ScaleWithDocument = true;
            }
        }

        /// <summary>
        /// Sets the header footer text.
        /// </summary>
        /// <param name="headerText">The header text.</param>
        public void SetHeaderFooterText( string headerText )
        {
            if( Verify.Input( headerText ) )
            {
                try
                {
                    var _header = _worksheet.HeaderFooter.FirstHeader;
                    _header.CenteredText = headerText;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
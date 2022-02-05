// <copyright file = "ExcelConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using OfficeOpenXml.Style;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "ExcelBase"/>
    /// <seealso cref = "IDisposable"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    public abstract class ExcelConfig : ExcelBase
    {
        /// <summary>
        /// The font color
        /// </summary>
        private protected Color FontColor { get; set; } = Color.Black;

        /// <summary>
        /// The Data font
        /// </summary>
        public virtual Font DataFont { get; set; } = new Font( "Roboto", 8, FontStyle.Regular );

        /// <summary>
        /// The header font
        /// </summary>
        public virtual Font HeaderFont { get; set; } = new Font( "Roboto", 10, FontStyle.Bold );

        /// <summary>
        /// The title font
        /// </summary>
        public virtual Font TitleFont { get; set; } = new Font( "Roboto", 12, FontStyle.Bold );

        /// <summary>
        /// The header image width
        /// </summary>
        public virtual double HeaderImageWidth { get; set; } = 1.75;

        /// <summary>
        /// The header image height
        /// </summary>
        public virtual double HeaderImageHeight { get; set; } = 0.85;

        /// <summary>
        /// The footer image width
        /// </summary>
        public virtual double FooterImageWidth { get; set; } = 2.04;

        /// <summary>
        /// The footer image height
        /// </summary>
        public virtual double FooterImageHeight { get; set; } = 0.70;
        
        /// <summary>
        /// Gets or sets the header image.
        /// </summary>
        /// <value>
        /// The header image.
        /// </value>
        public virtual Image HeaderImage { get; set; }

        /// <summary>
        /// Gets or sets the footer image.
        /// </summary>
        /// <value>
        /// The footer image.
        /// </value>
        public virtual Image FooterImage { get; set; }
        
        /// <summary>
        /// Sets the table format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        public virtual void SetTableFormat( Grid grid )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    using var _font = DataFont;
                    SetFontColor( grid, FontColor );
                    SetBackgroudColor( grid, PrimaryBackColor );
                    SetHorizontalAligment( grid, Left );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the caption format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        public virtual void SetCaptionFormat( Grid grid )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    SetFontColor( grid, FontColor );
                    SetBackgroudColor( grid, PrimaryBackColor );
                    SetHorizontalAligment( grid, Left );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the dark row format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        public virtual void SetDarkRowFormat( Grid grid )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    using var _range = grid.GetRange();
                    _range.Style.Font.Color.SetColor( Color.Black );
                    using var _font = DataFont;
                    _range.Style.Font.SetFromFont( DataFont );
                    _range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    _range.Style.Fill.BackgroundColor.SetColor( PrimaryBackColor );
                    _range.Style.HorizontalAlignment = Center;
                    _range.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the light row format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        public virtual void SetLightRowFormat( Grid grid )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    using var _range = grid.GetRange();
                    _range.Style.Font.Color.SetColor( FontColor );
                    using var _font = DataFont;
                    _range.Style.Font.SetFromFont( DataFont );
                    _range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    _range.Style.Fill.BackgroundColor.SetColor( Color.White );
                    _range.Style.HorizontalAlignment = Center;
                    _range.Style.Border.Bottom.Style = ExcelBorderStyle.Hair;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the alternating color format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        public virtual void SetAlternatingColorFormat( Grid grid )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    using var _excelWorksheet = grid.GetWorksheet();
                    using var _range = grid.GetRange();

                    for( var i = _range.Start.Row; i < _range.End.Row; i++ )
                    {
                        if( i % 2 == 0 )
                        {
                            SetLightRowFormat( grid );
                        }

                        if( i % 2 != 0 )
                        {
                            SetDarkRowFormat( grid );
                        }
                    }

                    SetNumericRowFormat( grid );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the numeric row format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        public virtual void SetNumericRowFormat( Grid grid )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    using var _range = grid.GetRange();
                    _range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    _range.Style.Numberformat.Format = "#,###";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the table format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "font" >
        /// The font.
        /// </param>
        /// <param name = "borderStyle" >
        /// The borderStyle.
        /// </param>
        public virtual void SetTableFormat( Grid grid, Font font,
            ExcelBorderStyle borderStyle = ExcelBorderStyle.Thin )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    using var _range = grid.GetRange();
                    SetCaptionFormat( grid );
                    using var _font = HeaderFont;
                    _range.Style.Font.SetFromFont( font );
                    _range.Style.Border.BorderAround( borderStyle );
                    _range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    _range.Style.Fill.BackgroundColor.SetColor( PrimaryBackColor );
                    _range.Style.HorizontalAlignment = Center;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the total row format.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        public virtual void SetTotalRowFormat( Grid grid )
        {
            if( Verify.Grid( grid ) )
            {
                try
                {
                    using var _excelWorksheet = grid.GetWorksheet();
                    using var _range = grid.GetRange();

                    var _total = _excelWorksheet.Cells[ _range.Start.Row, _range.Start.Column, 
                        _range.Start.Row, _range.Start.Column + 6 ];

                    _total.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    _total?.Style?.Fill?.BackgroundColor?.SetColor( PrimaryBackColor );

                    var data = _excelWorksheet.Cells[ _range.Start.Row, _range.Start.Column + 1, _range.Start.Row,
                        _range.Start.Column + 6 ];

                    data.Style.Border.Bottom.Style = ExcelBorderStyle.Double;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public virtual void AddComment( Grid grid, string text )
        {
            if( Verify.Grid( grid )
                && Verify.IsInput( text ) )
            {
                try
                {
                    using var _range = grid?.GetRange();
                    var _excelComment = _range?.AddComment( text, "Budget" );

                    if( _excelComment != null )
                    {
                        _excelComment.From.Row = _range.Start.Row;
                        _excelComment.From.Column = _range.Start.Column;
                        _excelComment.To.Row = _range.End.Row;
                        _excelComment.To.Column = _range.End.Column;
                        _excelComment.BackgroundColor = PrimaryBackColor;
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
    }
}

// <copyright file = "ColorConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using OfficeOpenXml.Style;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class ColorConfig
    {
        /// <summary>
        /// The orange border
        /// </summary>
        public static Color BorderYellow { get; set; } = Color.FromArgb( 128, 64, 0 );

        /// <summary>
        /// The gray border
        /// </summary>
        public static Color BorderDark { get; set; } = Color.FromArgb( 25, 18, 1 );

        /// <summary>
        /// The border blue
        /// </summary>
        public static Color BorderBlue { get; set; } = Color.FromArgb( 0, 120, 210 );

        /// <summary>
        /// The red border
        /// </summary>
        public static Color BorderRed { get; set; } = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// The black background
        /// </summary>
        public static Color FormDarkBackColor { get; set; } = Color.FromArgb( 5, 5, 5 );

        /// <summary>
        /// The hover color yellow
        /// </summary>
        public static Color HoverYellow { get; set; } = Color.FromArgb( 24, 19, 1 );

        /// <summary>
        /// The red foreground
        /// </summary>
        public static Color ForeRed { get; set; } = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// The gray foreground
        /// </summary>
        public static Color ForeGray { get; set; } = Color.FromArgb( 141, 139, 138 );

        /// <summary>
        /// The white foreground
        /// </summary>
        public static Color ForeWhite { get; set; } = Color.White;

        /// <summary>
        /// The black foreground
        /// </summary>
        public static Color ForeBlack { get; set; } = Color.Black;

        /// <summary>
        /// The control dark back color
        /// </summary>
        public static Color ControlDarkBackColor { get; set; } = Color.FromArgb( 15, 15, 15 );

        /// <summary>
        /// The clear background
        /// </summary>
        public static Color Transparent { get; set; } = Color.Transparent;

        /// <summary>
        /// The dark background inside a control
        /// </summary>
        public static Color ControlDarkInterior { get; set; } = Color.FromArgb( 25, 25, 25 );

        /// <summary>
        /// The gray back hover
        /// </summary>
        public static Color HoverGray { get; set; } = Color.FromArgb( 38, 38, 39 );

        /// <summary>
        /// The blue back hover
        /// </summary>
        public static Color HoverBlue { get; set; } = Color.FromArgb( 50, 93, 129 );
        
        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorConfig"/> class.
        /// </summary>
        public ColorConfig()
        {
        }
        
        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name = "color" >
        /// The color.
        /// </param>
        /// <returns>
        /// </returns>
        public static Color GetColor( Color color )
        {
            try
            {
                return color != Color.Empty
                    ? color
                    : Color.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Color.Empty;
            }
        }

        /// <summary>
        /// Gets the excel fill style.
        /// </summary>
        /// <param name="fillStyle">The fillStyle.</param>
        /// <returns></returns>
        public static ExcelFillStyle GetExcelFillStyle( ExcelFillStyle fillStyle )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelFillStyle ), fillStyle )
                    ? fillStyle
                    : ExcelFillStyle.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ExcelFillStyle.None;
            }
        }

        /// <summary>
        /// Gets the type of the excel fill gradient.
        /// </summary>
        /// <param name="gradient">The gradient.</param>
        /// <returns></returns>
        public static ExcelFillGradientType GetExcelFillGradientType( ExcelFillGradientType gradient )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelFillGradientType ), gradient )
                    ? gradient
                    : ExcelFillGradientType.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ExcelFillGradientType.None;
            }
        }

        /// <summary>
        /// Gets the type of the spreadsheet fill.
        /// </summary>
        /// <param name="fillType">The fillType.</param>
        /// <returns></returns>
        public static ExcelFillType GetSpreadsheetFillType( ExcelFillType fillType )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelFillType ), fillType )
                    ? fillType
                    : ExcelFillType.UnknownGradient;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ExcelFillType.UnknownGradient;
            }
        }

        /// <summary>
        /// Gets the spreadsheet gradient style.
        /// </summary>
        /// <param name="gradient">The gradient.</param>
        /// <returns></returns>
        public static ExcelGradientStyle GetSpreadsheetGradientStyle( ExcelGradientStyle gradient )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelGradientStyle ), gradient )
                    ? gradient
                    : ExcelGradientStyle.Horizontal;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ExcelGradientStyle.Horizontal;
            }
        }
        
        /// <summary>
        /// Called when [color changed].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        public static void OnColorChanged( object sender, EventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    using var _message = new Message( "NOT YET IMPLEMENTED" );
                    _message?.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
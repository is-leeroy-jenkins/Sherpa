// <copyright file = "BudgetColor.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using OfficeOpenXml.Style;
    using Syncfusion.XlsIO;

    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class BudgetColor
    {
        /// <summary>
        /// Gets or sets the border dark.
        /// </summary>
        /// <value>
        /// The border dark.
        /// </value>
        public static Color BorderDark { get; set; } = Color.FromArgb( 64, 64, 64 );

        /// <summary>
        /// Gets or sets the border blue.
        /// </summary>
        /// <value>
        /// The border blue.
        /// </value>
        public static Color SteelBlue { get; set; } = Color.SteelBlue;

        /// <summary>
        /// Gets or sets the border red.
        /// </summary>
        /// <value>
        /// The border red.
        /// </value>
        public static Color BorderRed { get; set; } = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// Gets or sets the color of the form dark back.
        /// </summary>
        /// <value>
        /// The color of the form dark back.
        /// </value>
        public static Color FormDark { get; set; } = Color.FromArgb( 10, 10, 10 );

        /// <summary>
        /// Gets the default color of the caption button.
        /// </summary>
        /// <value>
        /// The default color of the caption button.
        /// </value>
        public static Color CaptionButtonDefaultColor { get; } = Color.FromArgb( 51, 51, 51 );

        /// <summary>
        /// Gets the color of the caption button hover.
        /// </summary>
        /// <value>
        /// The color of the caption button hover.
        /// </value>
        public static Color White { get; } = Color.White;
        
        /// <summary>
        /// Gets the caption bar black.
        /// </summary>
        /// <value>
        /// The caption bar black.
        /// </value>
        public static Color Black { get; } = Color.Black;

        /// <summary>
        /// Gets or sets the fore red.
        /// </summary>
        /// <value>
        /// The fore red.
        /// </value>
        public static Color Red { get; set; } = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// Gets or sets the fore gray.
        /// </summary>
        /// <value>
        /// The fore gray.
        /// </value>
        public static Color ForeColorGray { get; set; } = Color.FromArgb( 141, 139, 138 );

        /// <summary>
        /// Gets or sets the fore color light gray.
        /// </summary>
        /// <value>
        /// The fore color light gray.
        /// </value>
        public static Color LightGray { get; set; } = Color.LightGray;

        /// <summary>
        /// Gets or sets the fore black.
        /// </summary>
        /// <value>
        /// The fore black.
        /// </value>
        public static Color ForeColorBlack { get; set; } = Color.Black;

        /// <summary>
        /// Gets or sets the transparent.
        /// </summary>
        /// <value>
        /// The transparent.
        /// </value>
        public static Color Transparent { get; set; } = Color.Transparent;

        /// <summary>
        /// Gets or sets the control dark interior.
        /// </summary>
        /// <value>
        /// The control dark interior.
        /// </value>
        public static Color ControlInteriorDark { get; set; } = Color.FromArgb( 45, 45, 45 );

        /// <summary>
        /// Gets or sets the hover gray.
        /// </summary>
        /// <value>
        /// The hover gray.
        /// </value>
        public static Color HoverDark { get; set; } = Color.FromArgb( 40, 40, 40 );

        /// <summary>
        /// Gets or sets the hover blue.
        /// </summary>
        /// <value>
        /// The hover blue.
        /// </value>
        public static Color HoverBlue { get; set; } = Color.FromArgb( 4, 18, 74 );

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetColor"/> class.
        /// </summary>
        public BudgetColor()
        {
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns></returns>
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
        /// <param name="fillStyle">The fill style.</param>
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
        /// <param name="fillType">Type of the fill.</param>
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
        /// Fails the specified ex.
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
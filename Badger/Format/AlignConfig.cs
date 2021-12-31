// <copyright file = "AlignConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using OfficeOpenXml.Style;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Global" ) ]
    public class AlignConfig
    {
        /// <summary>
        /// Gets the left align.
        /// </summary>
        /// <value>
        /// The left align.
        /// </value>
        public static HorizontalAlignment HorizontalLeft { get; } = HorizontalAlignment.Left;

        /// <summary>
        /// Gets the right align.
        /// </summary>
        /// <value>
        /// The right align.
        /// </value>
        public static HorizontalAlignment HorizontalRight { get; } = HorizontalAlignment.Right;

        /// <summary>
        /// Gets the center align.
        /// </summary>
        /// <value>
        /// The center align.
        /// </value>
        public static HorizontalAlignment HorizontalCenter { get; } = HorizontalAlignment.Center;

        /// <summary>
        /// Gets the center text.
        /// </summary>
        /// <value>
        /// The center text.
        /// </value>
        public static StringAlignment StringAlignCenter { get; } = StringAlignment.Center;

        /// <summary>
        /// Gets the far text.
        /// </summary>
        /// <value>
        /// The far text.
        /// </value>
        public static StringAlignment StringAlignFar { get; } = StringAlignment.Far;

        /// <summary>
        /// Gets the near text.
        /// </summary>
        /// <value>
        /// The near text.
        /// </value>
        public static StringAlignment StringAlignNear { get; } = StringAlignment.Near;

        /// <summary>
        /// The middle center
        /// </summary>
        public static ContentAlignment ContentAlignCenter { get; } = ContentAlignment.MiddleCenter;

        /// <summary>
        /// The content top
        /// </summary>
        public static ContentAlignment ContentAlignTop { get; } = ContentAlignment.TopCenter;

        /// <summary>
        /// The content left
        /// </summary>
        public static ContentAlignment ContentAlignLeft { get; } = ContentAlignment.MiddleLeft;

        /// <summary>
        /// The content right
        /// </summary>
        public static ContentAlignment ContentAlignRight { get; } = ContentAlignment.MiddleRight;

        /// <summary>
        /// The content bottom
        /// </summary>
        public static ContentAlignment ContentAlignBottom { get; } = ContentAlignment.BottomRight;
        
        /// <summary>
        /// Initializes a new instance of the <see cref = "ColorConfig"/> class.
        /// </summary>
        public AlignConfig()
        {
        }
        
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name = "alignment" >
        /// The alignment.
        /// </param>
        /// <returns>
        /// </returns>
        public static StringAlignment GetStringAlignment( StringAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( StringAlignment ), alignment )
                    ? alignment
                    : StringAlignment.Center;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( StringAlignment );
            }
        }

        /// <summary>
        /// Sets the string alignment.
        /// </summary>
        /// <param name = "alignment" >
        /// The alignment.
        /// </param>
        /// <returns>
        /// </returns>
        public static HorizontalAlignment GetHorizontalAlignment( HorizontalAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( HorizontalAlignment ), alignment )
                    ? alignment
                    : HorizontalAlignment.Center;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( HorizontalAlignment );
            }
        }

        /// <summary>
        /// Gets the excel vertical alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns></returns>
        public static ExcelVerticalAlignment GetExcelVerticalAlignment( ExcelVerticalAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelVerticalAlignment ), alignment )
                    ? alignment
                    : default( ExcelVerticalAlignment );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelVerticalAlignment );
            }
        }

        /// <summary>
        /// Gets the excel horizontal alignment.
        /// </summary>
        /// <param name="alignment">The alignment.</param>
        /// <returns></returns>
        public static ExcelHorizontalAlignment GetExcelHorizontalAlignment( ExcelHorizontalAlignment alignment )
        {
            try
            {
                return Enum.IsDefined( typeof( ExcelHorizontalAlignment ), alignment )
                    ? alignment
                    : default( ExcelHorizontalAlignment );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelHorizontalAlignment );
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
        public static void OnAlignmentChanged( object sender, EventArgs e )
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
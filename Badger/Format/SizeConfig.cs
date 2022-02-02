// <copyright file = "SizeConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class SizeConfig
    {
        /// <summary>
        /// Gets the form size normal.
        /// </summary>
        /// <value>
        /// The form size normal.
        /// </value>
        public static Size FormSizeNormal { get; } = new Size( 1400, 720 );

        /// <summary>
        /// Gets the form size maximum.
        /// </summary>
        /// <value>
        /// The form size maximum.
        /// </value>
        public static Size FormSizeMaximum { get; } = new Size( 1900, 1060 );

        /// <summary>
        /// Gets the form size minimum.
        /// </summary>
        /// <value>
        /// The form size minimum.
        /// </value>
        public static Size FormSizeMinimum { get; } = new Size( 600, 400 );

        /// <summary>
        /// Gets the dialog size normal.
        /// </summary>
        /// <value>
        /// The dialog size normal.
        /// </value>
        public static Size DialogSizeNormal { get; } = new Size( 680, 530 );

        /// <summary>
        /// Gets the caption size normal.
        /// </summary>
        /// <value>
        /// The caption size normal.
        /// </value>
        public static int CaptionSizeNormal { get; } = 26;

        /// <summary>
        /// Gets the chart size normal.
        /// </summary>
        /// <value>
        /// The chart size normal.
        /// </value>
        public static Size ChartSizeNormal { get; } = new Size( 900, 400 );

        /// <summary>
        /// Gets the dialog size minimum.
        /// </summary>
        /// <value>
        /// The dialog size minimum.
        /// </value>
        public static Size DialogSizeMinimum { get; } = new Size( 300, 300 );

        /// <summary>
        /// Gets the dialog size maximum.
        /// </summary>
        /// <value>
        /// The dialog size maximum.
        /// </value>
        public static Size DialogSizeMaximum { get; } = new Size( 800, 800 );

        /// <summary>
        /// Gets the context menu size normal.
        /// </summary>
        /// <value>
        /// The context menu size normal.
        /// </value>
        public static Size ContextMenuSizeNormal { get; } = new Size( 250, 350 );

        /// <summary>
        /// Gets the image size small.
        /// </summary>
        /// <value>
        /// The image size small.
        /// </value>
        public static Size ImageSizeSmall { get; } = new Size( 12, 12 );

        /// <summary>
        /// Gets the image size icon.
        /// </summary>
        /// <value>
        /// The image size icon.
        /// </value>
        public static Size ImageSizeIcon { get; } = new Size( 16, 16 );

        /// <summary>
        /// Gets the image size medium.
        /// </summary>
        /// <value>
        /// The image size medium.
        /// </value>
        public static Size ImageSizeMedium { get; } = new Size( 20, 20 );

        /// <summary>
        /// Gets the image size large.
        /// </summary>
        /// <value>
        /// The image size large.
        /// </value>
        public static Size ImageSizeLarge  { get; } = new Size( 250, 250 );

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public static Size GetSize( int width = 1, int height = 1 )
        {
            try
            {
                return width > 0 && height > 0
                    ? new Size( width, height )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Size );
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static Size GetSize( Size size )
        {
            if( size.Width > -1
                && size.Height > -1 )
            {
                try
                {
                    return size;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( Size );
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static Size GetSize( ImageSizer size )
        {
            if( Verify.IsImageSize( size ) )
            {
                try
                {
                    return size switch
                    {
                        ImageSizer.Small => ImageSizeSmall,
                        ImageSizer.Medium => ImageSizeIcon,
                        ImageSizer.Large => ImageSizeMedium,
                        ImageSizer.Huge => ImageSizeMedium,
                        _ => Size.Empty
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return Size.Empty;
        }

        /// <summary>
        /// Called when [size changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public static void OnSizeChanged( object sender, EventArgs e )
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
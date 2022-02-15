// <copyright file = "BudgetSize.cs" company = "Terry D. Eppler">
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
    public class BudgetSize
    {
        /// <summary>
        /// Gets the form size normal.
        /// </summary>
        /// <value>
        /// The form size normal.
        /// </value>
        public static Size FormSizeNormal { get; } = new Size( 1200, 700 );

        /// <summary>
        /// Gets the form size maximum.
        /// </summary>
        /// <value>
        /// The form size maximum.
        /// </value>
        public static Size FormSizeMaximum { get; } = new Size( 1400, 800 );

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
        public static int CaptionSize { get; } = 26;

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
        /// Gets or sets the button control.
        /// </summary>
        /// <value>
        /// The button control.
        /// </value>
        public static Size ButtonControl { get; set; } = new Size( 140, 40 );

        /// <summary>
        /// Gets or sets the ComboBox control.
        /// </summary>
        /// <value>
        /// The ComboBox control.
        /// </value>
        public static Size ComboBoxControl { get; set; } = new Size( 200, 36 );

        /// <summary>
        /// Gets or sets the collection control.
        /// </summary>
        /// <value>
        /// The collection control.
        /// </value>
        public static Size CollectionControl { get; set; } = new Size( 250, 150 );

        /// <summary>
        /// Gets or sets the label control.
        /// </summary>
        /// <value>
        /// The label control.
        /// </value>
        public static Size LabelControl { get; set; } = new Size( 200, 20 );

        /// <summary>
        /// Gets or sets the tile control.
        /// </summary>
        /// <value>
        /// The tile control.
        /// </value>
        public static Size TileControl { get; set; } = new Size( 140, 140 );

        /// <summary>
        /// Gets or sets the text box control.
        /// </summary>
        /// <value>
        /// The text box control.
        /// </value>
        public static Size TextBoxControl { get; set; } = new Size( 140, 30 );

        /// <summary>
        /// Gets or sets the data grid control.
        /// </summary>
        /// <value>
        /// The data grid control.
        /// </value>
        public static Size DataGridControl { get; set; } = new Size( 240, 150 );

        /// <summary>
        /// Gets or sets the chart control.
        /// </summary>
        /// <value>
        /// The chart control.
        /// </value>
        public static Size ChartControl { get; set; } = new Size( 600, 400 );

        /// <summary>
        /// Gets or sets the picture control.
        /// </summary>
        /// <value>
        /// The picture control.
        /// </value>
        public static Size PictureControl { get; set; } = new Size( 60, 40 );

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
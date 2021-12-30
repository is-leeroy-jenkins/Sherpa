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
        /// Gets the size of the normal form.
        /// </summary>
        /// <value>
        /// The size of the normal form.
        /// </value>
        public static Size FormSizeNormal { get; } = new Size( 1500, 820 );

        /// <summary>
        /// Gets the maximum size of the form.
        /// </summary>
        /// <value>
        /// The maximum size of the form.
        /// </value>
        public static Size FormSizeMaximum { get; } = new Size( 1900, 1060 );

        /// <summary>
        /// Gets the minimum size of the form.
        /// </summary>
        /// <value>
        /// The minimum size of the form.
        /// </value>
        public static Size FormSizeMinimum { get; } = new Size( 600, 400 );

        /// <summary>
        /// The dialog size normal
        /// </summary>
        public static Size DialogSizeNormal { get; } = new Size( 680, 530 );

        /// <summary>
        /// The form size maximum
        /// </summary>
        public static Size DialogSizeMinimum { get; } = new Size( 300, 300 );

        /// <summary>
        /// The form size minimum
        /// </summary>
        public static Size DialogSizeMaximum { get; } = new Size( 800, 800 );

        /// <summary>
        /// The column configuration size
        /// </summary>
        public static Size ContextMenuSizeNormal { get; } = new Size( 250, 350 );

        /// <summary>
        /// The small
        /// </summary>
        public static Size ImageSizeSmall { get; } = new Size( 12, 12 );

        /// <summary>
        /// The medium
        /// </summary>
        public static Size ImageSizeIcon { get; } = new Size( 16, 16 );

        /// <summary>
        /// The large
        /// </summary>
        public static Size ImageSizeMedium { get; } = new Size( 20, 20 );

        /// <summary>
        /// The largest
        /// </summary>
        public static Size ImageSizeLarge  { get; } = new Size( 250, 250 );
        
        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <param name = "height" >
        /// The height.
        /// </param>
        /// <returns>
        /// </returns>
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
        /// Sets the size.
        /// </summary>
        /// <param name = "size" >
        /// The size.
        /// </param>
        /// <returns>
        /// </returns>
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
        /// Sets the size.
        /// </summary>
        /// <returns>
        /// </returns>
        public static Size GetSize( ImageSizer size )
        {
            if( Verify.IsImageSize( size ) )
            {
                try
                {
                    return size switch
                    {
                        ImageSizer.Small => SizeConfig.ImageSizeSmall,
                        ImageSizer.Medium => SizeConfig.ImageSizeIcon,
                        ImageSizer.Large => SizeConfig.ImageSizeMedium,
                        ImageSizer.Huge => SizeConfig.ImageSizeMedium,
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
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
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
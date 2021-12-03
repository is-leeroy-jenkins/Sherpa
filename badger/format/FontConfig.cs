﻿// <copyright file = "FontConfig.cs" company = "Terry D. Eppler">
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
    /// <seealso cref="System.IDisposable" />
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class FontConfig : IDisposable
    {
        /// <summary>
        /// The font style regular
        /// </summary>
        public static FontStyle FontStyleRegular = FontStyle.Regular;

        /// <summary>
        /// The font style bold
        /// </summary>
        public static FontStyle FontStyleBold = FontStyle.Bold;

        /// <summary>
        /// The font style italic
        /// </summary>
        public static FontStyle FontStyleItalic = FontStyle.Italic;

        /// <summary>
        /// The font size small
        /// </summary>
        public static Font FontSizeSmall = new Font( "Roboto", 8 );

        /// <summary>
        /// The font size medium
        /// </summary>
        public static Font FontSizeMedium = new Font( "Roboto", 10 );

        /// <summary>
        /// The font size large
        /// </summary>
        public static Font FontSizeLarge = new Font( "Roboto", 12 );

        /// <summary>
        /// Initializes a new instance of the <see cref="FontConfig"/> class.
        /// </summary>
        public FontConfig()
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
        /// </value>
        public bool IsDisposed { get; set; }

        /// <summary>
        /// Gets the size of the font.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static int GetFontSize( int size = 8 )
        {
            try
            {
                return size > 0
                    ? size
                    : 8;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the font style.
        /// </summary>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public static FontStyle GetFontStyle( FontStyle style = FontStyle.Regular )
        {
            try
            {
                return Enum.IsDefined( typeof( FontStyle ), style )
                    ? style
                    : FontStyle.Regular;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return FontStyle.Regular;
            }
        }

        /// <summary>
        /// Gets the font.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="size">The size.</param>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public static Font GetFont( string family = "Roboto", int size = 8,
            FontStyle style = FontStyle.Regular )
        {
            try
            {
                return Verify.Input( family ) && size > 0 && Enum.IsDefined( typeof( FontStyle ), style )
                    ? new Font( family, size, style )
                    : new Font( "Roboto", 8, FontStyle.Regular );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the font.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <returns></returns>
        public static Font GetFont( Font font )
        {
            try
            {
                return Verify.Input( font?.FontFamily?.Name )
                    ? font
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing">
        /// <c>true</c> to release both managed
        /// and unmanaged resources;
        /// <c>false</c>
        /// to release only unmanaged resources.
        /// </param>
        private void Dispose( bool disposing )
        {
            if( disposing )
            {
                try
                {
                    FontSizeSmall?.Dispose();
                    FontSizeMedium?.Dispose();
                    FontSizeLarge?.Dispose();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            try
            {
                Dispose( true );
                GC.SuppressFinalize( this );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [font changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public static void OnFontChanged( object sender, EventArgs e )
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
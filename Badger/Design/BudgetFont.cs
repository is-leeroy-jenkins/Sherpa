// <copyright file = "BudgetFont.cs" company = "Terry D. Eppler">
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
    [SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class BudgetFont : IDisposable
    {
        /// <summary>
        /// Gets or sets the font style regular.
        /// </summary>
        /// <value>
        /// The font style regular.
        /// </value>
        public static FontStyle FontStyleRegular { get; set; } = FontStyle.Regular;

        /// <summary>
        /// Gets or sets the font style bold.
        /// </summary>
        /// <value>
        /// The font style bold.
        /// </value>
        public static FontStyle FontStyleBold { get; set; } = FontStyle.Bold;

        /// <summary>
        /// Gets or sets the font style italic.
        /// </summary>
        /// <value>
        /// The font style italic.
        /// </value>
        public static FontStyle FontStyleItalic { get; set; } = FontStyle.Italic;

        /// <summary>
        /// Gets or sets the font size small.
        /// </summary>
        /// <value>
        /// The font size small.
        /// </value>
        public static Font FontSizeSmall { get; set; } = new Font( "Roboto", 9 );

        /// <summary>
        /// Gets or sets the font size medium.
        /// </summary>
        /// <value>
        /// The font size medium.
        /// </value>
        public static Font FontSizeMedium { get; set; } = new Font( "Roboto", 11 );

        /// <summary>
        /// Gets or sets the font size large.
        /// </summary>
        /// <value>
        /// The font size large.
        /// </value>
        public static Font FontSizeLarge { get; set; } = new Font( "Roboto", 14 );

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is disposed; otherwise, <c>false</c>.
        /// </value>
        public bool IsDisposed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFont"/> class.
        /// </summary>
        public BudgetFont()
        {
        }

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
                return default( int );
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
                return Verify.IsInput( family ) && size > 0 && Enum.IsDefined( typeof( FontStyle ), style )
                    ? new Font( family, size, style )
                    : new Font( "Roboto", 8, FontStyle.Regular );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Font );
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
                return Verify.IsInput( font?.FontFamily?.Name )
                    ? font
                    : default( Font );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Font );
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
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
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
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
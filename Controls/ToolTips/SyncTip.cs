//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                SyncTip.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SyncTip.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    SyncTip.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Tools.SuperToolTip"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    public class SyncTip : SuperToolTip
    {
        /// <summary>
        /// Gets or sets the tip text.
        /// </summary>
        /// <value>
        /// The tip text.
        /// </value>
        public TextItem TipText { get; set; }

        /// <summary>
        /// Gets or sets the tip item.
        /// </summary>
        /// <value>
        /// The tip item.
        /// </value>
        public ToolTipInfo.ToolTipItem TipItem { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tip information.
        /// </summary>
        /// <value>
        /// The tip information.
        /// </value>
        protected ToolTipInfo TipInfo { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SyncTip"/>
        /// class.
        /// </summary>
        public SyncTip( )
        {
            // Basic Properties
            InitialDelay = 300;
            ToolTipDuration = 5;
            CanApplyTheme = true;
            VisualStyle = Appearance.Office2016Black;
            CanOverrideStyle = true;
            UseFading = FadingType.System;

            // TipInfo Properties
            TipInfo = new ToolTipInfo( );
            TipInfo.BackColor = Color.FromArgb( 70, 70, 70 );
            TipInfo.BorderColor = Color.FromArgb( 0, 120, 212 );
            TipInfo.ForeColor = Color.FromArgb( 106, 189, 252 );
            TipInfo.Separator = true;

            // Header Properties
            TipInfo.Header.Font = new Font( "Roboto", 10 );
            TipInfo.Header.ForeColor = Color.FromArgb( 106, 189, 252 );
            TipInfo.Header.TextAlign = ContentAlignment.TopCenter;
            TipInfo.Header.ImageAlign = ContentAlignment.TopLeft;
            TipInfo.Header.ImageScalingSize = new Size( 10, 14 );

            // Body Properties
            TipInfo.Body.Font = new Font( "Roboto", 9 );
            TipInfo.Body.ForeColor = Color.FromArgb( 106, 189, 252 );
            TipInfo.Body.TextAlign = ContentAlignment.TopLeft;

            // Footer Properties
            TipInfo.Footer.Font = new Font( "Roboto", 7 );
            TipInfo.Footer.ForeColor = Color.White;
            TipInfo.Footer.TextAlign = ContentAlignment.BottomLeft;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SyncTip"/>
        /// class.
        /// </summary>
        /// <param name="control"> The control. </param>
        /// <param name="text"> The text. </param>
        /// <param name="title"> The title. </param>
        public SyncTip( Control control, string text, string title = "" )
            : this( )
        {
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SyncTip"/>
        /// class.
        /// </summary>
        /// <param name="toolItem"> The tool item. </param>
        public SyncTip( ToolStripItem toolItem )
            : this( )
        {
        }

        /// <summary>
        /// Sets the header text.
        /// </summary>
        /// <param name="headerText">The header text.</param>
        /// <param name="fontSize">Size of the font.</param>
        /// <param name="textAlign">The text align.</param>
        /// <param name="imageAlign">The image align.</param>
        public void SetHeaderText( string headerText, int fontSize = 10,
            ContentAlignment textAlign = ContentAlignment.TopLeft, 
            ContentAlignment imageAlign = ContentAlignment.TopLeft )
        {
            try
            {
                ThrowIf.Null( headerText, nameof( headerText ) );
                TipInfo.Header.Text = headerText;
                TipInfo.Header.Font = new Font( "Roboto", fontSize );
                TipInfo.Header.ForeColor = Color.FromArgb( 106, 189, 252 );
                TipInfo.Header.TextAlign = textAlign;
                TipInfo.Header.ImageAlign = imageAlign;
                TipInfo.Header.ImageScalingSize = new Size( 10, 14 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the body text.
        /// </summary>
        /// <param name="bodyText">The body text.</param>
        /// <param name="fontSize">Size of the font.</param>
        /// <param name="textAlign">The text align.</param>
        public void SetBodyText( string bodyText, int fontSize = 9,
            ContentAlignment textAlign = ContentAlignment.TopLeft )
        {
            try
            { 
                ThrowIf.Null( bodyText, nameof( bodyText ) );
                TipInfo.Body.Text = bodyText;
                TipInfo.Body.Font = new Font( "Roboto", fontSize );
                TipInfo.Body.ForeColor = Color.FromArgb( 106, 189, 252 );
                TipInfo.Body.TextAlign = textAlign;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the footer text.
        /// </summary>
        /// <param name="footerText">The footer text.</param>
        /// <param name="fontSize">Size of the font.</param>
        /// <param name="textAlign">The text align.</param>
        public void SetFooterText( string footerText, int fontSize = 7, 
            ContentAlignment textAlign = ContentAlignment.BottomLeft )
        {
            try
            { 
                ThrowIf.Null( footerText, nameof( footerText ) );
                TipInfo.Footer.Text = footerText;
                TipInfo.Footer.Font = new Font( "Roboto", fontSize );
                TipInfo.Footer.ForeColor = Color.White;
                TipInfo.Footer.TextAlign = textAlign;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
﻿//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                DelayDialog.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DelayDialog.cs" company="Terry D. Eppler">
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
//    DelayDialog.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using static System.Configuration.ConfigurationManager;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class DelayDialog : MetroForm
    {
        /// <summary>
        /// The loading path
        /// </summary>
        public readonly string LoadingPath = AppSettings[ "PathPrefix" ] + AppSettings[ "Loading" ];

        /// <summary>
        /// The processing path
        /// </summary>
        public readonly string ProcessingPath = AppSettings[ "PathPrefix" ] + AppSettings[ "Processing" ];

        /// <summary>
        /// The waiting path
        /// </summary>
        public readonly string WaitingPath = AppSettings[ "PathPrefix" ] + AppSettings[ "Waiting" ];

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>
        /// The picture.
        /// </value>
        public Image Picture { get; set; }

        /// <summary>
        /// Gets or sets the loader.
        /// </summary>
        /// <value>
        /// The loader.
        /// </value>
        public Bitmap Loader { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public Status Status { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.DelayDialog" /> class.
        /// </summary>
        public DelayDialog( )
        {
            InitializeComponent( );

            // Basic Properties
            Size = new Size( 1340, 648 );
            MaximumSize = new Size( 1340, 648 );
            MinimumSize = new Size( 1340, 648 );
            MetroColor = Color.Black;
            ForeColor = Color.Black;
            CaptionBarColor = Color.Black;
            CaptionForeColor = Color.Black;
            CaptionButtonColor = Color.Black;
            CaptionButtonHoverColor = Color.Black;
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Regular );
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.None;
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            SizeGripStyle = SizeGripStyle.Hide;
            AutoScaleMode = AutoScaleMode.Font;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ControlBox = false;

            // Timer Configuration
            Timer.Enabled = true;
            Timer.Interval = 5000;
            Timer.Tick += OnTick;
            Timer.Start( );

            // Event Wiring
            Load += OnLoad;
            FormClosed += OnClose;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.DelayDialog" /> class.
        /// </summary>
        /// <param name="status">The status.</param>
        public DelayDialog( Status status )
            : this( )
        {
            Status = status;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                ShowImage( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnTick( object sender, EventArgs e )
        {
            try
            {
                Timer?.Stop( );
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the image.
        /// </summary>
        public void ShowImage( )
        {
            try
            {
                var _loading = AppSettings[ "PathPrefix" ] + AppSettings[ "Loading" ];
                var _processing = AppSettings[ "PathPrefix" ] + AppSettings[ "Processing" ];
                var _waiting = AppSettings[ "PathPrefix" ] + AppSettings[ "Waiting" ];
                if( Enum.IsDefined( typeof( Status ), Status ) )
                {
                    PictureBox.Image = Status switch
                    {
                        Status.Loading => Image.FromFile( _loading ),
                        Status.Processing => Image.FromFile( _processing ),
                        Status.Waiting => Image.FromFile( _waiting ),
                        _ => Image.FromFile( _loading )
                    };
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Raises the Close event.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnClose( object sender, EventArgs e )
        {
            try
            {
                Timer?.Dispose( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        public void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
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
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
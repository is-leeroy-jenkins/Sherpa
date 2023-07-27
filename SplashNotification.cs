//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                SplashNotification.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SplashNotification.cs" company="Terry D. Eppler">
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
//    SplashNotification.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Linq;
    using static System.Drawing.Region;
    using static System.Windows.Forms.Screen;
    using static FormAnimator;
    using static NativeMethods;
    using Timer = System.Windows.Forms.Timer;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public partial class SplashNotification : MetroForm
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value> The time. </value>
        public int Time { get; set; }

        /// <summary>
        /// Gets or sets the seconds.
        /// </summary>
        /// <value> The seconds. </value>
        public int Seconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow focus].
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if [allow focus]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool AllowFocus { get; set; }

        /// <summary>
        /// Gets a value indicating whether [shown without activation].
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if [shown without activation]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool ShownWithoutActivation { get; set; } = true;

        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        /// <value>
        /// The lines.
        /// </value>
        public List<string> Lines { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SplashNotification" /> class.
        /// </summary>
        public SplashNotification( )
        {
            InitializeComponent( );

            // Form Properties
            Size = new Size( 650, 250 );
            MinimumSize = new Size( 650, 250 );
            MaximumSize = new Size( 650, 250 );
            BackColor = Color.FromArgb( 3, 3, 3 );
            MetroColor = Color.FromArgb( 3, 3, 3 );
            BorderColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            CaptionBarColor = Color.FromArgb( 3, 3, 3 );
            CaptionButtonColor = Color.FromArgb( 3, 3, 3 );
            Message.BackColor = Color.FromArgb( 3, 3, 3 );
            Message.ForeColor = Color.White;
            Title.ForeColor = Color.FromArgb( 75, 135, 200 );
            Layout.BorderColor = Color.FromArgb( 0, 120, 212 );
            Layout.Margin = new Padding( 0 );
            Layout.Padding = new Padding( 0 );
            CaptionAlign = HorizontalAlignment.Left;
            CaptionBarHeight = 5;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ShowIcon = false;
            ShowMouseOver = false;
            ShowInTaskbar = true;
            DoubleBuffered = true;
            StartPosition = FormStartPosition.CenterScreen;
            SizeGripStyle = SizeGripStyle.Hide;
            Padding = new Padding( 0 );
            ForeColor = Color.LightGray;
            Font = new Font( "Roboto", 9 );

            // Wire Events
            Load += OnLoad;
            Click += OnClick;
            PictureBox.Click += OnClick;
            Title.Click += OnClick;
            Message.Click += OnClick;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SplashNotification" /> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name = "duration" > </param>
        /// <param name = "animation" > </param>
        /// <param name = "direction" > </param>
        public SplashNotification( string message, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            Time = 0;
            Seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = "Notification";
            Message.Text = message;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SplashNotification" /> class.
        /// </summary>
        /// <param name="lines">
        /// The lines.
        /// </param>
        /// <param name = "duration" > </param>
        /// <param name = "animation" > </param>
        /// <param name = "direction" > </param>
        public SplashNotification( IEnumerable<string> lines, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            Lines = lines.ToList( );
            Time = 0;
            Seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = "Notification";
        }

        /// <summary>
        /// Displays the control to the user.
        /// </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( Seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = 1000;
                    Timer.Tick += ( sender, args ) =>
                    {
                        Time++;
                        if( Time == Seconds )
                        {
                            Timer.Stop( );
                            FadeOut( );
                        }
                    };
                }

                base.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the in.
        /// </summary>
        private void FadeIn( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 1d )
                    {
                        _timer.Stop( );
                    }

                    Opacity += 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out and close.
        /// </summary>
        private void FadeOut( )
        {
            try
            {
                var _timer = new Timer( );
                _timer.Interval = 10;
                _timer.Tick += ( sender, args ) =>
                {
                    if( Opacity == 0d )
                    {
                        _timer.Stop( );
                        Close( );
                    }

                    Opacity -= 0.02d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Notifications the close.
        /// </summary>
        public void OnClose( )
        {
            try
            {
                FadeOut( );
                Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnClick( object sender, EventArgs e )
        {
            try
            {
                OnClose( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                FadeIn( );
                Timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Get ErrorDialog Dialog.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
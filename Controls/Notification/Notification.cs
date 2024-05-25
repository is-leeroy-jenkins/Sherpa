// ******************************************************************************************
//     Assembly:             BudgetExecution
//     Author:                  Terry D. Eppler
//     Created:                 12-24-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        04-03-2024
// ******************************************************************************************
// <copyright file="Terry Eppler" company="Terry D. Eppler">
//    Sherpa is a small Federal Budget, Finance, and Accounting data management
//    application for analysts with the US Environmental Protection Agency (US EPA).
//    Copyright ©  2024  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   Notification.cs
// </summary>
// ******************************************************************************************

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace Sherpa
{
    using System;
    using static Screen;
    using static FormAnimator;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ReplaceAutoPropertyWithComputedProperty" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ValueParameterNotUsed" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    public partial class Notification : MetroForm
    {
        /// <summary>
        /// The time
        /// </summary>
        private int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The allow focus
        /// </summary>
        private bool _allowFocus;

        /// <summary>
        /// The without activation
        /// </summary>
        private bool _withoutActivation;

        /// <summary>
        /// Gets or sets a value indicating whether [allow focus].
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if [allow focus]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool AllowFocus
        {
            get
            {
                return _allowFocus;
            }
            private set
            {
                _allowFocus = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether [shown without activation].
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if [shown without activation]; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        public bool ShownWithoutActivation
        {
            get
            {
                return _withoutActivation;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Notification"/>
        /// class.
        /// </summary>
        public Notification( )
        {
            InitializeComponent( );
            RegisterCallbacks( );

            // Form Properties
            DoubleBuffered = true;
            Size = new Size( 400, 190 );
            MinimumSize = new Size( 400, 190 );
            MaximumSize = new Size( 400, 190 );
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ShowIcon = false;
            ShowMouseOver = false;
            ShowInTaskbar = true;
            FormBorderStyle = FormBorderStyle.None;
            SizeGripStyle = SizeGripStyle.Hide;
            Padding = new Padding( 0 );
            Panel.BackColor = Color.FromArgb( 0, 73, 112 );
            Panel.BorderColor = Color.FromArgb( 0, 73, 112 );
            Title.ForeColor = Color.FromArgb( 0, 73, 112 );
            BorderColor = Color.FromArgb( 0, 73, 112 );
            BackColor = Color.FromArgb( 0, 73, 112 );
            CaptionBarColor = Color.FromArgb( 0, 73, 112 );

            // Splash Attributes
            _withoutActivation = true;
            _time = 0;
            _seconds = 5;

            // Event Wiring
            Resize += OnResized;
            Click += OnClose;
            Load += OnLoad;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Notification"/>
        /// class.
        /// </summary>
        /// <param name="body"> The body. </param>
        /// <param name="duration"> The duration. </param>
        /// <param name="animation"> The animation. </param>
        /// <param name="direction"> The direction. </param>
        public Notification( string body, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            _seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = nameof( Notification );
            Message.Text = body;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Notification"/>
        /// class.
        /// </summary>
        /// <param name="title"> The title. </param>
        /// <param name="body"> The body. </param>
        /// <param name="duration"> The duration. </param>
        /// <param name="animation"> The animation. </param>
        /// <param name="direction"> The direction. </param>
        public Notification( string title, string body, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            _seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = title;
            Message.Text = body;
        }

        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                Message.Click += OnClose;
                Title.Click += OnClose;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                Message.Font = new Font( "Roboto", 9, FontStyle.Bold );
                Message.BackColor = Color.FromArgb( 0, 73, 112 );
                Message.ForeColor = Color.White;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Displays the control to the user.
        /// </summary>
        public new void Show( )
        {
            try
            {
                Opacity = 0;
                if( _seconds != 0 )
                {
                    Timer = new Timer( );
                    Timer.Interval = 1000;
                    Timer.Tick += ( sender, args ) =>
                    {
                        _time++;
                        if( _time == _seconds )
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
                        base.Close( );
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                var _width = PrimaryScreen.WorkingArea.Width - Width - 5;
                var _height = PrimaryScreen.WorkingArea.Height - Height - 5;
                Location = new Point( _width, _height );
                InitializeLabels( );
                Timer.Start( );
                FadeIn( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [resized].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        private void OnResized( object sender, EventArgs e )
        {
            try
            {
                if( WindowState == FormWindowState.Minimized )
                {
                    WindowState = FormWindowState.Normal;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Notifications the close.
        /// </summary>
        public void OnClose( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
                base.Close( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Get ErrorDialog Dialog.
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
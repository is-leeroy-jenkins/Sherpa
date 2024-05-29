//  ******************************************************************************************
//      Assembly:                Sherpa
//      Filename:                SplashMessage.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="SplashMessage.cs" company="Terry D. Eppler">
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
//    SplashMessage.cs
//  </summary>
//  ******************************************************************************************

namespace Sherpa
{
    using System;
    using static FormAnimator;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    public partial class SplashMessage : MetroForm
    {
        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

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
        /// The lines
        /// </summary>
        private IList<string> _lines;

        /// <summary>
        /// Gets or sets a value indicating whether [allow focus].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow focus]; otherwise, <c>false</c>.
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
        /// Gets or sets a value indicating whether [shown without activation].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [shown without activation]; otherwise, <c>false</c>.
        /// </value>
        public bool ShownWithoutActivation
        {
            get
            {
                return _withoutActivation;
            }
            private set
            {
                _withoutActivation = value;
            }
        }

        /// <summary>
        /// Gets or sets the lines.
        /// </summary>
        /// <value>
        /// The lines.
        /// </value>
        public IList<string> Lines
        {
            get
            {
                return _lines;
            }
            private set
            {
                _lines = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is busy.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is busy; otherwise,
        /// <c> false </c>
        /// </value>
        public bool IsBusy
        {
            get
            {
                return _busy;
            }
            private set
            {
                _busy = value;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SplashMessage" /> class.
        /// </summary>
        public SplashMessage( )
        {
            InitializeComponent( );
            RegisterCallbacks( );

            // Form Properties
            Size = new Size( 650, 250 );
            MinimumSize = new Size( 650, 250 );
            MaximumSize = new Size( 650, 250 );
            BackColor = Color.FromArgb( 0, 73, 112 );
            MetroColor = Color.FromArgb( 0, 73, 112 );
            BorderColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            CaptionBarColor = Color.FromArgb( 0, 73, 112 );
            CaptionButtonColor = Color.FromArgb( 0, 73, 112 );
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
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );

            // Timer Settings
            _time = 0;
            _seconds = 5;

            // Splash Attributes
            _withoutActivation = true;
            _lines = new List<string>( );

            // Wire Events
            MouseClick += OnClick;
            Load += OnLoad;
            FormClosing += OnFormClosing;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        ///
        /// <see cref="T:Sherpa.SplashMessage" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animation">The animation.</param>
        /// <param name="direction">The direction.</param>
        public SplashMessage( string message, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            _seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = nameof( Notification );
            Message.Text = message;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.SplashMessage" /> class.
        /// </summary>
        /// <param name="lines">The lines.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="animation">The animation.</param>
        /// <param name="direction">The direction.</param>
        public SplashMessage( IEnumerable<string> lines, int duration = 5,
            AnimationMethod animation = AnimationMethod.Fade,
            AnimationDirection direction = AnimationDirection.Up )
            : this( )
        {
            _lines = lines.ToList( );
            _seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = nameof( Notification );
        }

        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                PictureBox.MouseClick += OnClick;
                Title.MouseClick += OnClick;
                Message.MouseClick += OnClick;
                Header.MouseClick += OnClick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the title.
        /// </summary>
        private protected void InitializeTitle( )
        {
            try
            {
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the panel.
        /// </summary>
        private protected void InitializePanel( )
        {
            try
            {
                BackPanel.BorderColor = Color.FromArgb( 106, 189, 252 );
                BackPanel.Margin = new Padding( 0 );
                BackPanel.Padding = new Padding( 0 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private protected virtual void InitializeLabels( )
        {
            try
            {
                Message.BackColor = Color.FromArgb( 0, 73, 112 );
                Message.Font = new Font( "Roboto", 11 );
                Message.ForeColor = Color.FromArgb( 106, 189, 252 );
                Message.TextAlign = ContentAlignment.TopLeft;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the in asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeInAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity < 1.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity += 0.05;
                }

                form.Opacity = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out asynchronous.
        /// </summary>
        /// <param name="form">The o.</param>
        /// <param name="interval">The interval.</param>
        private async void FadeOutAsync( Form form, int interval = 80 )
        {
            try
            {
                ThrowIf.Null( form, nameof( form ) );
                while( form.Opacity > 0.0 )
                {
                    await Task.Delay( interval );
                    form.Opacity -= 0.05;
                }

                form.Opacity = 0;
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
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                InitializeLabels( );
                InitializePanel( );
                InitializeTitle( );
                FadeInAsync( this );
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
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Left
               || e.Button == MouseButtons.Right )
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
        }

        /// <summary>
        /// Called when [form closing].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFormClosing( object sender, EventArgs e )
        {
            try
            {
                Opacity = 1;
                FadeOutAsync( this );
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
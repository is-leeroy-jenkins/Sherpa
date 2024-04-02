//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                DelayForm.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="DelayForm.cs" company="Terry D. Eppler">
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
//    DelayForm.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Timer = System.Windows.Forms.Timer;

    /// <summary>
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantEmptySwitchSection" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertSwitchStatementToSwitchExpression" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    public partial class DelayForm : MetroForm
    {
        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;

        /// <summary>
        /// The seconds
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The time
        /// </summary>
        private int _time;

        /// <summary>
        /// The status
        /// </summary>
        private Status _status;

        /// <summary>
        /// The picture
        /// </summary>
        private Image _picture;

        /// <summary>
        /// The loader
        /// </summary>
        private Bitmap _loader;

        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        public int Time
        {
            get
            {
                return _time;
            }
            private protected set
            {
                _time = value;
            }
        }

        /// <summary>
        /// Gets or sets the seconds.
        /// </summary>
        /// <value>
        /// The seconds.
        /// </value>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            private protected set
            {
                _seconds = value;
            }
        }

        /// <summary>
        /// Gets or sets the picture.
        /// </summary>
        /// <value>
        /// The picture.
        /// </value>
        public Image Picture
        {
            get
            {
                return _picture;
            }
            private protected set
            {
                _picture = value;
            }
        }

        /// <summary>
        /// Gets or sets the loader.
        /// </summary>
        /// <value>
        /// The loader.
        /// </value>
        public Bitmap Loader
        {
            get
            {
                return _loader;
            }
            private protected set
            {
                _loader = value;
            }
        }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public Status Status
        {
            get
            {
                return _status;
            }
            private protected set
            {
                _status = value;
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
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DelayForm"/>
        /// class.
        /// </summary>
        public DelayForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Form Properties
            Size = new Size( 1340, 740 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1330, 730 );
            Padding = new Padding( 1 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            SizeGripStyle = SizeGripStyle.Auto;
            AutoScaleMode = AutoScaleMode.Font;
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Regular );
            CaptionBarColor = Color.Black;
            BackColor = Color.Black;
            MetroColor = Color.Black;
            ForeColor = Color.Black;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            ShowIcon = false;
            ShowInTaskbar = true;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Form Event Wiring
            Load += OnLoad;
            Shown += OnShown;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.DelayForm"/>
        /// class.
        /// </summary>
        /// <param name="status"> The status. </param>
        public DelayForm( Status status )
            : this( )
        {
            _status = status;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( ) 
        {
            try
            {
                InitializeTimer( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the delegates.
        /// </summary>
        private void InitializeDelegates( )
        {
            try
            {
                _statusUpdate += Close;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the timer.
        /// </summary>
        private void InitializeTimer( )
        {
            try
            {
                // Timer Properties
                Timer.Enabled = true;
                Timer.Interval = 500;
                Timer.Tick += OnTimerTick;
                Timer.Start( );
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
                    var _timer = new Timer( );
                    _timer.Interval = 1000;
                    _timer.Tick += ( sender, args ) =>
                    {
                        _time++;
                        if( _time == _seconds )
                        {
                            _timer.Stop( );
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
        /// Displays the control to the user.
        /// </summary>
        public new void ShowDialog( )
        {
            try
            {
                Opacity = 0;
                if( _seconds != 0 )
                {
                    var _timer = new Timer( );
                    _timer.Interval = 1000;
                    _timer.Tick += ( sender, args ) =>
                    {
                        _time++;
                        if( _time == _seconds )
                        {
                            _timer.Stop( );
                        }
                    };
                }

                base.ShowDialog( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        public new void Close( )
        {
            try
            {
                Opacity = 0;
                if( _seconds != 0 )
                {
                    var _timer = new Timer( );
                    _timer.Interval = 1000;
                    _timer.Tick += ( sender, args ) =>
                    {
                        _time--;
                        if( _time == _seconds )
                        {
                            _timer.Stop( );
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

                    Opacity += 0.01d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fades the out.
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
                    }

                    Opacity -= 0.01d;
                };

                _timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        public void InvokeIf( Action action )
        {
            try
            {
                ThrowIf.Null( action, nameof( action ) );
                if( InvokeRequired )
                {
                    BeginInvoke( action );
                }
                else
                {
                    action.Invoke( );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Begins the initialize.
        /// </summary>
        private protected void BeginInit( )
        {
            try
            {
                _busy = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private protected void EndInit( )
        {
            try
            {
                _busy = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the image.
        /// </summary>
        private protected void SetImage( )
        {
            try
            {
                switch( _status )
                {
                    case Status.Loading:
                    {
                        PictureBox.Image = Resources.Images.LoaderImages.Loading;
                        break;
                    }
                    case Status.Processing:
                    {
                        PictureBox.Image = Resources.Images.LoaderImages.Processing;
                        break;
                    }
                    case Status.Waiting:
                    {
                        PictureBox.Image = Resources.Images.LoaderImages.Waiting;
                        break;
                    }
                    default:
                    {
                        PictureBox.Image = Resources.Images.LoaderImages.Loading;
                        break;
                    }
                }
            }
            catch( Exception _ex )
            {
                PictureBox.Image?.Dispose( );
                Fail( _ex );
            }
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetImage( );
                InitializeTimer( );
                FadeIn( );
            }
            catch( Exception _ex )
            {
                PictureBox.Image?.Dispose( );
                Fail( _ex );
            }
        }

        /// <summary> Called when [tick]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnTimerTick( object sender, EventArgs e )
        {
            try
            {
                InvokeIf( _statusUpdate );
            }
            catch( Exception _ex )
            {
                PictureBox.Image?.Dispose( );
                Fail( _ex );
            }
        }

        /// <summary> Called when [close button clicked]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Called when [shown]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                FadeIn( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
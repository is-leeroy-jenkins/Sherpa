﻿//  ******************************************************************************************
//      Assembly:                Budget Execution
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

namespace BudgetExecution
{
    using System;
    using static FormAnimator;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
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
    public partial class SplashMessage : MetroForm
    {
        /// <summary>
        /// Gets or sets the time.
        /// </summary>
        /// <value>
        /// The time.
        /// </value>
        public int Time { get; set; }

        /// <summary>
        /// Gets or sets the seconds.
        /// </summary>
        /// <value>
        /// The seconds.
        /// </value>
        public int Seconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [allow focus].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow focus]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowFocus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [shown without activation].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [shown without activation]; otherwise, <c>false</c>.
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
        /// <see cref="T:BudgetExecution.SplashMessage" /> class.
        /// </summary>
        public SplashMessage( )
        {
            InitializeComponent( );

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

            // Wire Events
            PictureBox.MouseClick += OnClick;
            Title.MouseClick += OnClick;
            Message.MouseClick += OnClick;
            Header.MouseClick += OnClick;
            MouseClick += OnClick;
            Load += OnLoad;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        ///
        /// <see cref="T:BudgetExecution.SplashMessage" /> class.
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
            Time = 0;
            Seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = nameof( Notification );
            Message.Text = message;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.SplashMessage" /> class.
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
            Lines = lines.ToList( );
            Time = 0;
            Seconds = duration;
            Timer.Interval = duration * 1000;
            Title.Text = nameof( Notification );
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
        /// Raises the Close event.
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
                    OnClose( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                InitializeLabels( );
                InitializePanel( );
                InitializeTitle( );
                FadeIn( );
                Timer.Start( );
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
        /// Fades the in.
        /// </summary>
        private protected virtual void FadeIn( )
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
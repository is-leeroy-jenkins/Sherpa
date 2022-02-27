// <copyright file = "Notification.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using DocumentFormat.OpenXml.Drawing.Diagrams;
    using Point = System.Drawing.Point;

    public partial class BudgetNotification : MetroForm
    {
        public static readonly List<BudgetNotification> OpenNotifications = new List<BudgetNotification>();

        public bool AllowFocus { get; set; }

        public FormAnimator Animator { get; }

        private IntPtr _currentForegroundWindow;

        public BudgetNotification()
        {
        }
        
        public BudgetNotification( string title, string body, int duration = 3,
            FormAnimator.AnimationMethod animation = FormAnimator.AnimationMethod.Slide,
            FormAnimator.AnimationDirection direction = FormAnimator.AnimationDirection.Left )
            : this()
        {
            InitializeComponent();
            BackColor = Color.FromArgb( 18, 18, 18 );
            Load += OnLoad;
            Timer.Interval = duration * 1000;
            Title.Text = title;
            Message.Text = body;
            Animator = new FormAnimator( this, animation, direction, 500 );
            Region = Region.FromHrgn( NativeMethods.CreateRoundRectRgn( 0, 0, Width - 5, Height - 5, 20, 20 ) );
            Activated += OnActivated;
            Shown += OnShown;
            FormClosed += OnClosed;
            Click += ( s, e ) => Close();
            Message.Click += ( s, e ) => Close();
            Title.Click += ( s, e ) => Close();
            Timer.Tick += OnTimerTick;
        }

        public new void Show()
        {
            _currentForegroundWindow = NativeMethods.GetForegroundWindow();

            base.Show();
        }

        private void OnLoad( object sender, EventArgs e )
        {
            Location = new Point( Screen.PrimaryScreen.WorkingArea.Width - Width, 
                Screen.PrimaryScreen.WorkingArea.Height - Height );

            foreach( var _form in OpenNotifications )
            {
                _form.Top -= Height;
            }

            OpenNotifications.Add( this );
            Timer.Start();
        }

        private void OnActivated( object sender, EventArgs e )
        {
            if( !AllowFocus )
            {
                NativeMethods.SetForegroundWindow( _currentForegroundWindow );
            }
        }

        private void OnShown( object sender, EventArgs e )
        {
            AllowFocus = true;
            Animator.Duration = 0;
            Animator.Direction = FormAnimator.AnimationDirection.Down;
        }

        private void OnClosed( object sender, FormClosedEventArgs e )
        {
            foreach( var _openForm in OpenNotifications )
            {
                if( _openForm == this )
                {
                    break;
                }

                _openForm.Top += Height;
            }

            OpenNotifications.Remove( this );
        }

        private void OnTimerTick( object sender, EventArgs e )
        {
            Close();
        }

        public void NotificationClose()
        {
            Close();
        }
    }
}

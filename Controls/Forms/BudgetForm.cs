// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-6-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-6-2024
// ******************************************************************************************
// <copyright file="BudgetForm.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
//    for the US Environmental Protection Agency (US EPA).
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
//    Contact at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   BudgetForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Timer = System.Windows.Forms.Timer;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public partial class BudgetForm : MetroForm
    {
        /// <summary>
        /// The time
        /// </summary>
        private protected int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private protected int _seconds;

        /// <summary>
        /// The SQL command
        /// </summary>
        private string _sqlQuery;

        /// <summary>
        /// The source
        /// </summary>
        private protected Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private protected Provider _provider;

        /// <summary>
        /// The busy
        /// </summary>
        private protected bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private protected Action _statusUpdate;

        /// <summary>
        /// The selected table
        /// </summary>
        private protected string _selectedTable;

        /// <summary>
        /// The selected columns
        /// </summary>
        private protected IList<string> _selectedColumns;

        /// <summary>
        /// The selected fields
        /// </summary>
        private protected IList<string> _selectedFields;

        /// <summary>
        /// The selected numerics
        /// </summary>
        private protected IList<string> _selectedNumerics;

        /// <summary>
        /// The filter
        /// </summary>
        private protected IDictionary<string, object> _filter;

        /// <summary>
        /// The data arguments
        /// </summary>
        private protected DataArgs _dataArgs;

        /// <summary>
        /// Gets the time.
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
        /// Gets the seconds.
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
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source
        {
            get
            {
                return _source;
            }
            private protected set
            {
                _source = value;
            }
        }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider
        {
            get
            {
                return _provider;
            }
            private protected set
            {
                _provider = value;
            }
        }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> Filter
        {
            get
            {
                return _filter;
            }
            private protected set
            {
                _filter = value;
            }
        }

        /// <summary>
        /// Gets or sets the data arguments.
        /// </summary>
        /// <value>
        /// The data arguments.
        /// </value>
        public DataArgs DataArgs
        {
            get
            {
                return _dataArgs;
            }
            private protected set
            {
                _dataArgs = value;
            }
        }

        /// <summary>
        /// Gets the selected columns.
        /// </summary>
        /// <value>
        /// The selected columns.
        /// </value>
        public IList<string> SelectedColumns
        {
            get
            {
                return _selectedColumns;
            }
            private set
            {
                _selectedColumns = value;
            }
        }

        /// <summary>
        /// Gets the selected fields.
        /// </summary>
        /// <value>
        /// The selected fields.
        /// </value>
        public IList<string> SelectedFields
        {
            get
            {
                return _selectedFields;
            }
            private set
            {
                _selectedFields = value;
            }
        }

        /// <summary>
        /// Gets the selected numerics.
        /// </summary>
        /// <value>
        /// The selected numerics.
        /// </value>
        public IList<string> SelectedNumerics
        {
            get
            {
                return _selectedNumerics;
            }
            private set
            {
                _selectedNumerics = value;
            }
        }

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <value>
        /// The SQL command.
        /// </value>
        public string SqlQuery
        {
            get
            {
                return _sqlQuery;
            }
            private set
            {
                _sqlQuery = value;
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

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.BudgetForm"/>
        /// class.
        /// </summary>
        public BudgetForm( )
        {
            InitializeComponent( );
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1340, 740 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 10, FontStyle.Regular );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            SizeGripStyle = SizeGripStyle.Hide;
            AutoScaleMode = AutoScaleMode.Font;
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Wire Events
            Load += OnLoad;
        }

        /// <summary>
        /// Begins the initialize.
        /// </summary>
        private void BeginInit( )
        {
            _busy = true;
        }

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private void EndInit( )
        {
            _busy = false;
        }

        /// <summary>
        /// Gets the controls.
        /// </summary>
        /// <returns>
        /// </returns>
        private IEnumerable<Control> GetControls( )
        {
            var _list = new List<Control>( );
            var _queue = new Queue( );
            try
            {
                _queue.Enqueue( Controls );
                while( _queue.Count > 0 )
                {
                    var _collection = (Control.ControlCollection)_queue.Dequeue( );
                    if( _collection?.Count > 0 )
                    {
                        foreach( Control _control in _collection )
                        {
                            _list.Add( _control );
                            _queue.Enqueue( _control.Controls );
                        }
                    }
                }

                return _list?.Any( ) == true
                    ? _list.ToArray( )
                    : default( Control[ ] );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( Control[ ] );
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
        /// Fades the form in.
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
        /// Fades the form out and close.
        /// </summary>
        private protected virtual void FadeOut( )
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
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        public void InvokeIf( Action action )
        {
            if( InvokeRequired )
            {
                BeginInvoke( action );
            }
            else
            {
                action.Invoke( );
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
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
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                CloseButton.Click += OnCloseButtonClick;
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
                _statusUpdate += UpdateStatus;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the timers.
        /// </summary>
        private void InitializeTimers( )
        {
            try
            {
                // Timer Properties
                Timer.Enabled = true;
                Timer.Interval = 500;
                Timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tool strip.
        /// </summary>
        private void InitializeToolStrip( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Captures the state.
        /// </summary>
        private void CaptureState( )
        {
            try
            {
                _dataArgs.Provider = _provider;
                _dataArgs.Source = _source;
                _dataArgs.Filter = _filter;
                _dataArgs.SelectedTable = _selectedTable;
                _dataArgs.SelectedFields = _selectedFields;
                _dataArgs.SelectedNumerics = _selectedNumerics;
                _dataArgs.SqlQuery = _sqlQuery;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the collections.
        /// </summary>
        private void ClearCollections( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the notification.
        /// </summary>
        /// <param name="text">The text.</param>
        private void SendNotification( string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                var _notification = new Notification( text );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="text">The text.</param>
        private void SendMessage( string text )
        {
            try
            {
                ThrowIf.NullOrEmpty( text, nameof( text ) );
                var _message = new SplashMessage( text );
                _message.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            InvokeIf( _statusUpdate );
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

        /// <summary> Called when [click]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private protected virtual void OnCloseButtonClick( object sender, EventArgs e )
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

        /// <summary> Called when [load]. </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private protected virtual void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeLabels( );
                FadeIn( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Get Error Dialog for exceptions.
        /// </summary>
        /// <param name="ex">
        /// The exception.
        /// </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
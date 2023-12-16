using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace BudgetExecution
{
    using System;

    /// <summary>
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    public partial class FolderBrowser : MetroForm
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
        /// Gets or sets the selected path.
        /// </summary>
        /// <value>
        /// The selected path.
        /// </value>
        public string SelectedPath { get; set; }

        /// <summary>
        /// Gets or sets the initial dir paths.
        /// </summary>
        /// <value>
        /// The initial dir paths.
        /// </value>
        public IEnumerable<string> InitialDirPaths { get; set; }

        /// <summary>
        /// Gets or sets the file paths.
        /// </summary>
        /// <value>
        /// The file paths.
        /// </value>
        public IEnumerable<string> DirPaths { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FolderBrowser"/>
        /// class.
        /// </summary>
        public FolderBrowser( )
        {
            InitializeComponent( );

            // Form Settings
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 700, 480 );
            MaximumSize = new Size( 700, 480 );
            MinimumSize = new Size( 700, 480 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            if( DirPaths?.Any( ) == true )
            {
                try
                {
                    InitializeLabels( );
                    InitializeButtons( );
                    RegisterCallbacks();
                    PopulateListBox( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                // Title Properties
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
        private void RegisterCallbacks()
        {
            try
            {
                CloseButton.Click += OnCloseButtonClicked;
                FileList.SelectedValueChanged += OnPathSelected;
                FindButton.Click += OnFindButtonClicked;
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
                Time = 0;
                Seconds = 5;
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
                CloseButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                FindButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                SelectButton.ForeColor = Color.FromArgb( 106, 189, 252 );
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
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex"> The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        /// <summary>
        /// Populates the ListBox.
        /// </summary>
        private protected virtual void PopulateListBox( )
        {
            if( DirPaths?.Any( ) == true )
            {
                try
                {
                    foreach( var _path in DirPaths )
                    {
                        FileList.Items.Add( _path );
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Gets the ListView paths.
        /// </summary>
        /// <returns> </returns>
        private protected IEnumerable<string> GetListViewPaths( )
        {
            if( InitialDirPaths?.Any( ) == true )
            {
                try
                {
                    var _list = new List<string>( );
                    var _paths = new Dictionary<string, string>( );
                    foreach( var _dirPath in InitialDirPaths )
                    {
                        var _dirs = Directory.GetDirectories( _dirPath );
                        for( var _index = 0; _index < _dirs.Length; _index++ )
                        {
                            var _dir = _dirs[ _index ];
                            if( !_dir.Contains( "My " ) )
                            {
                                var _name = Path.GetDirectoryName( _dir );
                                var _dirpath = Path.GetFullPath( _dir );
                                if( _name != null )
                                {
                                    _paths.Add( _name, _dirpath );
                                }

                                var _second = Directory.GetDirectories( _dirpath );
                                if( _second?.Any( ) == true )
                                {
                                    _list.AddRange( _second );
                                }

                                var _subDir = Directory.GetDirectories( _dir );
                                for( var _i = 0; _i < _subDir.Length; _i++ )
                                {
                                    var _path = _subDir[ _i ];
                                    if( !string.IsNullOrEmpty( _path ) )
                                    {
                                        var _last = Directory.GetDirectories( _path );
                                        if( _last?.Any( ) == true )
                                        {
                                            _list.AddRange( _last );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( IEnumerable<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Called when [path selected].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        private protected virtual void OnPathSelected( object sender )
        {
            if( sender is ListBox _listBox
               && !string.IsNullOrEmpty( _listBox.SelectedItem?.ToString( ) ) )
            {
                try
                {
                    SelectedPath = _listBox.SelectedItem?.ToString( );
                    MessageLabel.Text = SelectedPath;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [find button clicked].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private protected virtual void OnFindButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button )
            {
                try
                {
                    Dialog = new FolderBrowserDialog( );
                    Dialog.ShowDialog( );
                    var _selectedPath = Dialog.SelectedPath;
                    if( !string.IsNullOrEmpty( _selectedPath ) )
                    {
                        SelectedPath = _selectedPath;
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender"> The sender. </param>
        /// <param name="e">
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private protected virtual void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button )
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
    }
}
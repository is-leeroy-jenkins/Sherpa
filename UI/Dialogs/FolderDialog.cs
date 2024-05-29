// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 2-20-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        2-20-2024
// ******************************************************************************************
// <copyright file="FolderDialog.cs" company="Terry D. Eppler">
//    Sherpa is a Federal Budget, Finance, and Accounting application
//    for analysts with the US Environmental Protection Agency (US EPA).
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
//    Contact at:  terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   FolderDialog.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "LoopCanBePartlyConvertedToQuery" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    public partial class FolderDialog : MetroForm
    {
        /// <summary>
        /// The dir paths
        /// </summary>
        private IList<string> _dirPaths;

        /// <summary>
        /// The locked object
        /// </summary>
        private protected object _path;

        /// <summary>
        /// The busy
        /// </summary>
        private protected bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private protected Action _statusUpdate;

        /// <summary>
        /// The time
        /// </summary>
        private protected int _time;

        /// <summary>
        /// The count
        /// </summary>
        private protected int _count;

        /// <summary>
        /// The seconds
        /// </summary>
        private protected int _seconds;

        /// <summary>
        /// The duration
        /// </summary>
        private protected double _duration;

        /// <summary>
        /// The data
        /// </summary>
        private protected string _data;

        /// <summary>
        /// The selected path
        /// </summary>
        private protected string _selectedPath;

        /// <summary>
        /// The selected file
        /// </summary>
        private protected string _selectedFile;

        /// <summary>
        /// The initial directory
        /// </summary>
        private protected string _initialDirectory;

        /// <summary>
        /// The file paths
        /// </summary>
        private protected IList<string> _filePaths;

        /// <summary>
        /// The initial dir paths
        /// </summary>
        private protected IList<string> _searchPaths;

        /// <summary>
        /// The radio buttons
        /// </summary>
        private protected IList<RadioButton> _radioButtons;

        /// <summary>
        /// The image
        /// </summary>
        private protected Bitmap _image;

        /// <summary>
        /// Gets or sets the initial dir paths.
        /// </summary>
        /// <value>
        /// The initial dir paths.
        /// </value>
        public IList<string> SearchPaths
        {
            get
            {
                return _searchPaths;
            }
            private protected set
            {
                _searchPaths = value;
            }
        }

        /// <summary>
        /// Gets or sets the radio buttons.
        /// </summary>
        /// <value>
        /// The radio buttons.
        /// </value>
        public IList<RadioButton> RadioButtons
        {
            get
            {
                return _radioButtons;
            }
            private protected set
            {
                _radioButtons = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected path.
        /// </summary>
        /// <value>
        /// The selected path.
        /// </value>
        public string SelectedPath
        {
            get
            {
                return _selectedPath;
            }
            private protected set
            {
                _selectedPath = value;
            }
        }

        /// <summary>
        /// Gets or sets the initial dir paths.
        /// </summary>
        /// <value>
        /// The initial dir paths.
        /// </value>
        public IList<string> InitialDirPaths
        {
            get
            {
                return _searchPaths;
            }
            private protected set
            {
                _searchPaths = value;
            }
        }

        /// <summary>
        /// Gets or sets the file paths.
        /// </summary>
        /// <value>
        /// The file paths.
        /// </value>
        public IList<string> DirPaths
        {
            get
            {
                return _dirPaths;
            }
            private protected set
            {
                _dirPaths = value;
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:Sherpa.FolderDialog"/>
        /// class.
        /// </summary>
        public FolderDialog( ) 
            : base( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Form Settings
            Size = new Size( 700, 480 );
            MaximumSize = new Size( 700, 480 );
            MinimumSize = new Size( 700, 480 );
            Padding = new Padding( 1 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            WindowState = FormWindowState.Normal;
            SizeGripStyle = SizeGripStyle.Hide;
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
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
            DoubleBuffered = true;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ControlBox = false;

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Budget Properties
            _searchPaths = CreateInitialSearchPaths( );
            _dirPaths = GetListViewFolderPaths( );

            // Wire Events
            Load += OnLoad;
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
        /// Initializes the timer.
        /// </summary>
        private void InitializeTimer( )
        {
            try
            {
                // Timer Properties
                Timer.Interval = 80;
                Timer.Tick += OnTimerTick;
                Timer.Enabled = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the PictureBox.
        /// </summary>
        private void InitializePictureBox( )
        {
            try
            {
                PictureBox.Size = new Size( 20, 18 );
                PictureBox.Padding = new Padding( 1 );
                PictureBox.Margin = new Padding( 1 );
                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
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
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        private protected void InvokeIf( Action action )
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
        /// Populates the ListBox.
        /// </summary>
        private protected virtual void PopulateListBox( )
        {
            try
            {
                if( _dirPaths?.Any( ) == true )
                {
                    foreach( var _folder in _dirPaths )
                    {
                        FileList.Items.Add( _folder );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the initial dir paths.
        /// </summary>
        /// <returns>
        /// IList(string)
        /// </returns>
        private protected IList<string> CreateInitialSearchPaths( )
        {
            try
            {
                var _current = Environment.CurrentDirectory;
                var _list = new List<string>
                {
                    Environment.GetFolderPath( Environment.SpecialFolder.DesktopDirectory ),
                    Environment.GetFolderPath( Environment.SpecialFolder.Personal ),
                    Environment.GetFolderPath( Environment.SpecialFolder.Recent ),
                    @"C:\Users\terry\source\repos\Sherpa\Resources\Documents",
                    _current
                };

                return _list?.Any( ) == true
                    ? _list
                    : default( IList<string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the ListView paths.
        /// </summary>
        /// <returns> </returns>
        private protected IList<string> GetListViewFolderPaths( )
        {
            if( _searchPaths?.Any( ) == true )
            {
                try
                {
                    _dirPaths = new List<string>( );
                    foreach( var _dirPath in _searchPaths )
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
                                    _dirPaths.Add( _dirpath );
                                }

                                var _second = Directory.GetDirectories( _dirpath );
                                if( _second?.Any( ) == true )
                                {
                                    _dirPaths.AddRange( _second );
                                }

                                var _subDir = Directory.GetDirectories( _dir );
                                for( var _i = 0; _i < _subDir.Length; _i++ )
                                {
                                    var _directory = _subDir[ _i ];
                                    if( !string.IsNullOrEmpty( _directory ) )
                                    {
                                        var _last = Directory.GetDirectories( _directory );
                                        if( _last?.Any( ) == true )
                                        {
                                            _dirPaths.AddRange( _last );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _dirPaths?.Any( ) == true
                        ? _dirPaths
                        : default( IList<string> );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( IList<string> );
                }
            }

            return default( IList<string> );
        }

        /// <summary>
        /// Clears the radio buttons.
        /// </summary>
        private protected void ClearRadioButtons( )
        {
            try
            {
                foreach( var _radioButton in _radioButtons )
                {
                    _radioButton.CheckedChanged += null;
                    _radioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
                }
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
        private protected IEnumerable<Control> GetControls( )
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
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _now = DateTime.Now;
                StatusLabel.Text = $"{_now.ToLongTimeString( )}";
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
            try
            {
                InitializeTimer( );
                InitializeLabels( );
                InitializeButtons( );
                PopulateListBox( );
                Timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
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
                    _selectedPath = _listBox.SelectedItem?.ToString( );
                    MessageLabel.Text = _selectedPath;
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
                    FolderBrowser = new FolderBrowserDialog( );
                    FolderBrowser.ShowDialog( );
                    _selectedPath = FolderBrowser.SelectedPath;
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
        private protected void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button )
            {
                try
                {
                    Timer?.Dispose( );
                    Close( );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
            try
            {
                InvokeIf( _statusUpdate );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
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
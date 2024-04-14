// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-15-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-15-2024
// ******************************************************************************************
// <copyright file="FileDialog.cs" company="Terry D. Eppler">
//    Budget Execution is a Federal Budget, Finance, and Accounting application
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
//   FileDialog.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using static System.Environment;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantBaseConstructorCall" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Global" ) ]
    public partial class FileDialog : MetroForm
    {
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
        /// The file extension
        /// </summary>
        private protected string _fileExtension;

        /// <summary>
        /// The extension
        /// </summary>
        private protected EXT _extension;

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
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public EXT Extension
        {
            get
            {
                return _extension;
            }
            private protected set
            {
                _extension = value;
            }
        }

        /// <summary>
        /// Gets or sets the file extension.
        /// </summary>
        /// <value>
        /// The file extension.
        /// </value>
        public string FileExtension
        {
            get
            {
                return _fileExtension;
            }
            private protected set
            {
                _fileExtension = value;
            }
        }

        /// <summary>
        /// Gets or sets the initial dir paths.
        /// </summary>
        /// <value>
        /// The initial dir paths.
        /// </value>
        public IList<string> SearhPaths
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
        public IList<string> FilePaths
        {
            get
            {
                return _filePaths;
            }
            private protected set
            {
                _filePaths = value;
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
        /// Gets or sets the selected file.
        /// </summary>
        /// <value>
        /// The selected file.
        /// </value>
        public string SelectedFile
        {
            get
            {
                return _selectedFile;
            }
            private protected set
            {
                _selectedFile = value;
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
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        return _busy;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        return _busy;
                    }
                }
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FileDialog" /> class.
        /// </summary>
        public FileDialog( ) 
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
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
            _extension = EXT.XLSX;
            _fileExtension = _extension.ToString( ).ToLower( );
            _radioButtons = GetRadioButtons( );
            _searchPaths = CreateInitialDirectoryPaths( );
            _filePaths = new List<string>( );

            // Event Wiring
            Load += OnLoad;
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FileDialog" /> class.
        /// </summary>
        /// <param name="extension">The extension.</param>
        public FileDialog( EXT extension ) 
            : this( )
        {
            // Budget Properties
            _extension = extension;
            _fileExtension = _extension.ToString( ).ToLower( );
            _radioButtons = GetRadioButtons( );
            _searchPaths = CreateInitialDirectoryPaths( );
            _filePaths = GetFilePaths( );
            _count = _filePaths.Count;

            // Event Wiring
            Load += OnLoad;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                FileListBox.SelectedValueChanged += OnListBoxItemSelected;
                BrowseButton.Click += OnBrowseButtonClicked;
                CloseButton.Click += OnCloseButtonClicked;
                Timer.Tick += OnTimerTick;
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
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                // Title Properties
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
                Title.Text = $"{_extension} File Search";

                // Found Label Proerties
                var _nl = Environment.NewLine;
                FoundLabel.Font = new Font( "Roboto", 8 );
                FoundLabel.Text = "Found: " + $"{_count:N1} files" + _nl
                    + "Time: " + $"{_duration:N1} ms";
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
                BrowseButton.Text = "Browse";
                BrowseButton.HoverText = "Search File System";
                BrowseButton.ForeColor = Color.FromArgb( 106, 189, 252 );
                SelectButton.Text = "Ok";
                SelectButton.HoverText = "Select";
                CloseButton.Text = "Close";
                CloseButton.HoverText = "Close Window";
                CloseButton.ForeColor = Color.FromArgb( 106, 189, 252 );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the dialogs.
        /// </summary>
        private void InitializeDialogs( )
        {
            try
            {
                OpenDialog.Title = "Browse File System";
                OpenDialog.InitialDirectory = Environment.CurrentDirectory;
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
        /// Initializes the radios.
        /// </summary>
        private void InitializeRadioButtons( )
        {
            try
            {
                switch( _extension )
                {
                    case EXT.XLSX:
                    {
                        foreach( var _button in _radioButtons )
                        {
                            _button.Visible = true;
                        }

                        break;
                    }
                    default:
                    {
                        foreach( var _button in _radioButtons )
                        {
                            _button.Visible = false;
                        }

                        break;
                    }
                }
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
        /// Begins the initialize.
        /// </summary>
        private void BeginInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = true;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Ends the initialize.
        /// </summary>
        private void EndInit( )
        {
            try
            {
                if( _path == null )
                {
                    _path = new object( );
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
                else
                {
                    lock( _path )
                    {
                        _busy = false;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the ListBox.
        /// </summary>
        private protected void PopulateListBox( )
        {
            try
            {
                FileListBox.Items?.Clear( );
                if( _filePaths?.Any( ) == true )
                {
                    foreach( var _item in _filePaths )
                    {
                        FileListBox.Items.Add( _item );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Populates the ListBox.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        private protected void PopulateListBox( IEnumerable<string> filePaths )
        {
            try
            {
                ThrowIf.Null( filePaths, nameof( filePaths ) );
                FileListBox.Items?.Clear( );
                var _paths = filePaths.ToArray( );
                for( var _i = 0; _i < _paths.Length; _i++ )
                {
                    var _item = _paths[ _i ];
                    if( !string.IsNullOrEmpty( _item ) )
                    {
                        FileListBox?.Items?.Add( _item );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the RadioButton events.
        /// </summary>
        private protected void RegisterRadioButtonEvents( )
        {
            try
            {
                foreach( var _radioButton in _radioButtons )
                {
                    _radioButton.CheckedChanged += OnRadioButtonSelected;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the extension.
        /// </summary>
        private void SetImage( )
        {
            try
            {
                switch( _extension )
                { 
                    case EXT.XLS:
                    case EXT.XLSX:
                    {
                        ExcelRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.XLSX;
                        break;
                    }
                    case EXT.PDF:
                    {
                        PdfRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.PDF;
                        break;
                    }
                    case EXT.CSV:
                    {
                        CsvRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.CSV;
                        break;
                    }
                    case EXT.PPT:
                    {
                        PowerPointRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.PPTX;
                        break;
                    }
                    case EXT.MDB:
                    case EXT.ACCDB:
                    {
                        AccessRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.ACCDB;
                        break;
                    }
                    case EXT.DB:
                    {
                        SQLiteRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.DB;
                        break;
                    }
                    case EXT.DLL:
                    {
                        LibraryRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.DLL;
                        break;
                    }
                    case EXT.DOC:
                    case EXT.DOCX:
                    {
                        WordRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.DOCX;
                        break;
                    }
                    case EXT.EXE:
                    {
                        ExecutableRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.EXE;
                        break;
                    }
                    case EXT.MDF:
                    {
                        SqlServerRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.MDF;
                        break;
                    }
                    case EXT.SDF:
                    {
                        SqlCeRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.SDF;
                        break;
                    }
                    case EXT.TXT:
                    {
                        TextRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.TXT;
                        break;
                    }
                    default:
                    {
                        ExcelRadioButton.Checked = true;
                        _image = Resources.Images.ExtensionImages.XLSX;
                        break;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        private protected virtual IList<RadioButton> GetRadioButtons( )
        {
            try
            {
                var _list = new List<RadioButton>
                {
                    PdfRadioButton,
                    AccessRadioButton,
                    SQLiteRadioButton,
                    SqlCeRadioButton,
                    SqlServerRadioButton,
                    ExcelRadioButton,
                    CsvRadioButton,
                    TextRadioButton,
                    PowerPointRadioButton,
                    WordRadioButton,
                    ExecutableRadioButton,
                    LibraryRadioButton
                };

                return _list?.Any( ) == true
                    ? _list
                    : default( IList<RadioButton> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<RadioButton> );
            }
        }
        
        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns></returns>
        private protected Image GetImage( )
        {
            if( !string.IsNullOrEmpty( _fileExtension ) )
            {
                try
                {
                    var _filePath = ConfigurationManager.AppSettings[ "ExtensionImages" ];
                    if( _filePath != null )
                    {
                        var _files = Directory.GetFiles( _filePath );
                        if( _files?.Any( ) == true )
                        {
                            var _ext = _fileExtension.TrimStart( '.' ).ToUpper( );
                            var _file = _files
                                ?.Where( f => f.Contains( _ext ) )
                                ?.First( );

                            var _stream = File.Open( _file, FileMode.Open );
                            var _img = Image.FromStream( _stream );
                            return new Bitmap( _img, 20, 18 );
                        }
                    }
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                    return default( Bitmap );
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Gets the ListView paths.
        /// </summary>
        /// <returns></returns>
        private protected void CreateListViewFilePaths( )
        {
            try
            {
                _filePaths?.Clear( );
                var _pattern = "*." + _fileExtension;
                for( var _i = 0; _i < _searchPaths.Count; _i++ )
                {
                    var _dirPath = _searchPaths[ _i ];
                    var _parent = Directory.CreateDirectory( _dirPath );
                    var _folders = _parent.GetDirectories( )
                        ?.Where( s => s.Name.Contains( "My" ) == false )
                        ?.Select( s => s.FullName )
                        ?.ToList( );
                    
                    var _topLevelFiles = _parent.GetFiles( _pattern, SearchOption.TopDirectoryOnly )
                        ?.Select( f => f.FullName )
                        ?.ToArray( );
                    
                    _filePaths.AddRange( _topLevelFiles );
                    for( int _k = 0; _k < _folders.Count; _k++ )
                    {
                        var _folder = Directory.CreateDirectory( _folders[ _k ] );
                        var _lowerLevelFiles = _folder.GetFiles( _pattern, SearchOption.AllDirectories )
                            ?.Select( s => s.FullName )
                            ?.ToArray( );
                        
                        _filePaths.AddRange( _lowerLevelFiles );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the file paths.
        /// </summary>
        /// <returns></returns>
        private protected IList<string> GetFilePaths( )
        {
            try
            {
                BeginInit( );
                var _watch = new Stopwatch( );
                _watch.Start( );
                var _list = new List<string>( );
                var _pattern = "*" + _fileExtension;
                for( var _i = 0; _i < _searchPaths.Count; _i++ )
                {
                    var _dirPath = _searchPaths[ _i ];
                    var _parent = Directory.CreateDirectory( _dirPath );
                    var _folders = _parent.GetDirectories( )
                        ?.Where( s => s.Name.StartsWith( "My" ) == false )
                        ?.Select( s => s.FullName )
                        ?.ToList( );

                    var _topLevelFiles = _parent.GetFiles( _pattern, SearchOption.TopDirectoryOnly )
                        ?.Select( f => f.FullName )
                        ?.ToArray( );

                    _list.AddRange( _topLevelFiles );
                    for( int _k = 0; _k < _folders.Count; _k++ )
                    {
                        var _folder = Directory.CreateDirectory( _folders[ _k ] );
                        var _lowerLevelFiles = _folder.GetFiles( _pattern, SearchOption.AllDirectories )
                            ?.Select( s => s.FullName )
                            ?.ToArray( );

                        _list.AddRange( _lowerLevelFiles );
                    }
                }

                EndInit( );
                _watch.Stop( );
                _duration = _watch.Elapsed.TotalMilliseconds;
                return _list;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IList<string> );
            }
        }

        /// <summary>
        /// Gets the initial dir paths.
        /// </summary>
        /// <returns>
        /// IList(string)
        /// </returns>
        private protected IList<string> CreateInitialDirectoryPaths( )
        {
            try
            {
                var _current = CurrentDirectory;
                var _list = new List<string>
                {
                    GetFolderPath( SpecialFolder.DesktopDirectory ),
                    GetFolderPath( SpecialFolder.Personal ),
                    GetFolderPath( SpecialFolder.Recent ),
                    Environment.CurrentDirectory,
                    @"C:\Users\terry\source\repos\BudgetExecution\Resources\Documents",
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                PopulateListBox( );
                InitializeLabels( );
                InitializeButtons( );
                InitializeDialogs( );
                InitializeTimer( );
                InitializeRadioButtons( );
                RegisterRadioButtonEvents( );
                SetImage( );
                Timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [RadioButton selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private protected void OnRadioButtonSelected( object sender )
        {
            try
            {
                var _radioButton = sender as RadioButton;
                _fileExtension = _radioButton?.Result;
                var _filePath = ConfigurationManager.AppSettings[ "ExtensionImages" ];
                var _ext = _radioButton.Tag?.ToString( )
                    ?.Trim( ".".ToCharArray( ) )
                    ?.ToUpper( );

                _filePaths = GetFilePaths( );
                _count = _filePaths.Count;
                PopulateListBox( _filePaths );
                Title.Text = $"{_ext} File Search";
                var _nl = Environment.NewLine;
                FoundLabel.Text = $"Found: {_count} files" + _nl + $"Time: {_duration} ms";
                PictureBox.ImageLocation = _filePath + $@"\{_ext.ToUpper( )}.png";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [path selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        private protected virtual void OnListBoxItemSelected( object sender )
        {
            if( sender is ListBox _listBox
               && !string.IsNullOrEmpty( _listBox.SelectedItem?.ToString( ) ) )
            {
                try
                {
                    _selectedPath = _listBox.SelectedItem?.ToString( );
                    PathLabel.Text = _selectedPath;
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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected virtual void OnBrowseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                OpenDialog.DefaultExt = _fileExtension;
                OpenDialog.CheckFileExists = true;
                OpenDialog.CheckPathExists = true;
                OpenDialog.Multiselect = false;
                var _ext = _fileExtension.ToLower( );
                OpenDialog.Filter = $@"File Extension | *{_ext}";
                OpenDialog.Title = $@"Search Directories for *{_ext} files...";
                OpenDialog.InitialDirectory = GetFolderPath( SpecialFolder.DesktopDirectory );
                OpenDialog.ShowDialog( );
                _selectedPath = OpenDialog.FileName;
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

        /// <summary>
        /// Called when [clear button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private protected virtual void OnClearButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button )
            {
                try
                {
                    PathLabel.Text = string.Empty;
                    FileListBox.SelectedValue = string.Empty;
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
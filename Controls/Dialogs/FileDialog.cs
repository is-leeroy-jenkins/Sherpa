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
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
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
    public partial class FileDialog : DialogBase
    {
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FileDialog" /> class.
        /// </summary>
        public FileDialog( ) 
            : base( )
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
            _searchPaths = CreateInitialDirectoryPaths( );
            _filePaths = CreateListViewFilePaths( );
            _radioButtons = GetRadioButtons( );

            // Event Wiring
            Load += OnLoad;
            Activated += OnActivated;
            FormClosing += OnFormClosing;
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
            _extension = extension;
            _fileExtension = _extension.ToString( ).ToLower( );
            _searchPaths = CreateInitialDirectoryPaths( );
            _filePaths = CreateListViewFilePaths( );
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                FileList.SelectedValueChanged += OnListBoxItemSelected;
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
        /// Updates the status.
        /// </summary>
        private void UpdateStatus( )
        {
            try
            {
                var _now = DateTime.Now;
                MessageLabel.Text = $"{_now.ToShortDateString( )} - {_now.ToLongTimeString( )}";
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
                if( _filePaths?.Any( ) == true )
                {
                    FileList.Items?.Clear( );
                    foreach( var _path in _filePaths )
                    {
                        FileList.Items.Add( _path );
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
                FileList.Items?.Clear( );
                var _paths = filePaths.ToArray( );
                for( var _i = 0; _i < _paths.Length; _i++ )
                {
                    var _path = _paths[ _i ];
                    if( !string.IsNullOrEmpty( _path ) )
                    {
                        FileList?.Items?.Add( _path );
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
                        _image = Resources.Images.ExtensionImages.XLSX;
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                _filePaths = CreateListViewFilePaths( );
                FoundLabel.Text = "Found : " + _filePaths?.Count ?? "0";
                Title.Text = $"{_extension} File Search";
                InitializeLabels( );
                InitializeButtons( );
                InitializeDialogs( );
                InitializeTimer( );
                RegisterRadioButtonEvents( );
                SetImage( );
                InitializeRadioButtons( );
                PopulateListBox( );
                FadeInAsync( this );
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
        private protected virtual void OnRadioButtonSelected( object sender )
        {
            try
            {
                var _radioButton = sender as RadioButton;
                _fileExtension = _radioButton?.Result;
                var _path = ConfigurationManager.AppSettings[ "ExtensionImages" ];
                var _ext = _radioButton.Tag?.ToString( )
                    ?.Trim( ".".ToCharArray( ) )
                    ?.ToUpper( );

                _filePaths = CreateListViewFilePaths( );
                Title.Text = $"{_ext} File Search";
                FoundLabel.Text = "Found: " + _filePaths?.ToList( )?.Count ?? "0";
                PopulateListBox( );
                PictureBox.ImageLocation = _path + $@"\{_ext.ToUpper( )}.png";
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
                    MessageLabel.Text = string.Empty;
                    FileList.SelectedValue = string.Empty;
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
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnActivated( object sender, EventArgs e )
        {
            try
            {
                Opacity = 0;
                FadeInAsync( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}
// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 2-26-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        2-26-2024
// ******************************************************************************************
// <copyright file="DocViewer.cs" company="Terry D. Eppler">
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
//    Contact at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   DocViewer.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    public partial class DocViewer : MetroForm
    {
        /// <summary>
        /// The locked object
        /// </summary>
        private object _path;

        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The status update
        /// </summary>
        private System.Action _statusUpdate;

        /// <summary>
        /// The data arguments
        /// </summary>
        private DataArgs _dataArgs;

        /// <summary>
        /// 
        /// </summary>
        private int _time;

        /// <summary>
        /// 
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The source
        /// </summary>
        private Source _source;

        /// <summary>
        /// The provider
        /// </summary>
        private Provider _provider;

        /// <summary>
        /// The ext
        /// </summary>
        private EXT _extension;

        /// <summary>
        /// The SQL command
        /// </summary>
        private string _sqlQuery;

        /// <summary>
        /// The selected path
        /// </summary>
        private string _selectedPath;

        /// <summary>
        /// The filter
        /// </summary>
        private IDictionary<string, string> _documents;

        /// <summary>
        /// The filter
        /// </summary>
        private IDictionary<string, object> _filter;

        /// <summary>
        /// The data model
        /// </summary>
        private DataBuilder _dataModel;

        /// <summary>
        /// The data table
        /// </summary>
        private DataTable _dataTable;

        /// <summary>
        /// The prefix
        /// </summary>
        private string _prefix;
        
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

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery
        {
            get
            {
                return _sqlQuery;
            }
            private protected set
            {
                _sqlQuery = value;
            }
        }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel
        {
            get
            {
                return _dataModel;
            }
            private protected set
            {
                _dataModel = value;
            }
        }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            private protected set
            {
                _dataTable = value;
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
        /// Gets or sets the prefix.
        /// </summary>
        /// <value>
        /// The prefix.
        /// </value>
        public string Prefix
        {
            get
            {
                return _prefix;
            }
            private protected set
            {
                _prefix = value;
            }
        }

        /// <summary>
        /// Gets or sets the source.
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
        /// Gets or sets the provider.
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
        /// Gets or sets the extenstion.
        /// </summary>
        /// <value>
        /// The extenstion.
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
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>
        /// The selected item.
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

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="T:BudgetExecution.DocViewer" /> class.
        /// </summary>
        public DocViewer( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
            MaximumSize = new Size( 1920, 1080 );
            MinimumSize = new Size( 1330, 730 );
            Size = new Size( 1340, 740 );
            Padding = new Padding( 1 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            SizeGripStyle = SizeGripStyle.Auto;
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 3;
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

            // Initialize Default Provider
            _source = Source.Resources;
            _provider = Provider.Access;

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Budget Collections
            _filter = new Dictionary<string, object>( );
            _dataArgs = new DataArgs( );

            // Form Event Wiring
            Load += OnLoad;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// Registers the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                CloseButton.Click += OnExitButtonClicked;
                MenuButton.Click += OnMenuButtonClicked;
                RefreshButton.Click += OnRefreshButtonClick;
                BrowseButton.Click += OnFileBrowserClick;
                LookupButton.Click += OnLookupButtonClick;
                TextBox.MouseEnter += OnTextBoxEnter;
                TextBox.MouseLeave += OnTextBoxLeave;
                Timer.Tick += OnTimerTick;
                Title.MouseClick += OnRightClick;
                DocumentTable.MouseClick += OnRightClick;
                Title.MouseClick += OnRightClick;
                GuidancePanel.MouseClick += OnRightClick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the icon.
        /// </summary>
        private void InitializeFlowPanel( )
        {
            try
            {
                ButtonPanel.FlowDirection = FlowDirection.TopDown;
                ButtonPanel.WrapContents = false;
                ButtonPanel.AutoScroll = true;
                ButtonPanel.BackColor = Color.FromArgb( 5, 5, 5 );
                ButtonPanel.BorderStyle = BorderStyle.FixedSingle;
                ButtonPanel.Margin = new Padding( 1 );
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
                ToolStrip.Visible = true;
                ToolStrip.Text = string.Empty;
                ToolStrip.VisualStyle = ToolStripExStyle.Office2016DarkGray;
                ToolStrip.Office12Mode = true;
                ToolStrip.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                ToolStrip.LauncherStyle = LauncherStyle.Office12;
                ToolStrip.ImageSize = new Size( 16, 16 );
                ToolStrip.ImageScalingSize = new Size( 16, 16 );
                TextBox.TextBox.Font = new Font( "Roboto", 9 );
                TextBox.TextBox.Size = new Size( 180, 25 );
                TextBox.TextBox.ForeColor = Color.White;
                TextBox.TextBox.Text = "     < Enter Keywords >     ";
                TextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the PictureBox.
        /// </summary>
        private void InitializeIcon( )
        {
            try
            {
                PictureBox.Size = new Size( 18, 16 );
                PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the title.
        /// </summary>
        private void InitializeTitle( )
        {
            try
            {
                Title.Font = new Font( "Roboto", 10 );
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
                Title.Text = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the viewer.
        /// </summary>
        private void InitializeViewer( )
        {
            try
            {
                PdfViewer.VisualStyle = VisualStyle.Office2016Black;
                PdfViewer.IsBookmarkEnabled = true;
                PdfViewer.IsTextSelectionEnabled = true;
                PdfViewer.ShowHorizontalScrollBar = true;
                PdfViewer.ShowVerticalScrollBar = true;
                PdfViewer.IsTextSearchEnabled = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the list boxes.
        /// </summary>
        private void InitializeButtons( )
        {
            try
            {
                _documents = CreatePaths( );
                foreach( var _name in _documents.Keys )
                {
                    var _button = new Button( );
                    _button.Padding = new Padding( 3 );
                    _button.Margin = new Padding( 3 );
                    _button.Size = new Size( 250, 42 );
                    _button.Tag = _name;
                    _button.Text = _name.SplitPascal( );
                    _button.Click += OnDocumentSelected;
                    ButtonPanel.Controls.Add( _button );
                }
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
        /// Initializes the PictureBox.
        /// </summary>
        private void InitializePictureBox( )
        {
            try
            {
                PictureBox.Size = new Size( 18, 18 );
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
        /// Invokes if needed.
        /// </summary>
        /// <param name="action">The action.</param>
        public void InvokeIf( System.Action action )
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
        /// Binds the data.
        /// </summary>
        private void BindData( )
        {
            try
            {
                var _criteria = new Dictionary<string, object>
                {
                    {
                        "Type", "DOCUMENT"
                    }
                };

                _dataModel = new DataBuilder( _source, _provider, _criteria );
                _dataTable = _dataModel.DataTable;
                _documents = CreatePaths( );
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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                _selectedPath = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Clears the data.
        /// </summary>
        public void ClearViewer( )
        {
            try
            {
                if( PdfViewer.IsDocumentLoaded )
                {
                    PdfViewer.Unload( );
                    Title.Text = string.Empty;
                    _selectedPath = string.Empty;
                }
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
        /// Sends the notification.
        /// </summary>
        /// <param name="message">The message.</param>
        private void PostMessage( string message )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                var _notification = new SplashMessage( message );
                _notification.Show( );
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
                StatusLabel.Text = 
                    $"{_now.ToShortDateString( )} - {_now.ToLongTimeString( )}";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the main form.
        /// </summary>
        private void OpenMainForm( )
        {
            try
            {
                var _form = (MainForm)Program.Windows[ nameof( MainForm ) ];
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.TopMost = true;
                _form.Visible = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the document paths.
        /// </summary>
        /// <returns>
        /// IDictionary
        /// </returns>
        private IDictionary<string, string> CreatePaths( )
        {
            try
            {
                var _names = Enum.GetNames( typeof( Guidance ) );
                var _documentPaths = new Dictionary<string, string>( );
                for( int _i = 0; _i < _names.Length; _i++ )
                {
                    var _query = new Dictionary<string, object> 
                    {
                        {
                            "Identifier", _names[ _i ]
                        }
                    };

                    var _row = _dataTable?.Filter( _query )
                        ?.FirstOrDefault( );

                    var _location = _row?[ "Location" ].ToString( );
                    _documentPaths.Add( _names[ _i ], _location );
                }

                return ( _documentPaths?.Any( ) == true )
                    ? _documentPaths
                    : default( IDictionary<string, string> );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IDictionary<string, string> );
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
                BindData( );
                InitializeTitle( );
                InitializeViewer( );
                InitializeFlowPanel( );
                InitializeButtons( );
                InitializeIcon( );
                InitializeToolStrip( );
                InitializeTimer( );
                InitializePictureBox( );
                Opacity = 0;
                FadeInAsync( this );
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
        /// Called when [exit button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnExitButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Application.Exit( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [main menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
                OpenMainForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [select button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// nstance containing the event data.</param>
        private void OnDocumentSelected( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as Button;
                var _tag = _button?.Tag.ToString( );
                if( string.IsNullOrEmpty( _tag ) )
                {
                    var _message = "Select a document to view!";
                    var _notification = new SplashMessage( _message );
                    _notification.Show( );
                }
                else
                {
                    _selectedPath = _documents[ _tag ];
                    Title.TextAlign = ContentAlignment.TopCenter;
                    Title.Text = _tag.SplitPascal( );
                    PdfViewer.Load( _selectedPath );
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="MouseEventArgs"/>
        /// instance containing the event data.</param>
        private void OnRightClick( object sender, MouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                    ContextMenu.Show( this, e.Location );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Called when [file browser click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFileBrowserClick( object sender, EventArgs e )
        {
            try
            {
                var _browser = new FileDialog( EXT.PDF );
                _browser.ShowDialog( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [refresh button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnRefreshButtonClick( object sender, EventArgs e )
        {
            try
            {
                ClearViewer( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [lookup button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLookupButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _message = "NOT YET IMPLEMENTED!";
                var _notification = new Notification( _message );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [text box enter].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTextBoxEnter( object sender, EventArgs e )
        {
            try
            {
                var _textBox = sender as ToolStripTextBox;
                if( !string.IsNullOrEmpty( _textBox.Text ) )
                {
                    _textBox.Text = string.Empty;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [text box leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTextBoxLeave( object sender, EventArgs e )
        {
            try
            {
                var _textBox = sender as ToolStripTextBox;
                if( string.IsNullOrEmpty( _textBox.Text ) )
                {
                    _textBox.Text = "     < Enter Keywords >     ";
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
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

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
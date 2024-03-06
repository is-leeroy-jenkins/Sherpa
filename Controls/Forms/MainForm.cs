// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 1-6-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        1-6-2024
// ******************************************************************************************
// <copyright file="MainForm.cs" company="Terry D. Eppler">
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
//    Contact at: terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   MainForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Timer = System.Windows.Forms.Timer;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "RedundantNameQualifier" ) ]
    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// The time
        /// </summary>
        private int _time;

        /// <summary>
        /// The seconds
        /// </summary>
        private int _seconds;

        /// <summary>
        /// The busy
        /// </summary>
        private bool _busy;

        /// <summary>
        /// The delay
        /// </summary>
        private Action _beginLoad;

        /// <summary>
        /// The end load
        /// </summary>
        private Action _endLoad;

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
        /// Gets or sets the tiles.
        /// </summary>
        /// <value>
        /// The tiles.
        /// </value>
        public IEnumerable<Tile> Tiles { get; set; }

        /// <summary>
        /// The loader
        /// </summary>
        private DelayForm _loader;

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.MainForm" /> class.
        /// </summary>
        public MainForm( )
        {
            InitializeComponent( );
            InitializeDelegates( );
            RegisterCallbacks( );

            // Basic Properties
            Name = nameof( MainForm );
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1340, 740 );
            Padding = new Padding( 1 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
            ExitButton.HoverText = "Exit Application";
            Tiles = GetTiles( );

            // Timer Properties
            _time = 0;
            _seconds = 5;

            // Wire Events
            Load += OnLoad;
            Shown += OnShown;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                ExitButton.Click += OnExitButtonClick;
                LookupTile.Click += OnLookupTileClick;
                CalendarTile.Click += OnCalendarTileClick;
                ProgramProjectTile.Click += OnProgramProjectTileClick;
                MessageTile.Click += OnMessageTileClick;
                SqlEditorTile.Click += OnSqlEditorTileClick;
                VisualizationTile.Click += OnVisualizationTileClick;
                ExcelDataTile.Click += OnExcelDataTileClick;
                SQLiteTile.Click += OnSQLiteTileClick;
                SqlCeTile.Click += OnSqlCeTileClick;
                GuidanceTile.Click += OnGuidanceTileClick;
                BrowserTile.Click += OnBrowserTileClick;
                EdgeTile.Click += OnEdgeTileClick;
                ChromeTile.Click += OnChromeTileClick;
                FirefoxTile.Click += OnFirefoxTileClick;
                BrowserTile.Click += OnBrowserTileClick;
                MessageTile.Click += OnMessageTileClick;
                SqlServerTile.Click += OnSqlServerTileClick;
                TestButton.Click += OnTestButtonClick;
                AccessTile.Click += OnAccessTileClick;
                MapTile.Click += OnMapTileClick;
                PivotTile.Click += OnPivotTileClick;
                Timer.Tick += OnTimerTick;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Initializes the tiles.
        /// </summary>
        private void InitializeTiles( )
        {
            try
            {
                if( Tiles?.Any( ) == true )
                {
                    foreach( var _tile in Tiles )
                    {
                        _tile.Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        _tile.Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        _tile.Footer.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        _tile.Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        _tile.BackColor = Color.FromArgb( 40, 40, 40 );
                        _tile.TurnLiveTileOn = true;
                    }
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
                Timer.Enabled = true;
                Timer.Interval = 5000;
                Timer.Tick += OnTimerTick;
                Timer.Start( );
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
                _beginLoad += ShowLoadingForm;
                _endLoad += CloseLoadingForm;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Displays the control to the user.
        /// </summary>
        public new virtual void Show( )
        {
            try
            {
                Opacity = 0;
                if( Seconds != 0 )
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
        /// Sends the notification.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        private void SendNotification( string message )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                var _notify = new Notification( message );
                _notify.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Gets the tiles.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Tile> GetTiles( )
        {
            try
            {
                var _tiles = new List<Tile>( );
                for( var _i = 0; _i < Controls.Count; _i++ )
                {
                    var _control = Controls[ _i ];
                    if( _control.GetType( ) == typeof( Tile ) )
                    {
                        var _tile = _control as Tile;
                        _tiles.Add( _tile );
                    }
                }

                return _tiles?.Any( ) == true
                    ? _tiles
                    : Enumerable.Empty<Tile>( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( IEnumerable<Tile> );
            }
        }

        /// <summary>
        /// Sets the tile text.
        /// </summary>
        private void SetTileText( )
        {
            try
            {
                BrowserTile.Title.Text = "Baby";
                BrowserTile.Body.Text = string.Empty;
                BrowserTile.Banner.Text = string.Empty;
                BrowserTile.HoverText = "Baby Browser";
                ChromeTile.HoverText = "Chrome";
                ChromeTile.Body.Text = string.Empty;
                ChromeTile.Banner.Text = string.Empty;
                ChromeTile.HoverText = "Chrome Web Browser";
                EdgeTile.Title.Text = "Edge";
                EdgeTile.Body.Text = string.Empty;
                EdgeTile.Banner.Text = string.Empty;
                EdgeTile.HoverText = "Edge Browser";
                FirefoxTile.Title.Text = "Firefox";
                FirefoxTile.Body.Text = string.Empty;
                FirefoxTile.Banner.Text = string.Empty;
                FirefoxTile.HoverText = "Firefox Web Browser";
                AccessTile.Title.Text = "Access";
                AccessTile.Body.Text = string.Empty;
                AccessTile.Banner.Text = string.Empty;
                AccessTile.HoverText = "Access Database";
                SQLiteTile.Title.Text = "SQLite";
                SQLiteTile.Body.Text = string.Empty;
                SQLiteTile.Banner.Text = string.Empty;
                SQLiteTile.HoverText = "SQLite Database";
                SqlCeTile.Title.Text = "SQL Compact";
                SqlCeTile.Body.Text = string.Empty;
                SqlCeTile.Banner.Text = string.Empty;
                SqlCeTile.HoverText = "SQL Compact Edition";
                SqlServerTile.Title.Text = "SQL Server";
                SqlServerTile.Body.Text = string.Empty;
                SqlServerTile.Banner.Text = string.Empty;
                SqlServerTile.HoverText = "MS SQL Server";
                LookupTile.Title.Text = "Grids";
                LookupTile.Body.Text = string.Empty;
                LookupTile.Banner.Text = string.Empty;
                LookupTile.HoverText = "Look-Up";
                SqlEditorTile.Title.Text = "SQL";
                SqlEditorTile.Body.Text = string.Empty;
                SqlEditorTile.Banner.Text = string.Empty;
                SqlEditorTile.HoverText = "SQL Editor";
                VisualizationTile.Title.Text = "Charts";
                VisualizationTile.Body.Text = string.Empty;
                VisualizationTile.Banner.Text = string.Empty;
                VisualizationTile.HoverText = "Data Visualization";
                ExcelDataTile.Title.Text = "Excel Data";
                ExcelDataTile.Body.Text = string.Empty;
                ExcelDataTile.Banner.Text = string.Empty;
                ExcelDataTile.HoverText = "Spreadsheet Data";
                GuidanceTile.Title.Text = "Guidance";
                GuidanceTile.Body.Text = string.Empty;
                GuidanceTile.Banner.Text = string.Empty;
                GuidanceTile.HoverText = "Guidance & Documentation";
                ProgramProjectTile.Title.Text = "Program Projects";
                ProgramProjectTile.Body.Text = string.Empty;
                ProgramProjectTile.Banner.Text = string.Empty;
                ProgramProjectTile.HoverText = "Program Descriptions";
                CalendarTile.Title.Text = "Calendar";
                CalendarTile.Body.Text = string.Empty;
                CalendarTile.Banner.Text = string.Empty;
                CalendarTile.HoverText = "Time Series Data";
                MessageTile.Title.Text = "Email";
                MessageTile.Body.Text = string.Empty;
                MessageTile.Banner.Text = string.Empty;
                MessageTile.HoverText = "Send Email Message";
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the SQL client.
        /// </summary>
        private void OpenSqlClient( )
        {
            try
            {
                Minion.RunSqlCe( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the loading form.
        /// </summary>
        private void ShowLoadingForm( )
        {
            try
            {
                BeginInit( );
                _loader = new DelayForm( Status.Processing );
                _loader.StartPosition = FormStartPosition.CenterParent;
                _loader.ShowDialog( this );
                EndInit( );
                Timer.Start( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Closes the loading form.
        /// </summary>
        private void CloseLoadingForm( )
        {
            try
            {
                _loader?.Close( );
                Timer.Stop( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the guidance dialog.
        /// </summary>
        private void ShowGuidanceDialog( )
        {
            try
            {
                var _guidance = new GuidanceDialog( );
                _guidance.StartPosition = FormStartPosition.CenterScreen;
                _guidance.Owner = this;
                _guidance.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the program project dialog.
        /// </summary>
        private void ShowProgramProjectDialog( )
        {
            try
            {
                var _programs = new ProgramProjectDialog( );
                _programs.Owner = this;
                _programs.StartPosition = FormStartPosition.CenterScreen;
                _programs.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the edit dialog.
        /// </summary>
        private void ShowEditDialog( )
        {
            try
            {
                var _editor = new EditPage( );
                _editor.Owner = this;
                _editor.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the lookup dialog.
        /// </summary>
        private void ShowLookupDialog( )
        {
            try
            {
                var _editor = new LookupPage( );
                _editor.Owner = this;
                _editor.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the splash message.
        /// </summary>
        private void SendMessage( string message )
        {
            try
            {
                ThrowIf.Null( message, nameof( message ) );
                var _splash = new SplashMessage( message );
                _splash.Owner = this;
                _splash.TopMost = true;
                _splash.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the sheet form.
        /// </summary>
        private void ShowSheetForm( )
        {
            try
            {
                var _data = new DataBuilder( Source.BudgetContacts );
                var _table = _data.DataTable;
                var _grid = new GridForm( _table );
                _grid.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the path message.
        /// </summary>
        private void ShowPathMessage( )
        {
            try
            {
                var _location = @"C:\Users\terry\Desktop\dev\export";
                var _folder = new Folder( _location );
                var _text = _folder?.ToString( );
                var _message = new MessageDialog( _text );
                _message.Owner = this;
                _message.StartPosition = FormStartPosition.CenterScreen;
                _message.Show( );
                _message.Focus( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the dialogs.
        /// </summary>
        private void ShowDialogs( )
        {
            try
            {
                var _dialog = new FileDialog( );
                _dialog.Owner = this;
                _dialog.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Creates the excel report.
        /// </summary>
        private void CreateExcelReport( )
        {
            try
            {
                var _data = new DataBuilder( Source.StatusOfAppropriations, Provider.Access );
                var _dataTable = _data.DataTable;
                var _report = new ExcelReport( _dataTable );
                _report.Save( );
                var _message = "The Excel File has been created!";
                SendMessage( _message );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the fiscal year form.
        /// </summary>
        private void OpenFiscalYearForm( )
        {
            try
            {
                var _form = new CalendarForm( );
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.Owner = this;
                _form.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the email dialog.
        /// </summary>
        private void ShowEmailDialog( )
        {
            try
            {
                var _dialog = new EmailDialog( );
                _dialog.StartPosition = FormStartPosition.CenterScreen;
                _dialog.Owner = this;
                _dialog.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the chart data form.
        /// </summary>
        private void OpenChartDataForm( )
        {
            try
            {
                var _form = new ChartDataForm( );
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.Owner = this;
                _form.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the document viewer.
        /// </summary>
        private void OpenDocumentViewer( )
        {
            try
            {
                var _form = new DocViewer( );
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.Owner = this;
                _form.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the excel data form.
        /// </summary>
        private void OpenExcelDataForm( )
        {
            try
            {
                var _form = new ExcelDataForm( );
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.Owner = this;
                _form.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the SQL editor.
        /// </summary>
        private void OpenSqlEditor( )
        {
            try
            {
                var _sqlEditor = new SqlDataForm( );
                _sqlEditor.StartPosition = FormStartPosition.CenterScreen;
                _sqlEditor.Owner = this;
                _sqlEditor.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the geo mapper.
        /// </summary>
        private void OpenGeoMapper( )
        {
            try
            {
                var _geoMapper = new GeoMapper( );
                _geoMapper.StartPosition = FormStartPosition.CenterScreen;
                _geoMapper.Owner = this;
                _geoMapper.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the SQL server editor.
        /// </summary>
        private void OpenSqlServerEditor( )
        {
            try
            {
                var _sqlEditor = new SqlEditForm( Provider.SqlServer );
                _sqlEditor.StartPosition = FormStartPosition.CenterScreen;
                _sqlEditor.Owner = this;
                _sqlEditor.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the baby browser.
        /// </summary>
        private void OpenBabyBrowser( )
        {
            try
            {
                var _browser = new WebBrowser( );
                _browser.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the data grid form.
        /// </summary>
        private void OpenDataGridForm( )
        {
            try
            {
                var _dataGridForm = new DataGridForm( );
                _dataGridForm.StartPosition = FormStartPosition.CenterScreen;
                _dataGridForm.Owner = this;
                _dataGridForm.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the calculation form.
        /// </summary>
        private void OpenCalculationForm( )
        {
            try
            {
                var _calculator = new CalculationForm( );
                _calculator.ShowDialog( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the pivot chart form.
        /// </summary>
        private void OpenPivotChartForm( )
        {
            try
            {
                var _pivotChart = new PivotChartForm( );
                _pivotChart.StartPosition = FormStartPosition.CenterScreen;
                _pivotChart.Owner = this;
                _pivotChart.Show( );
                Hide( );
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
        /// Fades the in.
        /// </summary>
        private protected void FadeIn( )
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
        private protected void FadeOut( )
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
        /// Gets the controls.
        /// </summary>
        /// <returns></returns>
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
                    foreach( Control _control in _collection )
                    {
                        _list.Add( _control );
                        _queue.Enqueue( _control.Controls );
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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                InitializeTiles( );
                SetTileText( );
                FadeIn( );
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
        /// Called when [shown].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
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

        /// <summary>
        /// Called when [edge tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnEdgeTileClick( object sender, EventArgs e )
        {
            try
            {
                Minion.RunEdge( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [chrome tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnChromeTileClick( object sender, EventArgs e )
        {
            try
            {
                Minion.RunChrome( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [firefox tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFirefoxTileClick( object sender, EventArgs e )
        {
            try
            {
                Minion.RunFirefox( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [browser tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnBrowserTileClick( object sender, EventArgs e )
        {
            Minion.RunBudgetBrowser( );
        }

        /// <summary>
        /// Called when [SQL ce tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSqlCeTileClick( object sender, EventArgs e )
        {
            try
            {
                var _sqlEditor = new SqlEditForm( Provider.SqlCe );
                _sqlEditor.Owner = this;
                _sqlEditor.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [sq lite tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSQLiteTileClick( object sender, EventArgs e )
        {
            try
            {
                var _sqlEditor = new SqlEditForm( Provider.SQLite );
                _sqlEditor.Owner = this;
                _sqlEditor.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [SQL server tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSqlServerTileClick( object sender, EventArgs e )
        {
            OpenSqlServerEditor( );
        }

        /// <summary>
        /// Called when [access tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnAccessTileClick( object sender, EventArgs e )
        {
            try
            {
                var _sqlEditor = new SqlEditForm( Provider.Access );
                _sqlEditor.Owner = this;
                _sqlEditor.Show( );
                Hide( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [excel data tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnExcelDataTileClick( object sender, EventArgs e )
        {
            OpenExcelDataForm( );
        }

        /// <summary>
        /// Called when [lookup tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnLookupTileClick( object sender, EventArgs e )
        {
            OpenDataGridForm( );
        }

        /// <summary>
        /// Called when [SQL editor tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSqlEditorTileClick( object sender, EventArgs e )
        {
            OpenSqlEditor( );
        }

        /// <summary>
        /// Called when [visualization tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnVisualizationTileClick( object sender, EventArgs e )
        {
            OpenChartDataForm( );
        }

        /// <summary>
        /// Called when [pivot tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnPivotTileClick( object sender, EventArgs e )
        {
            InvokeIf( _beginLoad );
        }

        /// <summary>
        /// Called when [timer tick].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTimerTick( object sender, EventArgs e )
        {
            InvokeIf( _endLoad );
        }

        /// <summary>
        /// Called when [program project tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnProgramProjectTileClick( object sender, EventArgs e )
        {
            ShowProgramProjectDialog( );
        }

        /// <summary>
        /// Called when [calculator tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCalculatorTileClick( object sender, EventArgs e )
        {
            OpenCalculationForm( );
        }

        /// <summary>
        /// Called when [guidance tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnGuidanceTileClick( object sender, EventArgs e )
        {
            OpenDocumentViewer( );
        }

        /// <summary>
        /// Called when [calendar tile click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCalendarTileClick( object sender, EventArgs e )
        {
            OpenFiscalYearForm( );
        }

        /// <summary>
        /// Called when [test button click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnTestButtonClick( object sender, EventArgs e )
        {
            try
            {
                OpenPivotChartForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [message tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMessageTileClick( object sender, EventArgs e )
        {
            ShowEmailDialog( );
        }

        /// <summary>
        /// Called when [exit button click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnExitButtonClick( object sender, EventArgs e )
        {
            try
            {
                FadeOut( );
                Application.Exit( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [map tile click].
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnMapTileClick( object sender, EventArgs e )
        {
            OpenGeoMapper( );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">
        /// The ex.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
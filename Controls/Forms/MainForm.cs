// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-12-2023
// ******************************************************************************************
// <copyright file="MainForm.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   MainForm.cs
// </summary>
// ******************************************************************************************


namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System;
    using MetroSet_UI;
    using static System.Configuration.ConfigurationManager;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "FunctionComplexityOverflow" )]
    [SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" )]
    public partial class MainForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the tiles.
        /// </summary>
        /// <value>
        /// The tiles.
        /// </value>
        public IEnumerable<Tile> Tiles { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Controls.Forms.MainForm" /> class.
        /// </summary>
        public MainForm( )
        {
            InitializeComponent( );

            // Basic Properties
            Name = "Main";
            Size = new Size( 1350, 750 );
            MaximumSize = new Size( 1350, 750 );
            MinimumSize = new Size( 1350, 750 );
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            BorderThickness = 1;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.DarkGray;
            Font = new Font( "Roboto", 9 );
            ShowIcon = false;
            ShowInTaskbar = true;
            MetroColor = Color.FromArgb( 20, 20, 20 );
            CaptionBarHeight = 5;
            CaptionAlign = HorizontalAlignment.Center;
            CaptionFont = new Font( "Roboto", 12, FontStyle.Regular );
            CaptionBarColor = Color.FromArgb( 20, 20, 20 );
            CaptionForeColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonColor = Color.FromArgb( 20, 20, 20 );
            CaptionButtonHoverColor = Color.FromArgb( 20, 20, 20 );
            SizeGripStyle = SizeGripStyle.Auto;
            ShowMouseOver = false;
            MinimizeBox = false;
            MaximizeBox = false;
            ExitButton.HoverText = "Exit Application";
            Tiles = GetTiles( );

            // Event Wiring
            ExitButton.Click += OnExitButtonClick;
            LookupTile.Click += OnDataManagementTileClick;
            CalculatorTile.Click += OnCalculatorTileClick;
            CalendarTile.Click += OnCalendarTileClick;
            ProgramProjectTile.Click += OnProgramProjectTileClick;
            MessageTile.Click += OnMessageTileClick;
            SqlEditorTile.Click += OnSqlEditorTileClick;
            VisualizationTile.Click += OnVisualizationTileClick;
            ExcelDataTile.Click += OnExcelDataTileClick;
            SQLiteTile.Click += OnSQLiteTileClick;
            SqlCeTile.Click += OnSqlCeTileClick;
            SqlServerTile.Click += OnSqlCeTileClick;
            GuidanceTile.Click += OnGuidanceTileClick;
            BrowserTile.Click += OnBrowserTileClick;
            EdgeTile.Click += OnEdgeTileClick;
            ChromeTile.Click += OnChromeTileClick;
            FirefoxTile.Click += OnFirefoxTileClick;
            BrowserTile.Click += OnBrowserTileClick;
            MessageTile.Click += OnMessageTileClick;
            TestButton.Click += OnTestButtonClick;
            Load += OnLoad;
            Shown += OnShown;
            MouseClick += OnRightClick;
        }

        /// <summary>
        /// Notifies this instance.
        /// </summary>
        private void Notify( )
        {
            try
            {
                var _message = "THIS IS NOT YET IMPLEMENTED!!";
                var _notify = new Notification( _message );
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
                    var _control = Controls[_i];
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
                ChromeTile.Title.Text = "Chrome";
                ChromeTile.Body.Text = string.Empty;
                ChromeTile.Banner.Text = string.Empty;
                EdgeTile.Title.Text = "Edge";
                EdgeTile.Body.Text = string.Empty;
                EdgeTile.Banner.Text = string.Empty;
                FirefoxTile.Title.Text = "Firefox";
                FirefoxTile.Body.Text = string.Empty;
                FirefoxTile.Banner.Text = string.Empty;
                AccessTile.Title.Text = "Access";
                AccessTile.Body.Text = string.Empty;
                AccessTile.Banner.Text = string.Empty;
                SQLiteTile.Title.Text = "SQLite";
                SQLiteTile.Body.Text = string.Empty;
                SQLiteTile.Banner.Text = string.Empty;
                SqlCeTile.Title.Text = "SQL Compact";
                SqlCeTile.Body.Text = string.Empty;
                SqlCeTile.Banner.Text = string.Empty;
                SqlServerTile.Title.Text = "SQL Server";
                SqlServerTile.Body.Text = string.Empty;
                SqlServerTile.Banner.Text = string.Empty;
                LookupTile.Title.Text = "Data Lookup";
                LookupTile.Body.Text = string.Empty;
                LookupTile.Banner.Text = string.Empty;
                SqlEditorTile.Title.Text = "SQL Editor";
                SqlEditorTile.Body.Text = string.Empty;
                SqlEditorTile.Banner.Text = string.Empty;
                VisualizationTile.Title.Text = "Data Visualizations";
                VisualizationTile.Body.Text = string.Empty;
                VisualizationTile.Banner.Text = string.Empty;
                ExcelDataTile.Title.Text = "Excel Data";
                ExcelDataTile.Body.Text = string.Empty;
                ExcelDataTile.Banner.Text = string.Empty;
                GuidanceTile.Title.Text = "Guidance";
                GuidanceTile.Body.Text = string.Empty;
                GuidanceTile.Banner.Text = string.Empty;
                ProgramProjectTile.Title.Text = "Program Projects";
                ProgramProjectTile.Body.Text = string.Empty;
                ProgramProjectTile.Banner.Text = string.Empty;
                CalculatorTile.Title.Text = "Calculator";
                CalculatorTile.Body.Text = string.Empty;
                CalculatorTile.Banner.Text = string.Empty;
                CalendarTile.Title.Text = "Calendar";
                CalendarTile.Body.Text = string.Empty;
                CalendarTile.Banner.Text = string.Empty;
                MessageTile.Title.Text = "Email";
                MessageTile.Body.Text = string.Empty;
                MessageTile.Banner.Text = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the tile properties.
        /// </summary>
        private void SetTileProperties( )
        {
            try
            {
                if( Tiles?.Any( ) == true )
                {
                    foreach( var _tile in Tiles )
                    {
                        _tile.Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        _tile.Title.TextColor = Color.DarkGray;
                        _tile.Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        _tile.Body.TextColor = Color.DarkGray;
                        _tile.Footer.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        _tile.Footer.TextColor = Color.DarkGray;
                        _tile.Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        _tile.Banner.TextColor = Color.DarkGray;
                        _tile.BackColor = Color.FromArgb( 27, 27, 27 );
                        _tile.ImageSource = new Bitmap( _tile.ImageSource, 18, 22 );
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
                var _loader = new LoadingForm( Status.Processing );
                _loader.StartPosition = FormStartPosition.CenterParent;
                _loader.ShowDialog( this );
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
                _programs.StartPosition = FormStartPosition.CenterScreen;
                _programs.Owner = this;
                _programs.Show( );
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
                var _editor = new EditDialog( );
                _editor.ShowDialog( this );
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
                var _editor = new EditDialog( );
                _editor.ShowDialog( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Shows the calendar dialog.
        /// </summary>
        private void ShowCalendarDialog( )
        {
            try
            {
                var _calendar = new CalendarDialog( );
                _calendar.ShowDialog( this );
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
                var _emailDialog = new EmailDialog( );
                _emailDialog.StartPosition = FormStartPosition.CenterScreen;
                _emailDialog.Owner = this;
                _emailDialog.Show( );
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
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "ChartDataForm" ) )
                {
                    var _chartDataForm = (ChartDataForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( ChartDataForm ) )
                        ?.First( );

                    _chartDataForm.Owner = this;
                    _chartDataForm.ClearData( );
                    _chartDataForm.Refresh( );
                    _chartDataForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _chartDataForm = new ChartDataForm( );
                    _chartDataForm.Owner = this;
                    _chartDataForm.Show( );
                    Visible = false;
                }
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
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "ExcelDataForm" ) )
                {
                    var _excelDataForm = (ExcelDataForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( ExcelDataForm ) )
                        ?.First( );

                    _excelDataForm.Owner = this;
                    _excelDataForm.ClearData( );
                    _excelDataForm.Refresh( );
                    _excelDataForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _excelDataForm = new ExcelDataForm( );
                    _excelDataForm.Owner = this;
                    _excelDataForm.Show( );
                    Visible = false;
                }
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
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "SqlEditor" ) )
                {
                    var _sqlEditor = (SqlEditor)_forms
                        ?.Where( f => f.GetType( ) == typeof( SqlEditor ) )
                        ?.First( );

                    _sqlEditor.Owner = this;
                    _sqlEditor.Refresh( );
                    _sqlEditor.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _excelDataForm = new SqlEditor( );
                    _excelDataForm.Owner = this;
                    _excelDataForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the WebBrowser.
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
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "DataGridForm" ) )
                {
                    var _dataGridForm = (DataGridForm)_forms
                        ?.Where( f => f.GetType( ) == typeof( DataGridForm ) )
                        ?.First( );

                    _dataGridForm.Owner = this;
                    _dataGridForm.ResetData( );
                    _dataGridForm.Refresh( );
                    _dataGridForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _dataGridForm = new DataGridForm( );
                    _dataGridForm.Owner = this;
                    _dataGridForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Opens the calculator form.
        /// </summary>
        private void OpenCalculationForm( )
        {
            try
            {
                var _calculator = new CalculationForm( );
                _calculator.Owner = this;
                _calculator.Show( );
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetTileProperties( );
                SetTileText( );
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
                Program.Windows[ "MainForm" ] = this;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

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
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnBrowserTileClick( object sender, EventArgs e )
        {
            Minion.RunBudgetBrowser( );
        }

        /// <summary>
        /// Called when [SQL ce tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSqlCeTileClick( object sender, EventArgs e )
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
        /// Called when [sq lite tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSQLiteTileClick( object sender, EventArgs e )
        {
            try
            {
                Minion.RunSQLite( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [access tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnAccessTileClick( object sender, EventArgs e )
        {
            try
            {
                Minion.RunAccess( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [database tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnDataManagementTileClick( object sender, EventArgs e )
        {
            OpenDataGridForm( );
        }

        private void OnExcelDataTileClick( object sender, EventArgs e )
        {
            OpenExcelDataForm( );
        }

        private void OnLookupTileClick( object sender, EventArgs e )
        {
            Notify( );
        }

        /// <summary>
        /// Called when [SQL editor tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSqlEditorTileClick( object sender, EventArgs e )
        {
            OpenSqlEditor( );
        }

        /// <summary>
        /// Called when [reporting tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnVisualizationTileClick( object sender, EventArgs e )
        {
            OpenChartDataForm( );
        }

        /// <summary>
        /// Called when [web tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnProgramProjectTileClick( object sender, EventArgs e )
        {
            ShowProgramProjectDialog( );
        }

        /// <summary>
        /// Called when [calculator tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCalculatorTileClick( object sender, EventArgs e )
        {
            OpenCalculationForm( );
        }
        
        /// <summary>
        /// Called when [guidance tile clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnGuidanceTileClick( object sender, EventArgs e )
        {
            ShowGuidanceDialog( );
        }

        private void OnCalendarTileClick( object sender, EventArgs e )
        {
            ShowCalendarDialog( );
        }

        /// <summary>
        /// Called when [test button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTestButtonClick( object sender, EventArgs e )
        {
            ShowLoadingForm( );
        }

        /// <summary>
        /// Called when [email tile click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnMessageTileClick( object sender, EventArgs e )
        {
            ShowEmailDialog( );
        }

        /// <summary>
        /// Called when [exit button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnExitButtonClick( object sender, EventArgs e )
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
// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-19-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-11-2023
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
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary> </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm"/>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    public partial class MainForm : MetroForm
    {
        /// <summary> Gets or sets the tiles. </summary>
        /// <value> The tiles. </value>
        public IEnumerable<Tile> Tiles { get; set; }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.MainForm"/>
        /// class.
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
            ExitButton.Click += null;
            DataTile.Click += OnDatabaseTileClicked;
            CalculatorTile.Click += OnCalculatorTileClicked;
            ChartTile.Click += OnReportingTileClicked;
            SqlServerTile.Click += OnClientTileClicked;
            GuidanceTile.Click += OnGuidanceTileClicked;
            BrowserTile.Click += OnWebTileClicked;
            ExitButton.Click += OnExitButtonClicked;
            TestButton.Click += OnTestButtonClick;
            Load += OnLoad;
            Shown += OnShown;
            MouseClick += OnRightClick;
        }

        /// <summary> Called when [load]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Gets the tiles. </summary>
        /// <returns> </returns>
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

        /// <summary> Sets the tile text. </summary>
        private void SetTileText( )
        {
            try
            {
                DataTile.Title.Text = "Data Management";
                DataTile.Body.Text = string.Empty;
                DataTile.Banner.Text = string.Empty;
                CalculatorTile.Title.Text = "Calculator";
                CalculatorTile.Body.Text = string.Empty;
                CalculatorTile.Banner.Text = string.Empty;
                ChartTile.Title.Text = "Visualizations";
                ChartTile.Body.Text = string.Empty;
                ChartTile.Banner.Text = string.Empty;
                SqlServerTile.Title.Text = "SQL Server";
                SqlServerTile.Body.Text = string.Empty;
                SqlServerTile.Banner.Text = string.Empty;
                GuidanceTile.Title.Text = "Guidance";
                GuidanceTile.Body.Text = string.Empty;
                GuidanceTile.Banner.Text = string.Empty;
                BrowserTile.Title.Text = "Web Browser";
                BrowserTile.Body.Text = string.Empty;
                BrowserTile.Banner.Text = string.Empty;
                AccessTile.Title.Text = "Access DB";
                AccessTile.Body.Text = string.Empty;
                AccessTile.Banner.Text = string.Empty;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Sets the tile properties. </summary>
        private void SetTileProperties( )
        {
            try
            {
                if( Tiles?.Any( ) == true )
                {
                    foreach( var _tile in Tiles )
                    {
                        _tile.Size = new Size( 120, 100 );
                        _tile.Title.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        _tile.Body.Font = new Font( "Roboto", 9, FontStyle.Regular );
                        _tile.Footer.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        _tile.Banner.Font = new Font( "Roboto", 8, FontStyle.Regular );
                        _tile.TurnLiveTileOn = true;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Shows the selection dialog. </summary>
        private void ShowSelectionDialog( )
        {
            try
            {
                var _minion = new MinionSelector( );
                _minion.ShowDialog( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Opens the chart data form. </summary>
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

        /// <summary> Opens the excel data form. </summary>
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

        /// <summary> Opens the WebBrowser. </summary>
        private void OpenWebBrowser( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "WebBrowser" ) )
                {
                }
                else
                {
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Opens the PDF form. </summary>
        private void OpenPdfForm( )
        {
            try
            {
                var _forms = Program.Windows.Values;
                if( Program.Windows.ContainsKey( "PdfForm" ) )
                {
                    var _pdfForm = (PdfForm)_forms?.Where( f => f.GetType( ) == typeof( PdfForm ) )
                        ?.First( );

                    _pdfForm.Owner = this;
                    _pdfForm.Refresh( );
                    _pdfForm.Visible = true;
                    Visible = false;
                }
                else
                {
                    var _pdfForm = new PdfForm( );
                    _pdfForm.Owner = this;
                    _pdfForm.Show( );
                    Visible = false;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Opens the data grid form. </summary>
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
                    _dataGridForm.ClearData( );
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

        /// <summary> Called when [database tile clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnDatabaseTileClicked( object sender, EventArgs e )
        {
            try
            {
                OpenDataGridForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [reporting tile clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnReportingTileClicked( object sender, EventArgs e )
        {
            try
            {
                OpenChartDataForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        private void OnWebTileClicked( object sender, EventArgs e )
        {
            try
            {
                OpenWebBrowser( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [client tile clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnClientTileClicked( object sender, EventArgs e )
        {
            try
            {
                ShowSelectionDialog( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [utility tile clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnCalculatorTileClicked( object sender, EventArgs e )
        {
            try
            {
                var _msg = "THIS IS NOT YET IMPLEMENTED!!";
                var _notification = new Notification( _msg );
                _notification.Show( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [guidance tile clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnGuidanceTileClicked( object sender, EventArgs e )
        {
            try
            {
                OpenPdfForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [exit button clicked]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnExitButtonClicked( object sender, EventArgs e )
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

        /// <summary> Called when [test button click]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnTestButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _loader = new LoadingForm( Status.Processing );
                _loader.StartPosition = FormStartPosition.CenterParent;
                _loader.ShowDialog( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Called when [right click]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="MouseEventArgs"/>
        /// instance containing the event data.
        /// </param>
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

        /// <summary> Called when [shown]. </summary>
        /// <param name="sender" > The sender. </param>
        /// <param name="e" >
        /// The
        /// <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnShown( object sender, EventArgs e )
        {
            try
            {
                Program.Windows["MainForm"] = this;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary> Fails the specified ex. </summary>
        /// <param name="ex" > The ex. </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
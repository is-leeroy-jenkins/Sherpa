// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 07-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-23-2023
// ******************************************************************************************
// <copyright file="FiscalYearForm.cs" company="Terry D. Eppler">
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
//   FiscalYearForm.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using Exception = System.Exception;

    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public sealed partial class FiscalYearForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the date string.
        /// </summary>
        /// <value>
        /// The date string.
        /// </value>
        public string DateString { get; set; }

        /// <summary>
        /// Gets or sets the selected start date.
        /// </summary>
        /// <value>
        /// The selected start date.
        /// </value>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the selected end date.
        /// </summary>
        /// <value>
        /// The selected end date.
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the selected start date.
        /// </summary>
        /// <value>
        /// The selected start date.
        /// </value>
        public string SelectedStart { get; set; }

        /// <summary>
        /// Gets or sets the selected end date.
        /// </summary>
        /// <value>
        /// The selected end date.
        /// </value>
        public string SelectedEnd { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public DataSet Data { get; set; }

        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public DataTable Holidays { get; set; }

        /// <summary>
        /// Gets or sets the fiscal years.
        /// </summary>
        /// <value>
        /// The fiscal years.
        /// </value>
        public DataTable FiscalYears { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FiscalYearForm" /> class.
        /// </summary>
        public FiscalYearForm( )
        {
            InitializeComponent( );

            // Basic Properties
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

            // Title Properties
            Title.ForeColor = Color.FromArgb( 0, 120, 212 );
            Title.TextAlign = ContentAlignment.TopLeft;

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClick;
            MenuButton.Click += OnMenuButtonClicked;
            FirstCalendar.SelectionChanged += OnFirstCalendarSelectionChanged;
            SecondCalendar.SelectionChanged += OnSecondCalendarSelectionChanged;
            ChartButton.Click += OnChartButtonClick;
            TableButton.Click += OnTableButtonClick;
            RefreshButton.Click += OnRefreshButtonClick;
            TabControl.SelectedIndexChanged += OnSelectedTabChanged;
        }

        /// <summary>
        /// Sets the tool strip properties.
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
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the title text.
        /// </summary>
        private void SetTitleText( string text )
        {
            try
            {
                if( !string.IsNullOrEmpty( text ) )
                {
                    Chart.Titles[ 0 ].Text = text;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        private void ResetLabelText( )
        {
            try
            {
                Label1.Text = $"Start: ";
                Label2.Text = $"End: ";
                Label3.Text = $"Weeks: ";
                Label4.Text = $"Days:  ";
                Label5.Text = $"Hours: ";
                Label6.Text = $"Weekdays: ";
                Label7.Text = $"Holidays: ";
                Label8.Text = $"Weekends: ";
                Label9.Text = $"Workdays: ";
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns></returns>
        private DataTable GetFederalHolidays( )
        {
            try
            {
                var _data = new DataBuilder( Source.FederalHolidays, Provider.Access );
                var _table = _data?.DataTable;
                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Gets the fiscal years.
        /// </summary>
        /// <returns></returns>
        private DataTable GetFiscalYears( )
        {
            try
            {
                var _data = new DataBuilder( Source.FiscalYears, Provider.Access );
                var _table = _data?.DataTable;
                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Sets the active tab.
        /// </summary>
        private void SetActiveTab( )
        {
            try
            {
                switch( TabControl.SelectedIndex )
                {
                    case 0:
                    {
                        break;
                    }
                    case 1:
                    {
                        BindingSource.DataSource = GetFiscalYears( );
                        DataGrid.DataSource = BindingSource;
                        ToolStrip.BindingSource = BindingSource;
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
        /// Updates the label text.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        private void UpdateLabelText( DateTime start, DateTime end )
        {
            try
            {
                var _timeSpan = end - start;
                var _days = _timeSpan.TotalDays;
                var _hours = _timeSpan.TotalHours.ToString( "N2" );
                var _weekdays = start.CountWeekDays( end );
                var _weekends = start.CountWeekEnds( end );
                var _workdays = start.CountWorkdays( end );
                var _holidays = start.CountHolidays( end );
                var _fte = ( ( _workdays * 8M ) / 2050M ).ToString( "N3" );
                Label1.Text = $"Start:  {start.ToShortDateString( )}";
                Label2.Text = $"End:  {end.ToShortDateString( )}";
                Label3.Text = $"Days: {_days}";
                Label4.Text = $"Hours:  {_hours}";
                Label5.Text = $"FTE: {_fte} ";
                Label6.Text = $"Weekdays: {_weekdays}";
                Label7.Text = $"Workdays: {_workdays}";
                Label8.Text = $"Weekends: {_weekends}";
                Label9.Text = $"Holidays: {_holidays}";
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
                Chart.Refresh( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Binds the column chart.
        /// </summary>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        private void BindChart( DateTime start, DateTime end )
        {
            try
            {
                var _start = start.ToLongDateString( );
                var _end = end.ToLongDateString( );
                var _weekdays = start.CountWeekDays( end );
                var _weekends = start.CountWeekEnds( end );
                var _workdays = start.CountWorkdays( end );
                var _holidays = start.CountHolidays( end );
                var _total = ( end - start ).TotalDays;
                var _data = new Dictionary<string, double>( );
                _data.Add( "Weekdays", _weekdays );
                _data.Add( "Workdays", _workdays );
                _data.Add( "Weekends", _weekends );
                _data.Add( "Holidays", _holidays );
                var _text = $"From {_start} To {_end} ";
                Chart.Titles[ 0 ].Text = _text;
                var _values = _data.Values.ToArray( );
                var _names = _data.Keys.ToArray( );
                Chart.Series[ 0 ].Points.Clear( );
                Chart.Series[ 0 ].ChartType = SeriesChartType.Pie;
                for( var _i = 0; _i < _data.Count; _i++ )
                {
                    Chart.Series[ 0 ].IsXValueIndexed = false;
                    Chart.Series[ 0 ].Points.AddXY( _names[ _i ], _values[ _i ] );
                }

                Chart.Refresh( );
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
                if( ( Owner != null )
                   && ( Owner.Visible == false )
                   && ( Owner.GetType( ) == typeof( MainForm ) ) )
                {
                    var _form = (MainForm)Program.Windows[ nameof( MainForm ) ];
                    _form.Visible = true;
                    _form.Refresh( );
                    Close( );
                }
                else
                {
                    var _mainForm = new MainForm( );
                    _mainForm.Show( );
                    Close( );
                }
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
        /// instance containing the event data.</param>
        private void OnLoad( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
                InitializeToolStrip( );
                SetActiveTab( );
                ResetLabelText( );
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
                OpenMainForm( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [close button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnCloseButtonClick( object sender, EventArgs e )
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

        /// <summary>
        /// Called when [first calendar selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnFirstCalendarSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                StartDate = DateTime.Parse( FirstCalendar.SelectedDate.ToString( ) );
                Label1.Text = $"Start: ";
                Label2.Text = $"End: ";
                Label3.Text = $"Weeks: ";
                Label4.Text = $"Days:  ";
                Label5.Text = $"Hours: ";
                Label6.Text = $"Weekdays: ";
                Label7.Text = $"Holidays: ";
                Label8.Text = $"Weekends: ";
                Label9.Text = $"Workdays: ";
                Label10.Visible = false;
                Label11.Visible = false;
                Label12.Visible = false;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [second calendar selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSecondCalendarSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                EndDate = DateTime.Parse( SecondCalendar.SelectedDate.ToString( ) );
                BindChart( StartDate, EndDate );
                UpdateLabelText( StartDate, EndDate );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Called when [table button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnTableButtonClick( object sender, EventArgs e )
        {
            TabControl.SelectedIndex = 1;
        }

        /// <summary>
        /// Called when [chart button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnChartButtonClick( object sender, EventArgs e )
        {
            TabControl.SelectedIndex = 0;
        }

        /// <summary>
        /// Called when [selected tab changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSelectedTabChanged( object sender, EventArgs e )
        {
            SetActiveTab( );
        }

        private void OnRefreshButtonClick( object sender, EventArgs e )
        {
            try
            {
                ResetLabelText( );
                StartDate = DateTime.Today;
                EndDate = DateTime.Today;
                FirstCalendar.SelectedDate = StartDate;
                SecondCalendar.SelectedDate = EndDate;
                Chart.Series[ 0 ].Points.Clear( );
                Chart.Titles[ 0 ].Text = string.Empty;
                TabControl.SelectedIndex = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="_ex">The ex.</param>
        private void Fail( Exception _ex )
        {
            using var _error = new ErrorDialog( _ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
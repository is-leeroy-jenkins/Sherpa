﻿// ******************************************************************************************
//     Assembly:                Sherpa
//     Author:                  Terry D. Eppler
//     Created:                 05-14-2024
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-14-2024
// ******************************************************************************************
// <copyright file="CalendarForm.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application
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
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   CalendarForm.cs
// </summary>
// ******************************************************************************************

namespace Sherpa
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.Tools;
    using Action = System.Action;
    
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWhenPossible" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "FieldCanBeMadeReadOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToAutoPropertyWithPrivateSetter" ) ]
    public sealed partial class CalendarForm : MetroForm
    {
        /// <summary>
        /// The locked object
        /// </summary>
        private object _path;
        
        /// <summary>
        /// The status update
        /// </summary>
        private Action _statusUpdate;
        
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
        /// The start date
        /// </summary>
        private DateTime _startDate;
        
        /// <summary>
        /// The end date
        /// </summary>
        private DateTime _endDate;
        
        /// <summary>
        /// The date string
        /// </summary>
        private string _dateString;
        
        /// <summary>
        /// The selected start
        /// </summary>
        private string _selectedStart;
        
        /// <summary>
        /// The selected end
        /// </summary>
        private string _selectedEnd;
        
        /// <summary>
        /// The filter
        /// </summary>
        private IDictionary<string, object> _filter;
        
        /// <summary>
        /// The columns
        /// </summary>
        private IList<string> _columns;
        
        /// <summary>
        /// The fields
        /// </summary>
        private IList<string> _fields;
        
        /// <summary>
        /// The numerics
        /// </summary>
        private IList<string> _numerics;
        
        /// <summary>
        /// The selected columns
        /// </summary>
        private IList<string> _selectedColumns;
        
        /// <summary>
        /// The selected fields
        /// </summary>
        private IList<string> _selectedFields;
        
        /// <summary>
        /// The data set
        /// </summary>
        private DataSet _dataSet;
        
        /// <summary>
        /// The holidays
        /// </summary>
        private DataTable _holidays;
        
        /// <summary>
        /// The fiscal years
        /// </summary>
        private DataTable _fiscalYears;

        /// <summary>
        /// The data table
        /// </summary>
        private DataTable _dataTable;

        /// <summary>
        /// The selected dates
        /// </summary>
        private IList<DateTime> _selectedDates;
        
        /// <summary>
        /// The data model
        /// </summary>
        private DataBuilder _dataModel;
        
        /// <summary>
        /// The data arguments
        /// </summary>
        private DataArgs _dataArgs;
        
        /// <summary>
        /// The provider
        /// </summary>
        private Provider _provider;
        
        /// <summary>
        /// Gets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> Filter
        {
            get
            {
                return _filter;
            }
            private set
            {
                _filter = value;
            }
        }
        
        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public IList<string> Columns
        {
            get
            {
                return _columns;
            }
            private set
            {
                _columns = value;
            }
        }
        
        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <value>
        /// The fields.
        /// </value>
        public IList<string> Fields
        {
            get
            {
                return _fields;
            }
            private set
            {
                _fields = value;
            }
        }
        
        /// <summary>
        /// Gets the numerics.
        /// </summary>
        /// <value>
        /// The numerics.
        /// </value>
        public IList<string> Numerics
        {
            get
            {
                return _numerics;
            }
            private set
            {
                _numerics = value;
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
        /// Gets or sets the date string.
        /// </summary>
        /// <value>
        /// The date string.
        /// </value>
        public string DateString
        {
            get
            {
                return _dateString;
            }
            private set
            {
                _dateString = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            private set
            {
                _startDate = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            private set
            {
                _endDate = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the selected start.
        /// </summary>
        /// <value>
        /// The selected start.
        /// </value>
        public string SelectedStart
        {
            get
            {
                return _selectedStart;
            }
            private set
            {
                _selectedStart = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the selected end.
        /// </summary>
        /// <value>
        /// The selected end.
        /// </value>
        public string SelectedEnd
        {
            get
            {
                return _selectedEnd;
            }
            private set
            {
                _selectedEnd = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public DataSet Data
        {
            get
            {
                return _dataSet;
            }
            private set
            {
                _dataSet = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public DataTable Holidays
        {
            get
            {
                return _holidays;
            }
            private set
            {
                _holidays = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the fiscal years.
        /// </summary>
        /// <value>
        /// The fiscal years.
        /// </value>
        public DataTable FiscalYears
        {
            get
            {
                return _fiscalYears;
            }
            private set
            {
                _fiscalYears = value;
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
            private set
            {
                _dataModel = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the selected dates.
        /// </summary>
        /// <value>
        /// The selected dates.
        /// </value>
        public IList<DateTime> SelectedDates
        {
            get
            {
                return _selectedDates;
            }
            private set
            {
                _selectedDates = value;
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
        /// <see cref="T:Sherpa.CalendarForm" /> class.
        /// </summary>
        public CalendarForm( )
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
            
            // Budget Properties
            _filter = new Dictionary<string, object>( );
            _fields = new List<string>( );
            _columns = new List<string>( );
            _dataArgs = new DataArgs( );
            _selectedDates = new List<DateTime>( );
            
            // Default Provider
            _provider = Provider.Access;
            
            // Timer Properties
            _time = 0;
            _seconds = 5;
            
            // Event Wiring
            Load += OnLoad;
            FormClosing += OnFormClosing;
            MouseClick += OnRightClick;
        }
        
        /// <summary>
        /// Initializes the callbacks.
        /// </summary>
        private void RegisterCallbacks( )
        {
            try
            {
                CloseButton.Click += OnCloseButtonClick;
                MenuButton.Click += OnMenuButtonClicked;
                FirstCalendar.SelectionChanged += OnFirstCalendarSelectionChanged;
                SecondCalendar.SelectionChanged += OnSecondCalendarSelectionChanged;
                ChartButton.Click += OnChartButtonClick;
                TableButton.Click += OnTableButtonClick;
                RefreshButton.Click += OnRefreshButtonClick;
                TabControl.SelectedIndexChanged += OnTabChanged;
                SaveButton.Click += OnSaveButtonClick;
                BrowseButton.Click += OnBrowserButtonClick;
                Timer.Tick += OnTimerTick;
                Title.MouseClick += OnRightClick;
                FirstCalendarTable.MouseClick += OnRightClick;
                SecondCalendarTable.MouseClick += OnRightClick;
                ChartTable.MouseClick += OnRightClick;
                HeaderTable.MouseClick += OnRightClick;
                ExportButton.Click += OnExportButtonClick;
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
        /// Initializes the labels.
        /// </summary>
        private void InitializeLabels( )
        {
            try
            {
                Title.Font = new Font( "Roboto", 10 );
                Title.ForeColor = Color.FromArgb( 106, 189, 252 );
                Title.TextAlign = ContentAlignment.TopLeft;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Initializes the chart.
        /// </summary>
        private void InitializeChart( )
        {
            try
            {
                Chart.Series[ 0 ].Type = ChartSeriesType.Pie;
                Chart.Titles[ 0 ].Font = new Font( "Roboto", 10 );
                Chart.Titles[ 0 ].ForeColor = Color.FromArgb( 106, 189, 252 );
                Chart.Series[ 0 ].Type = ChartSeriesType.Pie;
                Chart.Series[ 0 ].Style.DisplayText = true;
                Chart.Series[ 0 ].SmartLabels = true;
                Chart.Series[ 0 ].ConfigItems.PieItem.LabelStyle =
                    ChartAccumulationLabelStyle.Outside;
                
                var _today = DateTime.Today;
                var _start = new DateTime( _today.Year, 10, 1 );
                BindChart( _start, _today );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Invokes if.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        public void InvokeIf( Action action )
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
        /// Sets the title text.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        private void SetTitleText( string text )
        {
            try
            {
                ThrowIf.Null( text, nameof( text ) );
                Chart.Titles[ 0 ].Text = text;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Clears the labels.
        /// </summary>
        private void ClearLabels( )
        {
            try
            {
                Label1.Text = "Start: ";
                Label2.Text = "End: ";
                Label3.Text = "Weeks: ";
                Label4.Text = "Days:  ";
                Label5.Text = "Hours: ";
                Label6.Text = "Weekdays: ";
                Label7.Text = "Holidays: ";
                Label8.Text = "Weekends: ";
                Label9.Text = "Workdays: ";
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
        /// Clears the selections.
        /// </summary>
        private void ClearSelections( )
        {
            try
            {
                _selectedStart = string.Empty;
                _selectedEnd = string.Empty;
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
                _selectedDates?.Clear( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Clears the data.
        /// </summary>
        private void ClearData( )
        {
            try
            {
                _dataArgs = new DataArgs( );
                _holidays = null;
                _fiscalYears = null;
                BindingSource.DataSource = null;
                DataGrid.BindingSource.DataSource = null;
                ToolStrip.BindingSource.DataSource = null;
                ClearSelections( );
                ClearCollections( );
                TabControl.SelectedIndex = 0;
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
                if( _dataTable == null )
                {
                    var _message = "    The Data Table is null!";
                    SendMessage( _message );
                }
                else if( _dataModel.Numerics == null )
                {
                    var _message = "    The data is not alpha-numeric";
                    SendMessage( _message );
                }
                else
                {
                    var _report = new ExcelReport( _dataTable );
                    _report.SaveDialog( );
                    var _message = "    The Excel File has been created!";
                    SendNotification( _message );
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
        /// Gets the federal holidays.
        /// </summary>
        /// <returns>
        /// </returns>
        private DataTable GetFederalHolidays( )
        {
            try
            {
                var _data = new DataBuilder( Source.FederalHolidays, Provider.Access );
                _dataTable = _data?.DataTable;
                return _dataTable.Rows.Count > 0
                    ? _dataTable
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
        /// <returns>
        /// </returns>
        private DataTable GetFiscalYears( )
        {
            try
            {
                var _data = new DataBuilder( Source.FiscalYears, Provider.Access );
                _dataTable = _data?.DataTable;
                return _dataTable.Rows.Count > 0
                    ? _dataTable
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
                        // Chart Tab
                        ChartTab.Visible = true;
                        ChartButton.Visible = false;
                        ChartSeparator.Visible = false;
                        TableButton.Visible = true;
                        DataTab.Visible = false;
                        Separator13.Visible = false;
                        BusyTab.Visible = false;
                        break;
                    }
                    case 1:
                    {
                        // Data Tab
                        DataTab.Visible = true;
                        Separator13.Visible = true;
                        ChartButton.Visible = true;
                        ChartSeparator.Visible = true;
                        TableButton.Visible = false;
                        ChartTab.Visible = false;
                        BusyTab.Visible = false;
                        BindingSource.DataSource = GetFiscalYears( );
                        DataGrid.DataSource = BindingSource;
                        ToolStrip.BindingSource = BindingSource;
                        break;
                    }
                    case 2:
                    {
                        // Busy Tab
                        BusyTab.Visible = true;
                        ChartButton.Visible = false;
                        ChartSeparator.Visible = false;
                        TableButton.Visible = false;
                        ChartTab.Visible = false;
                        DataTab.Visible = false;
                        Separator13.Visible = false;
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
        /// <param name="start">
        /// The start.
        /// </param>
        /// <param name="end">
        /// The end.
        /// </param>
        private void UpdateLabels( DateTime start, DateTime end )
        {
            try
            {
                var _timeSpan = end - start;
                var _days = _timeSpan.TotalDays;
                var _hours = _timeSpan.TotalHours.ToString( "N0" );
                var _weekdays = start.CountWeekDays( end );
                var _weekends = start.CountWeekEnds( end );
                var _workdays = start.CountWorkdays( end );
                var _offDays = CountHolidays( start, end );
                var _fte = ( _workdays * 8M / 2050M ).ToString( "N3" );
                Label1.Text = $"Start:  {start.ToShortDateString( )}";
                Label2.Text = $"End:  {end.ToShortDateString( )}";
                Label3.Text = $"Days: {_days}";
                Label4.Text = $"Hours:  {_hours}";
                Label5.Text = $"FTE: {_fte} ";
                Label6.Text = $"Weekdays: {_weekdays}";
                Label7.Text = $"Workdays: {_workdays}";
                Label8.Text = $"Weekends: {_weekends}";
                Label9.Text = $"Holidays: {_offDays}";
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
        /// Binds the chart.
        /// </summary>
        /// <param name="start">
        /// The start.
        /// </param>
        /// <param name="end">
        /// The end.
        /// </param>
        private void BindChart( DateTime start, DateTime end )
        {
            try
            {
                var _start = start.ToLongDateString( );
                var _end = end.ToLongDateString( );
                var _weekdays = start.CountWeekDays( end );
                var _weekends = start.CountWeekEnds( end );
                var _workdays = start.CountWorkdays( end );
                var _offDays = CountHolidays( start, end );
                var _data = new Dictionary<string, double>( );
                _data.Add( "Weekdays", _weekdays );
                _data.Add( "Workdays", _workdays );
                _data.Add( "Weekends", _weekends );
                _data.Add( "Holidays", _offDays );
                var _text = $"From {_start} To {_end} ";
                Chart.Titles[ 0 ].Text = _text;
                var _values = _data.Values.ToArray( );
                Chart.Series[ 0 ].Points.Clear( );
                for( var _i = 0; _i < _data.Count; _i++ )
                {
                    double _k = _i;
                    var _pt = new ChartPoint( _k, _values[ _i ] );
                    Chart.Series[ 0 ].Points.Add( _pt );
                }
                
                Chart.Series[ 0 ].ExplodedAll = true;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Counts the holidays.
        /// </summary>
        /// <param name="start">
        /// The start.
        /// </param>
        /// <param name="end">
        /// The end.
        /// </param>
        private int CountHolidays( DateTime start, DateTime end )
        {
            try
            {
                var _period = end - start;
                var _days = _period.TotalDays;
                var _holiday = 0;
                for( var _i = 0d; _i <= _days; _i++ )
                {
                    var _day = start.AddDays( _i );
                    if( _day.IsFederalHoliday( ) )
                    {
                        _holiday += 1;
                    }
                }
                
                return _holiday;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
                return 0;
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
        /// Sends the notification.
        /// </summary>
        /// <param name="text">The text.</param>
        private void SendNotification( string text )
        {
            try
            {
                ThrowIf.Null( text, nameof( text ) );
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
                ThrowIf.Null( text, nameof( text ) );
                var _message = new SplashMessage( text );
                _message.Show( );
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
                Opacity = 0;
                RegisterCallbacks( );
                InitializeToolStrip( );
                InitializeLabels( );
                InitializeChart( );
                SetActiveTab( );
                ClearLabels( );
                _dataArgs = new DataArgs( );
                _selectedDates = new List<DateTime>( );
                TabControl.SelectedIndex = 0;
                FadeInAsync( this );
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
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnFirstCalendarSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                _startDate = DateTime.Parse( FirstCalendar.SelectedDate.ToString( ) );
                Label1.Text = "Start: ";
                Label2.Text = "End: ";
                Label3.Text = "Weeks: ";
                Label4.Text = "Days:  ";
                Label5.Text = "Hours: ";
                Label6.Text = "Weekdays: ";
                Label7.Text = "Holidays: ";
                Label8.Text = "Weekends: ";
                Label9.Text = "Workdays: ";
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
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnSecondCalendarSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                _endDate = DateTime.Parse( SecondCalendar.SelectedDate.ToString( ) );
                BindChart( _startDate, _endDate );
                UpdateLabels( _startDate, _endDate );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [table button click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnTableButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 1;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [chart button click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnChartButtonClick( object sender, EventArgs e )
        {
            try
            {
                TabControl.SelectedIndex = 0;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [selected tab changed].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnTabChanged( object sender, EventArgs e )
        {
            try
            {
                SetActiveTab( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [refresh button click].
        /// </summary>
        /// <param name="sender">The sender.
        /// </param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.
        /// </param>
        private void OnRefreshButtonClick( object sender, EventArgs e )
        {
            try
            {
                ClearLabels( );
                _startDate = DateTime.Today;
                _endDate = DateTime.Today;
                FirstCalendar.SelectedDate = _startDate;
                SecondCalendar.SelectedDate = _endDate;
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
        /// Called when [file dialog button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnBrowserButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _dialog = new FileDialog( );
                _dialog.ShowDialog( this );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
        
        /// <summary>
        /// Called when [save button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnSaveButtonClick( object sender, EventArgs e )
        {
            try
            {
                var _message = "THE SAVE FUCTIONALITY HAS NOT BEEN IMPLEMENTED!";
                SendNotification( _message );
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
        /// Called when [export button click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/>
        /// instance containing the event data.</param>
        private void OnExportButtonClick( object sender, EventArgs e )
        {
            try
            {
                CreateExcelReport( );
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
        /// The exception.
        /// </param>
        private void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
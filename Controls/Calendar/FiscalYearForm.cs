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
    using Syncfusion.WinForms.Input;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms.DataVisualization.Charting;

    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
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
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the selected end date.
        /// </summary>
        /// <value>
        /// The selected end date.
        /// </value>
        public DateTime? EndDate { get; set; }

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

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClick;
            MenuButton.Click += OnMenuButtonClicked;
            FirstCalendar.SelectionChanged += OnFirstCalendarSelectionChanged;
            SecondCalendar.SelectionChanged += OnSecondCalendarSelectionChanged;
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

        /// <summary>
        /// Sets the axis title.
        /// </summary>
        /// <param name="filter">The filter.</param>
        private void SetAxisTitle( IDictionary<string, object> filter )
        {
            if( filter?.Any( ) == true )
            {
                try
                {
                    var _keys = filter.Keys.ToArray( );
                    var _values = filter.Values.ToArray( );
                    var _title = _keys.First( ) + " - " + _values?.First( );
                    _title += "   ";
                    for( var i = 1; i < _values.Length; i++ )
                    {
                        var _split = _keys[ i ].SplitPascal( );
                        if( _split.EndsWith( "Name" ) )
                        {
                            var _key = _split.Replace( "Name", "" ).Trim( );
                            _title += _key + " - " + _values[ i ];
                            _title += "   ";
                        }
                        else if( _split.EndsWith( "Code" ) )
                        {
                            var _key = _split.Replace( "Code", "" ).Trim( );
                            _title += _key + " - " + _values[ i ];
                            _title += "   ";
                        }
                    }

                    Chart.ChartAreas[ 0 ].AxisX.Title = _title;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
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
                var _table = _data.DataTable;
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
                var _table = _data.DataTable;
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
                InitializeToolStrip( );
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
                StartDate = FirstCalendar.SelectedDate;
                var _date = StartDate?.ToLongDateString( );
                FirstCalendarTable.CaptionText = $"Start Date:  {_date}";
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
                EndDate = SecondCalendar.SelectedDate;
                var _date = EndDate?.ToLongDateString( );
                SecondCalendarTable.CaptionText = $"End Date:  {_date}";
                var _timeSpan = EndDate - StartDate;
                var _days = _timeSpan?.TotalDays;
                var _hours = _timeSpan?.TotalHours.ToString( "N0" );
                TimeSpanInformation.Text = $"{_days} days  {_hours} hrs";
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
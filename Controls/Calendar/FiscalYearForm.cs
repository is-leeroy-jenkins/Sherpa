// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 07-22-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        07-22-2023
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
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms.DataVisualization.Charting;

    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    public sealed partial class FiscalYearForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.FiscalYearForm" /> class.
        /// </summary>
        public FiscalYearForm( )
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

            // Title Properties
            Title.ForeColor = Color.FromArgb( 0, 120, 212 );

            // Event Wiring
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClick;
            MenuButton.Click += OnMenuButtonClicked;
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
        /// Initializes the chart.
        /// </summary>
        private void InitializeChart( )
        {
            try
            {
                SetChartProperties( );
                SetChartPaletteColors( );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the title text.
        /// </summary>
        private void SetTitleText( )
        {
            try
            {
                Chart.Titles[0].Text = string.Empty;
                var _text = DataTable?.TableName?.SplitPascal( );
                if( !string.IsNullOrEmpty( _text ) )
                {
                    Chart.Titles[0].Text = _text;
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the chart properties.
        /// </summary>
        private void SetChartProperties( )
        {
            try
            {
                Chart.BackColor = Color.FromArgb( 20, 20, 20 );
                Chart.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
                Chart.ForeColor = Color.White;
                Chart.BorderlineColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.BackColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.PageColor = Color.FromArgb( 20, 20, 20 );
                Chart.BorderSkin.BorderColor = Color.FromArgb( 20, 20, 20 );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                        var _split = _keys[i].SplitPascal( );
                        if( _split.EndsWith( "Name" ) )
                        {
                            var _key = _split.Replace( "Name", "" ).Trim( );
                            _title += _key + " - " + _values[i];
                            _title += "   ";
                        }
                        else if( _split.EndsWith( "Code" ) )
                        {
                            var _key = _split.Replace( "Code", "" ).Trim( );
                            _title += _key + " - " + _values[i];
                            _title += "   ";
                        }
                    }

                    Chart.ChartAreas[0].AxisX.Title = _title;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the area properties.
        /// </summary>
        private void SetAreaProperties( int i = 0, bool enabled = false )
        {
            if( enabled )
            {
                try
                {
                    var _black = Color.FromArgb( 20, 20, 20 );
                    var _gray = Color.FromArgb( 65, 65, 65 );
                    var _transparent = Color.Transparent;
                    var _blue = Color.FromArgb( 0, 120, 212 );
                    var _darkBlue = Color.FromArgb( 24, 47, 66 );

                    // General Area Properties
                    Chart.ChartAreas[i].BackColor = _black;
                    Chart.ChartAreas[i].Area3DStyle.Enable3D = true;
                    Chart.ChartAreas[i].BorderColor = _darkBlue;
                    Chart.ChartAreas[i].BackSecondaryColor = _black;
                    Chart.ChartAreas[i].Area3DStyle.PointDepth = 150;
                    Chart.ChartAreas[i].Area3DStyle.Inclination = 35;

                    // Horizontal Axis Properties
                    Chart.ChartAreas[i].AxisX.IsLabelAutoFit = true;
                    Chart.ChartAreas[i].AxisX.InterlacedColor = _transparent;
                    Chart.ChartAreas[i].AxisX.LineColor = _darkBlue;
                    Chart.ChartAreas[i].AxisX.TitleFont = new Font( "Roboto", 8 );
                    Chart.ChartAreas[i].AxisX.TitleForeColor = _blue;
                    Chart.ChartAreas[i].AxisX.LabelStyle.Font = new Font( "Roboto", 7 );
                    Chart.ChartAreas[i].AxisX.LabelStyle.ForeColor = _blue;
                    Chart.ChartAreas[i].AxisX.MajorGrid.LineColor = _darkBlue;
                    Chart.ChartAreas[i].AxisX.MinorGrid.LineColor = _gray;
                    Chart.ChartAreas[i].AxisX.TextOrientation = TextOrientation.Auto;

                    // Vertical Axis Properties
                    Chart.ChartAreas[i].AxisY.IsLabelAutoFit = true;
                    Chart.ChartAreas[i].AxisY.InterlacedColor = _transparent;
                    Chart.ChartAreas[i].AxisY.LineColor = _darkBlue;
                    Chart.ChartAreas[i].AxisY.TitleFont = new Font( "Roboto", 8 );
                    Chart.ChartAreas[i].AxisY.TitleForeColor = _blue;
                    Chart.ChartAreas[i].AxisY.LabelStyle.Font = new Font( "Roboto", 7 );
                    Chart.ChartAreas[i].AxisY.LabelStyle.Format = "N0";
                    Chart.ChartAreas[i].AxisY.LabelStyle.ForeColor = _blue;
                    Chart.ChartAreas[i].AxisY.MajorGrid.LineColor = _darkBlue;
                    Chart.ChartAreas[i].AxisY.MinorGrid.LineColor = _gray;
                    Chart.ChartAreas[i].AxisY.TextOrientation = TextOrientation.Auto;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the title properties.
        /// </summary>
        private void SetTitleProperties( int i = 0, bool enabled = false )
        {
            if( enabled )
            {
                try
                {
                    Chart.Titles[i].Font = new Font( "Roboto", 10, FontStyle.Bold );
                    Chart.Titles[i].BackColor = Color.FromArgb( 20, 20, 20 );
                    Chart.Titles[i].BorderColor = Color.FromArgb( 20, 20, 20 );
                    Chart.Titles[i].ForeColor = Color.FromArgb( 0, 120, 212 );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the legend properties.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        private void SetLegendProperties( int i = 0, bool enabled = false )
        {
            try
            {
                Chart.Legends[i].HeaderSeparatorColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[i].ItemColumnSeparatorColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[i].BorderColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[i].TitleFont = new Font( "Roboto", 7 );
                Chart.Legends[i].TitleForeColor = Color.FromArgb( 0, 120, 212 );
                Chart.Legends[i].TitleBackColor = Color.FromArgb( 20, 20, 20 );
                Chart.Legends[i].Enabled = enabled;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the series properties.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="type">The type.</param>
        private void SetSeriesProperties( int i = 0, SeriesChartType type = SeriesChartType.Column )
        {
            try
            {
                Chart.Series[i].ChartType = type;
                Chart.Series[i].IsValueShownAsLabel = true;
                Chart.Series[i].IsVisibleInLegend = true;
                Chart.Series[i].LabelBorderColor = Color.Transparent;
                Chart.Series[i].LabelBackColor = Color.Transparent;
                Chart.Series[i].LabelForeColor = Color.LightGray;
                Chart.Series[i].LabelFormat = "N0";
                Chart.Series[i].MarkerColor = Color.Yellow;
                Chart.Series[i].Font = new Font( "Roboto", 7 );
                Chart.Series[i].XValueType = ChartValueType.Auto;
                Chart.Series[i].YValueType = ChartValueType.Auto;
                Chart.Series[i].SmartLabelStyle.CalloutBackColor = Color.Transparent;
                Chart.Series[i].SmartLabelStyle.CalloutStyle = LabelCalloutStyle.Box;
                Chart.Series[i].SmartLabelStyle.CalloutLineColor = Color.Transparent;
                Chart.Series[i].SmartLabelStyle.CalloutLineWidth = 0;
                Chart.Series[i].SmartLabelStyle.CalloutLineAnchorCapStyle =
                    LineAnchorCapStyle.Arrow;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the chart palette colors.
        /// </summary>
        private void SetChartPaletteColors( )
        {
            try
            {
                var _blue = Color.FromArgb( 0, 120, 212 );
                var _lightBlue = Color.FromArgb( 180, 0, 120, 202 );
                var _maroon = Color.Maroon;
                var _red = Color.FromArgb( 255, 65, 84 );
                var _green = Color.FromArgb( 0, 64, 0 );
                var _darkGreen = Color.FromArgb( 150, 0, 64, 0 );
                var _palette = new[ ]
                {
                    _blue,
                    _lightBlue,
                    _maroon,
                    _red,
                    _green,
                    _darkGreen
                };

                Chart.PaletteCustomColors = _palette;
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
                var _mainForm = new MainForm( );
                _mainForm.Show( );
                Close( );
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
                InitializeChart( );
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
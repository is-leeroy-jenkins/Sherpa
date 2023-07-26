// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 04-23-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Chart.cs" company="Terry D. Eppler">
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
//   Chart.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:BudgetExecution.ChartBase" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Chart : ChartBase
    {
        /// <summary>
        /// Gets or sets the measure.
        /// </summary>
        /// <value>
        /// The measure.
        /// </value>
        public STAT Measure { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Chart" /> class.
        /// </summary>
        public Chart( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            BorderlineColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.PageColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BorderColor = Color.FromArgb( 20, 20, 20 );
            InitializePalette( );
            SetAreaProperties( );
            SetTitleProperties( );
            SetSeriesProperties( );
        }

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Chart" /> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="category">The category.</param>
        /// <param name="values">The values.</param>
        /// <param name="type">The type.</param>
        /// <param name="stat">The stat.</param>
        public Chart( BindingSource bindingSource, string category, IEnumerable<string> values, 
            SeriesChartType type = SeriesChartType.Column,
            STAT stat = STAT.Total )
            : this( )
        {
            DataTable = (DataTable)bindingSource.DataSource;
            BindingSource.DataSource = (DataTable)bindingSource.DataSource;
            DataSource = (DataTable)bindingSource.DataSource;
            Data = DataTable.AsEnumerable( );
            Series[ 0 ].ChartType = type;
            Measure = stat;
        }
        
        /// <summary>
        /// Sets the area properties.
        /// </summary>
        private void SetAreaProperties( )
        {
            if( ChartAreas.Count > 0 )
            {
                try
                {
                    // General Area Properties
                    ChartAreas[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
                    ChartAreas[ 0 ].Area3DStyle.Enable3D = true;
                    ChartAreas[ 0 ].BorderColor = Color.FromArgb( 24, 47, 66 );
                    ChartAreas[ 0 ].BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
                    ChartAreas[ 0 ].Area3DStyle.PointDepth = 150;
                    ChartAreas[ 0 ].Area3DStyle.Inclination = 35;

                    // Horizontal Axis Properties
                    ChartAreas[ 0 ].AxisX.IsLabelAutoFit = true;
                    ChartAreas[ 0 ].AxisX.InterlacedColor = Color.Transparent;
                    ChartAreas[ 0 ].AxisX.LineColor = Color.FromArgb( 24, 47, 66 );
                    ChartAreas[ 0 ].AxisX.TitleFont = new Font( "Roboto", 8 );
                    ChartAreas[ 0 ].AxisX.TitleForeColor =Color.FromArgb( 0, 120, 212 );
                    ChartAreas[ 0 ].AxisX.LabelStyle.Font = new Font( "Roboto", 7 );
                    ChartAreas[ 0 ].AxisX.LabelStyle.ForeColor = Color.FromArgb( 0, 120, 212 );
                    ChartAreas[ 0 ].AxisX.MajorGrid.LineColor = Color.FromArgb( 24, 47, 66 );
                    ChartAreas[ 0 ].AxisX.MinorGrid.LineColor = Color.FromArgb( 65, 65, 65 );
                    ChartAreas[ 0 ].AxisX.TextOrientation = TextOrientation.Auto;

                    // Vertical Axis Properties
                    ChartAreas[ 0 ].AxisY.IsLabelAutoFit = true;
                    ChartAreas[ 0 ].AxisY.InterlacedColor = Color.Transparent;
                    ChartAreas[ 0 ].AxisY.LineColor = Color.FromArgb( 24, 47, 66 );
                    ChartAreas[ 0 ].AxisY.TitleFont = new Font( "Roboto", 8 );
                    ChartAreas[ 0 ].AxisY.TitleForeColor = Color.FromArgb( 0, 120, 212 );
                    ChartAreas[ 0 ].AxisY.LabelStyle.Font = new Font( "Roboto", 7 );
                    ChartAreas[ 0 ].AxisY.LabelStyle.Format = "N0";
                    ChartAreas[ 0 ].AxisY.LabelStyle.ForeColor = Color.FromArgb( 0, 120, 212 );
                    ChartAreas[ 0 ].AxisY.MajorGrid.LineColor = Color.FromArgb( 24, 47, 66 );
                    ChartAreas[ 0 ].AxisY.MinorGrid.LineColor = Color.FromArgb( 65, 65, 65 );
                    ChartAreas[ 0 ].AxisY.TextOrientation = TextOrientation.Auto;
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
        private void SetTitleProperties( )
        {
            if( Titles.Count > 0 )
            {
                try
                {
                    Titles[ 0 ].Font = new Font( "Roboto", 10, FontStyle.Bold );
                    Titles[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
                    Titles[ 0 ].BorderColor = Color.FromArgb( 20, 20, 20 );
                    Titles[ 0 ].ForeColor = Color.FromArgb( 0, 120, 212 );
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
        private void SetLegendProperties( )
        {
            if(Legends.Count > 0 )
            {
                try
                {
                    Legends[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
                    Legends[ 0 ].ForeColor = Color.LightGray;
                    Legends[ 0 ].HeaderSeparatorColor = Color.FromArgb( 20, 20, 20 );
                    Legends[ 0 ].ItemColumnSeparatorColor = Color.FromArgb( 20, 20, 20 );
                    Legends[ 0 ].BorderColor = Color.FromArgb( 20, 20, 20 );
                    Legends[ 0 ].TitleFont = new Font( "Roboto", 7 );
                    Legends[ 0 ].TitleForeColor = Color.FromArgb( 0, 120, 212 );
                    Legends[ 0 ].TitleBackColor = Color.FromArgb( 20, 20, 20 );
                    Legends[ 0 ].Enabled = true;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the series properties.
        /// </summary>
        private void SetSeriesProperties( )
        {
            if( Series.Count > 0 )
            {
                try
                {
                    Series[ 0 ].ChartType = SeriesChartType.Column;
                    Series[ 0 ].IsValueShownAsLabel = true;
                    Series[ 0 ].IsVisibleInLegend = true;
                    Series[ 0 ].LabelBorderColor = Color.Transparent;
                    Series[ 0 ].LabelBackColor = Color.Transparent;
                    Series[ 0 ].LabelForeColor = Color.LightGray;
                    Series[ 0 ].LabelFormat = "N0";
                    Series[ 0 ].MarkerColor = Color.Yellow;
                    Series[ 0 ].MarkerStyle = MarkerStyle.Triangle;
                    Series[ 0 ].Font = new Font( "Roboto", 7 );
                    Series[ 0 ].XValueType = ChartValueType.Auto;
                    Series[ 0 ].YValueType = ChartValueType.Auto;
                    Series[ 0 ].SmartLabelStyle.CalloutBackColor = Color.Transparent;
                    Series[ 0 ].SmartLabelStyle.CalloutStyle = LabelCalloutStyle.Box;
                    Series[ 0 ].SmartLabelStyle.CalloutLineColor = Color.Transparent;
                    Series[ 0 ].SmartLabelStyle.CalloutLineWidth = 0;
                    Series[ 0 ].SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.Arrow;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }
    }
}
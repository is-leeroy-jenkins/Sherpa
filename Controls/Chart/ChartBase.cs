// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-07-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="ChartBase.cs" company="Terry D. Eppler">
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
//   ChartBase.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms.DataVisualization.Charting;

    /// <summary>
    ///  
    /// </summary>
    /// <seealso cref="System.Windows.Forms.DataVisualization.Charting.Chart" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class ChartBase : System.Windows.Forms.DataVisualization.Charting.Chart
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBase"/> class.
        /// </summary>
        protected ChartBase( )
        {
            BackColor = Color.FromArgb( 20, 20, 20 );
            BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.White;
            BorderlineColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BackSecondaryColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.PageColor = Color.FromArgb( 20, 20, 20 );
            BorderSkin.BorderColor = Color.FromArgb( 20, 20, 20 );
        }

        /// <summary>
        /// Sets the area properties.
        /// </summary>
        private protected void SetAreaProperties( )
        {
            try
            {
                var _black = Color.FromArgb( 20, 20, 20 );
                var _gray = Color.FromArgb( 65, 65, 65 );
                var _transparent = Color.Transparent;
                var _blue = Color.FromArgb( 0, 120, 212 );
                var _darkBlue = Color.FromArgb( 24, 47, 66 );

                // General Area Properties
                ChartAreas[ 0 ].BackColor = _black;
                ChartAreas[ 0 ].Area3DStyle.Enable3D = true;
                ChartAreas[ 0 ].BorderColor = _darkBlue;
                ChartAreas[ 0 ].BackSecondaryColor = _black;
                ChartAreas[ 0 ].Area3DStyle.PointDepth = 150;
                ChartAreas[ 0 ].Area3DStyle.Inclination = 35;

                // Horizontal Axis Properties
                ChartAreas[ 0 ].AxisX.IsLabelAutoFit = true;
                ChartAreas[ 0 ].AxisX.InterlacedColor = _transparent;
                ChartAreas[ 0 ].AxisX.LineColor = _darkBlue;
                ChartAreas[ 0 ].AxisX.TitleFont = new Font( "Roboto", 8 );
                ChartAreas[ 0 ].AxisX.TitleForeColor = _blue;
                ChartAreas[ 0 ].AxisX.LabelStyle.Font = new Font( "Roboto", 7 );
                ChartAreas[ 0 ].AxisX.LabelStyle.ForeColor = _blue;
                ChartAreas[ 0 ].AxisX.MajorGrid.LineColor = _darkBlue;
                ChartAreas[ 0 ].AxisX.MinorGrid.LineColor = _gray;
                ChartAreas[ 0 ].AxisX.TextOrientation = TextOrientation.Auto;

                // Vertical Axis Properties
                ChartAreas[ 0 ].AxisY.IsLabelAutoFit = true;
                ChartAreas[ 0 ].AxisY.InterlacedColor = _transparent;
                ChartAreas[ 0 ].AxisY.LineColor = _darkBlue;
                ChartAreas[ 0 ].AxisY.TitleFont = new Font( "Roboto", 8 );
                ChartAreas[ 0 ].AxisY.TitleForeColor = _blue;
                ChartAreas[ 0 ].AxisY.LabelStyle.Font = new Font( "Roboto", 7 );
                ChartAreas[ 0 ].AxisY.LabelStyle.Format = "N0";
                ChartAreas[ 0 ].AxisY.LabelStyle.ForeColor = _blue;
                ChartAreas[ 0 ].AxisY.MajorGrid.LineColor = _darkBlue;
                ChartAreas[ 0 ].AxisY.MinorGrid.LineColor = _gray;
                ChartAreas[ 0 ].AxisY.TextOrientation = TextOrientation.Auto;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the title properties.
        /// </summary>
        private protected void SetTitleProperties( )
        {
            try
            {
                Titles[ 0 ].Font = new Font( "Roboto", 10, FontStyle.Bold );
                Titles[ 0 ].BackColor = Color.FromArgb( 20, 20, 20 );
                Titles[ 0 ].BorderColor = Color.FromArgb( 20, 20, 20 );
                Titles[ 0 ].ForeColor = Color.FromArgb( 0, 120, 212 );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the legend properties.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="enabled">if set to <c>true</c> [enabled].</param>
        private protected void SetLegendProperties( int i = 0, bool enabled = false )
        {
            try
            {
                Legends[ i ].HeaderSeparatorColor = Color.FromArgb( 20, 20, 20 );
                Legends[ i ].ItemColumnSeparatorColor = Color.FromArgb( 20, 20, 20 );
                Legends[ i ].BorderColor = Color.FromArgb( 20, 20, 20 );
                Legends[ i ].TitleFont = new Font( "Roboto", 7 );
                Legends[ i ].TitleForeColor = Color.FromArgb( 0, 120, 212 );
                Legends[ i ].TitleBackColor = Color.FromArgb( 20, 20, 20 );
                Legends[ i ].Enabled = enabled;
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
        private protected void SetSeriesProperties( int i = 0 )
        {
            try
            {
                Series[ i ].ChartType = SeriesChartType.Column;
                Series[ i ].IsValueShownAsLabel = true;
                Series[ i ].IsVisibleInLegend = true;
                Series[ i ].LabelBorderColor = Color.Transparent;
                Series[ i ].LabelBackColor = Color.Transparent;
                Series[ i ].LabelForeColor = Color.LightGray;
                Series[ i ].LabelFormat = "N0";
                Series[ i ].MarkerColor = Color.Yellow;
                Series[ i ].MarkerStyle = MarkerStyle.Triangle;
                Series[ i ].Font = new Font( "Roboto", 7 );
                Series[ i ].XValueType = ChartValueType.Auto;
                Series[ i ].YValueType = ChartValueType.Auto;
                Series[ i ].SmartLabelStyle.CalloutBackColor = Color.Transparent;
                Series[ i ].SmartLabelStyle.CalloutStyle = LabelCalloutStyle.Box;
                Series[ i ].SmartLabelStyle.CalloutLineColor = Color.Transparent;
                Series[ i ].SmartLabelStyle.CalloutLineWidth = 0;
                Series[ i ].SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.Arrow;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the chart palette colors.
        /// </summary>
        private protected void SetChartPaletteColors( )
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

                PaletteCustomColors = _palette;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}
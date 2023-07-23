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

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.DataVisualization.Charting.Chart" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class ChartBase : System.Windows.Forms.DataVisualization.Charting.Chart
    {
        /// <summary>
        /// Sets the area properties.
        /// </summary>
        private protected void InitializeArea( )
        {
            try
            {
                if( ChartAreas?.Count > 0 )
                {
                    var _black = Color.FromArgb( 20, 20, 20 );
                    var _gray = Color.FromArgb( 65, 65, 65 );
                    var _transparent = Color.Transparent;
                    var _blue = Color.FromArgb( 0, 120, 212 );
                    var _darkBlue = Color.FromArgb( 24, 47, 66 );
                    var _count = ChartAreas.Count;
                    for( var _i = 0; _i < _count; _i++ )
                    {
                        // General Area Properties
                        ChartAreas[ _i ].BackColor = _black;
                        ChartAreas[ _i ].Area3DStyle.Enable3D = true;
                        ChartAreas[ _i ].BorderColor = _darkBlue;
                        ChartAreas[ _i ].BackSecondaryColor = _black;
                        ChartAreas[ _i ].Area3DStyle.PointDepth = 150;
                        ChartAreas[ _i ].Area3DStyle.Inclination = 35;

                        // Horizontal Axis Properties
                        ChartAreas[ _i ].AxisX.IsLabelAutoFit = true;
                        ChartAreas[ _i ].AxisX.InterlacedColor = _transparent;
                        ChartAreas[ _i ].AxisX.LineColor = _darkBlue;
                        ChartAreas[ _i ].AxisX.TitleFont = new Font( "Roboto", 8 );
                        ChartAreas[ _i ].AxisX.TitleForeColor = _blue;
                        ChartAreas[ _i ].AxisX.LabelStyle.Font = new Font( "Roboto", 7 );
                        ChartAreas[ _i ].AxisX.LabelStyle.ForeColor = _blue;
                        ChartAreas[ _i ].AxisX.MajorGrid.LineColor = _darkBlue;
                        ChartAreas[ _i ].AxisX.MinorGrid.LineColor = _gray;
                        ChartAreas[ _i ].AxisX.TextOrientation = TextOrientation.Auto;

                        // Vertical Axis Properties
                        ChartAreas[ _i ].AxisY.IsLabelAutoFit = true;
                        ChartAreas[ _i ].AxisY.InterlacedColor = _transparent;
                        ChartAreas[ _i ].AxisY.LineColor = _darkBlue;
                        ChartAreas[ _i ].AxisY.TitleFont = new Font( "Roboto", 8 );
                        ChartAreas[ _i ].AxisY.TitleForeColor = _blue;
                        ChartAreas[ _i ].AxisY.LabelStyle.Font = new Font( "Roboto", 7 );
                        ChartAreas[ _i ].AxisY.LabelStyle.Format = "N0";
                        ChartAreas[ _i ].AxisY.LabelStyle.ForeColor = _blue;
                        ChartAreas[ _i ].AxisY.MajorGrid.LineColor = _darkBlue;
                        ChartAreas[ _i ].AxisY.MinorGrid.LineColor = _gray;
                        ChartAreas[ _i ].AxisY.TextOrientation = TextOrientation.Auto;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the title properties.
        /// </summary>
        private protected void InitializeTitle( )
        {
            try
            {
                if( Titles?.Count > 0 )
                {
                    var _count = Titles.Count;
                    for( var _i = 0; _i < _count; _i++ )
                    {
                        Titles[ _i ].Font = new Font( "Roboto", 10, FontStyle.Bold );
                        Titles[ _i ].BackColor = Color.FromArgb( 20, 20, 20 );
                        Titles[ _i ].BorderColor = Color.FromArgb( 20, 20, 20 );
                        Titles[ _i ].ForeColor = Color.FromArgb( 0, 120, 212 );
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the legend properties.
        /// </summary>
        /// <param name="count">The number of legends.</param>
        private protected void InitializeLegend( )
        {
            try
            {
                if( Legends?.Count > 0 )
                {
                    var _count = Legends.Count;
                    for( var _i = 0; _i < _count; _i++ )
                    {
                        Legends[ _i ].BackColor = Color.Transparent;
                        Legends[ _i ].ForeColor = Color.LightGray;
                        Legends[ _i ].HeaderSeparatorColor = Color.FromArgb( 20, 20, 20 );
                        Legends[ _i ].ItemColumnSeparatorColor = Color.FromArgb( 20, 20, 20 );
                        Legends[ _i ].BorderColor = Color.FromArgb( 20, 20, 20 );
                        Legends[ _i ].TitleFont = new Font( "Roboto", 7 );
                        Legends[ _i ].TitleForeColor = Color.FromArgb( 0, 120, 212 );
                        Legends[ _i ].TitleBackColor = Color.FromArgb( 20, 20, 20 );
                        Legends[ _i ].Enabled = true;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the series properties.
        /// </summary>
        private protected void InitializeSeries( )
        {
            try
            {
                if( Series?.Count > 0 )
                {
                    var _count = Series.Count;
                    for( var _i = 0; _i < _count; _i++ )
                    {
                        Series[ _i ].ChartType = SeriesChartType.Column;
                        Series[ _i ].IsValueShownAsLabel = true;
                        Series[ _i ].IsVisibleInLegend = true;
                        Series[ _i ].LabelBorderColor = Color.Transparent;
                        Series[ _i ].LabelBackColor = Color.Transparent;
                        Series[ _i ].LabelForeColor = Color.LightGray;
                        Series[ _i ].LabelFormat = "N0";
                        Series[ _i ].MarkerColor = Color.Yellow;
                        Series[ _i ].MarkerStyle = MarkerStyle.Triangle;
                        Series[ _i ].Font = new Font( "Roboto", 7 );
                        Series[ _i ].XValueType = ChartValueType.Auto;
                        Series[ _i ].YValueType = ChartValueType.Auto;
                        Series[ _i ].SmartLabelStyle.CalloutBackColor = Color.Transparent;
                        Series[ _i ].SmartLabelStyle.CalloutStyle = LabelCalloutStyle.Box;
                        Series[ _i ].SmartLabelStyle.CalloutLineColor = Color.Transparent;
                        Series[ _i ].SmartLabelStyle.CalloutLineWidth = 0;
                        Series[ _i ].SmartLabelStyle.CalloutLineAnchorCapStyle = LineAnchorCapStyle.Arrow;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the chart palette colors.
        /// </summary>
        private protected void InitializePalette( )
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
            catch( Exception _ex )
            {
                Fail( _ex );
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
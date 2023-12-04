//  ******************************************************************************************
//      Assembly:                Budget Execution
//      Filename:                Graph.cs
//      Author:                  Terry D. Eppler
//      Created:                 05-31-2023
// 
//      Last Modified By:        Terry D. Eppler
//      Last Modified On:        06-01-2023
//  ******************************************************************************************
//  <copyright file="Graph.cs" company="Terry D. Eppler">
// 
//     This is a Federal Budget, Finance, and Accounting application for the
//     US Environmental Protection Agency (US EPA).
//     Copyright ©  2023  Terry Eppler
// 
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the “Software”),
//     to deal in the Software without restriction,
//     including without limitation the rights to use,
//     copy, modify, merge, publish, distribute, sublicense,
//     and/or sell copies of the Software,
//     and to permit persons to whom the Software is furnished to do so,
//     subject to the following conditions:
// 
//     The above copyright notice and this permission notice shall be included in all
//     copies or substantial portions of the Software.
// 
//     THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//     INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//     IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//     DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//     ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//     DEALINGS IN THE SOFTWARE.
// 
//     You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// 
//  </copyright>
//  <summary>
//    Graph.cs
//  </summary>
//  ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;
    using Color = System.Drawing.Color;
    using Font = System.Drawing.Font;
    using Size = System.Drawing.Size;

    /// <inheritdoc />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "PossibleNullReferenceException" ) ]
    [ SuppressMessage( "ReSharper", "FunctionComplexityOverflow" ) ]
    public class Chart : ChartControl
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:BudgetExecution.Chart" />
        /// class.
        /// </summary>
        public Chart( )
        {
            //Basic Control Properties
            Size = new Size( 600, 400 );
            Font = new Font( "Roboto", 9 );
            ShowToolbar = true;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = new Padding( 1 );
            Margin = new Padding( 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            AllowGapForEmptyPoints = false;
            AllowGradientPalette = true;
            AutoHighlight = false;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            CalcRegions = true;
            ChartAreaMargins = new ChartMargins( 0, 0, 0, 0 );
            DropSeriesPoints = false;
            AddRandomSeries = true;
            ChartAreaShadow = false;
            Series3D = true;
            SeriesHighlight = true;
            RealMode3D = true;
            AutoHighlight = true;
            Style3D = true;
            ShowLegend = false;
            ShowToolTips = false;
            DisplayChartContextMenu = false;
            DisplaySeriesContextMenu = false;
            SeriesHighlightIndex = -1;
            Depth = 150;
            ElementsSpacing = 10;
            Spacing = 1;
            SpacingBetweenPoints = 10;
            SpacingBetweenSeries = 10;
            ColumnFixedWidth = 20;
            ColumnDrawMode = ChartColumnDrawMode.ClusteredMode;
            ColumnWidthMode = ChartColumnWidthMode.DefaultWidthMode;
            Palette = ChartColorPalette.Office2016;
            Skins = Skins.Office2016Black;
            Rotation = 15;
            SmoothingMode = SmoothingMode.AntiAlias;
            TextAlignment = StringAlignment.Center;
            TextPosition = ChartTextPosition.Top;
            Tilt = 3;
            RadarStyle = ChartRadarAxisStyle.Polygon;
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.FromArgb( 106, 189, 252 );
            PrimaryXAxis.Font = new Font( "Roboto", 8 );
            PrimaryXAxis.ForeColor = Color.White;
            PrimaryXAxis.AxisLabelPlacement = ChartPlacement.Outside;
            PrimaryXAxis.ValueType = ChartValueType.Category;
            PrimaryXAxis.TitleFont = new Font( "Roboto", 8 );
            PrimaryXAxis.TitleColor = Color.FromArgb( 106, 189, 252 );
            PrimaryXAxis.Title = "Records";
            PrimaryYAxis.Font = new Font( "Roboto", 8 );
            PrimaryYAxis.ForeColor = Color.White;
            PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Outside;
            PrimaryYAxis.ValueType = ChartValueType.Double;
            PrimaryYAxis.TitleFont = new Font( "Roboto", 9 );
            PrimaryYAxis.TitleColor = Color.FromArgb( 106, 189, 252 );
            PrimaryYAxis.Format = "#,##0";
            Tooltip.Font = new Font( "Roboto", 8 );
            Tooltip.ForeColor = Color.FromArgb( 106, 189, 252 );
            Tooltip.BackgroundColor = new BrushInfo( GradientStyle.None,
                Color.FromArgb( 106, 189, 252 ), Color.Black );

            Tooltip.BorderStyle = BorderStyle.FixedSingle;
            ToolBar.Border.ForeColor = Color.Black;
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.ButtonBackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.Position = ChartDock.Bottom;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
            ToolBar.BackColor = Color.FromArgb( 20, 20, 20 );
            Title.Font = new Font( "Roboto", 10 );
            Title.ForeColor = Color.FromArgb( 106, 189, 252 );
            Title.BackColor = Color.Transparent;
            Legend.BackColor = Color.Transparent;
            Legend.ForeColor = Color.FromArgb( 106, 189, 252 );
            Legend.Font = new Font( "Roboto", 7 );
            Legend.ShowBorder = false;
            Legend.ColumnsCount = 1;
            Legend.Position = ChartDock.Right;
            Legend.VisibleCheckBox = true;
            Legend.Visible = false;
            ChartArea.RealSeries3D = true;
            ChartArea.Series3D = true;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( GradientStyle.None, 
                Color.FromArgb( 106, 189, 252 ), Color.FromArgb( 20, 20, 20 ) );
        }

        /// <summary>
        /// Sets the custom palette.
        /// </summary>
        /// <param name="one">The one.</param>
        /// <param name="two">The two.</param>
        /// <param name="three">The three.</param>
        /// <param name="four">The four.</param>
        public void SetCustomPalette( Color one, Color two, Color three, Color four )
        {
            if( one != Color.Empty 
               && two != Color.Empty 
               && three != Color.Empty 
               && four != Color.Empty )
            {
                try
                {
                    CustomPalette = new[ ]
                    {
                        one, 
                        two, 
                        three, 
                        four
                    };
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary>
        /// Sets the primary axis titleInfo.
        /// </summary>
        /// <param name="text">
        /// The titleInfo.
        /// </param>
        /// <param name="font">
        /// </param>
        /// <param name="color">
        /// The color.
        /// </param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            try
            {
                PrimaryXAxis.Title = text;
                PrimaryXAxis.TitleColor = color;
                PrimaryXAxis.TitleFont = font;
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }

        /// <summary>
        /// Sets the main titleInfo.
        /// </summary>
        /// <param name="text">
        /// The text.
        /// </param>
        /// <param name="font">
        /// </param>
        /// <param name="color">
        /// </param>
        public void SetMainTitle( string text, Font font, Color color )
        {
            try
            {
                if( Titles?.Count > 0 )
                {
                    Titles.Clear( );
                }

                using var _title = new ChartTitle( );
                _title.Visible = true;
                _title.Font = font;
                _title.BackColor = Color.Transparent;
                _title.ForeColor = color;
                _title.Text = text;
                Titles[ 0 ] = _title;
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
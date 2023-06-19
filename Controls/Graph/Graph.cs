// ******************************************************************************************
//     Assembly:                Budget Execution
//     Author:                  Terry D. Eppler
//     Created:                 05-18-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        05-31-2023
// ******************************************************************************************
// <copyright file="Graph.cs" company="Terry D. Eppler">
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
//   Graph.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class Graph : GraphBase
    {
        // Initializes Properties
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Graph"/>
        /// class.
        /// </summary>
        public Graph( )
        {
            //Basic Control Properties
            Size = new Size( 600, 400 );
            ShowLegend = false;
            ShowToolbar = true;
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.ButtonBackColor = Color.FromArgb( 20, 20, 20 );
            ToolBar.Position = ChartDock.Bottom;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = new Padding( 1 );
            Margin = new Padding( 3 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            AllowGapForEmptyPoints = true;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            BackColor = Color.FromArgb( 20, 20, 20 );
            ForeColor = Color.LightGray;
            CalcRegions = true;
            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, 
                Color.LightSteelBlue, Color.FromArgb( 20, 20, 20 ) );
            
            //ChartArea Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            ChartArea.BorderWidth = 1;
            ChartArea.BorderColor = Color.Transparent;
            ChartArea.BorderStyle = BorderStyle.FixedSingle;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;
            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, 
                Color.FromArgb( 20, 20, 20 ), Color.Silver );
            
            Depth = 250;
            ElementsSpacing = 10;
            ColumnDrawMode = ChartColumnDrawMode.InDepthMode;
            ColumnFixedWidth = 20;

            //Chart Appearance Setting
            Palette = ChartColorPalette.Metro;
            Skins = Skins.None;
            RealMode3D = true;
            Rotation = 0.1f;
            SmoothingMode = SmoothingMode.AntiAlias;
            Spacing = 5;
            AutoHighlight = true;
            SpacingBetweenPoints = 5;
            SpacingBetweenSeries = 10;
            Style3D = true;
            TextAlignment = StringAlignment.Center;
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Setting;
            ShowLegend = true;
            Legend.Font = new Font( "Roboto", 9 );
            Legend.ItemsSize = new Size( 12, 12 );
            Legend.VisibleCheckBox = true;
            Legend.BackInterior = new BrushInfo( Color.FromArgb( 20, 20, 20 ) );
            Legend.ItemsAlignment = StringAlignment.Center;
            Legend.ItemsTextAligment = VerticalAlignment.Center;
            Legend.Orientation = ChartOrientation.Vertical;
            Legend.FloatingAutoSize = true;
            Legend.ShowSymbol = true;
            Legend.ShowItemsShadow = true;
            Legend.ShowBorder = false;
            Legend.Visible = true;
        }

        /// <summary> Sets the size. </summary>
        /// <param name="width"> The width. </param>
        /// <param name="height"> The height. </param>
        public void SetSize( int width = 600, int height = 400 )
        {
            if( ( width > 0 )
               && ( height > 0 ) )
            {
                try
                {
                    Size = new Size( width, height );
                }
                catch( Exception _ex )
                {
                    Fail( _ex );
                }
            }
        }

        /// <summary> Sets the primary axis titleInfo. </summary>
        /// <param name="text"> The titleInfo. </param>
        /// <param name="font"> </param>
        /// <param name="color"> The color. </param>
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

        /// <summary> Sets the main titleInfo. </summary>
        /// <param name="text"> The t. </param>
        /// <param name="font"> </param>
        /// <param name="color"> </param>
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
                _title.BackColor = Color.FromArgb( 18, 18, 18 );
                _title.ForeColor = color;
                _title.Text = text;
                Titles?.Add( _title );
            }
            catch( Exception _ex )
            {
                Fail( _ex );
            }
        }
    }
}
// <copyright file = "BudgetExecutionChart.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class BudgetExecutionChart : ChartBase, IBudgetChart
    {
        // Initializes Properties
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetExecutionChart"/> class.
        /// </summary>
        public BudgetExecutionChart()
        {
            //Basic Control Properties
            Size = BudgetSize.GetSize( 600, 400 );
            Location = BudgetControl.GetLocation( 1, 1 );
            ShowLegend = false;
            ShowToolbar = false;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = BudgetControl.Padding;
            Margin = BudgetControl.Margin;
            Anchor = BudgetControl.GetAnchorStyle();
            AllowGapForEmptyPoints = true;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( BudgetColor.FormBackColorDark );
            BackColor = BudgetColor.FormBackColorDark;

            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, Color.LightGray,
                BudgetColor.FormBackColorDark );

            CalcRegions = true;

            //ChartArea Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( BudgetColor.FormBackColorDark );
            ChartArea.BorderWidth = BudgetBorder.Thin;
            ChartArea.BorderColor = BudgetColor.ColorTransparent;
            ChartArea.BorderStyle = BorderStyle.FixedSingle;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;

            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, BudgetColor.FormBackColorDark,
                Color.Silver );

            Depth = 250;
            ElementsSpacing = 10;
            ColumnDrawMode = ChartColumnDrawMode.InDepthMode;
            ColumnFixedWidth = 20;

            //Chart Appearance Settings
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
            TextAlignment = BudgetAlign.GetStringAlignment( StringAlignment.Center );
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Settings;
            ShowLegend = true;
            Legend.Font = BudgetFont.FontSizeSmall;
            Legend.ItemsSize = BudgetSize.ImageSizeSmall;
            Legend.VisibleCheckBox = true;
            Legend.BackInterior = new BrushInfo( BudgetColor.FormBackColorDark );
            Legend.ItemsAlignment = BudgetAlign.GetStringAlignment( StringAlignment.Center );
            Legend.ItemsTextAligment = VerticalAlignment.Center;
            Legend.Orientation = ChartOrientation.Vertical;
            Legend.FloatingAutoSize = true;
            Legend.ShowSymbol = true;
            Legend.ShowItemsShadow = true;
            Legend.ShowBorder = false;
            Legend.Visible = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetExecutionChart" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public BudgetExecutionChart( DataTable table, ISeriesConfig seriesConfig )
            : this()
        {
            SourceModel = new SourceModel( table, seriesConfig );
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( table, seriesConfig );
            DataMetric = SourceModel.GetMetric();
            TitleInfo = new TitleInfo( DataMetric.Data?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetExecutionChart" /> class.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public BudgetExecutionChart( IEnumerable<DataRow> dataRows, ISeriesConfig seriesConfig )
            : this()
        {
            SourceModel = new SourceModel( dataRows, seriesConfig );
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( dataRows, seriesConfig );
            DataMetric = SourceModel.GetMetric();
            TitleInfo = new TitleInfo( DataMetric.Data?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecutionChart" />
        /// class.
        /// </summary>
        /// <param name="sourceBinding">The sourceBinding.</param>
        public BudgetExecutionChart( IChartBinding sourceBinding )
            : this()
        {
            SourceModel = new SourceModel( sourceBinding );
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( sourceBinding );
            DataMetric = SourceModel.GetMetric();
            TitleInfo = new TitleInfo( DataMetric.Data?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecutionChart" />
        /// class.
        /// </summary>
        /// <param name="sourceModel">The sourceModel.</param>
        public BudgetExecutionChart( ISourceModel sourceModel )
            : this()
        {
            SourceModel = sourceModel;
            Configuration = SourceModel.GetSeriesConfiguration();
            ChartData = new SeriesModel( SourceModel.GetSourceBinding() );
            TitleInfo = new TitleInfo( Configuration.Name );
            DataMetric = SourceModel.GetMetric();
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecutionChart" />
        /// class.
        /// </summary>
        /// <param name="sourceModel">The sourceModel.</param>
        /// <param name="titleInfo">The titleInfo.</param>
        public BudgetExecutionChart( ISourceModel sourceModel, ITitleInfo titleInfo )
            : this()
        {
            SourceModel = sourceModel;
            Configuration = SourceModel.GetSeriesConfiguration();
            TitleInfo = titleInfo;
            DataMetric = SourceModel.GetMetric();
            ChartData = new SeriesModel( SourceModel.GetSourceBinding() );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecutionChart" />
        /// class.
        /// </summary>
        /// <param name="chartData">The chartData.</param>
        /// <param name="titleInfo">The titleInfo.</param>
        public BudgetExecutionChart( ISeriesModel chartData, ITitleInfo titleInfo )
            : this()
        {
            ChartData = chartData;
            Configuration = ChartData.GetSeriesConfiguration();
            SourceModel = ChartData.GetSourceModel();
            TitleInfo = titleInfo;
            DataMetric = ChartData.GetSeriesMetric();
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }
        
        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width = 600, int height = 400 )
        {
            if( width > 0
                && height > 0 )
            {
                try
                {
                    Size = new Size( width, height );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void SetLocation( int x = 1, int y = 1 )
        {
            if( x > 0
                && y > 0 )
            {
                try
                {
                    Location = new Point( x, y );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void SetParent( Control parent )
        {
            if( parent != null )
            {
                try
                {
                    Parent = parent;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the primary axis titleInfo.
        /// </summary>
        /// <param name="text">The titleInfo.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            try
            {
                PrimaryXAxis.Title = text;
                PrimaryXAxis.TitleColor = color;
                PrimaryXAxis.TitleFont = font;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the main titleInfo.
        /// </summary>
        /// <param name="text">The t.</param>
        /// <param name="font"></param>
        /// <param name="color"></param>
        public void SetMainTitle( string text, Font font, Color color )
        {
            try
            {
                if( Titles?.Count > 0 )
                {
                    Titles.Clear();
                }

                using var title = new ChartTitle();
                title.Visible = true;
                title.Font = font;
                title.BackColor = BudgetColor.FormBackColorDark;
                title.ForeColor = color;
                title.Text = text;
                Titles?.Add( title );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}
// <copyright file = "BudgetChart.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class BudgetChart : ChartBase, IBudgetChart
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public override ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public override Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public override NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        // Initializes Properties
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BudgetExecution.BudgetChart"/> class.
        /// </summary>
        public BudgetChart()
        {
            //Basic Control Properties
            Size = BudgetSize.ChartControl;
            Location = BudgetControl.GetLocation( );
            ShowLegend = false;
            ShowToolbar = true;
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.ButtonBackColor = BudgetColor.FormDark;
            ToolBar.Position = ChartDock.Bottom;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = BudgetControl.Padding;
            Margin = BudgetControl.Margin;
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            AllowGapForEmptyPoints = true;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( BudgetColor.FormDark );
            BackColor = BudgetColor.FormDark;

            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, Color.LightGray,
                BudgetColor.FormDark );

            CalcRegions = true;

            //ChartArea Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( BudgetColor.FormDark );
            ChartArea.BorderWidth = BudgetBorder.Thin;
            ChartArea.BorderColor = BudgetColor.Transparent;
            ChartArea.BorderStyle = BorderStyle.FixedSingle;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;

            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, BudgetColor.FormDark,
                Color.Silver );

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
            TextAlignment = BudgetAlign.GetStringAlignment( StringAlignment.Center );
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Setting;
            ShowLegend = true;
            Legend.Font = BudgetFont.FontSizeSmall;
            Legend.ItemsSize = BudgetSize.ImageSizeSmall;
            Legend.VisibleCheckBox = true;
            Legend.BackInterior = new BrushInfo( BudgetColor.FormDark );
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
        /// Initializes a new instance of the <see cref="BudgetExecution.BudgetChart" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public BudgetChart( DataTable table, ISeriesConfig seriesConfig )
            : this()
        {
            SourceModel = new SourceModel( table, seriesConfig );
            Configuration = seriesConfig;
            ChartData = new SeriesModel( table, seriesConfig );
            DataMetric = SourceModel.Metric;
            TitleInfo = new TitleInfo( DataMetric.Data?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetExecution.BudgetChart" /> class.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public BudgetChart( IEnumerable<DataRow> dataRows, ISeriesConfig seriesConfig )
            : this()
        {
            SourceModel = new SourceModel( dataRows, seriesConfig );
            Configuration = seriesConfig;
            ChartData = new SeriesModel( dataRows, seriesConfig );
            DataMetric = SourceModel.Metric;
            TitleInfo = new TitleInfo( DataMetric.Data?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecution.BudgetChart" />
        /// class.
        /// </summary>
        /// <param name="sourceBinding">The sourceBinding.</param>
        public BudgetChart( IChartBinding sourceBinding )
            : this()
        {
            SourceModel = new SourceModel( sourceBinding );
            Configuration = sourceBinding.GetSeriesConfig();
            ChartData = new SeriesModel( sourceBinding );
            DataMetric = SourceModel.Metric;
            TitleInfo = new TitleInfo( DataMetric.Data?.CopyToDataTable()?.TableName );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecution.BudgetChart" />
        /// class.
        /// </summary>
        /// <param name="sourceModel">The sourceModel.</param>
        public BudgetChart( ISourceModel sourceModel )
            : this()
        {
            SourceModel = sourceModel;
            Configuration = SourceModel.SourceBinding.GetSeriesConfig();
            ChartData = new SeriesModel( SourceModel.SourceBinding );
            TitleInfo = new TitleInfo( Configuration.Name );
            DataMetric = SourceModel.Metric;
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecution.BudgetChart" />
        /// class.
        /// </summary>
        /// <param name="sourceModel">The sourceModel.</param>
        /// <param name="titleInfo">The titleInfo.</param>
        public BudgetChart( ISourceModel sourceModel, ITitleInfo titleInfo )
            : this()
        {
            SourceModel = sourceModel;
            Configuration = SourceModel.SourceBinding.GetSeriesConfig();
            TitleInfo = titleInfo;
            DataMetric = SourceModel.Metric;
            ChartData = new SeriesModel( SourceModel.SourceBinding );
            DataSeries = new DataSeries( ChartData );
            Series.Add( DataSeries );
            Titles.Add( TitleInfo.GetChartMainTitle() );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetExecution.BudgetChart" />
        /// class.
        /// </summary>
        /// <param name="chartData">The chartData.</param>
        /// <param name="titleInfo">The titleInfo.</param>
        public BudgetChart( ISeriesModel chartData, ITitleInfo titleInfo )
            : this()
        {
            ChartData = chartData;
            Configuration = ChartData.SeriesConfiguration;
            SourceModel = ChartData.SourceModel;
            TitleInfo = titleInfo;
            DataMetric = ChartData.DataMetric;
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
                title.BackColor = BudgetColor.FormDark;
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
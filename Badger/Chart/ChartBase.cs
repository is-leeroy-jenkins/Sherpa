// <copyright file = "ChartBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Chart.ChartControl" />
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public class ChartBase : ChartControl
    {
        /// <summary>
        /// The style
        /// </summary>
        public IChartConfig Style { get; set; } = new ChartConfig();

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public ISourceModel SourceModel { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public ISeriesConfig Configuration { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public IDataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public ISeriesModel ChartData { get; set; }

        /// <summary>
        /// Gets the data series.
        /// </summary>
        /// <value>
        /// The data series.
        /// </value>
        public DataSeries DataSeries { get; set; }

        /// <summary>
        /// Gets the default title.
        /// </summary>
        /// <value>
        /// The title information.
        /// </value>
        public ITitleInfo TitleInfo { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBase"/> class.
        /// </summary>
        public ChartBase()
        {
        }

        /// <summary>
        /// Sets the legend configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="size">The size.</param>
        /// <param name="backColor">The backcolor.</param>
        public void SetLegend( Font font, Size size, Color backColor )
        {
            try
            {
                ShowLegend = true;
                Legend.Font = font;
                Legend.ItemsSize = size;
                Legend.VisibleCheckBox = true;
                Legend.BackInterior = new BrushInfo( backColor );
                Legend.ItemsAlignment = AlignConfig.GetStringAlignment( StringAlignment.Center );
                Legend.ItemsTextAligment = VerticalAlignment.Center;
                Legend.Orientation = ChartOrientation.Vertical;
                Legend.FloatingAutoSize = true;
                Legend.ShowSymbol = true;
                Legend.ShowItemsShadow = true;
                Legend.ShowBorder = false;
                Legend.Visible = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public ISourceModel GetSourceModel()
        {
            try
            {
                return SourceModel?.GetData()?.Any() == true
                    ? SourceModel
                    : default( ISourceModel );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISourceModel );
            }
        }

        /// <summary>
        /// Gets the series configuration.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfiguration()
        {
            try
            {
                var _type = Configuration?.GetSeriesType();

                return _type != null && Enum.IsDefined( typeof( ChartType ), _type )
                    ? Configuration
                    : default( ISeriesConfig );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISeriesConfig );
            }
        }

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetDataMetric()
        {
            try
            {
                return ( DataMetric?.Data?.Any() == true )
                    ? DataMetric
                    : default( IDataMetric );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataMetric );
            }
        }

        /// <summary>
        /// Gets the chart data.
        /// </summary>
        /// <returns></returns>
        public ISeriesModel GetChartData()
        {
            try
            {
                return ( ChartData?.GetSeriesValues()?.Any() == true )
                    ? ChartData
                    : default( ISeriesModel );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISeriesModel );
            }
        }

        /// <summary>
        /// Gets the data series.
        /// </summary>
        /// <returns></returns>
        public IDataSeries GetDataSeries()
        {
            try
            {
                return ( DataSeries?.Points?.Count > 0 )
                    ? DataSeries
                    : default( DataSeries );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataSeries );
            }
        }

        /// <summary>
        /// Gets the tile information.
        /// </summary>
        /// <returns></returns>
        public ITitleInfo GetTileInfo()
        {
            try
            {
                return Verify.IsInput( TitleInfo?.GetAxisText() )
                    ? TitleInfo
                    : default( ITitleInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ITitleInfo );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText();
            _error?.ShowDialog();
        }
    }
}
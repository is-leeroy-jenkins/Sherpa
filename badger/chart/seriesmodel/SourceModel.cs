// <copyright file = "SourceModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Chart.ChartDataBindModel" />
    /// <seealso cref="ISourceModel" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    public class SourceModel : ChartDataBindModel, ISourceModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        public SourceModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SourceModel( IEnumerable<DataRow> data, ISeriesConfig seriesConfig )
        {
            SourceBinding = new ChartBinding( data, seriesConfig );
            BindingModel = new ChartDataBindModel( data, seriesConfig?.GetField().ToString() );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding?.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding?.GetDataMetric();
            SeriesData = Metric?.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SourceModel( DataTable table, ISeriesConfig seriesConfig )
        {
            SourceBinding = new ChartBinding( table?.AsEnumerable(), seriesConfig );
            BindingModel = new ChartDataBindModel( table, seriesConfig?.GetField().ToString() );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding?.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding?.GetDataMetric();
            SeriesData = Metric?.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> struct.
        /// </summary>
        /// <param name="bindingsource">The bindingsource.</param>
        public SourceModel( IChartBinding bindingsource )
        {
            SourceBinding = bindingsource;
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding?.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding?.GetDataMetric();
            SeriesData = Metric?.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }
        
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the chart binding.
        /// </summary>
        /// <value>
        /// The chart binding.
        /// </value>
        public IChartBinding SourceBinding { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        public ChartDataBindModel BindingModel { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public IDataMetric Metric { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public ISeriesConfig Configuration { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public STAT Stat { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public IDictionary<string, IEnumerable<double>> SeriesData { get; set; }
        
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataRow> GetData()
        {
            try
            {
                return Verify.Rows( Data )
                    ? Data
                    : default( IEnumerable<DataRow> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<DataRow> );
            }
        }

        /// <summary>
        /// Gets the source binding.
        /// </summary>
        /// <returns></returns>
        public IChartBinding GetSourceBinding()
        {
            try
            {
                return Verify.IsRef( SourceBinding )
                    ? SourceBinding
                    : default( IChartBinding );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IChartBinding );
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, IEnumerable<double>> GetSeriesData()
        {
            try
            {
                return SeriesData?.Any() == true
                    ? SeriesData
                    : default( IDictionary<string, IEnumerable<double>> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, IEnumerable<double>> );
            }
        }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetMetric()
        {
            try
            {
                var data = Metric?.Data;

                return Verify.Rows( data )
                    ? Metric
                    : default( IDataMetric );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataMetric );
            }
        }

        /// <summary>
        /// Gets the series configurations.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfiguration()
        {
            try
            {
                return Verify.IsRef( Configuration )
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
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnChanged( object sender, EventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    using var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog();
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var error = new Error( ex );
            error?.SetText();
            error?.ShowDialog();
        }
    }
}
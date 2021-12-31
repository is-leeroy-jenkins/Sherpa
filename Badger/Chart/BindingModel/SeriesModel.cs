// <copyright file = "SeriesModel.cs" company = "Terry D. Eppler">
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
    /// <seealso cref="SourceModel" />
    /// <seealso cref="ISeriesModel" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class SeriesModel : SourceModel, ISeriesModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        public SeriesModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        /// <param name="bindingSource"></param>
        public SeriesModel( IChartBinding bindingSource )
            : base( bindingSource )
        {
            SourceBinding = bindingSource;
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding.GetDataMetric();
            SeriesData = Metric.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SeriesModel( DataTable table, ISeriesConfig seriesConfig )
            : base( table, seriesConfig )
        {
            SourceBinding = new ChartBinding( table, seriesConfig );
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding.GetDataMetric();
            SeriesData = Metric.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SeriesModel( IEnumerable<DataRow> data, ISeriesConfig seriesConfig )
            : base( data, seriesConfig )
        {
            SourceBinding = new ChartBinding( data, seriesConfig );
            BindingModel = new ChartDataBindModel( SourceBinding );
            Data = SourceBinding.GetData();
            Configuration = SourceBinding.GetSeriesConfig();
            Stat = Configuration.GetStatistic();
            Metric = SourceBinding.GetDataMetric();
            SeriesData = Metric.CalculateStatistics();
            BindingModel.Changed += OnChanged;
        }
        
        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetSeriesMetric()
        {
            try
            {
                return Metric;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataMetric );
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<double> GetSeriesValues()
        {
            try
            {
                var _values = SeriesData
                    ?.Values
                    ?.SelectMany( v => v );

                return ( _values?.Any() == true )
                    ? _values.ToArray()
                    : default( double[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<double> );
            }
        }

        /// <summary>
        /// Gets the series categories.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetSeriesCategories()
        {
            try
            {
                var _data = GetSeriesData();
                var _values = _data.Keys;

                return _values?.Any() == true
                    ? _values.ToArray()
                    : default( string[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
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
                return (SourceModel)MemberwiseClone();
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISourceModel );
            }
        }
    }
}
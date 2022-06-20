// <copyright file = "ChartBinding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetBinding" />
    /// <seealso cref="IChartBinding" />
    /// <seealso cref="IChartSeriesModel" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedType.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public class ChartBinding : BudgetBinding, IChartBinding, IChartSeriesModel
    {
        /// <summary>
        /// Gets or sets the chart handler.
        /// </summary>
        /// <value>
        /// The chart handler.
        /// </value>
        public ListChangedEventHandler ChartHandler { get; set; }

        /// <summary>
        /// Occurs when [changed].
        /// </summary>
        public event ListChangedEventHandler Changed;

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public new int Count { get; set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public ISeriesConfig SeriesConfiguration { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public IDataMetric Metric { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BudgetBinding" />
        /// class.
        /// </summary>
        public ChartBinding()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding" /> class.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartBinding( DataTable table, ISeriesConfig seriesConfig )
            : base( table.AsEnumerable( ) )
        {
            Data = table.AsEnumerable( );
            SeriesConfiguration = seriesConfig;
            DataTable = table;
            DataSet = DataTable?.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartBinding" />
        /// class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartBinding( IEnumerable<DataRow> data, ISeriesConfig seriesConfig )
            : base( data )
        {
            Data = data;
            SeriesConfiguration = seriesConfig;
            DataTable = data.CopyToDataTable( );
            DataSet = DataTable.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Gets the series configuration.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfig()
        {
            try
            {
                return SeriesConfiguration;
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
                return Metric;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataMetric );
            }
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            try
            {
                return Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the empty.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public bool GetEmpty( int xIndex )
        {
            try
            {
                var _numeric = SeriesConfiguration?.Numeric;
                return double.Parse( Record[ $"{_numeric}" ].ToString( ) ) > 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double GetX( int xIndex )
        {
            try
            {
                var _numeric = SeriesConfiguration?.Numeric;

                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $"{_numeric}" ].ToString( ) )
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double GetY( int xIndex )
        {
            try
            {
                var _numeric = SeriesConfiguration?.Numeric;

                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $@"{_numeric}" ].ToString( ) )
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="ListChangedEventArgs" />
        /// instance containing the event data.</param>
        public void OnCurrentChanged( object sender, ListChangedEventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    using var _message = new Message( "NOT YET IMPLEMENTED" );
                    _message?.ShowDialog( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
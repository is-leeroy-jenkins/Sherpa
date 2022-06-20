// <copyright file = "IDataSeries.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    public interface IDataSeries
    {
        /// <summary>
        /// Sets the call out.
        /// </summary>
        void SetCallOut();

        /// <summary>
        /// Gets the type of the series.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        ChartSeriesType GetSeriesType( ChartType type = ChartType.Column );

        /// <summary>
        /// Sets the point configuration.
        /// </summary>
        /// <param name="stat">The stat.</param>
        void SetPointConfiguration( STAT stat = STAT.Total );

        /// <summary>
        /// Sets the points.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="type">The type.</param>
        /// <param name="stat">The stat.</param>
        void SetPoints( IDictionary<string, double> data,
            ChartType type = ChartType.Column, STAT stat = STAT.Total );

        /// <summary>
        /// Gets the series values.
        /// </summary>
        /// <returns></returns>
        IDictionary<string, IEnumerable<double>> GetSeriesValues();
    }
}
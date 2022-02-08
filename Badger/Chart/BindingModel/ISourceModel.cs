// <copyright file = "ISourceModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    public interface ISourceModel
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        IEnumerable<DataRow> SourceData { get; set; }

        /// <summary>
        /// Gets or sets the source binding.
        /// </summary>
        /// <value>
        /// The source binding.
        /// </value>
        IChartBinding SourceBinding { get; set; }

        /// <summary>
        /// Gets or sets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        IDictionary<string, IEnumerable<double>> SeriesData { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        IDataMetric Metric { get; set; }
    }
}
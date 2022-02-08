// <copyright file = "ISeriesModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface ISeriesModel
    {
        /// <summary>
        /// Gets or sets the series configuration.
        /// </summary>
        /// <value>
        /// The series configuration.
        /// </value>
        ISeriesConfig SeriesConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the series metric.
        /// </summary>
        /// <value>
        /// The series metric.
        /// </value>
        IDataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets or sets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Gets or sets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the source model.
        /// </summary>
        /// <value>
        /// The source model.
        /// </value>
        ISourceModel SourceModel { get; set; }
    }
}
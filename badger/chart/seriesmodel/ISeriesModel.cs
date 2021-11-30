// // <copyright file = "ISeriesModel.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    public interface ISeriesModel
    {
        /// <summary> Gets the configurationg. </summary>
        /// <returns> </returns>
        ISeriesConfig GetSeriesConfiguration();

        /// <summary> Gets the data metric. </summary>
        /// <returns> </returns>
        IDataMetric GetSeriesMetric();

        /// <summary> Gets the data. </summary>
        /// <returns> </returns>
        IEnumerable<double> GetSeriesValues();

        /// <summary> Gets the series categories. </summary>
        /// <returns> </returns>
        IEnumerable<string> GetSeriesCategories();

        /// <summary> Gets the source model. </summary>
        /// <returns> </returns>
        ISourceModel GetSourceModel();
    }
}
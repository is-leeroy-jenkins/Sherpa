// <copyright file = "IChartBinding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    public interface IChartBinding : IBindingSource
    {
        /// <summary> Gets the empty. </summary>
        /// <param name = "xIndex" > The xIndex. </param>
        /// <returns> </returns>
        bool GetEmpty( int xIndex );

        /// <summary> Gets the x. </summary>
        /// <param name = "xIndex" > The xIndex. </param>
        /// <returns> </returns>
        double GetX( int xIndex );

        /// <summary> Gets the y. </summary>
        /// <param name = "xIndex" > The xIndex. </param>
        /// <returns> </returns>
        double GetY( int xIndex );

        /// <summary> Occurs when [changed]. </summary>
        event ListChangedEventHandler Changed;

        /// <summary> Gets the count. </summary>
        /// <returns> </returns>
        int GetCount();

        /// <summary> Gets the series configuration. </summary>
        /// <returns> </returns>
        ISeriesConfig GetSeriesConfig();

        /// <summary> Gets the data metric. </summary>
        /// <returns> </returns>
        IDataMetric GetDataMetric();
    }
}
// <copyright file = "ISeriesConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    public interface ISeriesConfig
    {
        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <returns>
        /// </returns>
        Field Field { get; set; }

        /// <summary>
        /// Gets the statistic.
        /// </summary>
        /// <returns>
        /// </returns>
        STAT Stat { get; set; }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        /// <returns>
        /// </returns>
        Numeric Numeric { get; set; }

        /// <summary>
        /// Sets the call out.
        /// </summary>
        void SetCallOut();

        /// <summary> Gets the type of the series. </summary>
        /// <param name = "type" >
        /// The type.
        /// </param>
        /// <returns>
        /// </returns>
        ChartType GetSeriesType( ChartType type = ChartType.Column );

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        object Tag { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable styles].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable styles]; otherwise, <c>false</c>.
        /// </value>
        bool EnableStyles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ISeriesConfig"/> is visible.
        /// </summary>
        /// <value>
        ///   <c>true</c> if visible; otherwise, <c>false</c>.
        /// </value>
        bool Visible { get; set; }

        /// <summary>
        /// Gets the fancy tool tip.
        /// </summary>
        /// <value>
        /// The fancy tool tip.
        /// </value>
        ChartFancyToolTipInfo FancyToolTip { get; }

        /// <summary>
        /// Gets or sets a value indicating whether [legend item use series style].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [legend item use series style]; otherwise, <c>false</c>.
        /// </value>
        bool LegendItemUseSeriesStyle { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [optimize pie point positions].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [optimize pie point positions]; otherwise, <c>false</c>.
        /// </value>
        bool OptimizePiePointPositions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ISeriesConfig"/> is rotate.
        /// </summary>
        /// <value>
        ///   <c>true</c> if rotate; otherwise, <c>false</c>.
        /// </value>
        bool Rotate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [show ticks].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show ticks]; otherwise, <c>false</c>.
        /// </value>
        bool ShowTicks { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [draw series name in depth].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [draw series name in depth]; otherwise, <c>false</c>.
        /// </value>
        bool DrawSeriesNameInDepth { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [smart labels].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [smart labels]; otherwise, <c>false</c>.
        /// </value>
        bool SmartLabels { get; set; }

        /// <summary>
        /// Gets or sets the width of the smart labels border.
        /// </summary>
        /// <value>
        /// The width of the smart labels border.
        /// </value>
        float SmartLabelsBorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the color of the smart labels border.
        /// </summary>
        /// <value>
        /// The color of the smart labels border.
        /// </value>
        Color SmartLabelsBorderColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [enable area tool tip].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable area tool tip]; otherwise, <c>false</c>.
        /// </value>
        bool EnableAreaToolTip { get; set; }
    }
}
// <copyright file = "Chart.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Chart : ChartBase, IBudgetChart
    {
        public Chart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width = 600, int height = 400 )
        {
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void SetLocation( int x = 1, int y = 1 )
        {
        }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void SetParent( Control parent )
        {
        }

        /// <summary> Sets the primary axis title. </summary>
        /// <param name = "text" > The title. </param>
        /// <param name = "font" > </param>
        /// <param name = "color" > The color. </param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
        }

        /// <summary> Sets the main title. </summary>
        /// <param name = "text" > The t. </param>
        /// <param name = "font" > </param>
        /// <param name = "color" > </param>
        public void SetMainTitle( string text, Font font, Color color )
        {
        }
        
        /// <summary> Gets the style configuration. </summary>
        /// <returns> </returns>
        public IChartConfig GetStyleConfiguration()
        {
            return new ChartConfig();
        }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public new ISourceModel GetSourceModel()
        {
            return new SourceModel();
        }
    }
}

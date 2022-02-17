// // <copyright file = "BudgetPivotChartControl.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.PivotChart;

    [ SuppressMessage( "ReSharper", "BadListLineBreaks" ) ]
    public class BudgetPivotChartControl : PivotChartBase
    {
        public BudgetPivotChartControl()
        {
            // Basic Control Properties
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            BackColor = Color.FromArgb( 10, 10, 10 );
            Skins = Skins.Office2016Black;
            ShowLegend = true;
            Size = new Size( 400, 300 );
            CustomPalette = new [ ] { Color.SteelBlue, Color.Red, Color.Green };
            ChartTypes = PivotChartTypes.Column;
        }
    }
}

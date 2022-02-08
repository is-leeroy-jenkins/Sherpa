// // <copyright file = "BudgetPivotChart.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms.PivotChart;

    [ SuppressMessage( "ReSharper", "BadListLineBreaks" ) ]
    public class BudgetPivotChart : PivotChartBase
    {
        public BudgetPivotChart()
        {
            // Basic Control Properties
            Font = BudgetFont.FontSizeSmall;
            ForeColor = BudgetColor.LightGray;
            BackColor = BudgetColor.FormDark;
            Size = BudgetSize.GetSize( 400, 300 );
            CustomPalette = new [ ] { Color.SteelBlue, Color.Red, Color.Green };
            ChartTypes = PivotChartTypes.Column;
        }
    }
}
